using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multiple
{
    public class EmploymentDetails:StudentDetails
    {
        private static int s_employmentID=1000;
        public string EmploymentID { get; }
        public DateTime DOR { get; set;}
        public EmploymentDetails(string studentID,int aadharID,string name,string fatherName,Gender personGender,DateTime dob,string standard,DateTime dor):base(studentID,aadharID,name,fatherName,personGender,dob,standard)
        {
            s_employmentID++;
            EmploymentID="EID"+s_employmentID;
            DOR=dor;
        }
        
    }
}