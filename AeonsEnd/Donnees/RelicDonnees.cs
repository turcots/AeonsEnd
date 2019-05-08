
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

            string sql = "select relics.*, versions.name VersionName from relics inner join versions on versions.id = relics.versionId";
            SQLiteCommand command = new SQLiteCommand(sql, _database.sqlite_conn);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listRelics.Add(new RelicModel()
                {
                    Id = Convert.ToInt16(reader["id"]),
                    Name = reader["name"].ToString(),
                    VersionName = reader["VersionName"].ToString(),
                    VersionId = Convert.ToInt32(reader["versionId"]),
                    Cost = Convert.ToInt32(reader["cost"])
                });
            }

            _database.sqlite_conn.Close();

            return listRelics;
        }
    }
}