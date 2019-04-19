
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
            //Version 2
            Insert(GetModel("Bloodstone jewel", 2, 6));
            Insert(GetModel("Breach ore", 2, 4));
            Insert(GetModel("Dread diamond", 2, 3));
            Insert(GetModel("Erratic ingot", 2, 5));
            Insert(GetModel("Frozen magmite", 2, 3));
            Insert(GetModel("Scoria slag", 2, 4));
            Insert(GetModel("Volcanic glass", 2, 3));
            Insert(GetModel("Alien element", 2, 4));
            Insert(GetModel("Haunted berylite", 2, 3));
            Insert(GetModel("Pain stone", 2, 6));
            Insert(GetModel("Fossilized scarab", 2, 3));

            //Version 1
            Insert(GetModel("Rubis fulgurant", 1, 4));
            Insert(GetModel("Ambre de V''risbois", 1, 3));
            Insert(GetModel("Opale brûlante", 1, 5));
            Insert(GetModel("Perle filtrante", 1, 3));
            Insert(GetModel("Saphir nuageux", 1, 6));
            Insert(GetModel("Jade", 1, 2));
            Insert(GetModel("Agrégat de diamants", 1, 3));

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
