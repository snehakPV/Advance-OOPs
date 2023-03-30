using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        Cylinder cylinder=new Cylinder();
        cylinder.Radius=2.0;
        cylinder.Height=5.0;
        cylinder.CalculateArea();
        cylinder.CalculateVolume();
        System.Console.WriteLine($"Cylinder Area:{cylinder.Area},Volume:{cylinder.Volume}");
        Cube cube=new Cube();
        cube.Width=3.0;
        cube.CalculateArea();
        cube.CalculateVolume();
        System.Console.WriteLine($"Cube Area:{cube.Area},Volume:{cube.Volume}");
    }
}
