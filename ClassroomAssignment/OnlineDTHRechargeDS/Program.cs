using System;
namespace OnlineDTHRechargeDS;
class Program
{
    public static void Main(string[] args)
    {
        FileHandling file=new FileHandling();
        file.Create();
        Operations operate=new Operations();
    //  operate.DefaultData();
        file.ReadFromCSV();
        operate.MainMenu();
        file.WriteToCSV();
    }
}
