
using System.Configuration;
using System.Data.SQLite;

namespace AeonsEnd.Donnees
{
    public class Database
    {
        private string _databaseConnection;
        public SQLiteConnection sqlite_conn;

        public Database()
        {
            _databaseConnection = ConfigurationManager.AppSettings["aeonsEndBdName"];
            sqlite_conn = new SQLiteConnection(_databaseConnection);
        }

    }
}