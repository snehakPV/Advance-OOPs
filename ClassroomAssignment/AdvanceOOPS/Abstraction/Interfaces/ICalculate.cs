using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICalculate
    {
        int Number {get;set;}  //property
        int Calculate();  //method - declaration
        //fully abstraction - no method allowed
    }
}