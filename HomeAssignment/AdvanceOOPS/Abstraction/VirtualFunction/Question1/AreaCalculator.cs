using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class AreaCalculator
    {
        public double Radius {get;set;}
        public virtual double Calculate ()
        {
            return 3.14*Radius*Radius;
        }
        public virtual void Display()
        {
            System.Console.WriteLine($"Area:{Calculate()}");
        }
    }
}