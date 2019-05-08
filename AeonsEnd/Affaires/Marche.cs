
using AeonsEnd.Models;
using System.Linq;

namespace AeonsEnd.Affaires
{
    public class Marche
    {
        public MarcheModel ObtenirMarche()
        {
            MarcheModel marche = new MarcheModel();

            marche.ListeNemesis = new Nemesis().ObtenirNemesisTous();
            marche.ListeMages = new Mage().ObtenirMagesTous();
            marche.ListeGems = new Gem().ObtenirGemsTous();
            marche.ListeRelics = new Relic().ObtenirRelicsTous();
            marche.ListeSorts = new Sort().ObtenirSortsTous();
            marche.ListeVersions = new Version().ObtenirVersionsTous();

            return marche;
        }

        public MarcheModel ObtenirMarche(int nbJoueur, int versionId)
        {
            var nemesis = new Nemesis().ObtenirNemesis(1, versionId).FirstOrDefault();
            var listeMages = new Mage().ObtenirMages(nbJoueur, versionId);
            var listeGems = new Gem().ObtenirGems(3, versionId);
            var listeRelics = new Relic().ObtenirRelics(2, versionId);
            var listeSorts = new Sort().ObtenirSorts(4, versionId);

            return new MarcheModel() {
                Nemesis = nemesis,
                ListeGems = listeGems,
                ListeMages = listeMages,
                ListeRelics = listeRelics,
                ListeSorts = listeSorts
            };
        }
    }
}