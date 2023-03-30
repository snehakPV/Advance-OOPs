using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Single
{
    public class StudentDetails:PersonalDetails
    {
        private static int s_studentID=1000;
        public string StudentID {get;}
        public string Standard {get;set;}
        public StudentDetails(int aadharID,string name,string fatherName,Gender personGender,DateTime dob,string standard):base(aadharID,name,fatherName,personGender,dob)
        {
            s_studentID++;
            StudentID="SID"+s_studentID;
            Standard=standard;
        }
    }
}