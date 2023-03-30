using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question3
{
    public class FullTimeEmployee:Employee
    {
        public override void DisplaySalary()
        {
            base.DisplaySalary();
            System.Console.WriteLine($"Salary:{this.NumberOfDaysWorked*600}");
        }
    }
}