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

            string sql = "select *, versions.name VersionName from sorts inner join versions on versions.id = sorts.versionId";
            SQLiteCommand command = new SQLiteCommand(sql, _database.sqlite_conn);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listSort.Add(new SortModel()
                {
                    Id = Convert.ToInt16(reader["id"]),
                    Name = reader["name"].ToString(),
                    VersionId = Convert.ToInt32(reader["versionId"]),
                    VersionName = reader["VersionName"].ToString(),
                    Cost = Convert.ToInt32(reader["cost"])
                });
            }

            _database.sqlite_conn.Close();

            return listSort;
        }
    }
}