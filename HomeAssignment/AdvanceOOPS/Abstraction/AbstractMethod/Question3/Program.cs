using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
       FullTimeEmployee fullTime=new FullTimeEmployee();
       fullTime.EmployeeID=100;
       fullTime.EmployeeName="Sneha";
       fullTime.Gender="Female";
       fullTime.NumberOfDaysWorked=20;
       fullTime.DisplaySalary();

       PartTimeEmployee partTime=new PartTimeEmployee();
       partTime.EmployeeID=101;
       partTime.EmployeeName="Leo";
       partTime.Gender="Male";
       partTime.NumberOfDaysWorked=23;
       partTime.DisplaySalary();
    }
}
