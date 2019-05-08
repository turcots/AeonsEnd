
using AeonsEnd.Affaires;
using AeonsEnd.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace AeonsEnd.Controllers.Versions
{
    public class VersionsController : ApiController
    {
        // GET api/Version http://aeonsend.com/Version/ObtenirVersion?randomNumber=6&versionId=1
        [HttpGet()]
        public VersionModel ObtenirVersion(int hasard, int versionId)
        {
            return new Version().ObtenirVersionHasard();
        }

        // GET api/Version http://aeonsend.com/Version/ObtenirVersionTous
        [HttpGet()]
        [Route("ObtenirVersionTous/")]
        public List<VersionModel> ObtenirVersionTous()
        {
            return new Version().ObtenirVersionsTous();
        }

        //// GET api/Version http://aeonsend.com/Version/ObtenirVersionTous?versionId=1
        //[HttpGet()]
        //public VersionModel ObtenirVersionTous(int id)
        //{
        //    return new Version().ObtenirVersions(id);
        //}
    }
}