using System;
using System.Collections;
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
        private int threadIndex = 0;
        private int priceCutCount = 0;
        private ArrayList creditCardIDList = new ArrayList() { "5023958311730285", "6385028598820285", "6999620102820285" };
        private int lastPrice = 0;

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

        public int ComfirmRoomNumByNewPrice(int newPrice)
        {
            int roomsToOrder;
            if (lastPrice > newPrice)
            {
                roomsToOrder = rand.Next(5, 10);  // 随机生成订单数量
            }
            else
            {
                roomsToOrder = rand.Next(1, 5);
            }
            return roomsToOrder;
        }

        // 降价事件处理函数
        public void OnPriceCut(int newPrice)
        {
            this.priceCutCount = this.priceCutCount + 1;

            //根据模型确定订单数量: 旅行社将根据需求以及之前的价格和当前价格之间的差异计算要订购的房间数量。
            int roomsToOrder = ComfirmRoomNumByNewPrice(newPrice);

            //生成信用卡号
            int cardNumberIndex = rand.Next(0, 3);
            string cardNumberString = creditCardIDList[cardNumberIndex].ToString();

            OrderClass order = new OrderClass
            {
                SenderId = this.threadIndex,
                CardNumber = cardNumberString,
                Amount = roomsToOrder,
                OrderTime = GetUtcNowTimeStamp(),  // 在将订单发送到MultiCell Buffer之前，必须保存时间戳。
                AgencyName = this.agencyName
            };
            lastPrice = newPrice;  // 记住本次价格，用于下次定购买数量

            string encodedOrder = Encoder.EncodeOrder(order); // 对象被发送到编码器进行编码。
            // 然后，旅行社将以字符串格式将订单发送到MultiCellBuffer。
            MultiCellBuffer.SetOneCell(encodedOrder);  // TravelAgency将编码字符串发送到MultiCellBuffer中的一个空闲单元格。
        }

        public void RunAgency()
        {
            // 旅行社的线程运行逻辑，可以是等待降价事件的发生并处理订单
            while (this.priceCutCount < 10)
            {
                this.threadIndex = Thread.CurrentThread.ManagedThreadId;
                // 这里可以加入具体的业务逻辑，例如等待事件发生，或者处理其他任务
                Thread.Sleep(1000); // 模拟旅行社的运行状态
            }
        }
    }

}
