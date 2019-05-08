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
                    mageLife4       INTEGER NOT NULL,
                    replique1Id     INTEGER NOT NULL,
                    replique2Id     INTEGER NOT NULL,
                    gem1Id          INTEGER NOT NULL,
                    gem2Id          INTEGER NOT NULL,
                    gem3Id          INTEGER NOT NULL,
                    sort1Id         INTEGER NOT NULL,
                    sort2Id         INTEGER NOT NULL,
                    sort3Id         INTEGER NOT NULL,
                    sort4Id         INTEGER NOT NULL,
                    partieGagne     BIT NOT NULL,
                    nbCycle         INTEGER NOT NULL,
                    graveholdVie    INTEGER NOT NULL,
                    Commentaire     VARCHAR(50),
                    FOREIGN KEY(versionId) REFERENCES versions(id)
                    FOREIGN KEY(nemesisId) REFERENCES nemesis(id)
                    FOREIGN KEY(replique1Id) REFERENCES relics(id)
                    FOREIGN KEY(replique2Id) REFERENCES relics(id)
                    FOREIGN KEY(gem1Id) REFERENCES gems(id)
                    FOREIGN KEY(gem2Id) REFERENCES gems(id)
                    FOREIGN KEY(gem3Id) REFERENCES gems(id)
                    FOREIGN KEY(sort1Id) REFERENCES sorts(id)
                    FOREIGN KEY(sort2Id) REFERENCES sorts(id)
                    FOREIGN KEY(sort3Id) REFERENCES sorts(id)
                    FOREIGN KEY(sort4Id) REFERENCES sorts(id))";

            _sqlite_cmd.ExecuteNonQuery();

            Console.WriteLine("Create partie table");
        }
    }
}
