using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    public partial class Operations
    {
        
       public static void FoodOrder()
       {
        List<CartItem> cartList=new List<CartItem>();
        OrderDetails orderInitiated =new OrderDetails(currentUser.UserID,DateTime.Now,0,OrderStatus.Initiated);
        string choice=string.Empty;
        do
        {
        foreach(FoodDetails food in foodList)
        {
            System.Console.WriteLine($"{food.FoodID}|{food.FoodName}|{food.AvailableQuantity}|{food.FoodPrice}");
        }
        
        orderList.Add(orderInitiated);
        
        System.Console.WriteLine("Pick a Food ID:");
        string foodID=Console.ReadLine().ToUpper();
        System.Console.WriteLine("Enter the quantity:");
        int quantity=int.Parse(Console.ReadLine());
        bool flag=true;
        foreach(FoodDetails food in foodList)
        {
            if(food.FoodID==foodID)
            {
                flag=false;
                if(food.AvailableQuantity>=quantity)
                {
                    CartItem cartItem=new CartItem();
                    cartItem.OrderQuantity+=food.AvailableQuantity;
                    //food.AvailableQuantity-=cartItem.OrderQuantity;
                    cartList.Add(cartItem);
                    System.Console.WriteLine("Do you wish to pick another product? (yes/no)");
                    choice=Console.ReadLine().ToLower();
                    if(choice=="no")
                    {
                        System.Console.WriteLine("Do you confirm the wishlist to purchase?(yes/no)");
                        string choice1=Console.ReadLine().ToLower();
                        if(choice1=="no")
                        {
                            foreach(CartItem cart in cartList)
                            {
                              //  if(food.FoodID==cart.FoodID)
                                {
                                food.AvailableQuantity+=cart.OrderQuantity;
                                }
                            }
                        }
                        else
                        {
                            bool flag1=true;
                            string choice2=string.Empty;
                               do
                               {
                            foreach(CartItem cart in cartList)
                            {
                               // if(food.FoodID==cart.FoodID)
                               
                                
                                orderInitiated.TotalPrice=food.FoodPrice*cart.OrderQuantity;
                                if(currentUser.WalletBalance>=orderInitiated.TotalPrice)
                                {
                                    flag1=false;
                                    currentUser.DeductAmount(orderInitiated.TotalPrice);
                                    cartGlobalList.AddRange(cartList);
                                    foreach(OrderDetails order in orderList)
                                    {
                                      order.TotalPrice=orderInitiated.TotalPrice;
                                      order.OrderStatus=OrderStatus.Ordered;
                                      System.Console.WriteLine("Order placed!\nYour OrderID: "+order.OrderID);
                                      
                                    }
                                    break;
                                }
                                
                                }
                                if(flag1)
                                {
                                    System.Console.WriteLine("Insufficient balance to purchase!\nAre you willing to recharge?(yes/no)");
                                    choice2=Console.ReadLine().ToLower();
                                    if(choice2=="yes")
                                    {
                                        WalletRecharge();   
                                        break;                       
                                    }
                                
                                    else
                                    {
                                       System.Console.WriteLine("Exiting without order due to insufficient balance."); 
                                    }
                                }
                                
                            }while(choice2=="yes");
                        }
                    }
                }
                else
                {
                    System.Console.WriteLine("Quantity not available");
                }
            }
        }
        if(flag)
        {
            System.Console.WriteLine("Invalid Food ID!");
        }
       }while(choice=="yes");
       }
    }
}