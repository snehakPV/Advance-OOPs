using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
   
    public partial class Operations
    {
       public static void CancelOrder()
       {
       // bool flag=true;
        foreach (OrderDetails order in orderList)
        {
            if(currentUser.UserID==order.UserID && OrderStatus.Ordered==order.OrderStatus)
            {
               // flag=false;
                System.Console.WriteLine($"{order.UserID}|{order.OrderID}|{order.OrderDate}|{order.TotalPrice}|{order.OrderStatus}");
            }
        } 
        
        System.Console.WriteLine("Enter your OrderID");
        string orderID=Console.ReadLine();
        bool flag2=true;
        foreach (OrderDetails order in orderList)
        {
            if(orderID==order.OrderID && OrderStatus.Ordered==order.OrderStatus)
            {
                flag2=false;
                    currentUser.WalletRecharge(order.TotalPrice);
                    foreach(CartItem cart in cartGlobalList)
                    {
                       if(cart.OrderID==order.OrderID)
                        {
                         foreach(FoodDetails food in foodList)
                         {
                            if(food.FoodID==cart.FoodID)
                            {
                                food.AvailableQuantity+=cart.OrderQuantity;
                                order.OrderStatus=OrderStatus.Cancelled;
                                System.Console.WriteLine("Order Cancelled Successfully!\nItems returned to cart.");
                                break;
                            }
                         }
                        }
                    }
                
                
                
            }
            
        }
        if(flag2)
        {
            
            System.Console.WriteLine("Invalid Order ID!");
                
        }
       }
       public static void OrderHistory()
       {
        bool flag=true;
        foreach(OrderDetails order in orderList)
        {
            if(currentUser.UserID==order.UserID)
            {
                flag=false;
                System.Console.WriteLine($"{order.UserID}|{order.OrderID}|{order.OrderDate}|{order.TotalPrice}|{order.OrderStatus}");
            }
        }
        if(flag)
        {
             System.Console.WriteLine("You have no order history!");
        }
       }
    }
}