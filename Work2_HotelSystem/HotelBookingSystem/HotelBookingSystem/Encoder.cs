using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem
{
    public class Encoder
    {
        public static string EncodeOrder(OrderClass order)
        {
            return $"{order.SenderId},{order.CardNumber},{order.Amount}, {order.OrderTime}, {order.AgencyName}";
        }
    }

}
