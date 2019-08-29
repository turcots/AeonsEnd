
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
            Insert(GetModel("Kadir", (int)Versions.AeonsEnd, "breach mage delver"));//mage de la brèche, chercheuse; breach mage delver
            Insert(GetModel("Phaedraxa", (int)Versions.AeonsEnd, "breach mage seer"));//mage de la brèche, voyante; ; breach mage seer
            Insert(GetModel("Adelheim", (int)Versions.AeonsEnd, "breach mage weaponsmith"));//mage de la brèche, armurier; ; breach mage weaponsmith
            Insert(GetModel("Brama", (int)Versions.AeonsEnd, "breach mage elder"));//mage de la brèche, ancienne; ; breach mage elder
            Insert(GetModel("Jian", (int)Versions.AeonsEnd, "breach mage orphan"));//mage de la brèche, orpheline; ; breach mage orphan
            Insert(GetModel("Mist", (int)Versions.AeonsEnd, "dagger captain"));//capitaine de la dague; dagger captain
            Insert(GetModel("Xanos", (int)Versions.AeonsEnd, "breach mage adept"));//mage de la brèche, adepte; ; breach mage adept
            Insert(GetModel("Lash", (int)Versions.AeonsEnd, "breach mage scout")); //mage de la brèche,éclaireur; breach mage scout

            //Aeon's End - War Ethernal
            Insert(GetModel("Garu", (int)Versions.WarEternal, "oathsworn protector"));//oathsworn protector
            Insert(GetModel("Quilius", (int)Versions.WarEternal, "breach mage assassin"));//breach mage assassin
            Insert(GetModel("Ulgimor", (int)Versions.WarEternal, "shadowkin beast"));//shadowkin beast
            Insert(GetModel("Mazahaedron", (int)Versions.WarEternal, "henge mystic"));//henge mystic
            Insert(GetModel("Yan magda", (int)Versions.WarEternal, "enlightened exile"));//enlightened exile
            Insert(GetModel("Mist-VW", (int)Versions.WarEternal, "voidwalker"));//voidwalker
            Insert(GetModel("Dezmodia", (int)Versions.WarEternal, "voidborn prodigy"));//voidborn prodigy
            Insert(GetModel("Gex", (int)Versions.WarEternal, "breach mage adviser"));//breach mage adviser
 
            //The void
            Insert(GetModel("Sparrow", (int)Versions.TheVoid, "breach mage soldier"));//breach mage soldier
            Insert(GetModel("Xaxos-VB", (int)Versions.TheVoid, "voidbringer"));//voidbringer

            //The outer dark
            Insert(GetModel("Indira", (int)Versions.TheOuterDark, "breach apprentice"));//breach apprentice
            Insert(GetModel("Remnant", (int)Versions.TheOuterDark, "aethereal entity"));//aethereal entity

            //The depths
            Insert(GetModel("Nym", (int)Versions.Depths, "Breach mage apprentice"));
            Insert(GetModel("Reeve", (int)Versions.Depths, "Breach mage elite"));
            Insert(GetModel("Z''hana", (int)Versions.Depths, "Breach mage renegade"));

            //The nameless
            Insert(GetModel("Malastar", (int)Versions.Nameless, "Breach mage mentor"));

            Console.WriteLine("Insert nemesis rows");
        }

        private Mages GetModel( string name, int versionId, string description)
        {
            return new Mages() { Name = name, VersionId = versionId, Description = description};
        }

        public void Insert(Mages mages)
        {
            _sqlite_cmd.CommandText = string.Format("INSERT INTO mages (name, versionId, description) VALUES ('{0}', {1}, '{2}');", mages.Name, mages.VersionId, mages.Description);
            _sqlite_cmd.ExecuteNonQuery();
        }
    }
}
