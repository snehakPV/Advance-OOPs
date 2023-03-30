using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
       Rectangle rec=new Rectangle(){Length=5,Height=10};
       rec.Calculate();
       rec.DisplayArea();
       Sphere sphere=new Sphere() {Radius=3};
       sphere.Calculate();
       sphere.DisplayArea();
    }
}
