
using AeonsEnd.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace AeonsEnd.Donnees
{
    public class NemesisDonnees
    {
        private Database _database;

        public NemesisDonnees()
        {
            _database = new Database();
        }

        public IEnumerable<NemesisModel> ObtenirNemesis()
        {
            _database.sqlite_conn.Open();

            List<NemesisModel> listNemesis = new List<NemesisModel>();

            string sql = "select * from Nemesis";
            SQLiteCommand command = new SQLiteCommand(sql, _database.sqlite_conn);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listNemesis.Add(new NemesisModel()
                {
                    Id = Convert.ToInt32(reader["id"]),
                    Name = reader["name"].ToString(),
                    VersionId = Convert.ToInt32(reader["versionId"]),
                    Level = Convert.ToInt32(reader["level"]),
                    Life = Convert.ToInt32(reader["life"])    
                });
            }

            _database.sqlite_conn.Close();

            return listNemesis;
        }
    }
}
