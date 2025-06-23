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
            // Connection string for the SQLite database file.
            // Make sure "unicomtic.db" exists in the application directory or specify a full path.
            string Query = "DATA SOURCE=unicomtic.db;VERSION=3;";

            // Create a new connection using the connection string
            SQLiteConnection sqliteconnect = new SQLiteConnection(Query);

            // Open the connection before returning it
            sqliteconnect.Open();

            return sqliteconnect;
        }
    }
}
