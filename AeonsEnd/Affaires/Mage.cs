
using System;
using System.Collections.Generic;
using System.Linq;
using AeonsEnd.Donnees;
using AeonsEnd.Models;
namespace AeonsEnd.Affaires
{
    public class Mage : IMage
    {
        public MageModel ObtenirMage(int id)
        {
            var listeMages = new MageDonnees().ObtenirMages();
            return listeMages.Where(pr => id == pr.Id).FirstOrDefault();
        }

        public List<MageModel> ObtenirMages(int numberRandom, int versionId)
        {
            List<MageModel> listModelRandom = new List<MageModel>();

            var random = new Random();
            var listeMages = new MageDonnees().ObtenirMages();
            var listeMagesVersion = listeMages
                .Where(pr => versionId == pr.VersionId).ToList();

            foreach (var MageModel in listeMagesVersion)
            {
                int index = random.Next(listeMagesVersion.Count);

                if (!listModelRandom.Contains(listeMagesVersion[index]))
                    listModelRandom.Add(listeMagesVersion[index]);
                if (listModelRandom.Count == numberRandom)
                    break;
            }

            return listModelRandom;
        }

        public List<MageModel> ObtenirMagesTous()
        {
            return new MageDonnees().ObtenirMages().ToList();
        }

        public List<MageModel> ObtenirMagesTous(int versionId)
        {
            List<MageModel> listModelRandom = new List<MageModel>();
            var listeMages = new MageDonnees().ObtenirMages();
            var listeMagesVersion = listeMages
                .Where(pr => versionId == pr.VersionId).ToList();
            return listeMagesVersion;
        }
    }
}
