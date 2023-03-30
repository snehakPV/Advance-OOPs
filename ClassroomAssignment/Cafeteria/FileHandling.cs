using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace Cafeteria
{
    public class FileHandling
    {
        public static void Create()
       {
            if(!Directory.Exists("Cafeteria"))
            {
                System.Console.WriteLine("Creating Folder..");
                Directory.CreateDirectory("Cafeteria");
            }
            if(!File.Exists("Cafeteria/UserDetails.csv"))
            {
                System.Console.WriteLine("Creating File user Details");
                File.Create("Cafeteria/UserDetails.csv").Close();
            }
            if(!File.Exists("Cafeteria/FoodDetails.csv"))
            {
                System.Console.WriteLine("Creating File food Details");
                File.Create("Cafeteria/FoodDetails.csv").Close();
            }
            if(!File.Exists("Cafeteria/OrderDetails.csv"))
            {
                System.Console.WriteLine("Creating File Order Details");
                File.Create("Cafeteria/OrderDetails.csv").Close();
            }
            if(!File.Exists("Cafeteria/CartItem.csv"))
            {
                System.Console.WriteLine("Creating File Order Details");
                File.Create("Cafeteria/CartItem.csv").Close();
            }
       } 
       public static void WriteToCSV()
       {
        string [] users=new string[Operations.userList.Count];
        for(int i=0;i<Operations.userList.Count;i++)
        {
          var user=Operations.userList[i];
          users[i]=user.UserID+","+user.Name+","+user.FatherName +","+user.Gender+","+user.Mobile+","+user.MailID+","+user.WorkStationNumber+","+user.WalletBalance;
        }
        File.WriteAllLines("Cafeteria/UserDetails.csv",users);

        string[] foods=new string[Operations.foodList.Count];
        for(int i=0;i<Operations.foodList.Count;i++)
        {
            var food=Operations.foodList[i];
            foods[i]=food.FoodID+","+food.FoodName+","+food.FoodPrice+","+food.AvailableQuantity;
        }
        File.WriteAllLines("Cafeteria/FoodDetails.csv",foods);

        string [] orders=new string[Operations.orderList.Count];
        for(int i=0;i<Operations.orderList.Count;i++)
        {
            var order=Operations.orderList[i];
            orders[i]=order.OrderID+","+order.UserID+","+order.OrderDate+","+order.TotalPrice+","+order.OrderStatus;
        }
        File.WriteAllLines("Cafeteria/OrderDetails.csv",orders);

        string [] carts=new string[Operations.cartGlobalList.Count];
        for(int i=0;i<Operations.cartGlobalList.Count;i++)
        {
            var cart=Operations.cartGlobalList[i];
            carts[i]=cart.ItemID+","+cart.OrderID+","+cart.FoodID+","+cart.OrderPrice+","+cart.OrderQuantity;
        }
        File.WriteAllLines("Cafeteria/CartItem.csv",carts);
       }
       public static void ReadFromCSV()
       {
        string [] users=File.ReadAllLines("Cafeteria/UserDetails.csv");
        for(int i=0;i<users.Length;i++)
        {
            Operations.userList.Add(new UserDetails(users[i]));
        }
        string [] foods=File.ReadAllLines("Cafeteria/FoodDetails.csv");
        for(int i=0;i<foods.Length;i++)
        {
            Operations.foodList.Add(new FoodDetails(foods[i]));
        }
        string [] orders=File.ReadAllLines("Cafeteria/OrderDetails.csv");
        for(int i=0;i<orders.Length;i++)
        {
            Operations.orderList.Add(new OrderDetails(orders[i]));
        }
        string [] carts=File.ReadAllLines("Cafeteria/CartItem.csv");
        for(int i=0;i<carts.Length;i++)
        {
            Operations.cartGlobalList.Add(new CartItem(carts[i]));
        }
       }
    }
}