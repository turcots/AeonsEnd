
using System;
using System.Data.SQLite;

namespace SQLiteAeonsEnd.Affaires.SqlLite
{
    public class TableSorts
    {
        private SQLiteConnection _sqlite_conn;
        private SQLiteCommand _sqlite_cmd;

        public TableSorts(SQLiteConnection sqlite_conn, SQLiteCommand sqlite_cmd)
        {
            _sqlite_conn = sqlite_conn;
            _sqlite_cmd = sqlite_cmd;
        }

        public void Create()
        {
            _sqlite_cmd.CommandText =
                @"CREATE TABLE IF NOT EXISTS
                    sorts (
                    id     INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                    name    NVARCHAR(25)  NOT NULL,
                    versionId    INTEGER NOT NULL,
                    cost    INTEGER NOT NULL,
                    FOREIGN KEY(versionId) REFERENCES versions(id))";


            _sqlite_cmd.ExecuteNonQuery();

            Console.WriteLine("Create sorts table");

            new InsertSorts(_sqlite_conn, _sqlite_cmd).Inserts();          
        }
    }
}
