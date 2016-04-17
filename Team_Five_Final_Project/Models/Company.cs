using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Team_Five_Final_Project.Models
{

  

    
        public class Company
    {

        public Int32 CompanyID { get; set; }
        
        
        
        public String CompanyName { get; set;}
       
        public String Email { get; set; }

        public String Industry { get; set; }

        public String Description { get; set; }
        

        public enum IndustryList {Accounting, Consulting, Energy, Engineering, FinancialServices, Manufacturing, Hospitality, Insurance, Marketing, RealEstate, Technology, Retail, Transportation }
        [EnumDataType(typeof(IndustryList))]
        public IndustryList Industry1 {get; set;}
        
        

        

    }
}