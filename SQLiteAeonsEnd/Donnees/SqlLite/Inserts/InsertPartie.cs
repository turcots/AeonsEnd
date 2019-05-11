using SQLiteAeonsEnd.Entity;
using System;
using System.Data.SQLite;

namespace SQLiteAeonsEnd.Donnees.SqlLite.Inserts
{
    public class InsertPartie
    {
        private SQLiteConnection _sqlite_conn;
        private SQLiteCommand _sqlite_cmd;

        public InsertPartie(SQLiteConnection sqlite_conn, SQLiteCommand sqlite_cmd)
        {
            _sqlite_conn = sqlite_conn;
            _sqlite_cmd = sqlite_cmd;
        }

        public void Inserts()
        {
            Insert(GetModel("nom", (int)Versions.AeonsEnd, 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,true,1,1,""));
  
            Console.WriteLine("Insert partie rows");
        }

        private Partie GetModel(string partieName, int versionId, int nemesisVie, int mageId1, int mageVie1, int mageId2, int mageVie2, int mageId3, int mageVie3, int mageId4, int mageVie4,
            int repliqueId1, int repliqueId2, int gemId1, int gemId2, int gemId3, int sortId1, int sortId2, int sortId3, int sortId4, bool partieGagne, int nbCycle, int graveholdVie, string commentaire )
        {
            return new Partie() {
                partieName = partieName,
                versionId = versionId,
                nemesisVie = nemesisVie,
                mageId1 = mageId1,
                mageVie1 = mageVie1,
                mageId2 = mageId2,
                mageVie2 = mageVie2,
                mageId3 = mageId3,
                mageVie3 = mageVie3,
                mageId4 = mageId4,
                mageVie4 = mageVie4,
                repliqueId1 = repliqueId1,
                repliqueId2 = repliqueId2,
                gemId1 = gemId1,
                gemId2 = gemId2,
                gemId3 = gemId3,
                sortId1 = sortId1,
                sortId2 = sortId2,
                sortId3 = sortId3,
                sortId4 = sortId4,
                partieGagne = partieGagne,
                nbCycle = nbCycle,
                graveholdVie = graveholdVie,
                commentaire = commentaire
            };
        }

        public void Insert(Partie partie)
        {
            _sqlite_cmd.CommandText = string.Format("INSERT INTO partie (name, level, versionId, life) " +
                "VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19}, {20}, {21}, {22}, {23});",
                partie.versionId,
                partie.nemesisVie,
                partie.mageId1,
                partie.mageVie1,
                partie.mageId2,
                partie.mageVie2,
                partie.mageId3,
                partie.mageVie3,
                partie.mageId4,
                partie.mageVie4,
                partie.repliqueId1,
                partie.repliqueId2,
                partie.gemId1,
                partie.gemId2,
                partie.gemId3,
                partie.sortId1,
                partie.sortId2,
                partie.sortId3,
                partie.sortId4,
                partie.partieGagne,
                partie.nbCycle,
                partie.graveholdVie,
                partie.commentaire);
            _sqlite_cmd.ExecuteNonQuery();
        }
    }
}