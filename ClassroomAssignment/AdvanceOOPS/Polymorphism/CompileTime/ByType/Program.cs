using System;
namespace ByType;
class Program
{
    public static void Main(string[] args)
    {
       Display(10);
       Display("SNEHA");
    }
     //Method with int parameter
        static void Display(int number)
        {
            System.Console.WriteLine("Int type:"+number);
        }
        //Method with string parameter
        static void Display( string name)
        {
            System.Console.WriteLine("String type:"+name);
        }
}
