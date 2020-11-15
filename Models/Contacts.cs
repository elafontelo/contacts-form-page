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
        public string address { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public int? zipCode { get; set; }
        public string phoneNumber { get; set; }
        public string notes { get; set; }

    }
}