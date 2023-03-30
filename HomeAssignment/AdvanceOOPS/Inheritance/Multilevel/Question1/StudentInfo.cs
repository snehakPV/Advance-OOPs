using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multilevel
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
      
      
      
        
    }
}