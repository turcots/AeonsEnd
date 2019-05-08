using System.Collections.Generic;
using System.Web.Http;
using AeonsEnd.Affaires;
using AeonsEnd.Models;

namespace AeonsEnd.Controllers
{
    public class NemesisController : ApiController
    {
        // GET api/Nemesis http://aeonsend.com/Nemesis/ObtenirNemesis?randomNumber=6&versionId=1
        [HttpGet()]
        public List<NemesisModel> ObtenirNemesis(int hasard, int versionId)
        {
            return new Nemesis().ObtenirNemesis(hasard, versionId);
        }

        // GET api/Nemesis http://aeonsend.com/Nemesis/ObtenirNemesisTous
        [HttpGet()]
        [Route("ObtenirNemesisTous/")]
        public List<NemesisModel> ObtenirNemesisTous()
        {
            return new Nemesis().ObtenirNemesisTous();
        }

        //// GET api/Nemesis http://aeonsend.com/Nemesis/ObtenirNemesisTous?versionId=1
        //[HttpGet()]
        //public List<NemesisModel> ObtenirNemesisTous(int versionId)
        //{
        //    return new Nemesis().ObtenirNemesisTous(versionId);
        //}
    }
}