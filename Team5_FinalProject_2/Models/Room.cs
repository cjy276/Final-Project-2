using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Team5_FinalProject_2.Models
{

    public enum RoomNumbers { One, Two, Three, Four }

    public class Room
    {

        public Int32 RoomID { get; set; }

        public RoomNumbers RoomNumber { get; set; }

        public Boolean Slot1 { get; set; }

        public Boolean Slot2 { get; set; }

        public Boolean Slot3 { get; set; }

        public Boolean Slot4 { get; set; }

        public Boolean Slot5 { get; set; }

        public Boolean Slot6 { get; set; }

        public Boolean Slot7 { get; set; }

        public Boolean Slot8 { get; set; }
        
        public Boolean Slot9 { get; set; }

    }
}