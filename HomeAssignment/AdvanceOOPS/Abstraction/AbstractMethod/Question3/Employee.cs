using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question3
{
    public class Employee
    {
        public int EmployeeID {get;set;}
        public string EmployeeName {get;set;}
        public string Gender {get;set;}
        public int NumberOfDaysWorked {get;set;}
        public virtual void DisplaySalary()
        {
            System.Console.WriteLine(EmployeeID+" "+EmployeeName+" "+Gender+" "+NumberOfDaysWorked);
        }
    }
}