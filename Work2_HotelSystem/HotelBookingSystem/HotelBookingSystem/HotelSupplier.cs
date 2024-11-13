using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

namespace HotelBookingSystem
{
    public class HotelSupplier
    {
        public delegate void PriceCutEventHandler(int newPrice);  //新建委托，用于传递新价格给旅行社线程
        public event PriceCutEventHandler PriceCutEvent;  // 降价事件
        private int currentPrice = 500;
        private int priceCutCount = 0;
        private static readonly object priceLock = new object();
        private ArrayList creditCardIDList = new ArrayList();
        private int lastCrefitRoomCount = 0;  // 上次所有旅行社订房的数量

        public void StartHotelSupplier()
        {
            while (priceCutCount < 10)
            {
                int newPrice = PricingModel();
                Console.WriteLine($"newPrice: {newPrice}");
                if (newPrice < currentPrice)
                {
                    Console.WriteLine($"开始{priceCutCount+1}次降价处理");
                    PriceCutEvent?.Invoke(newPrice);
                    priceCutCount++;
                    this.ProcessingAllOrder(newPrice);
                }
                currentPrice = newPrice;

                Thread.Sleep(500);
            }
        }

        /**
         * 定价模型：
         * 您必须定义一个数学模型（随机函数很好）
         * 以根据在给定时间段内收到的订单和HotelSupplier在同一时间段内可用的房间数量来确定价格。
         */
        private int PricingModel()
        {
            // 随机函数来模拟价格变化
            Random rand = new Random();

            if (lastCrefitRoomCount > 5)
            {
                return rand.Next(500, 700);
            }
            else
            {
                return rand.Next(300, 500);
            }
        }

        private void ProcessingAllOrder(int lowPrice)
        {
            string encodedOrder = null;
            do
            {
                encodedOrder = MultiCellBuffer.GetOneCell();  // HotelSupplier从MultiCellBuffer接收编码字符串，并将字符串发送到解码器进行解码。
                if (encodedOrder != null)
                {
                    OrderClass orderClass = Decoder.DecodeOrder(encodedOrder);  // （7） 解码器将OrderObject发送给HotelSupplier。解码对象必须包含TravelAgency生成的相同值。
                    lastCrefitRoomCount = orderClass.Amount;
                    OrderProcessing orderProcessing = new OrderProcessing();
                    Thread orderProcessingThread = new Thread(() => orderProcessing.ProcessOrder(orderClass, lowPrice, this.creditCardIDList));
                    orderProcessingThread.Start();
                    // orderProcessing.ProcessOrder(orderClass, lowPrice);
                }
            } while (encodedOrder != null);
        }

        /**
         * 它将检查信用卡号的有效性。您可以定义您的信用卡格式，例如，旅行社的信用卡号必须是向HotelSupplier注册的号码
         */
        public bool RegCreditCardID(string creditCardID)
        {
            if (creditCardID.Length != 16)
            {
                Console.WriteLine($"卡号:{creditCardID}格式错误，请检查注册信息!");
                return false;
            }
            if (!creditCardIDList.Contains(creditCardID))
            {
                string frontFourNum = creditCardID.Substring(0, 4);
                if (Convert.ToInt32(frontFourNum) > 5000 && Convert.ToInt32(frontFourNum) < 7000)
                {
                    creditCardIDList.Add(creditCardID);
                    Console.WriteLine($"卡号:{creditCardID}成功注册!");
                }
                else 
                {
                    Console.WriteLine($"卡号:{creditCardID}不在可注册范围内!");
                    return false;
                }

            }
            return true;
        }
    }

}
