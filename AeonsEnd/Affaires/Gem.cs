
using System;
using System.Collections.Generic;
using System.Linq;
using AeonsEnd.Donnees;
using AeonsEnd.Models;

namespace AeonsEnd.Affaires
{
    public class Gem : IGem
    {
        public Gem(){}

        public List<GemModel> ObtenirGems(int numberRandom, int versionId)
        {
            List<GemModel> listModelRandom = new List<GemModel>();

            var random = new Random();
            var listeGems = new GemDonnees().ObtenirGems();
            var listeGemsVersion = listeGems
                .Where(pr => versionId == pr.VersionId).ToList();

            foreach (var gemModel in listeGemsVersion)
            {
                int index = random.Next(listeGemsVersion.Count);

                if (!listModelRandom.Contains(listeGemsVersion[index]))
                    listModelRandom.Add(listeGemsVersion[index]);
                if (listModelRandom.Count == numberRandom)
                    break;
            }

            return listModelRandom;
        }

        public GemModel ObtenirGems(int id)
        {
            var listeGems = new GemDonnees().ObtenirGems();
            return listeGems.Where(pr => id == pr.Id).FirstOrDefault();
        }

        public List<GemModel> ObtenirGemsTous()
        {
            return new GemDonnees().ObtenirGems().ToList();
        }

        public List<GemModel> ObtenirGemsTous(int versionId)
        {
            List<GemModel> listModelRandom = new List<GemModel>();
            var listeGems = new GemDonnees().ObtenirGems();
            var listeGemsVersion = listeGems
                .Where(pr => versionId == pr.VersionId).ToList();
            return listeGemsVersion;
        }
    }
}