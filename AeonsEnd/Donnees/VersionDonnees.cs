using System;
using System.Collections.Generic;
using System.Data.SQLite;
using AeonsEnd.Models;

namespace AeonsEnd.Donnees
{
    public class VersionDonnees
    {
        private Database _database;

        public VersionDonnees()
        {
            _database = new Database();
        }

        public IEnumerable<VersionModel> ObtenirVersions()
        {
            _database.sqlite_conn.Open();

            List<VersionModel> listVersions = new List<VersionModel>();

            string sql = "select * from versions";
            SQLiteCommand command = new SQLiteCommand(sql, _database.sqlite_conn);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listVersions.Add(new VersionModel()
                {
                    Id = Convert.ToInt32(reader["id"]),
                    Nom = reader["name"].ToString()
                });
            }

            _database.sqlite_conn.Close();

            return listVersions;
        }
    }
}