using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybrid
{
    public interface IAcadamic:IStudent
    {
        int AcademicMark {get;set;}
    }
}