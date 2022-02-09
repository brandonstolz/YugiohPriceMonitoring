using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace YugiohPriceMonitoring.Classes
{
    class SQLObject
    {
        SQLiteConnection connection;
        SQLiteCommand cmd;

        public SQLObject(SQLiteConnection connection, SQLiteCommand cmd)
        {
            this.connection = connection;
            this.cmd = cmd;
        }

        public SQLiteConnection getConnection()
        {
            return connection;
        }

        public SQLiteCommand getCommand()
        {
            return cmd;
        }
    }
}
