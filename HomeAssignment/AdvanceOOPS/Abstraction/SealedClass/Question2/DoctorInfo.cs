using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class DoctorInfo:PatientInfo
    {
       public int DoctorID {get;set;}
       public void DisplayInfo()
       {
        base.DisplayInfo();
        System.Console.WriteLine("DoctorID:"+DoctorID);
       } 
    }
}