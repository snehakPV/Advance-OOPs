using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public partial class StudentInfo
    {
        public int CalculateTotal()
        {
          int Total=Physics+Chemistry+Maths;  
          return Total;
        }
        public int Percentage()
        {
           int Percent=(Physics+Chemistry+Maths)/3; 
           return Percent;
        }
        public void Display()
        {
            System.Console.WriteLine(StudentID+" "+Name+" "+Gender+" "+Mobile+" "+DOB+" "+Physics+" "+Chemistry+" "+Maths);
        } 
    }
}