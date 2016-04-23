using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Team_Five_Final_Project.Models
{


    public enum IndustryList { Accounting, Consulting, Energy, Engineering, FinancialServices, Manufacturing, Hospitality, Insurance, Marketing, RealEstate, Technology, Retail, Transportation }
    
        public class Company
    {

        public Int32 CompanyID { get; set; }
        
        
        
        public String CompanyName { get; set;}
       
        public String Email { get; set; }

        public String Industry { get; set; }

        public String Description { get; set; }
        

        
        public String Industry1 {get; set;}

        public String Industry2 { get; set; }

        public String Industry3 { get; set; }


        
        

        

    }
}