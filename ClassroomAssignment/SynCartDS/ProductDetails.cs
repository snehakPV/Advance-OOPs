using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SynCartDS
{
    public class ProductDetails
    {
      /*  •	ProductID (Auto Increment – PID101)
•	ProductName
•	Price
•	Stock 
•	ShippingDuration*/
    private static int s_productID=100;
    public string ProductID { get; }
    public string ProductName { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
    public int ShippingDuration { get; set; }
    public ProductDetails(string productName,double price,int stock,int shippingDuration)
    {
        s_productID++;
        ProductID="PID"+s_productID;
        ProductName=productName;
        Price=price;
        Stock=stock;
        ShippingDuration=shippingDuration;
    }
    public ProductDetails(string product)
    {
        string [] values=product.Split(",");
        ProductID=values[0];
        s_productID=int.Parse(values[0].Remove(0,3));
        ProductName=values[1];
        Price=double.Parse(values[2]);
        Stock=int.Parse(values[3]);
        ShippingDuration=int.Parse(values[4]);
    }
    
    
    
    
    
    
    
    
    

    }
}