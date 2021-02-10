using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MPYouthHubMVP.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GoToVolunteer()
        {
            return RedirectToAction("Index","Volunteer");
        }

        [HttpGet]
        public ActionResult GoToSkills()
        {
            return RedirectToAction("Index","Skills");
        }

        [HttpGet]
        public ActionResult GoToCommunicate()
        {
            return RedirectToAction("Index","Communicate");
        }

        public ActionResult GoToPropose()
        {
            throw new NotImplementedException();
        }

        public ActionResult GoToMentor()
        {
            throw new NotImplementedException();
        }

        public ActionResult GoToWater()
        {
            throw new NotImplementedException();
        }

        public ActionResult GoToBuild()
        {
            throw new NotImplementedException();
        }

        public ActionResult GoToShare()
        {
            throw new NotImplementedException();
        }

        public ActionResult GoToProfile()
        {
            throw new NotImplementedException();
        }
    }
}