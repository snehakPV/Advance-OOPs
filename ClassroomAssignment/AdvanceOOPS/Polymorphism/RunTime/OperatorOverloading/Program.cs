using System;
namespace OperatorOverloading;
class Program
{
    public static void Main(string[] args)
    {
        Box box1=new Box(1.2,3.2,4.2);  //declaring box 1 and box 2 of type box
        Box box2=new Box(10.1,11.1,12.1);

        System.Console.WriteLine($"Volume of box1 {box1.CalculateVolume()}");  //Volume of box1
        System.Console.WriteLine($"Volume of box2 {box2.CalculateVolume()}");  //Volume of box2

        //Add 2 obj
        Box box3=box1+box2; //adding using operator - which is overload
        box3=Box.Add(box1,box2); //adding using method
    }
}
