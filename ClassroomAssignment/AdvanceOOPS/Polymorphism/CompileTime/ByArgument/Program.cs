using System;
namespace ByArgument;
class Program
{
    public static void Main(string[] args)
    {
      Display(100);
      Display(100,200);
      Console.ReadLine();  
    }
    //method with one arguments
    static void Display(int number)
    {
        System.Console.WriteLine("Arg1:"+number);
    }
    //method with two arguments
    static void Display(int number1,int number2)
    {
        System.Console.WriteLine("Arg1:"+number1+"Arg2:"+number2);
    }
}
