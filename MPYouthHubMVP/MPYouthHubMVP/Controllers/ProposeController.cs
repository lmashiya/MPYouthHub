using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MPYouthHubMVP.Controllers
{
    public class ProposeController : Controller
    {
        // GET: Propose
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult ViewVenues(string s)
        {
            throw new NotImplementedException();
        }

        public ActionResult NewProposal(string s)
        {
            return View();
        }
    }
}
