using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    public partial class Operations
    {
        public static void DefaultFood()
        {
            FoodDetails food1=new FoodDetails("Coffee",20,100);
            FoodDetails food2=new FoodDetails("Tea",15,100);
            FoodDetails food3=new FoodDetails("Biscuit",10,100);
            FoodDetails food4=new FoodDetails("Juice",50,100);
            FoodDetails food5=new FoodDetails("Puff",40,100);
            FoodDetails food6=new FoodDetails("Milk",10,100);
            FoodDetails food7=new FoodDetails("Popcorn",20,20);
            foodList.Add(food1);
            foodList.Add(food2);
            foodList.Add(food3);
            foodList.Add(food4);
            foodList.Add(food5);
            foodList.Add(food6);
            foodList.Add(food7);
            

        }
        public static void DefaultUser()
        {
            UserDetails user1=new UserDetails("Ravichandran","Ettapparajan",Gender.Male,"8857777575","ravi@gmail.com","WS101",400);
            UserDetails user2=new UserDetails("Baskaran","Sethurajan",Gender.Male,"9577747744","baskaran@gmail.com","WS105",500);
            userList.Add(user1);
            userList.Add(user2);
        }
        public static void DefaultOrder()
        {
            OrderDetails order1=new OrderDetails("SF1001",new DateTime(2022,06,15),70,OrderStatus.Ordered);
            OrderDetails order2=new OrderDetails("SF1002",new DateTime(2022,06,15),100,OrderStatus.Ordered);
            orderList.Add(order1);
            orderList.Add(order2);
           
        }
        public static void DefaultCartItem()
        {
            CartItem cart1=new CartItem("OID1001","FID101",20,1);
            CartItem cart2=new CartItem("OID1001","FID103",10,1);
            CartItem cart3=new CartItem("OID1001","FID105",40,1);
            CartItem cart4=new CartItem("OID1002","FID103",10,1);
            CartItem cart5=new CartItem("OID1002","FID104",50,1);
            CartItem cart6=new CartItem("OID1002","FID105",40,1);
            cartGlobalList.Add(cart1);
            cartGlobalList.Add(cart2);
            cartGlobalList.Add(cart3);
            cartGlobalList.Add(cart4);
            cartGlobalList.Add(cart5);
            cartGlobalList.Add(cart6);
        }
    }
}