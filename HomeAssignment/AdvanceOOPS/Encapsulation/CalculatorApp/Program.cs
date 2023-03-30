using System;
namespace CalculatorApp;
class Program
{
    public static void Main(string[] args)
    {
        CircleArea area=new CircleArea();
        CylinderVolume volume=new CylinderVolume();
        volume.Radius=5;
        volume.Height=10;
        System.Console.WriteLine("Circle Area:"+volume.Area);
        System.Console.WriteLine("Cylinder Volume:"+volume.Volume);
        
    }
}
