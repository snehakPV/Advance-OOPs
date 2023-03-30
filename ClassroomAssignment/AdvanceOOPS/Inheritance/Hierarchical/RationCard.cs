using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hierarchical
{
    public class RationCard:PersonalDetails
    {
        private static int s_rationID=1000;
        public string RationID{get;}
        public List<string> People {get;set;}
        public RationCard(int aadharID,string name,string fatherName,Gender personGender,DateTime dob,List <string> people):base(aadharID,name,fatherName,personGender,dob)
        {
            s_rationID++;
            RationID="RID"+s_rationID;
            People=people;
        }
    }
}