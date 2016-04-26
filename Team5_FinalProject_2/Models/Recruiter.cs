using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Team5_FinalProject_2.Models
{
    public class Recruiter
    {

        public Int32 RecruiterID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter a valid Email Address")]
        public String Email { get; set; }

        //TODO: Add Nav for Company

    }
}