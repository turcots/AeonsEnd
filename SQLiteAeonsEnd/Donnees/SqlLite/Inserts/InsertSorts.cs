
using SQLiteAeonsEnd.Entity;
using System;
using System.Data.SQLite;

namespace SQLiteAeonsEnd.Affaires.SqlLite
{
    public class InsertSorts
    {
        private SQLiteConnection _sqlite_conn;
        private SQLiteCommand _sqlite_cmd;

        public InsertSorts(SQLiteConnection sqlite_conn, SQLiteCommand sqlite_cmd)
        {
            _sqlite_conn = sqlite_conn;
            _sqlite_cmd = sqlite_cmd;
        }

        public void Inserts()
        {
            //Aeon's End
            Insert(GetModel("Arc chaotique", (int)Versions.AeonsEnd, 6)); //Chaos Arc
            Insert(GetModel("Fouet ardent", (int)Versions.AeonsEnd, 6)); //Wildfire Whip
            Insert(GetModel("Mise à feu", (int)Versions.AeonsEnd, 4)); //Ignite
            Insert(GetModel("Vol d''essence", (int)Versions.AeonsEnd, 5)); //Essence Theft
            Insert(GetModel("Vision amplifiée", (int)Versions.AeonsEnd, 4)); //Amplify Vision
            Insert(GetModel("Vague d''oubli", (int)Versions.AeonsEnd, 5)); //Oblivion Swell
            Insert(GetModel("Tentacule de lave", (int)Versions.AeonsEnd, 4)); //Lava Tendril
            Insert(GetModel("Nexus des arcanes", (int)Versions.AeonsEnd, 7)); //Arcane Nexus
            Insert(GetModel("Éclair enragé", (int)Versions.AeonsEnd, 5)); //Feral Lightning
            Insert(GetModel("Feu obscur", (int)Versions.AeonsEnd, 5)); //Dark Fire
            Insert(GetModel("Flamme du phénix", (int)Versions.AeonsEnd, 3)); //Phoenix Flame
            Insert(GetModel("Aperçu planaire", (int)Versions.AeonsEnd, 6)); //Planar Insight
            Insert(GetModel("Écho spectral", (int)Versions.AeonsEnd, 3)); //Spectral Echo
            Insert(GetModel("Vide dévorant", (int)Versions.AeonsEnd, 7)); //Consuming Void

            //Aeon's End - War Ethernal
            Insert(GetModel("Aurora", (int)Versions.WarEternal, 5));
            Insert(GetModel("Carbonize", (int)Versions.WarEternal, 4));
            Insert(GetModel("Conjure the lost", (int)Versions.WarEternal, 6));
            Insert(GetModel("Celestial spire", (int)Versions.WarEternal, 5));
            Insert(GetModel("Convection field", (int)Versions.WarEternal, 5));
            Insert(GetModel("Crystallize", (int)Versions.WarEternal, 8));
            Insert(GetModel("Equilibrium", (int)Versions.WarEternal, 7));
            Insert(GetModel("Fiery Torrent", (int)Versions.WarEternal, 5));
            Insert(GetModel("Jagged lightning", (int)Versions.WarEternal, 4));
            Insert(GetModel("Kindle", (int)Versions.WarEternal, 4));
            Insert(GetModel("Nova forge", (int)Versions.WarEternal, 6));
            Insert(GetModel("Pyrotechnic surge", (int)Versions.WarEternal, 4));
            Insert(GetModel("Reduce to ash", (int)Versions.WarEternal, 7));
            Insert(GetModel("Throughtform familiar", (int)Versions.WarEternal, 3));

            //The void
            Insert(GetModel("Resonate", (int)Versions.TheVoid, 6));
            Insert(GetModel("Inner fire", (int)Versions.TheVoid, 2));
            Insert(GetModel("Fulminate", (int)Versions.TheVoid, 5));
            Insert(GetModel("Thermal dart", (int)Versions.TheVoid, 4));
            Insert(GetModel("Conflagration", (int)Versions.TheVoid, 3));

            //The outer dark
            Insert(GetModel("Scorch", (int)Versions.TheOuterDark, 5));
            Insert(GetModel("Pyromancy", (int)Versions.TheOuterDark, 7));
            Insert(GetModel("Nether conduit", (int)Versions.TheOuterDark, 7));
            Insert(GetModel("Feedback aura", (int)Versions.TheOuterDark, 5));
            Insert(GetModel("Catalyst", (int)Versions.TheOuterDark, 6));
            Insert(GetModel("Char", (int)Versions.TheOuterDark, 8));

            //Aeon's End Legacy
            Insert(GetModel("Arcane Salvo", (int)Versions.Legacy, 5));
            Insert(GetModel("Bending Beam", (int)Versions.Legacy, 5));
            Insert(GetModel("Brane Knife", (int)Versions.Legacy, 3));
            Insert(GetModel("Breach Collision", (int)Versions.Legacy, 7));
            Insert(GetModel("Breach Communion", (int)Versions.Legacy, 4));
            Insert(GetModel("Breach Flare", (int)Versions.Legacy, 3));
            Insert(GetModel("Fiery Conclusion", (int)Versions.Legacy, 5));
            Insert(GetModel("Fire Chakram", (int)Versions.Legacy, 2));
            Insert(GetModel("Force Transfusion", (int)Versions.Legacy, 4));
            Insert(GetModel("Gravity Node", (int)Versions.Legacy, 5));
            Insert(GetModel("Incinerating Fist", (int)Versions.Legacy, 4));
            Insert(GetModel("Pyro Geist", (int)Versions.Legacy, 6));
            Insert(GetModel("Sparking Siphon", (int)Versions.Legacy, 3));
            Insert(GetModel("Sphere of Inversion", (int)Versions.Legacy, 9));
            Insert(GetModel("Starfire Frenzy", (int)Versions.Legacy, 6));
            Insert(GetModel("Thunderous Oath", (int)Versions.Legacy, 8));
            Insert(GetModel("Warping Haze", (int)Versions.Legacy, 3));

            //Buried Secrets (Legacy)
            Insert(GetModel("Blade of Wisdom", (int)Versions.BuriedSecrets, 6));
            Insert(GetModel("Burning Current", (int)Versions.BuriedSecrets, 3));
            Insert(GetModel("Double Tap", (int)Versions.BuriedSecrets, 3));
            Insert(GetModel("Draining Touch", (int)Versions.BuriedSecrets, 2));
            Insert(GetModel("Flash of Intellect", (int)Versions.BuriedSecrets, 4));
            Insert(GetModel("Nerve Jab", (int)Versions.BuriedSecrets, 2));
            Insert(GetModel("Precision Shot", (int)Versions.BuriedSecrets, 3));
            Insert(GetModel("Psychic Eruption", (int)Versions.BuriedSecrets, 8));
            Insert(GetModel("Stunning Force", (int)Versions.BuriedSecrets, 5));

            //The depths
            Insert(GetModel("Combustion", (int)Versions.Depths, 5));
            Insert(GetModel("Devouring Shadow", (int)Versions.Depths, 6));
            Insert(GetModel("Disintegrating Scythe", (int)Versions.Depths, 7));
            Insert(GetModel("Monstrous Inferno", (int)Versions.Depths, 8));
            Insert(GetModel("Void Bond", (int)Versions.Depths, 4));

            //The nameless
            Insert(GetModel("Blaze", (int)Versions.Nameless, 4));
            Insert(GetModel("Radiance", (int)Versions.Nameless, 8));
            Insert(GetModel("Sage''s Brand", (int)Versions.Nameless, 7));
            Insert(GetModel("Scrying Bolt", (int)Versions.Nameless, 6));

            //New Age
            //Into the Wild (NA)
            //The Ancients (NA)
            //Shattered Dreams (NA)

            Console.WriteLine("Insert sorts rows");
        }

        private Sorts GetModel(string name, int versionId, int cost)
        {
            return new Sorts() {Name = name, VersionId = versionId, Cost = cost };
        }

        private void Insert(Sorts sorts)
        {
            _sqlite_cmd.CommandText = String.Format("INSERT INTO sorts (name, versionId, cost) VALUES ('{0}', {1}, {2});", sorts.Name, sorts.VersionId, sorts.Cost);
            _sqlite_cmd.ExecuteNonQuery();
        }
    }
}
