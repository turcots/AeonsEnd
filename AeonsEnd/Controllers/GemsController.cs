
using System.Collections.Generic;
using System.Web.Http;
using AeonsEnd.Affaires;
using AeonsEnd.Models;

namespace AeonsEnd.Controllers
{
    public class GemsController : ApiController
    {
        // GET api/gems http://aeonsend.com/Gems/ObtenirGems?id=1
        [HttpGet()]
        public GemModel ObtenirGems(int id)
        {
            return new Gem().ObtenirGems(id);
        }

        // GET api/gems http://aeonsend.com/Gems/ObtenirGems?hasard=6&versionId=1
        [HttpGet()]
        public List<GemModel> ObtenirGems(int hasard, int versionId)
        {
            return new Gem().ObtenirGems(hasard, versionId); 
        }

        // GET api/gems http://aeonsend.com/Gems/ObtenirGemsTous
        [HttpGet()]
        public List<GemModel> ObtenirGemsTous()
        {
            return new Gem().ObtenirGemsTous();
        }

        // GET api/gems http://aeonsend.com/Gems/ObtenirGemsTous?versionId=1
        [HttpGet()]
        public List<GemModel> ObtenirGemsTous(int versionId)
        {
            return new Gem().ObtenirGemsTous(versionId);
        }
    }
}
