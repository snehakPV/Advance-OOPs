using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
       Bank bank;
       bank=new SBI();
       System.Console.WriteLine("SBI:"+bank.GetInterestInfo()); 
       bank=new ICICI();
       System.Console.WriteLine("ICICI:"+bank.GetInterestInfo());
       bank=new HDFC();
       System.Console.WriteLine("HDFC:"+bank.GetInterestInfo());
       bank=new IDBI();
       System.Console.WriteLine("IDBI:"+bank.GetInterestInfo());
    }
}
