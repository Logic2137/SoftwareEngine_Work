using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HotelBookingSystem
{
    public class HotelSupplier
    {
        public event Action PriceCutEvent;  // 降价事件
        private int currentPrice = 500;
        private int priceCutCount = 0;
        private static readonly object priceLock = new object();

        public void StartHotelSupplier()
        {
            while (priceCutCount < 10)
            {
                int newPrice = PricingModel();
                Console.WriteLine($"newPrice: {newPrice}");
                if (newPrice < currentPrice)
                {
                    Console.WriteLine($"开始{priceCutCount+1}次降价处理");
                    PriceCutEvent?.Invoke();
                    priceCutCount++;
                    this.ProcessingAllOrder(newPrice);
                }
                currentPrice = newPrice;

                Thread.Sleep(500);
            }
        }

        private int PricingModel()
        {
            // 随机函数来模拟价格变化
            Random rand = new Random();
            return rand.Next(300, 600);
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
                    OrderProcessing orderProcessing = new OrderProcessing();
                    Thread orderProcessingThread = new Thread(() => orderProcessing.ProcessOrder(orderClass, lowPrice));
                    orderProcessingThread.Start();
                    // orderProcessing.ProcessOrder(orderClass, lowPrice);
                }
            } while (encodedOrder != null);
        }
    }

}
