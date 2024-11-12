using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem
{
    /**
     * OrderClass是一个至少包含SenderId CardNumber Amount
     */
    public class OrderClass //每个订单都是一个OrderClass对象。
    {
        public int SenderId { get; set; }
        public int CardNumber { get; set; }
        public int Amount { get; set; }

        public string OrderTime { get; set; }

        public string AgencyName { get; set; }
    }

}
