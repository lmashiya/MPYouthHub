using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MPYouthHubMVP.Models
{
    public class VolunteerOption
    {
        public string OptionName { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int NumberOfVolunteersNeeded { get; set; }
    }
}