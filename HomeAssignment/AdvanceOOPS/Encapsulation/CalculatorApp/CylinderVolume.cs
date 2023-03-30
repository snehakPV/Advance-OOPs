using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class CylinderVolume : CircleArea
    {
        private double _height;
        public double Height { get {return _height;} set{_height=value;}}
        internal double Volume { get{return CalVolume();}}
        public double CalVolume()
        {
            return CalArea() * _height;
        }
    }
}