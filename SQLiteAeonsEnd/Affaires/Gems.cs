
using SQLiteAeonsEnd.Donnees.SqlLite;
using System.Collections.Generic;

namespace SQLiteAeonsEnd.Affaires
{
    public class Gems : IGems
    {
        public Gems(){}

        public List<Entity.Gems> ObtenirGems()
        {
            return new SelectGems().ObtenirGems();
        }
    }
}
