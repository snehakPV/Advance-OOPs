using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class LadiesWear:Dress
    {
        public LadiesWear(string name,decimal pricee)
        {
            dressType="Ladieswear";
            dressName=name;
            price=pricee;
        }
        public override void GetDressInfo()
        {
            System.Console.WriteLine("Name:"+dressName);
            System.Console.WriteLine("Price:"+price);
        }
        public override void DisplayInfo()
        {
            totalPrice=price*0.8m;
            System.Console.WriteLine($"Bill for {dressType},{dressName} is {totalPrice}");
        }
    }
}