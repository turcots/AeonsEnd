using System;
using System.Collections.Generic;
using System.Data.SQLite;
using AeonsEnd.Models;

namespace AeonsEnd.Donnees
{
    public class PartieDonnees
    {
        private Database _database;

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
                    partieId = Convert.ToInt16(reader["id"]),
                    //versionId = reader["name"].ToString(),
                    //VersionName = reader["VersionName"].ToString(),
                    //VersionId = Convert.ToInt32(reader["versionId"]),
                    //Cost = Convert.ToInt32(reader["cost"])
                });
            }

            _database.sqlite_conn.Close();

            return listRelics;
        }
    }
}