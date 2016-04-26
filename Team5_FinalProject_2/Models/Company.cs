using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Team5_FinalProject_2.Models
{
    public class Company
    {

        public Int32 CompanyID { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter a valid Email Address")]
        public String Email { get; set; }

        public String Description { get; set; }

        public String Industry { get; set; }

        public List<Recruiter> Recruiters { get; set; }

        public List<Position> Postitions { get; set; }

       


    }
}