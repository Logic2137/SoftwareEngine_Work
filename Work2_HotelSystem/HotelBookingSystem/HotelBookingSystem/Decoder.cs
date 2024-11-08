using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem
{
    public class Decoder
    {
        public static OrderClass DecodeOrder(string encodedOrder)
        {
            string[] parts = encodedOrder.Split(',');
            return new OrderClass
            {
                SenderId = int.Parse(parts[0]),
                CardNumber = int.Parse(parts[1]),
                Amount = int.Parse(parts[2]),
                OrderTime = parts[3],
                AgencyName = parts[4],
            };
        }
    }

}
