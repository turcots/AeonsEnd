
using AeonsEnd.Models;
using System.Collections.Generic;

namespace AeonsEnd.Affaires
{
    public interface IPartie
    {
        List<PartieModel> ObtenirPartieTous();
        string Insert(PartieModel partie);
        string Delete(int partieId);

    }
}
