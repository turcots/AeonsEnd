
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;

namespace SQLiteAeonsEnd.Donnees.SqlLite
{
    public class SelectGems
    {
        private SQLiteConnection _sqlite_conn;
        private string _databaseConnection;

        public SelectGems()
        {
            _databaseConnection = ConfigurationManager.ConnectionStrings["aeonsEndConnectionBd"].ConnectionString;
            _sqlite_conn = new SQLiteConnection(_databaseConnection);
        }

        public List<Entity.Gems> ObtenirGems()
        {
            _sqlite_conn.Open();

            List <Entity.Gems> listGems = new List<Entity.Gems>();

            string sql = "select * from gems";
            SQLiteCommand command = new SQLiteCommand(sql, _sqlite_conn);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listGems.Add(new Entity.Gems(){
                    Id = Convert.ToInt32(reader["id"]),
                    Name = reader["name"].ToString(),
                    VersionId = Convert.ToInt32(reader["versionId"]),
                    Cost = Convert.ToInt32(reader["cost"])
                });
            }

            _sqlite_conn.Close();

            return listGems;
        }

    }
}
