using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace YugiohPriceMonitoring.Classes
{
    class SqlOps
    {
        /// <summary>
        /// Provides an SQLObject which can serve as a connection to the database.
        /// Able to write queries and perform insertions and deletions
        /// </summary>
        /// <returns></returns>
        private static SQLObject dbConnect()
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;");
            connection.Open();
            SQLiteCommand cmd = connection.CreateCommand();

            SQLObject sqlObject = new SQLObject(connection, cmd);

            return sqlObject;
        }

        /// <summary>
        /// Method called to add in a new CardList into the DataBase
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="cardList"></param>
        public static void addCardCollection(string collectionName, List<Card> cardList)
        {
            CardCollection newCollection = new CardCollection(cardList);
            SQLObject sqlObject = dbConnect();

            //Makes sure required tables are created. Could be moved in future
            initializeCardCollectionTable(sqlObject);
            initializeCardTable(sqlObject);

            //Adds in collection to collection table

            sqlObject.getCommand().CommandText = "INSERT INTO CardCollections (Name)"
                                           + "VALUES (\"" + collectionName + "\");";
            int result = sqlObject.getCommand().ExecuteNonQuery();

            //Add individual cards into database
            addCardsToCardTable(sqlObject, cardList, collectionName);

            sqlObject.getConnection().Close();
        }

        /// <summary>
        /// Creates the CardCollection table in the sqlite database
        /// </summary>
        /// <param name="sqlObject"></param>
        public static void initializeCardCollectionTable(SQLObject sqlObject)
        {
            sqlObject.getCommand().CommandText = "CREATE TABLE IF NOT EXISTS CardCollections(" +
                "Name TEXT PRIMARY KEY" +
                ");";
            sqlObject.getCommand().ExecuteNonQuery();
        }

        /// <summary>
        /// Creates the CardTable used to store individual cards
        /// </summary>
        /// <param name="sqlObject"></param>
        public static void initializeCardTable(SQLObject sqlObject)
        {
            sqlObject.getCommand().CommandText = "CREATE TABLE IF NOT EXISTS CardTable("
                + "Id Integer PRIMARY KEY,"
                + "Name TEXT,"
                + "SetName TEXT,"
                + "Rarity TEXT,"
                + "ImagePath TEXT,"
                + "ProductId TEXT,"
                + "ProductSku TEXT,"
                + "Edition TEXT,"
                + "Condition Text,"
                + "Collection Text"
                + ");";

            sqlObject.getCommand().ExecuteNonQuery();
        }

        public static void addCardsToCardTable(SQLObject sqlObject, List<Card> cardList, string collection)
        {

            foreach (Card card in cardList)
            {
                addCardToCardTable(collection, card);
            }
        }

        public static void addCardToCardTable(string collection, Card card)
        {
            SQLObject sqlObject = dbConnect();

            try
            {
                sqlObject.getCommand().CommandText = "INSERT INTO CardTable (Id,Name,SetName,Rarity,ImagePath,ProductId,ProductSku,Edition,Condition,Collection)"
                                                   + "VALUES (\"" + generateCardID() + "\", \"" + card.getName().Replace("\"", "\"\"") + "\", \"" + card.getSetName() + "\", \"" + card.getRarity() + "\", \"" + card.getImagePath() + "\", \"" + card.getProductId() + "\", \"" + card.getProductSku() + "\", \"" + card.getEdition() + "\", \"" + card.getCondition() + "\", \"" + collection + "\");";
                Console.WriteLine(sqlObject.getCommand().CommandText);
                sqlObject.getCommand().ExecuteNonQuery();
            }
            // Effectively impossible to have card id be in use twice
            catch
            {
                sqlObject.getCommand().CommandText = "INSERT INTO CardTable (Id,Name,SetName,Rarity,ImagePath,ProductId,ProductSku,Edition,Condition,Collection)"
                                                   + "VALUES (\"" + generateCardID() + "\", \"" + card.getName().Replace("\"", "\"\"") + "\", \"" + card.getSetName() + "\", \"" + card.getRarity() + "\", \"" + card.getImagePath() + "\", \"" + card.getProductId() + "\", \"" + card.getProductSku() + "\", \"" + card.getEdition() + "\", \"" + card.getCondition() + "\", \"" + collection + "\");";
                Console.WriteLine(sqlObject.getCommand().CommandText);
                sqlObject.getCommand().ExecuteNonQuery();
            }
        }

        public static List<string> getCollections()
        {
            SQLObject sqlObject = dbConnect();
            List<string> CollectionList = new List<string>();

            sqlObject.getCommand().CommandText = "SELECT * FROM CardCollections;";

            SQLiteDataReader reader =  sqlObject.getCommand().ExecuteReader();

            

            while (reader.Read())
            {
                CollectionList.Add(reader.GetString(0));
            }

            CollectionList.Sort();
            return CollectionList;
        }

        /// <summary>
        /// Takes a collection, queries the database, then returns the collection
        /// </summary>
        /// <param name="collectionName"></param>
        /// <returns></returns>
        public static List<Card> viewCollection(string collectionName)
        {
            List<Card> collection = new List<Card>();

            SQLObject sqlObject = dbConnect();

            sqlObject.getCommand().CommandText = "SELECT * FROM CardTable WHERE collection = \"" + collectionName + "\";";
            SQLiteDataReader reader = sqlObject.getCommand().ExecuteReader();

            while (reader.Read())
            {
                collection.Add(new Card(reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4)
                    , reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9)));
            }

            collection = collection.OrderBy(c => c.getName()).ToList();
            return collection;
        }

        public static void removeCardFromCollection(string cardId)
        {
            SQLObject SqlObject = dbConnect();

            SqlObject.getCommand().CommandText = "DELETE FROM CardTable\nWHERE Id = \"" + cardId + "\";";
            SqlObject.getCommand().ExecuteNonQuery();
        }

        /// <summary>
        /// Generates a random ID for a card
        /// </summary>
        /// <returns></returns>
        private static string generateCardID()
        {
            Random rand = new Random();
            int id = rand.Next();

            if (id < 0)
            {
                id *= -1;
            }
            return id.ToString();
        }

        /// <summary>
        /// Method to remove collection from both Collection table and references from Card table.
        /// </summary>
        /// <param name="collection"></param>
        public static void removeCollection(string collection)
        {
            SQLObject sqlObject = dbConnect();

            sqlObject.getCommand().CommandText = "DELETE FROM CardCollections\nWHERE Name = \"" + collection + "\";";
            sqlObject.getCommand().ExecuteNonQuery();

            sqlObject.getCommand().CommandText = "DELETE FROM CardTable\nWHERE Collection = \"" + collection + "\";";
            sqlObject.getCommand().ExecuteNonQuery();

            sqlObject.getConnection().Close();
        }
    }
}
