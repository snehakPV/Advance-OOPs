using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    //Creating delegate method
    public delegate void Operation();
    //Created partial class to split application in several files
    public partial class Operations
    {
        //Declaring object for current user
        public static UserDetails currentUser;
        //MainMethod to show user the list of option 
        public static void MainMenu()
        {
            int Select = 0;
            do
            {
                System.Console.WriteLine("*****MetroCard Management*****");
                System.Console.WriteLine("Select from the following:\n1.New User Registration\n2.Login\n3.Exit");
                Select = int.Parse(Console.ReadLine());
                //Using switch statement to make user choose from the list of options
                switch (Select)
                {
                    case 1:
                        {
                            System.Console.WriteLine("***Registration***");
                            //calling Registration method inside switch
                            Registration();
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("***Login***");
                            //calling Login method inside switch
                            Login();
                            break;
                        }
                }
            } while (Select < 3);

        }
        //Registration method to get details from user
        public static void Registration()
        {
            System.Console.WriteLine("Enter your name:");
            string userName = Console.ReadLine();
            System.Console.WriteLine("Enter your phone number:");
            string phoneNumber = Console.ReadLine();
            System.Console.WriteLine("Enter your balance:");
            double balance = double.Parse(Console.ReadLine());
            //creating object to store the details gathered from user
            UserDetails registration = new UserDetails(userName, phoneNumber, balance);
            //storing the object inside List
            userList.Add(registration);
            System.Console.WriteLine("Successfully Registered!\nYour Card number: " + registration.CardNumber);
        }
        //Login method to verify the card number
        public static void Login()
        {
            System.Console.WriteLine("Enter your Card number:");
            string cardNumber = Console.ReadLine();
            //using boolean flag to check the condition
            bool flag = true;
            //Traversing userList
            foreach (UserDetails user in userList)
            {
                //comparing cardNumber which is given by user and card number present in userList
                if (cardNumber == user.CardNumber)
                {
                    flag = false;
                    //assigning user to current user to store the data of current user
                    currentUser = user;
                    //creating Submenu method to show the list of menu inside Login method
                    SubMenu();
                    break;
                }
            }
            //if flag condition is true - Invalid Card number will display
            if (flag)
            {
                System.Console.WriteLine("Invalid Card Number!");
            }
        }
        //Creating SubMenu to show list of options to user
        public static void SubMenu()
        {
            int Select = 0;
            do
            {
                System.Console.WriteLine("Select from the following:\n1.Balance Check\n2.Recharge\n3.Travel History\n4.Travel\n5.Exit");
                Select = int.Parse(Console.ReadLine());
                switch (Select)
                {
                    case 1:
                        {
                            System.Console.WriteLine("***Balance Check***");
                            //Calling BalanceCheck method inside switch statement
                            BalanceCheck();
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("***Recharge***");
                            //Calling Recharge method inside switch statement
                            Recharge();
                            break;
                        }
                    case 3:
                        {
                            System.Console.WriteLine("***Travel History***");
                            //Calling Travel History method inside switch statement
                            TravelHistory();
                            break;
                        }
                    case 4:
                        {
                            System.Console.WriteLine("***Travel***");
                            //Calling Travel method inside switch statement
                            Travel();
                            break;
                        }
                }
            } while (Select < 5);

        }
        //creating event to trigger the method
        public static event Operation start;
        //Creating private method to store each method  
        private static void Subscribe()
        {
            start = new Operation(FileHandling.Create);
            //start+=new Operation(Operations.UserDefault);
            //start+=new Operation(Operations.TravelDefault);
            //start+=new Operation(Operations.TicketFairDefault);
            start += new Operation(FileHandling.ReadFromCSV);
            start += new Operation(Operations.MainMenu);
            start += new Operation(FileHandling.WriteToCSV);

        }
        //Creating Starter method to call private method Subscribe and event - start.
        public static void Starter()
        {
            Subscribe();
            start();
        }
    }
}