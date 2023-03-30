using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class StudentInfo:IDisplayInfo
    {
        private string studentID;
        public string StudentID {get {return studentID;}set{studentID=value;}}
        private string name;
        public string Name { get{return name;} set{name=value;} }
        private string fatherName;
        public string FatherName { get{return fatherName;} set{fatherName=value;} }
        private string mobile;
        public string Mobile {get{return mobile;} set{mobile=value;}}
        public string Display()
        {
            studentID=StudentID;
            name=Name;
            fatherName=FatherName;
            mobile=Mobile;
            return studentID+" "+name+" "+fatherName+" "+mobile;
        }
    }
}