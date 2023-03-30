using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        Syncfusion employee=new Syncfusion();
        employee.Name="Sneha";
        employee.FatherName="kumar";
        employee.Gender="Female";
        employee.Qualification="BE";
        employee.Role="Developer";
        employee.SalaryAmount=5000;
        employee.NoOfWorkingDays=20;
        employee.EmployeeID=1234;
        employee.WorkLocation="Chennai";

        employee.Display();
        System.Console.WriteLine(employee.CalculateSalary());
    }
}
