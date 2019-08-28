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
            //Aeon's End
            Insert(GetModel("Dague fléchissante", (int)Versions.AeonsEnd, 2)); //Flexing Dagger
            Insert(GetModel("Bâton d''explosion", (int)Versions.AeonsEnd, 4)); //Blasting Staff
            Insert(GetModel("Prisme instable", (int)Versions.AeonsEnd, 3)); //Unstable Prism
            Insert(GetModel("Vortex en bouteille", (int)Versions.AeonsEnd, 3)); //Bottled Vortex
            Insert(GetModel("Talisman de mage", (int)Versions.AeonsEnd, 5)); //Mage's Talisman
            Insert(GetModel("Orbe de stabilisation", (int)Versions.AeonsEnd, 4)); //Focusing Orb

            //Aeon's End - War Ethernal
            Insert(GetModel("Cairn compass", (int)Versions.WarEternal, 4));
            Insert(GetModel("Conclave scroll", (int)Versions.WarEternal, 3));
            Insert(GetModel("Fiend catcher", (int)Versions.WarEternal, 3));
            Insert(GetModel("Mage''s totem", (int)Versions.WarEternal, 2));
            Insert(GetModel("Primordial fetish", (int)Versions.WarEternal, 4));
            Insert(GetModel("Vortex gauntlet", (int)Versions.WarEternal, 6));

            //The void
            Insert(GetModel("Dimensional key", (int)Versions.TheVoid, 8));
            Insert(GetModel("Eternity charm", (int)Versions.TheVoid, 3));

            //The outer dark
            Insert(GetModel("Riddlesphere", (int)Versions.TheOuterDark, 3));
            Insert(GetModel("Astral cube", (int)Versions.TheOuterDark, 5));

            //Aeon's End Legacy
            Insert(GetModel("Adrenal Batteries", (int)Versions.Legacy, 7));
            Insert(GetModel("Ethereal Hand", (int)Versions.Legacy, 6));
            Insert(GetModel("Geophage", (int)Versions.Legacy, 3));
            Insert(GetModel("Infernal Mirror", (int)Versions.Legacy, 5));
            Insert(GetModel("Neural Wreath", (int)Versions.Legacy, 4));
            Insert(GetModel("Prophetic Lens", (int)Versions.Legacy, 4));
            Insert(GetModel("Reality Stabilizer", (int)Versions.Legacy, 6));
            Insert(GetModel("Void Mill", (int)Versions.Legacy, 5));
            Insert(GetModel("Voltaic Relay", (int)Versions.Legacy, 4));

            //Buried Secrets (Legacy)
            Insert(GetModel("Bottled Star", (int)Versions.BuriedSecrets, 7));
            Insert(GetModel("Living Gauntlet", (int)Versions.BuriedSecrets, 4));
            Insert(GetModel("Manifold Container", (int)Versions.BuriedSecrets, 4));
            Insert(GetModel("Scholar's Opus", (int)Versions.BuriedSecrets, 3));
            Insert(GetModel("Soul Cords", (int)Versions.BuriedSecrets, 5));
  
            //The depths
            //Transmogrifier
            //Vim Dynamo

            //The nameless
            //Molten Hammer
            //Temporal Helix

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
