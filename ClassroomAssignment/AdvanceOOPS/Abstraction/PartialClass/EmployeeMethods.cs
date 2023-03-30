using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class Employee
    {
        //Constructor
        public Employee(int employeeID,string name)
        {
            EmployeeID=employeeID;
            Name=name;
        }
        //Normal Method
        public string DisplayEmpInfo()
        {
            return "Employee ID:"+EmployeeID+"\tEmployee Name:"+Name;
        }
        //Partial Method
        public partial string ShowName(){return Name;}
    }
}