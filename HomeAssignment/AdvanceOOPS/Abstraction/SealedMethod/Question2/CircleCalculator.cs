using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class CircleCalculator:Calculator
    {
        public sealed override double area(double[] dimensions)
        {
            double radius=dimensions[0];
            return 3.14*radius*radius;
        }
        public override double volume(double[] dimensions)
        {
            throw new NotImplementedException();
        }
    }
}