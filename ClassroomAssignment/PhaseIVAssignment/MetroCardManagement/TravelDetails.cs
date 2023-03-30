using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public class TravelDetails
    {
        /// <summary>
        /// <see cref="s_travelID"/> is a field used to store Travel ID
        /// </summary>
        private static int s_travelID = 100;
        /// <summary>
        /// <see cref="TravelID"/> is a property to get value from field <see cref="s_travelID"/>
        /// </summary>
        /// <value></value>
        public string TravelID { get; }
        /// <summary>
        /// <see cref="CardNumber"/> is a property used to get Card number
        /// </summary>
        /// <value></value>
        public string CardNumber { get; set; }
        /// <summary>
        /// <see cref="FromLocation"/> is a property used to get start location
        /// </summary>
        /// <value></value>
        public string FromLocation { get; set; }
        /// <summary>
        /// <see cref="ToLocation"/> is a property used to get destination
        /// </summary>
        /// <value></value>
        public string ToLocation { get; set; }
        /// <summary>
        /// <see cref="Date"> is a property used to get Date
        /// </summary>
        /// <value></value>
        public DateTime Date { get; set; }
        /// <summary>
        /// <see cref="TravelCost"> is a property used to get travel cost
        /// </summary>
        /// <value></value>
        public double TravelCost { get; set; }
        /// <summary>
        /// <see cref="TravelDetails"/> constructor used to assign values to properties
        /// </summary>
        /// <param name="cardNumber">cardNumber is a parameter used to assign value to Property <see cref="CardNumber"/></param>
        /// <param name="fromLocation">fromLocation is a parameter used to assign value to Property <see cref="FromLocation"/></param>
        /// <param name="toLocation">toLocation is a parameter used to assign value to Property <see cref="ToLocation"/></param>
        /// <param name="date">date is a parameter used to assign value to Property <see cref="Date"/></param>
        /// <param name="travelCost">travelCost is a parameter used to assign value to Property <see cref="TravelCost"/></param>
        public TravelDetails(string cardNumber, string fromLocation, string toLocation, DateTime date, double travelCost)
        {
            s_travelID++;
            TravelID = "TID" + s_travelID;
            CardNumber = cardNumber;
            FromLocation = fromLocation;
            ToLocation = toLocation;
            Date = date;
            TravelCost = travelCost;
        }
        /// <summary>
        /// <see cref="TravelDetails"/> constructor used to assign value array to the property
        /// </summary>
        /// <param name="travel"></param>
        public TravelDetails(string travel)
        {
            string [] values=travel.Split(",");
            TravelID=values[0];
            s_travelID=int.Parse(values[0].Remove(0,3));
            CardNumber=values[1];
            FromLocation=values[2];
            ToLocation=values[3];
            Date=DateTime.Parse(values[4]);
            TravelCost=double.Parse(values[5]);
        }
    }
}