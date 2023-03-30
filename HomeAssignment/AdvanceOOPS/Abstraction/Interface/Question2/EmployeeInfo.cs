using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class EmployeeInfo:IDisplayInfo
    {
        private string employeeID;
        public string EmployeeID {get {return employeeID;}set{employeeID=value;}}
        private string name;
        public string Name { get{return name;} set{name=value;} }
        private string fatherName;
        public string FatherName { get{return fatherName;} set{fatherName=value;} }
        public string Display()
        {
            employeeID=EmployeeID;
            name=Name;
            fatherName=FatherName;
            return employeeID+" "+name+" "+fatherName;
        }
    }
}