
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
            //Version 2
            Insert(GetModel("Aurora", 2, 5));
            Insert(GetModel("Carbonize", 2, 4));
            Insert(GetModel("Conjure the lost", 2, 6));
            Insert(GetModel("Celestial spire", 2, 5));
            Insert(GetModel("Convection field", 2, 5));
            Insert(GetModel("Crystallize", 2, 8));
            Insert(GetModel("Equilibrium", 2, 7));
            Insert(GetModel("Fiery Torrent", 2, 5));
            Insert(GetModel("Jagged lightning", 2, 4));
            Insert(GetModel("Kindle", 2, 4));
            Insert(GetModel("Nova forge", 2, 6));
            Insert(GetModel("Pyrotechnic surge", 2, 4));
            Insert(GetModel("Reduce to ash", 2, 7));
            Insert(GetModel("Throughtform familiar", 2, 3));
            Insert(GetModel("Char", 2, 8));
            Insert(GetModel("Catalyst", 2, 6));
            Insert(GetModel("Feedback aura", 2, 5));
            Insert(GetModel("Thermal dart", 2, 4));
            Insert(GetModel("Nether conduit", 2, 7));
            Insert(GetModel("Pyromancy", 2, 7));
            Insert(GetModel("Scorch", 2, 5));
            Insert(GetModel("Resonate", 2, 6));
            Insert(GetModel("Conflagration", 2, 3));
            Insert(GetModel("Fulminate", 2, 5));
            Insert(GetModel("Inner fire", 2, 2));

            //Version 1
            Insert(GetModel("Arc chaotique", 1, 6));
            Insert(GetModel("Fouet ardent", 1, 6));
            Insert(GetModel("Mise à feu", 1, 4));
            Insert(GetModel("Vol d''essence", 1, 5));
            Insert(GetModel("Vision amplifiée", 1, 4));
            Insert(GetModel("Vague d''oubli", 1, 5));
            Insert(GetModel("Tentacule de lave", 1, 4));
            Insert(GetModel("Nexus des arcanes", 1, 7));
            Insert(GetModel("Éclair enragé", 1, 5));
            Insert(GetModel("Feu obscur", 1, 5));
            Insert(GetModel("Flamme du phénix", 1, 3));
            Insert(GetModel("Aperçu planaire", 1, 6));
            Insert(GetModel("Écho spectral", 1, 3));
            Insert(GetModel("Vide dévorant", 1, 7));

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
