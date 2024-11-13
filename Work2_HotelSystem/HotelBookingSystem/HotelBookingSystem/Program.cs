using HotelBookingSystem;
using System.Collections;
using System.Threading;

public class Program
{
    public static int MAX_TRAVEL_NUM = 5;
    public static int MAX_SUPPLIERS_NUM = 1;
    public static void Main(string[] args)
    {
        HotelSupplier hotelSupplier = new HotelSupplier();
        // 创建每个旅行社对象 并 启动每个旅行社线程
        TravelAgency[] travelAgency = new TravelAgency[MAX_TRAVEL_NUM];
        Thread[] agenciesThreads = new Thread[MAX_TRAVEL_NUM];
        for (int i = 0; i < MAX_TRAVEL_NUM; i++)
        {
            travelAgency[i] = new TravelAgency("Agency" + i); // TravelAgency1到TravelAgencyN，每个旅行社都是从类中的同一类（或同一方法）实例化的线程。
            for (int j = 0; j < MAX_SUPPLIERS_NUM; j++)
            {
                hotelSupplier.PriceCutEvent += travelAgency[i].OnPriceCut; // 旅行社的行动是由事件驱动的。每家旅行社都包含一个回调方法（事件处理程序），供HotelSuppliers在发生降价事件时调用。
            }
            agenciesThreads[i] = new Thread(new ThreadStart(travelAgency[i].RunAgency));
            agenciesThreads[i].Start();
        }
        //TravelAgency travelAgency1 = new TravelAgency("Agency1");
        //TravelAgency travelAgency2 = new TravelAgency("Agency2");

        //hotelSupplier.PriceCutEvent += travelAgency1.OnPriceCut;
        //hotelSupplier.PriceCutEvent += travelAgency2.OnPriceCut;
        hotelSupplier.RegCreditCardID("5023958311730285");
        hotelSupplier.RegCreditCardID("6385028598820285");
        hotelSupplier.RegCreditCardID("6999620102820285");

        // 启动酒店供应商线程
        Thread hotelThread = new Thread(new ThreadStart(hotelSupplier.StartHotelSupplier));
        hotelThread.Start();

        // 主线程等待 hotelThread 执行完成
        hotelThread.Join(); // 确保主线程等待酒店线程结束,HotelSupplier线程终止后，线程将终止。
        foreach (Thread agencyThread in agenciesThreads)
        {
            agencyThread.Join();
        }
    }
}
