using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class RackInfo:DepartmentDetails
    {
        public int RackNumber {get;set;}
        public int ColumnNumber {get;set;}
        public RackInfo (string departmentName,string degree,string bookID,string bookName,string authorName,double price,int rackNumber,int columnNumber):base (departmentName,degree)
        {
            RackNumber=rackNumber;
            ColumnNumber=columnNumber;
        }
    }
}