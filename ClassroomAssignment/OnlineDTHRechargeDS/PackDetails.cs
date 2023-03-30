using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineDTHRechargeDS
{
    /// <summary>
    /// Class <see cref="PackDetails"/> To get details of the DTHPack
    /// </summary>
    public class PackDetails
    {
        /// <summary>
        ///  Property <see cref="PackID"/> To get Pack ID
        /// </summary>
        /// <value></value>
        public string PackID { get; set; }
        /// <summary>
        ///  Property <see cref="PackName"/> To get Pack Name
        /// </summary>
        /// <value></value>
        public string PackName { get; set; }
        /// <summary>
        ///  Property <see cref="Price"/> To get Pack Price
        /// </summary>
        /// <value></value>
        public double Price { get; set; }
        /// <summary>
        ///  Property <see cref="Validity"/> To get Validity of pack
        /// </summary>
        /// <value></value>
        public int Validity { get; set; }
        /// <summary>
        ///  Property <see cref="NumOfChannels"/> To get Number Of Channels in the pack
        /// </summary>
        /// <value></value>
        public int NumOfChannels { get; set; }
        /// <summary>
        /// Constructor <see cref="PackDetails"/> used to initialise the property
        /// </summary>
        /// <param name="packID">parameter packID used to initialise ID to Property PackID</param>
        /// <param name="packName">parameter packName used to initialise name to Property PackName</param>
        /// <param name="price">parameter price used to initialise price to Property Price</param>
        /// <param name="validity">parameter validity used to initialise validity to Property Validity</param>
        /// <param name="numOfChannels">parameter numOfChannels used to initialise number of channels to Property NumOfChannels</param>
        public PackDetails(string packID, string packName, double price, int validity, int numOfChannels)
        {
            PackID = packID;
            PackName = packName;
            Price = price;
            Validity = validity;
            NumOfChannels = numOfChannels;
        }
        public PackDetails(string pack)
        {
            string [] values=pack.Split(",");
            PackID=values[0];
            PackName=values[1];
            Price=double.Parse(values[2]);
            Validity=int.Parse(values[3]);
            NumOfChannels=int.Parse(values[4]);
        }




    }
}