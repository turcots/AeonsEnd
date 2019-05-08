
using SQLiteAeonsEnd.Entity;
using System;
using System.Data.SQLite;

namespace SQLiteAeonsEnd.Affaires.SqlLite
{
    public class InsertMages
    {
        private SQLiteConnection _sqlite_conn;
        private SQLiteCommand _sqlite_cmd;

        public InsertMages(SQLiteConnection sqlite_conn, SQLiteCommand sqlite_cmd)
        {
            _sqlite_conn = sqlite_conn;
            _sqlite_cmd = sqlite_cmd;
        }

        public void Inserts()
        {
            //Aeon's End
            Insert(GetModel("Kadir", (int)Versions.AeonsEnd));
            Insert(GetModel("Phaedraxa", (int)Versions.AeonsEnd));
            Insert(GetModel("Adelheim", (int)Versions.AeonsEnd));
            Insert(GetModel("Brama", (int)Versions.AeonsEnd));
            Insert(GetModel("Jian", (int)Versions.AeonsEnd));
            Insert(GetModel("Mist", (int)Versions.AeonsEnd));
            Insert(GetModel("Xanos", (int)Versions.AeonsEnd));
            Insert(GetModel("Lash", (int)Versions.AeonsEnd));

            //Aeon's End - War Ethernal
            Insert(GetModel("Garu", (int)Versions.WarEternal));
            Insert(GetModel("Quilius", (int)Versions.WarEternal));
            Insert(GetModel("Ulgimor", (int)Versions.WarEternal));
            Insert(GetModel("Mazahaedron", (int)Versions.WarEternal));
            Insert(GetModel("Yan magda", (int)Versions.WarEternal));
            Insert(GetModel("Mist", (int)Versions.WarEternal));
            Insert(GetModel("Dezmodia", (int)Versions.WarEternal));
            Insert(GetModel("Gex", (int)Versions.WarEternal));
 
            //The void
            Insert(GetModel("Sparrow", (int)Versions.TheVoid));
            Insert(GetModel("Xanos", (int)Versions.TheVoid));

            //The outer dark
            Insert(GetModel("Indira", (int)Versions.TheOuterDark));
            Insert(GetModel("Remnant", (int)Versions.TheOuterDark));

            Console.WriteLine("Insert nemesis rows");
        }

        private Mages GetModel( string name, int versionId)
        {
            return new Mages() { Name = name, VersionId = versionId};
        }

        public void Insert(Mages mages)
        {
            _sqlite_cmd.CommandText = string.Format("INSERT INTO mages (name, versionId) VALUES ('{0}', {1});", mages.Name, mages.VersionId);
            _sqlite_cmd.ExecuteNonQuery();
        }
    }
}
