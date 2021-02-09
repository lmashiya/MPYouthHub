using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MPYouthHubMVP.Models;

namespace MPYouthHubMVP.Controllers
{
    public class VolunteerController : Controller
    {
        // GET: Volunteer
        public ActionResult Index()
        {
            var volunteerOptions = GetVolunteerOptions();
            return View(volunteerOptions);
        }

        public List<VolunteerOption> GetVolunteerOptions()
        {
            var optionsList = new List<VolunteerOption>()
            {
                new VolunteerOption()
                {
                    OptionName = "Deliver Medication",
                    ExpiryDate = new DateTime(2020 - 20 - 28).Date
                },
                new VolunteerOption()
                {
                    OptionName = "Clean My Area",
                    ExpiryDate = new DateTime(2020 - 20 - 28).Date
                },
                new VolunteerOption()
                {
                    OptionName = "Food Parcel Distribution",
                    ExpiryDate = new DateTime(2020 - 20 - 28).Date
                }
            };
            
            return optionsList;
        }

        public ActionResult GoToLink()
        {
            return View("MedicineDeliveryView");
        }
    }
}
