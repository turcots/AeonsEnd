
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
            //Version 2
            Insert(GetModel("Sparrow", 2));
            Insert(GetModel("Garu", 2));
            Insert(GetModel("Indira", 2));
            Insert(GetModel("Quilius", 2));
            Insert(GetModel("Ulgimor", 2));
            Insert(GetModel("Mazahaedron", 2));
            Insert(GetModel("Yan magda", 2));
            Insert(GetModel("Xanos", 2));
            Insert(GetModel("Mist", 2));
            Insert(GetModel("Dezmodia", 2));
            Insert(GetModel("Gex", 2));
            Insert(GetModel("Remnant", 2));

            //Version 1
            Insert(GetModel("Kadir", 1));
            Insert(GetModel("Phaedraxa", 1));
            Insert(GetModel("Adelheim", 1));
            Insert(GetModel("Brama", 1));
            Insert(GetModel("Jian", 1));
            Insert(GetModel("Mist", 1));
            Insert(GetModel("Xanos", 1));
            Insert(GetModel("Lash", 1));

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
