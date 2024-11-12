using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem
{
    public class Encoder
    {
        /***
         * Encoder类将OrderObject转换为字符串。
         */
        public static string EncodeOrder(OrderClass order)
        {
            return $"{order.SenderId},{order.CardNumber},{order.Amount}, {order.OrderTime}, {order.AgencyName}";
        }
    }

}
