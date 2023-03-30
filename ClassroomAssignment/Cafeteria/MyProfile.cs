using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    public partial class Operations
    {
       public static void MyProfile()
       {
        System.Console.WriteLine($"User ID:{currentUser.UserID}");
        System.Console.WriteLine($"UserName:{currentUser.Name}");
        System.Console.WriteLine($"FatherName:{currentUser.FatherName}");
        System.Console.WriteLine($"Gender:{currentUser.Gender}");
        System.Console.WriteLine($"Mobile number:{currentUser.Mobile}");
        System.Console.WriteLine($"Mail ID:{currentUser.MailID}");
        System.Console.WriteLine($"Wallet Balance:{currentUser.WalletBalance}");
       } 
       public static void WalletRecharge()
       {
        System.Console.WriteLine("Enter the amount to recharge");
        double amount=double.Parse(Console.ReadLine());
        double balance=currentUser.WalletRecharge(amount);
        System.Console.WriteLine("Balance:"+balance);
       }
       public static void WalletBalance()
       {
        System.Console.WriteLine("Wallet Balance:"+currentUser.WalletBalance);
       }
    }
}