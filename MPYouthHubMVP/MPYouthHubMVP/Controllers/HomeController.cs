using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MPYouthHubMVP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GoToVolunteer()
        {
            return RedirectToAction("Index","Volunteer");
        }

        public ActionResult GoToSkills()
        {
            return RedirectToAction("Index","Skills");
        }

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