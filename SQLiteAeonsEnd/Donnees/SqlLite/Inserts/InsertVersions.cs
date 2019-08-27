using SQLiteAeonsEnd.Entity;
using System;
using System.Data.SQLite;

namespace SQLiteAeonsEnd.Affaires.SqlLite
{
    public class InsertVersions
    {
        private SQLiteConnection _sqlite_conn;
        private SQLiteCommand _sqlite_cmd;

        public InsertVersions(SQLiteConnection sqlite_conn, SQLiteCommand sqlite_cmd)
        {
            _sqlite_conn = sqlite_conn;
            _sqlite_cmd = sqlite_cmd;
        }

        public void Inserts()
        {
            Insert((int)Versions.AeonsEnd, "Aeons''End");
            Insert((int)Versions.Nameless, "Nameless (AE)");
            Insert((int)Versions.Depths, "Depths (AE)");       

            Insert((int)Versions.WarEternal, "War Eternal");
            Insert((int)Versions.TheVoid, "The void (WE)");
            Insert((int)Versions.TheOuterDark, "The outer dark  (WE)");

            Insert((int)Versions.Legacy, "Legacy");
            Insert((int)Versions.BuriedSecrets, "Buried Secrets (Legacy)");

            Insert((int)Versions.NewAge, "New Age");
            Insert((int)Versions.IntoTheWild, "Into the Wild (NA)");
            Insert((int)Versions.TheAncients, "The Ancients (NA)");
            Insert((int)Versions.ShatteredDreams, "Shattered Dreams (NA)");

            Console.WriteLine("Insert versions rows");
        }

        private void Insert(int id, string name)
        {
            _sqlite_cmd.CommandText = String.Format("INSERT INTO versions (id, name) VALUES ({0}, '{1}');", id, name);
            _sqlite_cmd.ExecuteNonQuery();
        }
    }
}
