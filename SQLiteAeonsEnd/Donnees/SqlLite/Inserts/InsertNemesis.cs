using SQLiteAeonsEnd.Entity;
using System;
using System.Data.SQLite;

namespace SQLiteAeonsEnd.Affaires.SqlLite
{

    public class InsertNemesis
    {
        private SQLiteConnection _sqlite_conn;
        private SQLiteCommand _sqlite_cmd;

        public InsertNemesis(SQLiteConnection sqlite_conn, SQLiteCommand sqlite_cmd)
        {
            _sqlite_conn = sqlite_conn;
            _sqlite_cmd = sqlite_cmd;
        }

        public void Inserts()
        {
            //Aeon's End
            Insert(GetModel("Rage incarnée", (int)Versions.AeonsEnd, 2, 70));
            Insert(GetModel("Reine carapace", (int)Versions.AeonsEnd, 3, 60));
            Insert(GetModel("Prince des gloutons", (int)Versions.AeonsEnd, 5, 70));
            Insert(GetModel("Masque tordu", (int)Versions.AeonsEnd, 5, 70));

            //Aeon's End - War Ethernal
            Insert(GetModel("Umbra titan", (int)Versions.WarEternal, 3, 70));
            Insert(GetModel("Magus of cloaks", (int)Versions.WarEternal, 7, 35));
            Insert(GetModel("Gate witch", (int)Versions.WarEternal, 7, 70));           
            Insert(GetModel("Hollow crown", (int)Versions.WarEternal, 5, 1));

            //The void
            Insert(GetModel("Knight of shackles", (int)Versions.TheVoid, 4, 70));
            Insert(GetModel("Maiden of thorns", (int)Versions.TheVoid, 4, 80));

            //The outer dark
            Insert(GetModel("Wraithmonger", (int)Versions.TheOuterDark, 6, 70));
            Insert(GetModel("Thrice-dead prophet", (int)Versions.TheOuterDark, 5, 40));

            //The depths
            //Horde-crone

            //The nameless
            //Wayward one
            //Blight Lord

            Console.WriteLine("Insert nemesis rows");
        }

        private Nemesis GetModel(string name, int versionId, int level, int life)
        {
            return new Nemesis() { Name = name, Level = level, VersionId = versionId, Life = life };
        }

        public void Insert(Nemesis nemesis)
        {
            _sqlite_cmd.CommandText = string.Format("INSERT INTO nemesis (name, level, versionId, life) VALUES ('{0}', {1}, {2}, {3});", nemesis.Name, nemesis.Level, nemesis.VersionId, nemesis.Life);
            _sqlite_cmd.ExecuteNonQuery();      
        }
    }
}
