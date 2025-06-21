using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Repositories
{
    internal static class DatabaseManager
    {
         public static SQLiteConnection DatabaseConnect()
        {
            string Query = "DATA SOURCE = unicomtic.db; VERSION = 3;";
            SQLiteConnection sqliteconnect = new SQLiteConnection(Query);
            sqliteconnect.Open();
            return sqliteconnect;
        }
    }
}
