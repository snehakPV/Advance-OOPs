using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    sealed class PatientInfo
    {
      public int PatientID {get;set;}
      public string Name { get; set; }
      public string FatherName { get; set; }
      public int BedNo {get;set;}
      public string NativePlace {get;set;}
      public string AdmittedFor {get;set;}
      public void DisplayInfo()
      {
        System.Console.WriteLine("Patient ID:"+PatientID);
        System.Console.WriteLine("Patient Name:"+Name);
        System.Console.WriteLine("Father Name:"+FatherName);
        System.Console.WriteLine("Bed No.:"+BedNo);
        System.Console.WriteLine("Native place:"+NativePlace);
        System.Console.WriteLine("Admitted for:"+AdmittedFor);
      }
    }
}