using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
       Attendance month1=new Attendance(23,3,2);
       System.Console.WriteLine(month1.CalculateSalary());
       
       Attendance month2=new Attendance(23,0,2); 
       System.Console.WriteLine(month2.CalculateSalary());

       Attendance month3=new Attendance(23,0,0);
       System.Console.WriteLine(month3.CalculateSalary());

    }
}
