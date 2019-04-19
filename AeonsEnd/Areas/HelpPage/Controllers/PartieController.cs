using System;
using System.Web.Http;
using System.Web.Mvc;
using AeonsEnd.Areas.HelpPage.ModelDescriptions;
using AeonsEnd.Areas.HelpPage.Models;

namespace AeonsEnd.Areas.HelpPage.Controllers
{
    public class PartieController : Controller
    {
        private HttpConfiguration configuration;

        public PartieController()
            : this(GlobalConfiguration.Configuration)
        {
        }

        public PartieController(HttpConfiguration configuration)
        {
            this.configuration = configuration;
        }

        // GET: HelpPage/Partie
        public ActionResult Index()
        {
            return View();
        }
    }
}