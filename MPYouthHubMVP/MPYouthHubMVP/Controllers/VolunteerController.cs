using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using MPYouthHubMVP.Models;
using Newtonsoft.Json;

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
            var clinics = GetClinics();  
            return View("MedicineDeliveryView",clinics);
        }

        public ActionResult GoToPatients()
        {
            return View("GoToPatients");
        }

        private IEnumerable<Clinic> GetClinics()
        {
            var clinics = new List<Clinic>()
            {
                new Clinic()
                {
                    Name = "Embalenhle Clinic",
                    ContactDetails = "017 685 4089",
                    Address = " 2285 Extension Four Dr, Embalenhle, 0700",
                    NumberOfPackages = 50,
                    OperatingTimes = "8am–8pm"
                },
                new Clinic()
                {
                    Name = "Embalenhle Clinic",
                    ContactDetails = "017 685 4089",
                    Address = " 2285 Extension Four Dr, Embalenhle, 0700",
                    NumberOfPackages = 50,
                    OperatingTimes = "8am–8pm"
                },
                new Clinic()
                {
                    Name = "Embalenhle Clinic",
                    ContactDetails = "017 685 4089",
                    Address = " 2285 Extension Four Dr, Embalenhle, 0700",
                    NumberOfPackages = 50,
                    OperatingTimes = "8am–8pm"
                },
                new Clinic()
                {
                    Name = "Embalenhle Clinic",
                    ContactDetails = "017 685 4089",
                    Address = " 2285 Extension Four Dr, Embalenhle, 0700",
                    NumberOfPackages = 50,
                    OperatingTimes = "8am–8pm"
                }, new Clinic()
                {
                    Name = "Embalenhle Clinic",
                    ContactDetails = "017 685 4089",
                    Address = " 2285 Extension Four Dr, Embalenhle, 0700",
                    NumberOfPackages = 50,
                    OperatingTimes = "8am–8pm"
                },

            };
            return clinics;
        }
    }
}
