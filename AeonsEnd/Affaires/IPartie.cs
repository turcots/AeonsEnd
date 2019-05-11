
using AeonsEnd.Models;
using System.Collections.Generic;

namespace AeonsEnd.Affaires
{
    public interface IPartie
    {
        List<PartieModel> ObtenirPartieTous();
        void Insert(PartieModel partie);
        void Update(PartieModel partie);
        void Delete(int partieId);

    }
}
