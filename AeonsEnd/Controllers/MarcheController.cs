using System.Collections.Generic;
using System.Web.Http;
using AeonsEnd.Affaires;
using AeonsEnd.Models;

namespace AeonsEnd.Controllers
{
    public class MarcheController : ApiController
    {
        // GET api/Marche http://aeonsend.com/Marche/ObtenirMarche?nbJoueur=2&versionId=2
        [HttpGet()]
        public MarcheModel ObtenirMarche(int nbJoueur, int versionId)
        {
            return new Marche().ObtenirMarche(nbJoueur, versionId);
        }
        [HttpGet()]
        public MarcheModel ObtenirMarcheTous()
        {
            return new Marche().ObtenirMarche();
        }
    }
}