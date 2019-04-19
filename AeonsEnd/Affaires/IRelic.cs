using AeonsEnd.Models;
using System.Collections.Generic;

namespace AeonsEnd.Affaires
{
    interface IRelic
    {
        List<RelicModel> ObtenirRelics(int numberRandom, int versionId);
        RelicModel ObtenirRelics(int id);
        List<RelicModel> ObtenirRelicsTous();
        List<RelicModel> ObtenirRelicsTous(int versionId);
    }
}
