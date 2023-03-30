using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class CylinderCalculator:Calculator
    {
        CircleCalculator circleCalculator=new CircleCalculator();
        public override double area(double[] dimensions)
        {
            double radius=dimensions[0];
            double height=dimensions[1];
            return 2*circleCalculator.area(new double[]{radius})+2*3.14*radius*height;
        }
        public override double volume(double[] dimensions)
        {
            double radius = dimensions[0];
            double height=dimensions[1];
            return circleCalculator.area(new double[] {radius})*height;
        }
    }
}