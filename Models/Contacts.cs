using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactsApp.Models
{
    public class Contacts
    {
        [Required]
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Required]
        [Display(Name ="Address")]
        public string address { get; set; }
        [Required]
        [Display(Name = "State")]
        public string state { get; set; }
        [Required]
        [Display(Name = "Country")]
        public string country { get; set; }
        [Required]
        [Display(Name = "Zip Code")]
        public int zipCode { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public string phoneNumber { get; set; }
        [Display(Name = "Notes")]
        [StringLength(250, MinimumLength = 0)]
        public string notes { get; set; }

    }
}