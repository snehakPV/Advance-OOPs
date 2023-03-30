using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question3
{
    public class OfflineTransaction:ITransaction
    {
        public int TransactionID {get;set;}
       public Purchase[] Purchases {get;set;}
       public DateTime DateOfPurchase {get;set;}
       public decimal TotalAmount {get;set;}
       public void CalculateAmount()
       {
        TotalAmount=0;
        foreach(Purchase purchase in Purchases)
        {
            purchase.Amount=purchase.Quantity*15;
            TotalAmount+=purchase.Amount;
        }
       } 
       public void DisplayBill()
       {
        System.Console.WriteLine(TransactionID+" "+DateOfPurchase+" "+TotalAmount);
        foreach(Purchase purchase in Purchases)
        {
            System.Console.WriteLine(purchase.MaterialID+" "+purchase.Name+" "+purchase.Quantity+" "+purchase.Amount);
        }
       }
 
    }
}