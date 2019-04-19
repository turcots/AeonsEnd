using SQLiteAeonsEnd.Entity;
using System;
using System.Data.SQLite;

namespace SQLiteAeonsEnd.Affaires.SqlLite
{
    public class InsertRelics
    {
        private SQLiteConnection _sqlite_conn;
        private SQLiteCommand _sqlite_cmd;

        public InsertRelics(SQLiteConnection sqlite_conn, SQLiteCommand sqlite_cmd)
        {
            _sqlite_conn = sqlite_conn;
            _sqlite_cmd = sqlite_cmd;
        }

        public void Inserts()
        {   
            //Version 2
            Insert(GetModel("Cairn compass", 2, 4));
            Insert(GetModel("Conclave scroll", 2, 3));
            Insert(GetModel("Fiend catcher", 2, 3));
            Insert(GetModel("Mage''s totem", 2, 2));
            Insert(GetModel("Primordial fetish", 2, 4));
            Insert(GetModel("Vortex gauntlet", 2, 6));
            Insert(GetModel("Astral cube", 2, 5));
            Insert(GetModel("Riddlesphere", 2, 3));
            Insert(GetModel("Dimensional key", 2, 8));
            Insert(GetModel("Eternity charm", 2, 3));

            //Version 1
            Insert(GetModel("Dague fléchissante", 1, 2));
            Insert(GetModel("Bâton d''explosion", 1, 4));
            Insert(GetModel("Prisme instable", 1, 3));
            Insert(GetModel("Vortex en bouteille", 1, 3));
            Insert(GetModel("Talisman de mage", 1, 5));
            Insert(GetModel("Orbe de stabilisation", 1, 4));


            Console.WriteLine("Insert relics rows");
        }

        private Relics GetModel(string name, int versionId, int cost)
        {
            return new Relics() {Name = name, VersionId = versionId, Cost = cost };
        }

        private void Insert(Relics relics)
        {
            _sqlite_cmd.CommandText = String.Format("INSERT INTO relics (name, versionId, cost) VALUES ('{0}', {1}, {2});", relics.Name, relics.VersionId, relics.Cost);
            _sqlite_cmd.ExecuteNonQuery();
        }

    }
}
