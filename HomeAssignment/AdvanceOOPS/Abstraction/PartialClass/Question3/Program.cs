using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator=new Calculator();
        System.Console.WriteLine("Addition:"+calculator.Addition(2,3));
        System.Console.WriteLine("Subtraction:"+calculator.Subtraction(50,22));
        System.Console.WriteLine("Sin:"+calculator.Sin(Math.PI/4));
        System.Console.WriteLine("Cos:"+calculator.Cos(Math.PI/6));
        System.Console.WriteLine("Tan:"+calculator.Tan(Math.PI/7));
    }
}
