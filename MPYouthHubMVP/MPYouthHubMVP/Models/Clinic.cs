using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MPYouthHubMVP.Models
{
    public class Clinic
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string OperatingTimes { get; set; }
        public string ContactDetails { get; set; }
        public int NumberOfPackages { get; set; }
    }
}