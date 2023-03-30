using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multiple
{
    public interface IMarkDetails
    {
        //No fields , no contructor , no object creation
        //Property declaration only
        //Purely for inheritance
        int Physics { get; set; }
        int Maths { get; set; }
        int Chemistry { get; set; }
        int Total { get; set; }
        void GetMarks(int physics, int chemistry, int maths);
        void Calculate();
    }
}