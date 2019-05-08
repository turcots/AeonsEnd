using System;
using System.Collections.Generic;
using System.Linq;
using AeonsEnd.Donnees;
using AeonsEnd.Models;


namespace AeonsEnd.Affaires
{
    public class Nemesis : INemesis
    {
        public List<NemesisModel> ObtenirNemesis(int hasard, int versionId)
        {
            List<NemesisModel> listModelRandom = new List<NemesisModel>();

            var random = new Random();
            var listeNemesis = new NemesisDonnees().ObtenirNemesis();
            var listeNemesisVersion = listeNemesis
                .Where(pr => versionId == pr.VersionId || versionId == 0).ToList();

            if (hasard >= listeNemesisVersion.Count)
                return listeNemesisVersion;

            while (listModelRandom.Count < hasard)
            {
                int index = random.Next(listeNemesisVersion.Count);

                if (!listModelRandom.Contains(listeNemesisVersion[index]))
                    listModelRandom.Add(listeNemesisVersion[index]);
            }
            
            return listModelRandom;
        }

        public NemesisModel ObtenirNemesis(int id)
        {
            var listeNemesis = new NemesisDonnees().ObtenirNemesis();
            return listeNemesis.Where(pr => id == pr.Id).FirstOrDefault();
        }

        public List<NemesisModel> ObtenirNemesisTous()
        {
            return new NemesisDonnees().ObtenirNemesis().ToList();
        }

        public List<NemesisModel> ObtenirNemesisTous(int versionId)
        {
            List<NemesisModel> listModelRandom = new List<NemesisModel>();
            var listeNemesiss = new NemesisDonnees().ObtenirNemesis();
            var listeNemesissVersion = listeNemesiss
                .Where(pr => versionId == pr.VersionId).ToList();
            return listeNemesissVersion;
        }

        public List<NemesisModel> ObtenirNemesis()
        {
            List<NemesisModel> listModelRandom = new List<NemesisModel>();

            var random = new Random();
            var listeNemesis = new NemesisDonnees().ObtenirNemesis().ToList();

            int index = random.Next(listeNemesis.Count);
            listModelRandom.Add(listeNemesis[index]);

            return listModelRandom;
        }
    }
}