using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        OnlineTicket online=new OnlineTicket("A",100);
        OfflineTicket offline=new OfflineTicket("B",150);
        online.SeatNumber="A1";
        online.ShowTicket();
        offline.SeatNumber="B1";
        offline.ShowTicket();

    }
}
