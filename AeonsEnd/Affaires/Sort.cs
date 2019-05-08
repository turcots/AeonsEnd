using System;
using System.Collections.Generic;
using System.Linq;
using AeonsEnd.Donnees;
using AeonsEnd.Models;

namespace AeonsEnd.Affaires
{
    public class Sort : ISort
    {
        public Sort() { }

        public List<SortModel> ObtenirSorts(int numberRandom, int versionId)
        {
            List<SortModel> listModelRandom = new List<SortModel>();

            var random = new Random();
            var listeSorts = new SortDonnees().ObtenirSorts();
            var listeSortsVersion = listeSorts
                .Where(pr => versionId == pr.VersionId || versionId == 0).ToList();

            if (numberRandom >= listeSortsVersion.Count)
                return listeSortsVersion;

            while (listModelRandom.Count < numberRandom)
            {
                int index = random.Next(listeSortsVersion.Count);

                if (!listModelRandom.Contains(listeSortsVersion[index]))
                    listModelRandom.Add(listeSortsVersion[index]);
            }
            return listModelRandom;
        }

        public SortModel ObtenirSorts(int id)
        {
            var listeSorts = new SortDonnees().ObtenirSorts();
            return listeSorts.Where(pr => id == pr.Id).FirstOrDefault();
        }

        public List<SortModel> ObtenirSortsTous()
        {
            return new SortDonnees().ObtenirSorts().ToList();
        }

        public List<SortModel> ObtenirSortsTous(int versionId)
        {
            List<SortModel> listModelRandom = new List<SortModel>();
            var listeSorts = new SortDonnees().ObtenirSorts();
            var listeSortsVersion = listeSorts
                .Where(pr => versionId == pr.VersionId).ToList();
            return listeSortsVersion;
        }
    }
}