using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
       Shape line=new Line();
       line.DrawShape();
       Shape pyramid=new Pyramid();
       pyramid.DrawShape();
       Shape square = new Square();
       square.DrawShape();
       Shape rectangle=new Rectangle();
       rectangle.DrawShape();
    }
}