
using AeonsEnd.Models;
using System.Collections.Generic;

namespace AeonsEnd.Affaires
{
    public interface IGem
    {
        List<GemModel> ObtenirGems(int numberRandom, int versionId);
        GemModel ObtenirGems(int id);
        List<GemModel> ObtenirGemsTous();
        List<GemModel> ObtenirGemsTous(int versionId);
    }
}
