using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question3
{
    public class OnlineTransaction:ITransaction
    {
       public int TransactionID {get;set;}
       public Purchase[] Purchases {get;set;}
        
    }
}