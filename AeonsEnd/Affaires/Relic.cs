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
                .Where(pr => versionId == pr.VersionId).ToList();

            foreach (var RelicModel in listeRelicsVersion)
            {
                int index = random.Next(listeRelicsVersion.Count);

                if (!listModelRandom.Contains(listeRelicsVersion[index]))
                    listModelRandom.Add(listeRelicsVersion[index]);
                if (listModelRandom.Count == numberRandom)
                    break;
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