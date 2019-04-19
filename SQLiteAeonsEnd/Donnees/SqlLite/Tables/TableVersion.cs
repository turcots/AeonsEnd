
using System;
using System.Data.SQLite;

namespace SQLiteAeonsEnd.Affaires.SqlLite
{
    public class TableVersion
    {
        private SQLiteConnection _sqlite_conn;
        private SQLiteCommand _sqlite_cmd;

        public TableVersion(SQLiteConnection sqlite_conn, SQLiteCommand sqlite_cmd)
        {
            _sqlite_conn = sqlite_conn;
            _sqlite_cmd = sqlite_cmd;
        }

        public void Create()
        {
            _sqlite_cmd.CommandText =
                @"CREATE TABLE IF NOT EXISTS
                    versions (
                    id     INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                    name    NVARCHAR(25) NULL)";

            _sqlite_cmd.ExecuteNonQuery();

            Console.WriteLine("Create versions table");

            new InsertVersions(_sqlite_conn, _sqlite_cmd).Inserts();
        }
    }
}
