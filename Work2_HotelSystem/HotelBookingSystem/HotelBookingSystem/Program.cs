using HotelBookingSystem;
using System.Threading;

public class Program
{
    public static void Main(string[] args)
    {
        HotelSupplier hotelSupplier = new HotelSupplier();
        TravelAgency travelAgency1 = new TravelAgency("Agency1");
        TravelAgency travelAgency2 = new TravelAgency("Agency2");

        hotelSupplier.PriceCutEvent += travelAgency1.OnPriceCut;
        hotelSupplier.PriceCutEvent += travelAgency2.OnPriceCut;

        Thread hotelThread = new Thread(new ThreadStart(hotelSupplier.StartHotelSupplier));
        hotelThread.Start();

        // 主线程等待 hotelThread 执行完成
        hotelThread.Join(); // 确保主线程等待酒店线程结束
    }
}
