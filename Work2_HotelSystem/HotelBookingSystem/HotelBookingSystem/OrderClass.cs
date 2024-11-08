using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem
{
    public class OrderClass
    {
        public int SenderId { get; set; }
        public int CardNumber { get; set; }
        public int Amount { get; set; }

        public string OrderTime { get; set; }

        public string AgencyName { get; set; }
    }

}
