using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;



namespace IntroToWeb.Models
{
    public class CustomerModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Business Name")]
        public string BusinessName { get; set; }
        [DataType(DataType.Currency)]
        [Display(Name = "Project Cost")]
        public decimal ProjectCost { get; set; }
    }
}