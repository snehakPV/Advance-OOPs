using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question4
{
    public enum Gender {Select,Male,Female}
    public class EmployeeInfo:SalaryInfo
    {
        /*EmployeeID,Name,FatherName,Gender,Mobile,DOB, Branch, List<Attendance>,*/
        public string EmployeeID {get;set;}
        public string Name {get;set;}
        public string FatherName { get; set; }
        public Gender Gender {get;set;}
        public string Mobile {get;set;}
        public DateTime DOB{get;set;}
        public string Branch {get;set;}
        public List<Attendance> AttendanceList {get;set;}
        public EmployeeInfo(string employeeID,string name,string fatherName,Gender gender,string mobile,DateTime dob,string branch,List<Attendance> employee,double salaryOfTheMonth,int month):base (salaryOfTheMonth,month)
        {
            EmployeeID=employeeID;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Mobile=mobile;
            DOB=dob;
            Branch=branch;
            
        }
        public void LogAttendance(DateTime date,double numberOfHoursWorked)
        {
            Attendance attendance=new Attendance();
            attendance.Date=date;
            attendance.NumberOfHoursWorked=numberOfHoursWorked;
            AttendanceList.Add(attendance);
        }
        public void ShowDetails()
        {
            System.Console.WriteLine("Employee ID:"+EmployeeID);
            System.Console.WriteLine("Name:"+Name);
            System.Console.WriteLine("Father Name:"+FatherName);
            System.Console.WriteLine("Gender:"+Gender);
            System.Console.WriteLine("Mobile:"+Mobile);
            System.Console.WriteLine("DOB:"+DOB);
            System.Console.WriteLine("Branch:"+Branch);
            foreach(Attendance attendance in AttendanceList)
            {
                System.Console.WriteLine("Date:"+attendance.Date);
                System.Console.WriteLine("Hours worked:"+attendance.NumberOfHoursWorked);
            }
        }
    }
}