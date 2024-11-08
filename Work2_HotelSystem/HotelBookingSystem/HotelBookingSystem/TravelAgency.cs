using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem
{
    public class TravelAgency
    {
        private string agencyName;
        private Random rand = new Random();

        public TravelAgency(string name)
        {
            agencyName = name;
        }

        /// 获取时间戳
        public static string GetUtcNowTimeStamp()
        {
            DateTime now = DateTime.Now; // 当前日期和时间
            return now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public void OnPriceCut()
        {
            int roomsToOrder = rand.Next(1, 5);  // 随机生成订单数量
            int cardNumber = rand.Next(5000, 7000);

            OrderClass order = new OrderClass
            {
                SenderId = Thread.CurrentThread.ManagedThreadId,
                CardNumber = cardNumber,
                Amount = roomsToOrder,
                OrderTime = GetUtcNowTimeStamp(),
                AgencyName = this.agencyName
            };

            string encodedOrder = Encoder.EncodeOrder(order);
            MultiCellBuffer.SetOneCell(encodedOrder);
        }
    }

}
