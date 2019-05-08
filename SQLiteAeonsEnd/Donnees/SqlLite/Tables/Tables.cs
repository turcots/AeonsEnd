using SQLiteAeonsEnd.Donnees.SqlLite.Tables;
using System.Data.SQLite;

namespace SQLiteAeonsEnd.Affaires.SqlLite
{
    public class Tables
    {
        private SQLiteConnection _sqlite_conn;
        private SQLiteCommand _sqlite_cmd;

        public Tables(SQLiteConnection sqlite_conn)
        {
            _sqlite_conn = sqlite_conn;
        }

        public void Create()
        {
            _sqlite_cmd = _sqlite_conn.CreateCommand();
            _sqlite_cmd.CommandText = "PRAGMA foreign_keys = ON;";
            _sqlite_cmd.ExecuteNonQuery();

            new TableVersion(_sqlite_conn, _sqlite_cmd).Create();
            new TableNemesis(_sqlite_conn, _sqlite_cmd).Create();
            new TableMages(_sqlite_conn, _sqlite_cmd).Create();
            new TableGems(_sqlite_conn, _sqlite_cmd).Create();
            new TableRelics(_sqlite_conn, _sqlite_cmd).Create();
            new TableSorts(_sqlite_conn, _sqlite_cmd).Create();
            new TablePartie(_sqlite_conn, _sqlite_cmd).Create();
            //new TablePartieMage(_sqlite_conn, _sqlite_cmd).Create();
        }
    }
}
