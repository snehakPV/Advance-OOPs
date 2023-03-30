using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class SalaryInfo:EmployeeInfo
    {
        public int NoOfDaysWorked {get;set;}
        public override void Display()
        {
            base.Display();
            int salary=NoOfDaysWorked*500;
            System.Console.WriteLine("Salary:"+salary);
        }
    }
}