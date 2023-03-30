using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        Calculator cylinder=new CylinderCalculator();
        double[] dimensions={2.0,5.0};
        double area=cylinder.area(dimensions);
        double volume=cylinder.volume(dimensions);
        System.Console.WriteLine($"Dimension: radius:{dimension[0]},height:{dimension[1]}");
        System.Console.WriteLine("Area:"+area);
        System.Console.WriteLine("Volume:"+volume);
    }
}
