using System;
using System.Collections.Generic;
using System.Data.SQLite;
using AeonsEnd.Models;

namespace AeonsEnd.Donnees
{
    public class MageDonnees
    {
        private Database _database;

        public MageDonnees()
        {
            _database = new Database();
        }

        public IEnumerable<MageModel> ObtenirMages()
        {
            _database.sqlite_conn.Open();

            List<MageModel> listMages = new List<MageModel>();

            string sql = "select * from Mages";
            SQLiteCommand command = new SQLiteCommand(sql, _database.sqlite_conn);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listMages.Add(new MageModel()
                {
                    Id = Convert.ToInt32(reader["id"]),
                    Name = reader["name"].ToString(),
                    VersionId = Convert.ToInt32(reader["versionId"])
                });
            }

            _database.sqlite_conn.Close();

            return listMages;
        }
    }
}