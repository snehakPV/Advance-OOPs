using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        ComplexNumbers complex1=new ComplexNumbers(5,10);
        ComplexNumbers complex2=new ComplexNumbers(3,-2);
        ComplexNumbers sum=complex1+complex2;
        System.Console.WriteLine("Sum:"+sum);
        ComplexNumbers difference=complex1-complex2;
        System.Console.WriteLine("Difference:"+difference);
    }
}