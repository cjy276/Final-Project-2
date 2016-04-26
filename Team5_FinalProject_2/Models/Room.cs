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

    }
}