using AeonsEnd.Models;
using System.Collections.Generic;

namespace AeonsEnd.Affaires
{
    interface IMage
    {
        List<MageModel> ObtenirMages(int numberRandom, int versionId);
        MageModel ObtenirMage(int id);
        List<MageModel> ObtenirMagesTous();
        List<MageModel> ObtenirMagesTous(int versionId);
    }
}
