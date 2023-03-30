using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        Car swift=new MarutiSwift();
        swift.DisplayDetails();
        Car ciaz=new SuzukiCiaz();
        ciaz.DisplayDetails();
    }
}
