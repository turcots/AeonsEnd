using System;
using System.Collections.Generic;
using System.Data.SQLite;
using AeonsEnd.Models;

namespace AeonsEnd.Donnees
{
    public class GemDonnees
    {
        private Database _database;

        public GemDonnees()
        {
            _database = new Database();
        }

        public IEnumerable<GemModel> ObtenirGems()
        {
            _database.sqlite_conn.Open();

            List<GemModel> listGems = new List<GemModel>();

            string sql = "select * from gems";
            SQLiteCommand command = new SQLiteCommand(sql, _database.sqlite_conn);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listGems.Add(new GemModel()
                {
                    Id = Convert.ToInt32(reader["id"]),
                    Name = reader["name"].ToString(),
                    VersionId = Convert.ToInt32(reader["versionId"]),
                    Cost = Convert.ToInt32(reader["cost"])
                });
            }

            _database.sqlite_conn.Close();

            return listGems;
        }
    }
}