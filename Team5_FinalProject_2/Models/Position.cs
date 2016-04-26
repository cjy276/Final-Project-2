using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Team5_FinalProject_2.Models
{
    public class Position
    {

        public Int32 PositionID { get; set; }

        public String Title { get; set; }

        public String PostitionType { get; set; }

        public String Location { get; set; }

        public List<Major> ApplicableMajors { get; set; }

        public DateTime Deadline { get; set; }

        public virtual Company Company { get; set; }


    }
}