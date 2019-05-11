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
                    partieId        INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                    partieName      VARCHAR(50) NOT NULL,
                    versionId       INTEGER NOT NULL,
                    nemesisId       INTEGER NOT NULL,
                    nemesisVie      INTEGER NOT NULL,
                    mageId1         INTEGER NOT NULL,
                    mageVie1        INTEGER NOT NULL,
                    mageId2         INTEGER NOT NULL,
                    mageVie2        INTEGER NOT NULL,
                    mageId3         INTEGER NOT NULL,
                    mageVie3        INTEGER NOT NULL,
                    mageId4         INTEGER NOT NULL,
                    mageVie4        INTEGER NOT NULL,
                    repliqueId1     INTEGER NOT NULL,
                    repliqueId2     INTEGER NOT NULL,
                    gemId1          INTEGER NOT NULL,
                    gemId2          INTEGER NOT NULL,
                    gemId3          INTEGER NOT NULL,
                    sortId1         INTEGER NOT NULL,
                    sortId2         INTEGER NOT NULL,
                    sortId3         INTEGER NOT NULL,
                    sortId4         INTEGER NOT NULL,
                    partieGagne     BIT NOT NULL,
                    nbCycle         INTEGER NOT NULL,
                    graveholdVie    INTEGER NOT NULL,
                    commentaire     VARCHAR(50),
                    FOREIGN KEY(versionId) REFERENCES versions(id)
                    FOREIGN KEY(nemesisId) REFERENCES nemesis(id)
                    FOREIGN KEY(repliqueId1) REFERENCES relics(id)
                    FOREIGN KEY(repliqueId2) REFERENCES relics(id)
                    FOREIGN KEY(gemId1) REFERENCES gems(id)
                    FOREIGN KEY(gemId2) REFERENCES gems(id)
                    FOREIGN KEY(gemId3) REFERENCES gems(id)
                    FOREIGN KEY(sortId1) REFERENCES sorts(id)
                    FOREIGN KEY(sortId2) REFERENCES sorts(id)
                    FOREIGN KEY(sortId3) REFERENCES sorts(id)
                    FOREIGN KEY(sortId4) REFERENCES sorts(id))";

            _sqlite_cmd.ExecuteNonQuery();

            Console.WriteLine("Create partie table");
        }
    }
}
