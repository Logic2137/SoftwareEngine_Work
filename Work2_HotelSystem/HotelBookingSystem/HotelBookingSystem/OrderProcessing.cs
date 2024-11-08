using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem
{
    public class OrderProcessing
    {
        public void ProcessOrder(OrderClass order, int hotelPrice)
        {
            if (order.CardNumber >= 5000 && order.CardNumber <= 7000)
            {
                int totalCost = order.Amount * hotelPrice; // 假设单价为500
                Console.WriteLine($"订单处理成功，发送线程ID: {order.SenderId}\n 当前处理线程ID: {Thread.CurrentThread.ManagedThreadId}\n" + 
                    $" 旅行社名: {order.AgencyName}\n 房间数: {order.Amount}\n 总费用: {totalCost}\n 订单创建时间: {order.OrderTime}\n\r");
            }
            else
            {
                Console.WriteLine("信用卡无效，订单处理失败");
            }
        }
    }

}
