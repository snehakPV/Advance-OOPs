using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question4
{
    public class SalaryInfo
    {
        public double SalaryOfTheMonth{get;set;}
        public int Month{get;set;}
        public SalaryInfo(double salaryOfTheMonth,int month)
        {
            SalaryOfTheMonth=salaryOfTheMonth;
            Month=month;
        }
        public void CalculateSalary(List<Attendance> attendanceList)
        {
            double totalHoursWorked=0;
            foreach(Attendance attendance in attendanceList)
            {
               totalHoursWorked+=attendance.NumberOfHoursWorked; 
            }
            SalaryOfTheMonth=totalHoursWorked*500;
        }
        public void DisplaySalary()
        {
            System.Console.WriteLine("Salary :"+SalaryOfTheMonth);
        }
    }
}