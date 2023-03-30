using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        Purchase purchase=new Purchase();
        purchase.MaterialID=100;
        purchase.Name="AAA";
        purchase.Quantity=2;
        OnlineTransaction online=new OnlineTransaction();
        online.CalculateAmount();
        online.DisplayBill();
        OfflineTransaction offline=new OfflineTransaction();
        offline.CalculateAmount();
        offline.DisplayBill();
    }
}
