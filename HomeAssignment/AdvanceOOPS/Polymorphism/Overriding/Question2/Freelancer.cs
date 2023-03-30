using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class Freelancer:PersonDetails
    {
        public string Role {get;set;}
        public int SalaryAmount {get;set;}
        public int NoOfWorkingDays {get;set;}
        public override void Display()
        {
            base.Display();
            System.Console.WriteLine("Role:"+Role);
            System.Console.WriteLine("Salary Amount:"+SalaryAmount);
            System.Console.WriteLine("Number of working days:"+NoOfWorkingDays);
        } 
        public virtual int CalculateSalary()
        {
            return NoOfWorkingDays*500;
        }
        
    }
}