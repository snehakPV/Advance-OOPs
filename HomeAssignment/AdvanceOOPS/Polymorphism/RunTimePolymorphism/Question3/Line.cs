using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question3
{
    public class Line:Shape
    {
        public override double DrawShape()
        {
            System.Console.WriteLine("Drawing a Line");
            return 0;
        }
        
    }
}