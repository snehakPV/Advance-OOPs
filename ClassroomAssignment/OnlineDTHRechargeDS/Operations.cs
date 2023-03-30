using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineDTHRechargeDS
{
    public class Operations
    {
        public UserDetails currentUser;
        public static CustomList<UserDetails> userList = new CustomList<UserDetails>();
        public static CustomList<PackDetails> packList = new CustomList<PackDetails>();
        public static CustomList<RechargeDetails> rechargeList = new CustomList<RechargeDetails>();
        public void DefaultData()
        {
            UserDetails user1 = new UserDetails("John", "9746646466", "john@gmail.com", 500);
            UserDetails user2 = new UserDetails("Merlin", "9782136543", "merlin@gmail.com", 150);
            userList.Add(user1);
            userList.Add(user2);
            PackDetails pack1 = new PackDetails("RC150", "Pack1", 150, 28, 50);
            PackDetails pack2 = new PackDetails("RC300", "Pack2", 300, 56, 75);
            PackDetails pack3 = new PackDetails("RC500", "Pack3", 500, 28, 200);
            PackDetails pack4 = new PackDetails("RC1500", "Pack4", 1500, 365, 200);
            packList.Add(pack1);
            packList.Add(pack2);
            packList.Add(pack3);
            packList.Add(pack4);
            RechargeDetails recharge1 = new RechargeDetails("UID1001", "RC150", new DateTime(2021, 11, 30), 150, new DateTime(2021, 12, 27), 50);
            RechargeDetails recharge2 = new RechargeDetails("UID1002", "RC150", new DateTime(2022, 01, 01), 150, new DateTime(2022, 01, 28), 50);
            rechargeList.Add(recharge1);
            rechargeList.Add(recharge2);
        }
        public void MainMenu()
        {
            int option = 0;
            System.Console.WriteLine("***Welcome to Online DTH Recharge***");
            do
            {
                System.Console.WriteLine("Select from the following:\n1.Registration\n2.Login\n3.Exit");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Registration();
                            break;
                        }
                    case 2:
                        {
                            Login();
                            break;
                        }
                }
            } while (option < 3);

        }
        public void Registration()
        {
            System.Console.WriteLine("Enter your Name:");
            string userName = Console.ReadLine();
            System.Console.WriteLine("Enter your Mobile Number:");
            string mobileNumber = Console.ReadLine();
            System.Console.WriteLine("Enter your MailID:");
            string emailID = Console.ReadLine();
            System.Console.WriteLine("Enter your Balance:");
            double walletBalance = double.Parse(Console.ReadLine());
            UserDetails userDetails = new UserDetails(userName, mobileNumber, emailID, walletBalance);
            userList.Add(userDetails);
            System.Console.WriteLine("Registered Successfully!\nYour User ID: " + userDetails.UserID);
        }
        public void Login()
        {
            System.Console.WriteLine("Enter your User ID:");
            string userID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (UserDetails user in userList)
            {
                if (userID == user.UserID)
                {
                    flag = false;
                    currentUser = user;
                    SubMenu();
                }
            }
            if (flag)
            {
                System.Console.WriteLine("Invalid UserID!");
            }
        }
        public void SubMenu()
        {
            int option = 0;
            do
            {
                System.Console.WriteLine("Select from the following:\n1.Current pack\n2.Pack Recharge\n3.Wallet Recharge\n4.Pack Recharge History\n5.Show Wallet Balance\n6.Exit");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            CurrentPack();
                            break;
                        }
                    case 2:
                        {
                            PackRecharge();
                            break;
                        }
                    case 3:
                        {
                            WalletRecharge();
                            break;
                        }
                    case 4:
                        {
                            PackRechargeHistory();
                            break;
                        }
                    case 5:
                        {
                            WalletBalance();
                            break;
                        }
                }
            } while (option < 6);
        }
        public void CurrentPack()
        {
            foreach (RechargeDetails recharge in rechargeList)
            {
                if (currentUser.UserID == recharge.UserID)
                {
                    System.Console.WriteLine($"{recharge.UserID}|{recharge.PackID}|{recharge.RechargeAmount}|{recharge.ValidTill}|{recharge.NumberOfChannels}");
                }
            }
        }
        public void PackRecharge()
        {
            foreach (PackDetails pack in packList)
            {
                System.Console.WriteLine($"{pack.PackID}|{pack.PackName}|{pack.Price}|{pack.Validity}|{pack.NumOfChannels}");
            }
            System.Console.WriteLine("Select a pack to recharge");
            string packID = Console.ReadLine().ToUpper();
            bool flag = true;
            bool flag1= true;

            do{
            foreach (PackDetails pack in packList)
            {
                if (packID == pack.PackID)
                {
                    flag = false;
                    if (currentUser.WalletBalance >= pack.Price)
                    {
                        double totalamount = currentUser.DeductBalance(pack.Price);
                        DateTime valid = DateTime.Now.AddDays(pack.Validity);
                        RechargeDetails rechargedetail = new RechargeDetails(currentUser.UserID, packID, DateTime.Now, totalamount, valid, pack.NumOfChannels);
                        rechargeList.Add(rechargedetail);
                        System.Console.WriteLine("Pack Recharged Successfully!\nYour Recharge ID: " + rechargedetail.RechargeID);
                        flag1=false;
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Insufficient Balance.Recharge your wallet.");
                        WalletRecharge();
                    }

                }
            }
            }while(flag1);
            if (flag)
            {
                System.Console.WriteLine("Invalid Pack ID!");
            }
        }
        public void WalletRecharge()
        {
            System.Console.WriteLine("Enter the amount to be recharged:");
            double amount = double.Parse(Console.ReadLine());
            Console.WriteLine(currentUser.Balance(amount));
        }
        public void PackRechargeHistory()
        {
            foreach (RechargeDetails recharge in rechargeList)
            {
                if (currentUser.UserID == recharge.UserID)
                {
                    System.Console.WriteLine("Your Recharge History:");
                    System.Console.WriteLine($"{recharge.RechargeID}|{recharge.UserID}|{recharge.PackID}|{recharge.RechargeDate}|{recharge.RechargeAmount}|{recharge.ValidTill}|{recharge.NumberOfChannels}");
                }
            }
        }
        public void WalletBalance()
        {
            System.Console.WriteLine("Wallet Balance: "+currentUser.WalletBalance);
        }
    }
}