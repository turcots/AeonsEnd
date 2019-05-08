using System.Collections.Generic;
using System.Web.Http;
using AeonsEnd.Affaires;
using AeonsEnd.Models;

namespace AeonsEnd.Controllers
{
    public class MagesController : ApiController
    {
        // GET api/Mages http://aeonsend.com/Mages/ObtenirMages?id=1
        [HttpGet()]
        public MageModel ObtenirMages(int id)
        {
            return new Mage().ObtenirMage(id);
        }

        // GET api/Mages http://aeonsend.com/Mages/ObtenirMages?hasard=6&versionId=1
        [HttpGet()]
        public List<MageModel> ObtenirMages(int hasard, int versionId)
        {
            return new Mage().ObtenirMages(hasard, versionId);
        }

        // GET api/Mages http://aeonsend.com/Mages/ObtenirMagesTous
        [HttpGet()]
        [Route("ObtenirMagesTous/")]
        public List<MageModel> ObtenirMagesTous()
        {
            return new Mage().ObtenirMagesTous();
        }

        //// GET api/Mages http://aeonsend.com/Mages/ObtenirMagesTous?versionId=1
        //[HttpGet()]
        //public List<MageModel> ObtenirMagesTous(int versionId)
        //{
        //    return new Mage().ObtenirMagesTous(versionId);
        //}

    }
}