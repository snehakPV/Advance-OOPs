using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SynCartDS
{
    public class CustomerDetails
    {
        /*
•	CustomerID (Auto Increment -CID1000)
•	Name
•	City
•	MobileNumber
•	WalletBalance
•	EmailID
*/
        private static int s_customerID = 1000;
        public string CustomerID { get; }
        public string CustomerName { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        private double _balance;
        public double WalletBalance { get{return _balance;} }
        public string MailID { get; set; }
        public CustomerDetails(string customerName,string city,string phone,double walletBalance,string mailID)
        {
          s_customerID++;
          CustomerID="CID"+s_customerID;
          CustomerName=customerName;
          City=city;
          Phone=phone;
          _balance=walletBalance;
          MailID=mailID;
        }
        public CustomerDetails(string customer)
        {
            string [] values=customer.Split(",");
            CustomerID=values[0];
            s_customerID=int.Parse(values[0].Remove(0,3));
            CustomerName=values[1];
            City=values[2];
            Phone=values[3];
            _balance=double.Parse(values[4]);
            MailID=values[5];

        }
        public void WalletRecharge(double amount)
        {
            _balance+=amount;
        }
        public void DeductBalance(double amount)
        {
            _balance-=amount;
        }












    }
}