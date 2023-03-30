using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        EEE eee=new EEE();
        CSE cse=new CSE();
        eee.SetBookInfo();
        eee.DisplayInfo();
        cse.SetBookInfo();
        cse.DisplayInfo();
    }
}
