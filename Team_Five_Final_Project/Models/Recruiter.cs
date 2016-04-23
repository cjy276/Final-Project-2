using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Team_Five_Final_Project.Models
{
    public class Recruiter
    {
        public Int32 RecruiterID { get; set; }

        //navigational properties
        public virtual Company Company { get; set; }
        public virtual AppUser AppUsers { get; set; }
    }
}