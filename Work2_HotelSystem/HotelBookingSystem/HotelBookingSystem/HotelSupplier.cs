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
                }
                currentPrice = newPrice;

                string encodedOrder = MultiCellBuffer.GetOneCell();
                if (encodedOrder != null)
                {
                    OrderClass orderClass = Decoder.DecodeOrder(encodedOrder);
                    OrderProcessing orderProcessing = new OrderProcessing();
                    orderProcessing.ProcessOrder(orderClass, currentPrice);
                }

                Thread.Sleep(500);
            }
        }

        private int PricingModel()
        {
            // 随机函数来模拟价格变化
            Random rand = new Random();
            return rand.Next(300, 600);
        }
    }

}
