﻿
using AeonsEnd.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace AeonsEnd.Donnees
{
    public class RelicDonnees
    {
        private Database _database;

        public RelicDonnees()
        {
            _database = new Database();
        }

        public IEnumerable<RelicModel> ObtenirRelics()
        {
            _database.sqlite_conn.Open();

            List<RelicModel> listRelics = new List<RelicModel>();

            string sql = "select * from relics";
            SQLiteCommand command = new SQLiteCommand(sql, _database.sqlite_conn);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listRelics.Add(new RelicModel()
                {
                    Id = Convert.ToInt32(reader["id"]),
                    Name = reader["name"].ToString(),
                    VersionId = Convert.ToInt32(reader["versionId"]),
                    Cost = Convert.ToInt32(reader["cost"])
                });
            }

            _database.sqlite_conn.Close();

            return listRelics;
        }
    }
}