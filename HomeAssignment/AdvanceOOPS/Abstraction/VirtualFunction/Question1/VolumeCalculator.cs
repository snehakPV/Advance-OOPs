using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class VolumeCalculator:AreaCalculator
    {
      public double Height {get;set;}
        public override double Calculate()
        {
            return base.Calculate()*Height;
        }
        public override void Display()
        {
            System.Console.WriteLine($"Volume:{Calculate()}");
        }
    }
}