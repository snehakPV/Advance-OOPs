using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineDTHRechargeDS
{
    /// <summary>
    /// Class <see cref="UserDetails"/> used to get details from user
    /// </summary>
    public class UserDetails
    {
        /// <summary>
        /// Field <see cref="s_userID"/> used to increment the user ID
        /// </summary>
        private static int s_userID = 1000;
        /// <summary>
        /// Property <see cref="UserID"/> To get User ID
        /// </summary>
        /// <value></value>
        public string UserID { get; }
        /// <summary>
        /// Property <see cref="UserName"/> To get name of user
        /// </summary>
        /// <value></value>
        public string UserName { get; set; }
        /// <summary>
        /// Property <see cref="MobileNumber"/> To get mobile number from user
        /// </summary>
        /// <value></value>
        public string MobileNumber { get; set; }
        /// <summary>
        /// Property <see cref="EmailID"/> To get email ID from user
        /// </summary>
        /// <value></value>
        public string EmailID { get; set; }
        /// <summary>
        /// Field <see cref="s_balance"/> To get balance
        /// </summary>
        private static double s_balance;
        /// <summary>
        /// Property <see cref="WalletBalance"/> To store User balance
        /// </summary>
        /// <value></value>
        public double WalletBalance { get { return s_balance; } }
        /// <summary>
        /// Constructor <see cref="UserDetails"/> To initialise the property
        /// </summary>
        /// <param name="userName">parameter userName used to initialise name to Property UserName</param>
        /// <param name="mobileNumber">parameter mobileNumber used to initialise number to Property MobileNumber</param>
        /// <param name="emailID">parameter emailID used to initialise mail ID to Property EmailID</param>
        /// <param name="walletBalance">parameter walletBalance used to initialise balance to Property WalletBalance</param>
        public UserDetails(string userName, string mobileNumber, string emailID, double walletBalance)
        {
            s_userID++;
            UserID = "UID" + s_userID;
            UserName = userName;
            MobileNumber = mobileNumber;
            EmailID = emailID;
            s_balance = walletBalance;
        }
        public UserDetails(string user)
        {
            string[] values = user.Split(",");
            UserID = values[0];
            s_userID = int.Parse(values[0].Remove(0, 3));
            UserName = values[1];
            MobileNumber = values[2];
            EmailID = values[3];
            s_balance = double.Parse(values[4]);
        }
        /// <summary>
        /// Method <see cref="Balance"/> calculate the amount to add in the user wallet
        /// </summary>
        /// <param name="amount">Parameter amount used to get amount to add with balance</param>
        /// <returns></returns>
        public double Balance(double amount)
        {
            s_balance += amount;
            return s_balance;
        }
        /// <summary>
        /// Method <see cref="DeductBalance"/>deduct the amount from user wallet
        /// </summary>
        /// <param name="amount">Parameter amount used to deduct amount from wallet</param>
        /// <returns></returns>
        public double DeductBalance(double amount)
        {
            s_balance -= amount;
            return s_balance;
        }
    }
}