using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        Square(8);
        Square(2.5f);
        Square(2.9);
        Square(2345678987654345678);
    }
    static void Square(int num1)
    {
        System.Console.WriteLine("Square:"+num1*num1);
    }
    static void Square(float num2 )
    {
       System.Console.WriteLine("Square:"+num2*num2); 
    }
    static void Square(double num3)
    {
        System.Console.WriteLine("Square:"+num3*num3);
    }
    static void Square(long num4)
    {
        System.Console.WriteLine("Square:"+num4*num4);
    }
}
