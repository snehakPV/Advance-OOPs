using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public class UserDetails
    {
        /// <summary>
        /// <see cref="s_cardNumber"/> is a field to store Card number
        /// </summary>
        private static int s_cardNumber = 100;
        /// <summary>
        /// <see cref="CardNumber"/> is a property to get value from field <see cref="s_cardNumber"/>
        /// </summary>
        /// <value></value>
        public string CardNumber { get; }
        /// <summary>
        /// <see cref="UserName"/> is a property to get User Name
        /// </summary>
        /// <value></value>
        public string UserName { get; set; }
        /// <summary>
        /// <see cref="PhoneNumber"/> is a property to get Phone number
        /// </summary>
        /// <value></value>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// <see cref="_balance"/> is a field to store Balance
        /// </summary>
        private double _balance;
        /// <summary>
        /// <see cref="Balance"/> is a property to get Balance from field <see cref="_balance"/>
        /// </summary>
        /// <value></value>
        public double Balance { get { return _balance; } }
        /// <summary>
        /// <see cref="UserDetails"/> is a contructor used to assign value to properties
        /// </summary>
        /// <param name="userName">parameter userName is used to assign values to Property <see cref="UserName"/></param>
        /// <param name="phoneNumber">parameter phoneNumber is used to assign values to Property <see cref="PhoneNumber"/></param>
        /// <param name="balance">parameter balance is used to assign values to field <see cref="_balance"/></param>
        public UserDetails(string userName, string phoneNumber, double balance)
        {
            s_cardNumber++;
            CardNumber = "CMRL" + s_cardNumber;
            UserName = userName;
            PhoneNumber = phoneNumber;
            _balance = balance;
        }
        /// <summary>
        /// <see cref="UserDetails"/> is a constructor which is used to assign array to the property
        /// </summary>
        /// <param name="user"></param>
        public UserDetails(string user)
        {
            string[] values = user.Split(",");
            CardNumber = values[0];
            s_cardNumber = int.Parse(values[0].Remove(0, 4));
            UserName = values[1];
            PhoneNumber = values[2];
            _balance = double.Parse(values[3]);
        }
        /// <summary>
        /// <see cref="RechargeBalance"/> is a method used to add amount to the user balance
        /// </summary>
        /// <param name="amount">Parameter used to get amount</param>
        /// <returns></returns>
        public double RechargeBalance(double amount)
        {
            _balance += amount;
            return _balance;
        }
        /// <summary>
        /// <see cref="DeductAmount"/> is a method used to deduct amount from user balance
        /// </summary>
        /// <param name="amount">Parameter used to get amount</param>
        /// <returns></returns>
        public double DeductAmount(double amount)
        {
            _balance -= amount;
            return _balance;
        }

    }
}