using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team_Five_Final_Project.Models
{

    public class CSO
    {


     

        public Int32 CSOID { get; set; }

      
        public virtual AppUser AppUsers { get; set; }
    }
}