using System;
namespace Interfaces;
class Program
{
    public static void Main(string[] args)
    {
    //class    
        Square number=new Square();  //class variable as object
        number.Number=10;
        System.Console.WriteLine(number.Calculate());
    //accessing from interface
        ICalculate value=new Square();  //Interface variable as object
        value.Number=20;
        System.Console.WriteLine(value.Calculate());    
    }
}
