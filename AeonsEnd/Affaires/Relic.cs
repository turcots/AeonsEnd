using System;
using System.Collections.Generic;
using System.Linq;
using AeonsEnd.Donnees;
using AeonsEnd.Models;


namespace AeonsEnd.Affaires
{
    public class Relic : IRelic
    {
        public Relic() { }

        public List<RelicModel> ObtenirRelics(int numberRandom, int versionId)
        {
            List<RelicModel> listModelRandom = new List<RelicModel>();

            var random = new Random();
            var listeRelics = new RelicDonnees().ObtenirRelics();
            var listeRelicsVersion = listeRelics
                .Where(pr => versionId == pr.VersionId || versionId == 0).ToList();

            if (numberRandom >= listeRelicsVersion.Count)
                return listeRelicsVersion;

            while (listModelRandom.Count < numberRandom)
            {
                int index = random.Next(listeRelicsVersion.Count);

                if (!listModelRandom.Contains(listeRelicsVersion[index]))
                    listModelRandom.Add(listeRelicsVersion[index]);
            }

            return listModelRandom;
        }

        public RelicModel ObtenirRelics(int id)
        {
            var listeRelics = new RelicDonnees().ObtenirRelics();
            return listeRelics.Where(pr => id == pr.Id).FirstOrDefault();
        }

        public List<RelicModel> ObtenirRelicsTous()
        {
            return new RelicDonnees().ObtenirRelics().ToList();
        }

        public List<RelicModel> ObtenirRelicsTous(int versionId)
        {
            List<RelicModel> listModelRandom = new List<RelicModel>();
            var listeRelics = new RelicDonnees().ObtenirRelics();
            var listeRelicsVersion = listeRelics
                .Where(pr => versionId == pr.VersionId).ToList();
            return listeRelicsVersion;
        }
    }
}