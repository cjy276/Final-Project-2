using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Team5_FinalProject_2.Models
{
    public class Interview
    {

        public Int32 InterviewID { get; set; }

        public virtual Position Position { get; set; }

        public virtual Room Room { get; set; }

        public Int32 InterviewTimeSlot { get; set; }

        public DateTime InterviewDate { get; set; }


    }
}