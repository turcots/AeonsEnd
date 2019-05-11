
using AeonsEnd.Donnees;
using AeonsEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AeonsEnd.Affaires
{
    public class Partie : IPartie
    {
        public Partie() { }

        public void Delete(int partieId)
        {
            new PartieDonnees().Delete(partieId);
        }

        public void Insert(PartieModel partie)
        {
            new PartieDonnees().Insert(partie);
        }

        public List<PartieModel> ObtenirPartieTous()
        {  
           return new PartieDonnees().ObtenirParties().ToList();
        }

        public void Update(PartieModel partie)
        {
            new PartieDonnees().Update(partie);
        }
    }
}