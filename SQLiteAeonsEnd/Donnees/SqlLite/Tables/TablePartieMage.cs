using System;
using System.Data.SQLite;

namespace SQLiteAeonsEnd.Donnees.SqlLite.Tables
{
    public class TablePartieMage
    {
        private SQLiteConnection _sqlite_conn;
        private SQLiteCommand _sqlite_cmd;

        public TablePartieMage(SQLiteConnection sqlite_conn, SQLiteCommand sqlite_cmd)
        {
            _sqlite_conn = sqlite_conn;
            _sqlite_cmd = sqlite_cmd;
        }

        public void Create()
        {
            _sqlite_cmd.CommandText =
                @"CREATE TABLE IF NOT EXISTS
                    partieMage (
                    id              INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                    partieId        INTEGER NOT NULL,
                    mageId          INTEGER NOT NULL,
                    FOREIGN KEY(partieId) REFERENCES partie(id)
                    FOREIGN KEY(mageId) REFERENCES mages(id))";

            _sqlite_cmd.ExecuteNonQuery();

            Console.WriteLine("Create partie mage table");
        }
    }
}
