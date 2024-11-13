using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem
{
    public class OrderProcessing
    {
        public void ProcessOrder(OrderClass order, int hotelPrice, ArrayList creditCardIDList)
        {
            if (creditCardIDList.Contains(order.CardNumber))
            {
                int totalCost = order.Amount * hotelPrice;
                Console.WriteLine($"订单处理成功，发送线程ID: {order.SenderId}\n 当前处理线程ID: {Thread.CurrentThread.ManagedThreadId}\n" + 
                    $" 旅行社名: {order.AgencyName}\n 房间数: {order.Amount}\n 总费用: {totalCost}\n 信用卡号: {order.CardNumber}\n 订单创建时间: {order.OrderTime}\n\r");
            }
            else
            {
                Console.WriteLine("信用卡未注册，订单处理失败");
            }
        }
    }

}
