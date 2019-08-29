
using SQLiteAeonsEnd.Entity;
using System;
using System.Data.SQLite;

namespace SQLiteAeonsEnd.Affaires.SqlLite
{
    public class InsertGems
    {
        private SQLiteConnection _sqlite_conn;
        private SQLiteCommand _sqlite_cmd;

        public InsertGems(SQLiteConnection sqlite_conn, SQLiteCommand sqlite_cmd)
        {
            _sqlite_conn = sqlite_conn;
            _sqlite_cmd = sqlite_cmd;
        }

        public void Inserts()
        {
            //Aeon's End
            Insert(GetModel("Rubis fulgurant", (int)Versions.AeonsEnd, 4)); //Searing Ruby
            Insert(GetModel("Ambre de V''risbois", (int)Versions.AeonsEnd, 3)); //V'riswood Amber  
            Insert(GetModel("Opale brûlante", (int)Versions.AeonsEnd, 5)); //Burning Opal
            Insert(GetModel("Perle filtrante", (int)Versions.AeonsEnd, 3)); //Sifter's Pearl
            Insert(GetModel("Saphir nuageux", (int)Versions.AeonsEnd, 6)); //Clouded Sapphire
            Insert(GetModel("Jade", (int)Versions.AeonsEnd, 2)); //Jade
            Insert(GetModel("Agrégat de diamants", (int)Versions.AeonsEnd, 3)); //Diamond Cluster

            //Aeon's End - War Ethernal
            Insert(GetModel("Bloodstone jewel", (int)Versions.WarEternal, 6));
            Insert(GetModel("Breach ore", (int)Versions.WarEternal, 4));
            Insert(GetModel("Dread diamond", (int)Versions.WarEternal, 3));
            Insert(GetModel("Erratic ingot", (int)Versions.WarEternal, 5));
            Insert(GetModel("Frozen magmite", (int)Versions.WarEternal, 3));
            Insert(GetModel("Scoria slag", (int)Versions.WarEternal, 4));
            Insert(GetModel("Volcanic glass", (int)Versions.WarEternal, 3));
 
            //The void
            Insert(GetModel("Fossilized scarab", (int)Versions.TheVoid, 3));

            //The outer dark
            Insert(GetModel("Pain stone", (int)Versions.TheOuterDark, 6));
            Insert(GetModel("Haunted berylite", (int)Versions.TheOuterDark, 3));
            Insert(GetModel("Alien element", (int)Versions.TheOuterDark, 4));

            //Aeon's End Legacy
            Insert(GetModel("Ancient Cyanolith", (int)Versions.Legacy, 3));
            Insert(GetModel("Arcing Silicate", (int)Versions.Legacy, 4));
            Insert(GetModel("Branching Radite", (int)Versions.Legacy, 4));
            Insert(GetModel("Conductive Grit", (int)Versions.Legacy, 3));
            Insert(GetModel("Crumbling Compound", (int)Versions.Legacy, 5));
            Insert(GetModel("Entangled Shard", (int)Versions.Legacy, 4));
            Insert(GetModel("Fulmite Slab", (int)Versions.Legacy, 6));
            Insert(GetModel("Gilded Marble", (int)Versions.Legacy, 6));
            Insert(GetModel("Phased Portalite", (int)Versions.Legacy, 4));
            Insert(GetModel("Refined Lumenium", (int)Versions.Legacy, 5));
            Insert(GetModel("Soothing Torporene", (int)Versions.Legacy, 3));

            //Buried Secrets (Legacy)
            Insert(GetModel("Jolting Crust", (int)Versions.BuriedSecrets, 3));
            Insert(GetModel("Mentite Chunk", (int)Versions.BuriedSecrets, 5));
            Insert(GetModel("Muted Lacosite", (int)Versions.BuriedSecrets, 5));
            Insert(GetModel("Oblivium Resin", (int)Versions.BuriedSecrets, 5));
            Insert(GetModel("Shining Tetrite", (int)Versions.BuriedSecrets, 6));
            Insert(GetModel("Summonite", (int)Versions.BuriedSecrets, 3));
            Insert(GetModel("Triplite Core", (int)Versions.BuriedSecrets, 4));
            Insert(GetModel("Voidium Spike", (int)Versions.BuriedSecrets, 3));

            //The depths
            Insert(GetModel("Banishing Topaz", (int)Versions.Depths, 5));

            //The nameless
            Insert(GetModel("Leeching Agate", (int)Versions.Nameless, 3));

            //New Age
            //Into the Wild (NA)
            //The Ancients (NA)
            //Shattered Dreams (NA)

            Console.WriteLine("Insert gems rows");
        }

        private Entity.Gems GetModel(string name, int versionId, int cost)
        {
            return new Entity.Gems() { Name = name, VersionId = versionId, Cost = cost };
        }

        private void Insert(Entity.Gems gems)
        {
            _sqlite_cmd.CommandText = String.Format("INSERT INTO gems (name, versionId, cost) VALUES ('{0}', {1}, {2});", gems.Name, gems.VersionId, gems.Cost);
            _sqlite_cmd.ExecuteNonQuery();
        }
    }
}
