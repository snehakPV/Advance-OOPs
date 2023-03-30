using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
         VolumeCalculator volCalc=new VolumeCalculator{Radius=2,Height=5};
         AreaCalculator areaCalc=new AreaCalculator{Radius=3};
         areaCalc.Display();
         volCalc.Display();

    }
}
