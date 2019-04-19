using System;
using System.Data.SQLite;

namespace SQLiteAeonsEnd.Donnees.SqlLite.Tables
{
    public class TablePartie
    {
        private SQLiteConnection _sqlite_conn;
        private SQLiteCommand _sqlite_cmd;

        public TablePartie(SQLiteConnection sqlite_conn, SQLiteCommand sqlite_cmd)
        {
            _sqlite_conn = sqlite_conn;
            _sqlite_cmd = sqlite_cmd;
        }

        public void Create()
        {
            _sqlite_cmd.CommandText =
                @"CREATE TABLE IF NOT EXISTS
                    partie (
                    id              INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                    versionId       INTEGER NOT NULL,
                    nemesisId       INTEGER NOT NULL,
                    replique1Id     INTEGER NOT NULL,
                    replique2Id     INTEGER NOT NULL,
                    gems1Id         INTEGER NOT NULL,
                    gems2Id         INTEGER NOT NULL,
                    gems3Id         INTEGER NOT NULL,
                    sort1Id         INTEGER NOT NULL,
                    sort2Id         INTEGER NOT NULL,
                    sort3Id         INTEGER NOT NULL,
                    sort4Id         INTEGER NOT NULL,
                    FOREIGN KEY(versionId) REFERENCES versions(id)
                    FOREIGN KEY(nemesisId) REFERENCES nemesis(id)
                    FOREIGN KEY(replique1Id) REFERENCES relics(id)
                    FOREIGN KEY(replique1Id) REFERENCES relics(id)
                    FOREIGN KEY(gems1Id) REFERENCES gems(id)
                    FOREIGN KEY(gems2Id) REFERENCES gems(id)
                    FOREIGN KEY(gems3Id) REFERENCES gems(id)
                    FOREIGN KEY(sort1Id) REFERENCES sorts(id)
                    FOREIGN KEY(sort2Id) REFERENCES sorts(id)
                    FOREIGN KEY(sort3Id) REFERENCES sorts(id)
                    FOREIGN KEY(sort4Id) REFERENCES sorts(id))";

            _sqlite_cmd.ExecuteNonQuery();

            Console.WriteLine("Create partie table");
        }
    }
}
