using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Team_Five_Final_Project.Models
{
    public class Interview
    {
        public Int32 InterviewID {get; set;}

        public DateTime Date { get; set; }

        public DateTime Time { get; set; }

        //navigational properties
        public virtual Student Student { get; set; }
        public virtual Company Company { get; set;}
        public virtual InterviewRoom Room { get; set; }
        public virtual Position Position { get; set; }


    }
}