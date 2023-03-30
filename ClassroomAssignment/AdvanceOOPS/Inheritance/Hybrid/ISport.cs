using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybrid
{
    public interface ISport:IStudent
    {
      int SportsMark {get;set;}  
    }
}