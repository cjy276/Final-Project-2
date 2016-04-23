using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Team_Five_Final_Project.Models
{

  

    public class Student
    {
        public Int32 StudentID { get; set; }

        
        public DateTime GraduationDate { get; set; }

        [EnumDataType(typeof(PositionType))]
        public PositionType PositionType { get; set; }

        public Decimal GPA { get; set; }

        public String Major { get; set; }
        //navigational
        public virtual AppUser AppUsers { get; set; }
    }
}