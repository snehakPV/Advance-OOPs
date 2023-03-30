using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        Draw draw=new Draw();
        DrawPyramid drawPyramid=new DrawPyramid();
        DrawStar drawStar=new DrawStar();
        draw.DrawLine();
        drawPyramid.DrawLine();
        drawStar.DrawLine();
    }
}
