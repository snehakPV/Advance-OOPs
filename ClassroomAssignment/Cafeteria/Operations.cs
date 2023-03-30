using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    public delegate void Operation();
    public partial class Operations
    {
        public static UserDetails currentUser;
        public static List<UserDetails> userList=new List<UserDetails>();
        public static List<FoodDetails> foodList=new List<FoodDetails>();
        public static List<OrderDetails> orderList=new List<OrderDetails>();
        public static List<CartItem> cartGlobalList = new List<CartItem>();
        public static void MainMenu()
        {
            int Select=0;
            do
            {
                System.Console.WriteLine("**********Cafeteria**********");
                System.Console.WriteLine("Select from the following:\n1.Registration\n2.Login\n3.Exit");
            Select=int.Parse(Console.ReadLine());
            switch(Select)
            {
                case 1:
                {
                    System.Console.WriteLine("*****Registration*****");
                    Registration();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("*****Login*****");
                    Login();
                    break;
                }
            }
            }while(Select<3);
            
        }
        public static void Registration()
        {
            System.Console.WriteLine("Enter your name:");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your father name:");
            string fatherName=Console.ReadLine();
            System.Console.WriteLine("Enter your mobile number:");
            string mobile=Console.ReadLine();
            System.Console.WriteLine("Enter your mail Id:");
            string mailID=Console.ReadLine();
            System.Console.WriteLine("Enter your gender:");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine());
            System.Console.WriteLine("Enter work station number:");
            string workStationNumber=Console.ReadLine();
            System.Console.WriteLine("Enter balance:");
            double balance=double.Parse(Console.ReadLine());
            UserDetails userDetails=new UserDetails(name,fatherName,gender,mobile,mailID,workStationNumber,balance);
            userList.Add(userDetails);
            System.Console.WriteLine("Registered Successfully!\nYour User ID: "+userDetails.UserID);
        }
        public static void Login()
        {
            System.Console.WriteLine("Enter the User Id:");
            string UserID=Console.ReadLine();
            bool flag=true;
            foreach(UserDetails user in userList)
            {
                if(UserID==user.UserID)
                {
                    System.Console.WriteLine("Login Successful!");
                    currentUser=user;
                    flag=false;
                    SubMenu();
                }
            }
            if(flag)
            {
                System.Console.WriteLine("Invalid Login ID!");
            }
        }
        public static void SubMenu()
        {
            int Select=0;
            do
            {
                System.Console.WriteLine("Select from the following:\n1.My Profile\n2.Food Order\n3.Cancel Order\n4.Order History\n5.Wallet Recharge\n6.Show Wallet Balance\n7.Exit");
            Select=int.Parse(Console.ReadLine());
            switch(Select)
            {
                case 1:
                {
                    System.Console.WriteLine("*****My Profile*****");
                    MyProfile();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("*****Food Order******");
                    FoodOrder();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("*****Cancel Order*****");
                    CancelOrder();
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("*****Order History*****");
                    OrderHistory();
                    break;
                }
                case 5:
                {
                    System.Console.WriteLine("*****Wallet Recharge*****");
                    WalletRecharge();
                    break;
                }
                case 6:
                {
                    System.Console.WriteLine("*****Wallet balance*****");
                    WalletBalance();
                    break;
                }
            }
            }while(Select<7);
            
        }
    public static event Operation start;
    private static void Subscribe()
    {
        start=new Operation(FileHandling.Create);
        //start+=new Operation (Operations.DefaultUser);
        //start+=new Operation (Operations.DefaultFood);
        //start+=new Operation (Operations.DefaultOrder);
        //start+=new Operation (Operations.DefaultCartItem);
        start+=new Operation (FileHandling.ReadFromCSV);
        start+=new Operation(Operations.MainMenu);
        start+=new Operation (FileHandling.WriteToCSV);
        
    }
    public static void Starter()
    {
        Subscribe();
        start();
    }
    }
}