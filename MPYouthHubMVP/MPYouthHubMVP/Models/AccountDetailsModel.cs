using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MPYouthHubMVP.Models
{
    public class AccountDetailsModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Surname")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public string DateOfBirth { get; set; }
        [Required]
        //[RSAIDNumber(ErrorMessage = "A valid south african ID number is required.")]
        [Display(Name = "ID No")]
        public string SouthAfricanId { get; set; }


        //Physical Address
        [Required]
        [Display(Name = "House No")]
        public string HouseUnitNo { get; set; }

        [Display(Name = "Building/Complex Name")]
        public string ComplexBuildingName { get; set; }
        [Required]
        [Display(Name = "Street Name")]
        public string StreetName { get; set; }
        [Required]
        [Display(Name = "Suburbs")]
        public string Suburb { get; set; }
        [Required]
        [Display(Name = "Town/City")]
        public string TownCity { get; set; }
        [Required]
        [Display(Name = "Province")]
        public int ProvinceId { get; set; }

        //Postal address
       
        [Display(Name = "Box Number")]
        public string BoxNumber { get; set; }

        [Display(Name = "Postal Code")]
        public int PostalCode { get; set; }
       
        [Display(Name = "Town/City")]
        public string PostalCity { get; set; }
        [Required]
        [Display(Name = "Province")]
        public int PostalProvinceId { get; set; }

        [Required]
        [Display(Name = "Drivers License Code")]
        public int DriversLinceseCode { get; set; }

        public System.Web.Mvc.SelectList Provinces { get; set; }
    }
}