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
            //Version 2
            Insert(GetModel("Umbra titan", 2, 3, 70));
            Insert(GetModel("Magus of cloaks", 2, 7, 35));
            Insert(GetModel("Gate witch", 2, 7, 70));
            Insert(GetModel("Knight of shackles", 2, 4, 70));
            Insert(GetModel("Maiden of thorns", 2, 4, 80));
            Insert(GetModel("Hollow crown", 2, 5, 1));
            Insert(GetModel("Thrice-dead prophet", 2, 5, 40));
            Insert(GetModel("Wraithmonger", 2, 6, 70));

            //Version 1
            Insert(GetModel("Rage incarnée", 1, 2, 70));
            Insert(GetModel("Reine carapace", 1, 3, 60));
            Insert(GetModel("Prince des gloutons", 1, 5, 70));
            Insert(GetModel("Masque tordu", 1, 5, 70));


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
