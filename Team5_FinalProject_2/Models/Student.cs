using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Team5_FinalProject_2.Models
{

    public enum Major { Accounting, BusinessHonors, Finance, InternationalBusiness, Management, MIS, Marketing, SCM, STM }

    public enum PositionType { Internship, FullTime }

    public class Student
    {
    
        public Int32 StudentID { get; set; }

        [Required]
        [Display(Name="First Name")]
        public String FirstName { get; set; }
        
        [Required]
        [Display(Name="Last Name")]
        public String LastName { get; set; }

        [Required]
        [Display(Name= "Email Address")]
        [DataType(DataType.EmailAddress, ErrorMessage="Please enter a valid Email Address")]
        public String Email { get; set; }

        [Required]
        public Major Major { get; set; }

        [Required]
        public PositionType PositionType { get; set; }

        [Required]
        public DateTime GradDate { get; set; }

        [Required]
        public Decimal GPA { get; set; }

    }



        

  


    }
