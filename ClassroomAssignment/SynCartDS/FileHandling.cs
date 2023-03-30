using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SynCartDS
{
    public class FileHandling
    {
       public static void Create()
       {
            if(!Directory.Exists("SynCartDS"))
            {
                System.Console.WriteLine("Creating Folder..");
                Directory.CreateDirectory("SynCartDS");
            }
            if(!File.Exists("SynCartDS/CustomerDetails.csv"))
            {
                System.Console.WriteLine("Creating File Customer Details");
                File.Create("SynCartDS/CustomerDetails.csv").Close();
            }
            if(!File.Exists("SynCartDS/ProductDetails.csv"))
            {
                System.Console.WriteLine("Creating File Product Details");
                File.Create("SynCartDS/ProductDetails.csv").Close();
            }
            if(!File.Exists("SynCartDS/OrderDetails.csv"))
            {
                System.Console.WriteLine("Creating File Order Details");
                File.Create("SynCartDS/OrderDetails.csv").Close();
            }
       } 
       public static void WriteToCSV()
       {
        string [] customers=new string[Operation.customerList.Count];
        for(int i=0;i<Operation.customerList.Count;i++)
        {
          var customer=Operation.customerList[i];
          customers[i]=customer.CustomerID+","+customer.CustomerName+","+customer.City+","+customer.Phone+","+customer.WalletBalance+","+customer.MailID;
        }
        File.WriteAllLines("SynCartDS/CustomerDetails.csv",customers);

        string[] products=new string[Operation.productList.Count];
        for(int i=0;i<Operation.productList.Count;i++)
        {
            var product=Operation.productList[i];
            products[i]=product.ProductID+","+product.ProductName+","+product.Price+","+product.Stock+","+product.ShippingDuration;
        }
        File.WriteAllLines("SynCartDS/ProductDetails.csv",products);
        string [] orders=new string[Operation.orderList.Count];
        for(int i=0;i<Operation.orderList.Count;i++)
        {
            var order=Operation.orderList[i];
            orders[i]=order.OrderID+","+order.CustomerID+","+order.ProductID+","+order.TotalPrice+","+order.PurchaseDate+","+order.Quantity+","+order.Status;
        }
        File.WriteAllLines("SynCartDS/OrderDetails.csv",orders);
       }
       public static void ReadFromCSV()
       {
        string [] customers=File.ReadAllLines("SynCartDS/CustomerDetails.csv");
        for(int i=0;i<customers.Length;i++)
        {
            Operation.customerList.Add(new CustomerDetails(customers[i]));
        }
        string [] products=File.ReadAllLines("SynCartDS/ProductDetails.csv");
        for(int i=0;i<products.Length;i++)
        {
            Operation.productList.Add(new ProductDetails(products[i]));
        }
        string [] orders=File.ReadAllLines("SynCartDS/OrderDetails.csv");
        for(int i=0;i<orders.Length;i++)
        {
            Operation.orderList.Add(new OrderDetails(orders[i]));
        }
       }
    }
}