using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    public class UserDetails : PersonalDetails, IBalance
    {
        private static int s_userID = 1000;
        public string UserID { get; }
        public string WorkStationNumber { get; set; }
        private double _balance;
        public double WalletBalance { get { return _balance; } }
        public UserDetails(string name, string fatherName, Gender gender, string mobile, string mailID, string workStationNumber, double walletBalance) : base(name, fatherName, gender, mobile, mailID)
        {
            s_userID++;
            UserID = "SF" + s_userID;
            WorkStationNumber = workStationNumber;
            _balance = walletBalance;
        }
        public UserDetails(string userID,string name, string fatherName, Gender gender, string mobile, string mailID, string workStationNumber, double walletBalance) : base(name, fatherName, gender, mobile, mailID)
        {
            
            UserID = userID;
        
            WorkStationNumber = workStationNumber;
            _balance = walletBalance;
        }
        
        public UserDetails(string user)
        {
            string [] values=user.Split(",");
            s_userID=int.Parse(values[0].Remove(0,2));
            UserID=values[0];
            Name=values[1];
            FatherName=values[2];
            Gender=Enum.Parse<Gender>(values[3]);
            Mobile=values[4];
            MailID=values[5];
            WorkStationNumber=values[6];
            _balance=double.Parse(values[7]);
        }    
        public double WalletRecharge(double amount)
        {
            _balance+=amount;
            return _balance;
        }
        public double DeductAmount(double amount)
        {
            _balance-=amount;
            return _balance;
        }
    }
}