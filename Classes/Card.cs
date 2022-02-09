using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace YugiohPriceMonitoring.Classes
{
    class Card
    {
        private string name { get; set; }
        private string setName { get; set; }
        private string subTypeName { get; set; }
        private string rarity { get; set; }
        private string imagePath { get; set; }
        private string productId { get; set; }
        private string lowPrice { get; set; }
        private string midPrice { get; set; }
        private string highPrice { get; set; }
        private string marketPrice { get; set; }
        private string productSku { get; set; }
        private string edition { get; set; }
        private string condition { get; set; }
        private string collection { get; set; }
        private string cardId { get; set; }

        public Card(string name, string setName, string subTypeName, string rarity, string imagePath, string productId)
        {
            this.name = name;
            this.setName = setName;
            this.subTypeName = subTypeName;
            this.rarity = rarity;
            this.imagePath = imagePath;
            this.productId = productId;
        }

        public Card(string cardId, string name, string setName, string rarity, string imagePath, string productId, string productSku, string edition, string condition, string collection)
        {
            this.cardId = cardId;
            this.name = name;
            this.setName = setName;
            this.rarity = rarity;
            this.imagePath = imagePath;
            this.productId = productId;
            this.productSku = productSku;
            this.edition = edition;
            this.condition = condition;
            this.collection = collection;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public string SetName
        {
            get
            {
                return this.setName;
            }
        }

        public string SubTypeName
        {
            get
            {
                return this.SubTypeName;
            }
        }

        public string Rarity
        {
            get
            {
                return this.Rarity;
            }
        }

        public string ImagePath
        {
            get
            {
                return this.imagePath;
            }
        }

        public string ProductId
        {
            get
            {
                return this.ProductId;
            }
        }

        public string NameAndSet
        {
            get
            {
                return this.name + "   (" + this.setName + ")";
            }
        }

        public string MainFields
        {
            get
            {
                return this.name + "   (" + this.setName + " - " + this.edition + " - " + this.rarity + " - " + this.condition + ")";
            }
        }

        public void setMarketPrice(string marketPrice)
        {
            this.marketPrice = marketPrice;
        }

        public string getMarketPrice()
        {
            return marketPrice;
        }

        public string getLowestPrice()
        {
            return lowPrice;
        }

        public void setLowPrice(string lowPrice)
        {
            this.lowPrice = lowPrice;
        }

        public string getProductId()
        {
            return productId;
        }

        public void setProductSku(string productSku)
        {
            this.productSku = productSku;
        }

        public string getProductSku()
        {
            return productSku;
        }

        public string getCondition()
        {
            return condition;
        }

        public void setCondition(string condition)
        {
            this.condition = condition;
        }

        public string getEdition()
        {
            return edition;
        }

        public void setEdition(string edition)
        {
            this.edition = edition;
        }

        public string getName()
        {
            return name;
        }

        public string getRarity()
        {
            return rarity;
        }

        public string getImagePath()
        {
            return imagePath;
        }

        public string getCollection()
        {
            return collection;
        }
        
        public void setCollection(string collection)
        {
            this.collection = collection;
        }

        public string getSetName()
        {
            return setName;
        }

        public string getCardId()
        {
            return cardId;
        }

        /// <summary>
        /// Takes a json response and parses it into a List of Cards
        /// </summary>
        /// <param name="jsonCards"> The json response </param>
        /// <returns></returns>
        public static List<Card> parseCards(string jsonCards)
        {
            // The new list of cards
            List<Card> cardList = new List<Card>();
            
            //Creates JObject out of json file
            JObject jsonDoc = JObject.Parse(jsonCards);
            
            //Takes the results section of the cards and makes a list of JTokens
            List<JToken> cardListJToken = jsonDoc["results"].ToList<JToken>();

            // Iterates through the tokens list and creates a Card object using extracted fields
            // Then creates a Card object from it and adds to list
            foreach (JToken result in cardListJToken)
            {
                Card card;
                try
                {
                    card = new Card(result["name"].ToString(),
                                        result["extendedData"][0]["value"].ToString(),
                                        "???",
                                        result["extendedData"][1]["value"].ToString(),
                                        result["imageUrl"].ToString(),
                                        result["productId"].ToString()
                                        );
                    cardList.Add(card);
                }
                catch (Exception ex)
                {
                    //Not a card 
                    Console.WriteLine(ex.Message);
                }
            }

            return cardList;
        }
    }
}
