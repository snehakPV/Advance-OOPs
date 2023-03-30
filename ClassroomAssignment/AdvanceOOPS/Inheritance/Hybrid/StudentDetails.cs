using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybrid
{
    public class StudentDetails:IAcadamic,ISport
    {
        public string Name {get;set;}
        public string Standard {get;set;}
        public int AcademicMark {get;set;}
        public int SportsMark {get;set;}
    }
}