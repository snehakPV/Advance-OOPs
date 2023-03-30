using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class Calculator
    {
        public int[] marks;
        public Calculator(int mark1,int mark2,int mark3,int mark4,int mark5,int mark6)
        {
            marks=new int[] {mark1,mark2,mark3,mark4,mark5,mark6};
        }
        public int GetTotalMarks()
        {
            int total=0;
            foreach(int mark in marks)
            {
                total+=mark;
            }
            return total;
        }
        public float GetPercentage()
        {
            return (float)GetTotalMarks()/(float)(marks.Length*100)*100;
        }
        public static Calculator operator+(Calculator calc1,Calculator calc2)
        {
            int totalMarks=calc1.GetTotalMarks()+calc2.GetTotalMarks();
            float percentage=(float)totalMarks/(float)(calc1.marks.Length+calc2.marks.Length)/100*100;
            System.Console.WriteLine("Total marks:"+totalMarks);
            System.Console.WriteLine("Percentage:"+percentage);
            return new Calculator(0,0,0,0,0,0);
        }
    }
}