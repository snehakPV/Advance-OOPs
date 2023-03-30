using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class Dimension
    {
        public double value1;
        public double value2;
        public double Area {get;set;}
        public virtual void Calculate()
        {
            Area=value1*value2;
        }
        public void DisplayArea()
        {
            System.Console.WriteLine("Area:"+Area);
        }
    }
}