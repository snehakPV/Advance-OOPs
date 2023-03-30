using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multilevel
{
    public class HSCDetails : PersonalInfo
    {
        public int HSCMarksheetNumber { get;set;}
        public int Physics {get;set;}
        public int Chemistry { get; set; }
        public int Maths {get;set;}
        public int Total {get;set;}
        public int Percentage {get;set;}
        public HSCDetails(string name,string fatherName,string phone,string mailID,DateTime dob,Gender gender,int registerNumber,string standard,string branch,int academicYear,int hSCMarksheetNumber,int physics,int chemistry,int maths,int total,int percentage ): base (name,fatherName,phone,mailID,dob,gender)
        {
            HSCMarksheetNumber=hSCMarksheetNumber;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
            Total=total;
            Percentage=percentage;
        }

        public void GetMarks(int physics,int chemistry,int maths)
        {
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
        public void Calculate()
        {
            Total=Physics+Chemistry+Maths;
            Percentage=(Physics+Chemistry+Maths)/3;
        }
        public void ShowMarksheet(int hSCMarksheetNumber,int physics,int chemistry,int maths)
        {
            HSCMarksheetNumber=hSCMarksheetNumber;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
            Total=Physics+Chemistry+Maths;
            System.Console.WriteLine("Total:"+Total);
            Percentage=(Physics+Chemistry+Maths)/3;
            System.Console.WriteLine("Percentage:"+Percentage);
            
        }
    }
}