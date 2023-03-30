using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineDTHRechargeDS
{
    /// <summary>
    /// Class <see cref="RechargeDetails"/> To get details of the DTH Recharge
    /// </summary>
    public class RechargeDetails
    {
        /// <summary>
        /// Field <see cref="s_rechargeID"/> used to increment the recharge ID
        /// </summary>
        private static int s_rechargeID = 100;
        /// <summary>
        /// Property <see cref="RechargeID"/>used to get Recharge ID
        /// </summary>
        /// <value></value>
        public string RechargeID { get; }
        /// <summary>
        /// Property <see cref="UserID"/> To get User ID
        /// </summary>
        /// <value></value>
        public string UserID { get; set; }
        /// <summary>
        /// Property <see cref="PackID"/> To get Pack ID
        /// </summary>
        /// <value></value>
        public string PackID { get; set; }
        /// <summary>
        /// Property <see cref="RechargeDate"/> To get date of recharge
        /// </summary>
        /// <value></value>
        public DateTime RechargeDate { get; set; }
        /// <summary>
        /// Property <see cref="RechargeAmount"/> To get recharge amount
        /// </summary>
        /// <value></value>
        public double RechargeAmount { get; set; }
        /// <summary>
        /// Property <see cref="ValidTill"/> To get validity date
        /// </summary>
        /// <value></value>
        public DateTime ValidTill { get; set; }
        /// <summary>
        /// Property <see cref="NumberOfChannels"/> used to get number of channels
        /// </summary>
        /// <value></value>
        public int NumberOfChannels { get; set; }
        /// <summary>
        /// Constructor <see cref="RechargeDetails"/> To initialise the property
        /// </summary>
        /// <param name="userID">parameter userID used to initialise ID to Property UserID</param>
        /// <param name="packID">parameter packID used to initialise ID to Property PackID</param>
        /// <param name="rechargeDate">parameter rechargeDate used to initialise date to Property RechargeDate</param>
        /// <param name="rechargeAmount">parameter rechargeAmount used to initialise amount to Property RechargeAmount</param>
        /// <param name="validTill">parameter validDate used to initialise date to Property ValidDate</param>
        /// <param name="numOfChannels">parameter numOfChannels used to initialise number of channels to Property NumOfChannels</param>
        public RechargeDetails(string userID, string packID, DateTime rechargeDate, double rechargeAmount, DateTime validTill, int numOfChannels)
        {
            s_rechargeID++;
            RechargeID = "RP" + s_rechargeID;
            UserID = userID;
            PackID = packID;
            RechargeDate = rechargeDate;
            RechargeAmount = rechargeAmount;
            ValidTill = validTill;
            NumberOfChannels = numOfChannels;
        }
        public RechargeDetails(string charge)
        {
            string [] values=charge.Split(",");
            RechargeID=values[0];
            s_rechargeID=int.Parse(values[0].Remove(0,2));
            UserID=values[1];
            PackID=values[2];
            RechargeDate=DateTime.Parse(values[3]);
            RechargeAmount=double.Parse(values[4]);
            ValidTill=DateTime.Parse(values[5]);
            NumberOfChannels=int.Parse(values[6]);
        }








    }
}