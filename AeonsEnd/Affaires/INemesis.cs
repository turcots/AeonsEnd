using AeonsEnd.Models;
using System.Collections.Generic;

namespace AeonsEnd.Affaires
{
    interface INemesis
    {
        List<NemesisModel> ObtenirNemesis(int hasard, int versionId);
        NemesisModel ObtenirNemesis(int id);
        List<NemesisModel> ObtenirNemesisTous();
        List<NemesisModel> ObtenirNemesisTous(int versionId);
    }
}
