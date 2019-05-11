using System;
using System.Collections.Generic;
using System.Data.SQLite;
using AeonsEnd.Models;

namespace AeonsEnd.Donnees
{
    public class PartieDonnees
    {
        private Database _database;
        //private SQLiteConnection _sqlite_conn;
        //private SQLiteCommand _sqlite_cmd;

        public PartieDonnees()
        {
            _database = new Database();
        }

        public IEnumerable<PartieModel> ObtenirParties()
        {
            _database.sqlite_conn.Open();

            List<PartieModel> listRelics = new List<PartieModel>();

            string sql = "select * from partie";
            SQLiteCommand command = new SQLiteCommand(sql, _database.sqlite_conn);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listRelics.Add(new PartieModel()
                {
                    partieId = Convert.ToInt16(reader["partieId"]),
                    partieName = Convert.ToString(reader["partieName"]),
                    versionId = Convert.ToInt16(reader["versionId"]),
                    nemesisId = Convert.ToInt16(reader["nemesisId"]),
                    nemesisVie = Convert.ToInt16(reader["nemesisVie"]),
                    mageId1 = Convert.ToInt16(reader["mageId1"]),
                    mageVie1 = Convert.ToInt16(reader["mageVie1"]),
                    mageId2 = Convert.ToInt16(reader["mageId2"]),
                    mageVie2 = Convert.ToInt16(reader["mageVie2"]),
                    mageId3 = Convert.ToInt16(reader["mageId3"]),
                    mageVie3 = Convert.ToInt16(reader["mageVie3"]),
                    mageId4 = Convert.ToInt16(reader["mageId4"]),
                    mageVie4 = Convert.ToInt16(reader["mageVie4"]),
                    repliqueId1 = Convert.ToInt16(reader["repliqueId1"]),
                    repliqueId2 = Convert.ToInt16(reader["repliqueId2"]),
                    gemId1 = Convert.ToInt16(reader["gemId1"]),
                    gemId2 = Convert.ToInt16(reader["gemId2"]),
                    gemId3 = Convert.ToInt16(reader["gemId3"]),
                    sortId1 = Convert.ToInt16(reader["sortId1"]),
                    sortId2 = Convert.ToInt16(reader["sortId2"]),
                    sortId3 = Convert.ToInt16(reader["sortId3"]),
                    sortId4 = Convert.ToInt16(reader["sortId4"]),
                    partieGagne = Convert.ToBoolean(reader["partieGagne"]),
                    nbCycle = Convert.ToInt16(reader["nbCycle"]),
                    graveholdVie = Convert.ToInt16(reader["graveholdVie"]),
                    commentaire = Convert.ToString(reader["commentaire"])
                });
            }

            _database.sqlite_conn.Close();

            return listRelics;
        }

        internal void Delete(int partieId)
        {
            _database.sqlite_conn.Open();
            var sql = string.Format("DELETE FROM partie where partieId = {0}", partieId);

            SQLiteCommand command = new SQLiteCommand(sql, _database.sqlite_conn);
            SQLiteDataReader reader = command.ExecuteReader();

            _database.sqlite_conn.Close();
        }

        public void Insert(PartieModel partie)
        {
            _database.sqlite_conn.Open();

            var sql = string.Format("INSERT INTO partie (partieName,versionId,nemesisId,nemesisVie,mageId1,mageVie1,mageId2,mageVie2,mageId3,mageVie3,mageId4,mageVie4,repliqueId1,repliqueId2,gemId1,gemId2,gemId3,sortId1,sortId2,sortId3,sortId4,partieGagne,nbCycle,graveholdVie,commentaire) VALUES " +
                "('{0}', {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19}, {20}, {21}, {22}, {23}, '{24}');", 
                partie.partieName,
                partie.versionId,
                partie.nemesisId,
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
                partie.commentaire
                );

            SQLiteCommand command = new SQLiteCommand(sql, _database.sqlite_conn);
            SQLiteDataReader reader = command.ExecuteReader();

            //_sqlite_cmd.ExecuteNonQuery();

            _database.sqlite_conn.Close();
        }
    }
}