using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Single
{
    public class StudentInfo : PersonalInfo
    {
      public int RegisterNumber { get; set; }
      public string Standard { get; set; }
      public string Branch { get; set; }
      public int AcademicYear { get; set; }
      public StudentInfo(string name,string fatherName,string phone,string mailID,DateTime dob,Gender gender,int registerNumber,string standard,string branch,int academicYear) : base (name,fatherName,phone,mailID,dob,gender)
      {
        RegisterNumber=registerNumber;
        Standard=standard;
        Branch=branch;
        AcademicYear=academicYear;
      }
       public void ShowStudentInfo()
        {
            System.Console.WriteLine("Name:"+Name);
            System.Console.WriteLine("Father Name:"+FatherName);
            System.Console.WriteLine("Phone:"+Phone);
            System.Console.WriteLine("Mail ID:"+MailID);
            System.Console.WriteLine("Gender:"+Gender);
            System.Console.WriteLine("Registration Number:"+RegisterNumber);
            System.Console.WriteLine("Standard:"+Standard);
            System.Console.WriteLine("Branch:"+Branch);
            System.Console.WriteLine("Academic:"+AcademicYear);
            
        }
      
      
        
    }
}