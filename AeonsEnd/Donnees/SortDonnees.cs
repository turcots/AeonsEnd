using AeonsEnd.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace AeonsEnd.Donnees
{
    public class SortDonnees
    {
        private Database _database;

        public SortDonnees()
        {
            _database = new Database();
        }

        public IEnumerable<SortModel> ObtenirSorts()
        {
            _database.sqlite_conn.Open();

            List<SortModel> listSort = new List<SortModel>();

            string sql = "select * from sorts";
            SQLiteCommand command = new SQLiteCommand(sql, _database.sqlite_conn);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listSort.Add(new SortModel()
                {
                    Id = Convert.ToInt32(reader["id"]),
                    Name = reader["name"].ToString(),
                    VersionId = Convert.ToInt32(reader["versionId"]),
                    Cost = Convert.ToInt32(reader["cost"])
                });
            }

            _database.sqlite_conn.Close();

            return listSort;
        }
    }
}