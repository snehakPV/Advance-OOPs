using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class Cube:Shape
    {
        private double _width;
        public override double Area {get;set;}
        public override double Volume {get;set;}
        public override double Radius {get;set;}
        public override double Height {get;set;}
        public override double Width {get{return _width;}set{_width=value;}}
        public override double PageA {get;set;}
        public override void CalculateArea()
        {
            Area=6*_width*_width*_width;
        }
        public override void CalculateVolume()
        {
            Volume=_width*_width*_width;
        }
    }
}