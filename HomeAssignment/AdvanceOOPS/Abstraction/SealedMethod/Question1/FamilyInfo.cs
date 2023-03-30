using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public  class FamilyInfo:PersonalInfo
    {
        public string MotherName {get;set;}
        public int NoOfSiblings {get;set;}
        public string NativePlace {get;set;}
        public sealed override void Update()
        {
            System.Console.WriteLine("Family info");
        }
        public void DisplayInfo()
        {
            System.Console.WriteLine("FatherName:"+FatherName);
            System.Console.WriteLine("Mothername:"+MotherName);
            System.Console.WriteLine("Number of sibling:"+NoOfSiblings);
            System.Console.WriteLine("Native Place:"+NativePlace);
        }
    }
}