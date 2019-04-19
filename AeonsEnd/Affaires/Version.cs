
using System;
using System.Collections.Generic;
using System.Linq;
using AeonsEnd.Donnees;
using AeonsEnd.Models;

namespace AeonsEnd.Affaires
{
    public class Version : IVersion
    {
        public VersionModel ObtenirVersionHasard()
        {
            var random = new Random();
            var listeVersions = new VersionDonnees().ObtenirVersions().ToList();

            int index = random.Next(listeVersions.Count);

            return listeVersions[index];
        }

        public VersionModel ObtenirVersions(int id)
        {
            var listeVersion = new VersionDonnees().ObtenirVersions();
            return listeVersion.Where(pr => id == pr.Id).FirstOrDefault();
        }

        public List<VersionModel> ObtenirVersionsTous()
        {
            return new VersionDonnees().ObtenirVersions().ToList();
        }
    }
}