using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        Calculator calc=new Calculator(90,89,78,87,89,99);
        System.Console.WriteLine("Total Mark:"+calc.GetTotalMarks());
        System.Console.WriteLine("Percentage:"+calc.GetTotalMarks());

    }
}
