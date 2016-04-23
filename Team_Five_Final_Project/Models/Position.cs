using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Team_Five_Final_Project.Models
{
    //enum for position type iternship or fulltime
    public enum PositionType { I, FT}
    
    //enum for industry list 
   
    
    //enum for majors
    public enum MajorList { MIS, InternatioanlBusiness, Finance, Marketing, SupplyChainManagement, BusinessHonors, Accounting}
   
    
    public class Position
    {
        public Int32 PositionID { get; set; }

        public String Title { get; set; }

        
        public String PositionType { get; set; }

       
        public String Industry { get; set; }

        public String Location { get; set; }

        [EnumDataType(typeof(MajorList))]
        public MajorList ApplicableMajors { get; set; }

        [DataType(DataType.Date)]
        public DateTime Deadline { get; set; }

        public String Description { get; set; }

        //navigational properties
        public virtual Company Company { get; set; }

    }
}