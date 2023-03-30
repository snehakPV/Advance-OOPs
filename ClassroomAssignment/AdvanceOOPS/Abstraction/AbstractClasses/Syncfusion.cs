using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class Syncfusion:Employee
    {
        //Abstract prop def
        public override string Name {get{return _name;} set{_name=value;}}
        //Abstract method def
        public override double Salary(int dates)
        {
            Amount=(double)dates*500;
            return Amount;
        }
    }
}