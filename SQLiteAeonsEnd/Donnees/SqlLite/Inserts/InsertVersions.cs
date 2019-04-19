using System;
using System.Data.SQLite;

namespace SQLiteAeonsEnd.Affaires.SqlLite
{
    public class InsertVersions
    {
        private SQLiteConnection _sqlite_conn;
        private SQLiteCommand _sqlite_cmd;

        public InsertVersions(SQLiteConnection sqlite_conn, SQLiteCommand sqlite_cmd)
        {
            _sqlite_conn = sqlite_conn;
            _sqlite_cmd = sqlite_cmd;
        }

        public void Inserts()
        {
            Insert("Second edition");
            Insert("War eternal");
            Insert("Legacy");
            Insert("New age");
            Insert("The void");
            Insert("The outer dark");

            Console.WriteLine("Insert versions rows");
        }

        private void Insert(string name)
        {
            _sqlite_cmd.CommandText = String.Format("INSERT INTO versions (name) VALUES ('{0}');", name);
            _sqlite_cmd.ExecuteNonQuery();
        }
    }
}
