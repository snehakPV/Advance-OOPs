using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multiple
{
    public class StudentDetails : PersonalDetails, IMarkDetails
    {
        private static int s_studentID = 1000;
        public string StudentID { get; }
        public string Standard { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public int Total { get; set; }
        public void GetMarks(int physics, int chemistry, int maths)
        {
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
        }
        public void Calculate()
        {
            Total = Physics + Chemistry + Maths;
        }
        public StudentDetails(int aadharID, string name, string fatherName, Gender personGender, DateTime dob, string standard) : base(aadharID, name, fatherName, personGender, dob)
        {
            s_studentID++;
            StudentID = "SID" + s_studentID;
            Standard = standard;
        }
        public StudentDetails(string studentID, int aadharID, string name, string fatherName, Gender personGender, DateTime dob, string standard) : base(aadharID, name, fatherName, personGender, dob)
        {
            StudentID = studentID;
            Standard = standard;
        }
    }
}