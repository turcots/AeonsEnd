
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

        public string Delete(int partieId)
        {
            string messageErreur = "Partie supprimée";
            try
            {
                new PartieDonnees().Delete(partieId);
            }
            catch (Exception e)
            {
                messageErreur = e.Message;
            }

            return messageErreur;
        }

        public string Insert(PartieModel partie)
        {
            string messageErreur = "Partie sauvegardée";
            //try
            //{
            //    new PartieDonnees().Insert(partie);
            //}
            //catch (Exception e)
            //{
            //    messageErreur = e.Message;
            //}
            new PartieDonnees().Insert(partie);

            return messageErreur;
        }

        public List<PartieModel> ObtenirPartieTous()
        {  
           return new PartieDonnees().ObtenirParties().ToList();
        }
    }
}