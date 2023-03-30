using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo personalInfo;
        EmployeeInfo employeeInfo = new EmployeeInfo();
        SalaryInfo salaryInfo=new SalaryInfo();
        employeeInfo.EmployeeID=123;
        employeeInfo.Name="Sneha";
        employeeInfo.FatherName="Kumar";
        employeeInfo.Mobile="23456789";
        employeeInfo.Gender="Female";
        personalInfo=employeeInfo;
        personalInfo.Display();

        salaryInfo.EmployeeID=234;
        salaryInfo.Name="chinnu";
        salaryInfo.FatherName="kumar";
        salaryInfo.Mobile="98765432";
        salaryInfo.Gender="Female";
        salaryInfo.NoOfDaysWorked=20;
        personalInfo=salaryInfo;
        personalInfo.Display();


    }
}