using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Square : ICalculate
    {
        private int _number; //field to access the property
        public int Number { get{return _number;} set{_number=value;} }  //property from interface
        public int Calculate()  //Method to interface
        {
            _number*=_number;
            return _number;
        }
    }
}