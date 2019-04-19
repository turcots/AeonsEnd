
using System.Collections.Generic;
using System.Web.Http;
using AeonsEnd.Affaires;
using AeonsEnd.Models;

namespace AeonsEnd.Controllers
{
    public class RelicsController : ApiController
    {
        // GET api/Relics http://aeonsend.com/Relics/ObtenirRelics?id=1
        [HttpGet()]
        public RelicModel ObtenirRelics(int id)
        {
            return new Relic().ObtenirRelics(id);
        }

        // GET api/Relics http://aeonsend.com/Relics/ObtenirRelics?hasard=6&versionId=1
        [HttpGet()]
        public List<RelicModel> ObtenirRelics(int hasard, int versionId)
        {
            return new Relic().ObtenirRelics(hasard, versionId);
        }

        // GET api/Relics http://aeonsend.com/Relics/ObtenirRelicsTous
        [HttpGet()]
        public List<RelicModel> ObtenirRelicsTous()
        {
            return new Relic().ObtenirRelicsTous();
        }

        // GET api/Relics http://aeonsend.com/Relics/ObtenirRelicsTous?versionId=1
        [HttpGet()]
        public List<RelicModel> ObtenirRelicsTous(int versionId)
        {
            return new Relic().ObtenirRelicsTous(versionId);
        }
    }
}
