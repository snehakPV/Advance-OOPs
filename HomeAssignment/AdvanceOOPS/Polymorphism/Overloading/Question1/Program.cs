using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
      Multiply(2);
      Multiply(2,2);
      Multiply(2,2,2);
      Multiply(2,2.5);
      Multiply(2,2.3,2);

    }
    static void Multiply(int num1)
    {
        System.Console.WriteLine("Result:"+num1*num1);
    }
    static void Multiply(int num1,int num2)
    {
        System.Console.WriteLine("Result:"+num1*num2);
    }
    static void Multiply(int num1,int num2,int num3)
    {
        System.Console.WriteLine("Result:"+num1*num2*num3);
    }
    static void Multiply(int num1,double num2)
    {
        System.Console.WriteLine("Result:"+num1*num2);
    }
    static void Multiply(int num1,double num4,short num5)
    {
        System.Console.WriteLine("Result:"+num1*num4*num5);
    }
}
