
using System.Collections.Generic;
using System.Web.Http;
using AeonsEnd.Affaires;
using AeonsEnd.Models;

namespace AeonsEnd.Controllers
{
    public class SortsController : ApiController
    {
        // GET api/Sorts http://aeonsend.com/Sorts/ObtenirSorts?id=1
        [HttpGet()]
        public SortModel ObtenirSorts(int id)
        {
            return new Sort().ObtenirSorts(id);
        }

        // GET api/Sorts http://aeonsend.com/Sorts/ObtenirSorts?hasard=6&versionId=1
        [HttpGet()]
        public List<SortModel> ObtenirSorts(int hasard, int versionId)
        {
            return new Sort().ObtenirSorts(hasard, versionId);
        }

        // GET api/Sorts http://aeonsend.com/Sorts/ObtenirSortsTous
        [HttpGet()]
        public List<SortModel> ObtenirSortsTous()
        {
            return new Sort().ObtenirSortsTous();
        }

        // GET api/Sorts http://aeonsend.com/Sorts/ObtenirSortsTous?versionId=1
        [HttpGet()]
        public List<SortModel> ObtenirSortsTous(int versionId)
        {
            return new Sort().ObtenirSortsTous(versionId);
        }
    }
}