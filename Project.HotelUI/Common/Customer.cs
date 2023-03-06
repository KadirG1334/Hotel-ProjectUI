using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.HotelUI.Common
{
    public class Customer
    {
        public string ID { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }

        public Reservation Reservation{ get; set; }

        public Room Room { get; set; } 
        public int NumberOfPerson {get; set; }

        
        public DateTime EntranceTime { get; set; }

        public DateTime QuitTime { get; set; }

    }
}
