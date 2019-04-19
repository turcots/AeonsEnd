using System;
using System.Configuration;
using System.Data.SQLite;
using System.IO;

namespace SQLiteAeonsEnd.Affaires.SqlLite
{
    public class Database : IDatabase
    {
        private string _databaseName;
        private string _databaseConnection;
        private SQLiteConnection _sqlite_conn;

        public Database()
        {
            _databaseName = ConfigurationManager.ConnectionStrings["aeonsEndBdName"].ConnectionString;
            _databaseConnection = ConfigurationManager.ConnectionStrings["aeonsEndConnectionBd"].ConnectionString;
            _sqlite_conn = new SQLiteConnection(_databaseConnection);
        }
        public void Create()
        {
            Drop();
            _sqlite_conn.Open();
            Console.WriteLine("Create database");

            new Tables(_sqlite_conn).Create();

            _sqlite_conn.Close();
            Console.WriteLine("Close database");
        }

        private void Drop()
        {
            File.Delete(GetPath());
            Console.WriteLine("Drop database");
        }

        private string GetPath()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _databaseName);
        }
    }
}
