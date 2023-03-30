using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public class TicketFairDetails
    {
        /// <summary>
        /// <see cref="s_ticketID"/> is a field used to store Ticket ID
        /// </summary>
        private static int s_ticketID = 100;
        /// <summary>
        /// <see cref="TicketID"/> is a property used to get value from field <see cref="s_ticketID"/>
        /// </summary>
        /// <value></value>
        public string TicketID { get; }
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
        /// <see cref="TicketPrice"/> is a property used to get price of ticket
        /// </summary>
        /// <value></value>
        public double TicketPrice { get; set; }
        /// <summary>
        /// <see cref="TicketFairDetails"/> constructor used to assign value to property
        /// </summary>
        /// <param name="fromLocation">parameter fromLocation is used to assign value to Property <see cref="FromLocation"/></param>
        /// <param name="toLocation">parameter toLocation is used to assign value to Property <see cref="ToLocation"/></param>
        /// <param name="ticketPrice">parameter ticketPrice is used to assign value to Property <see cref="TicketPrice"/></param>
        public TicketFairDetails(string fromLocation, string toLocation, double ticketPrice)
        {
            s_ticketID++;
            TicketID = "MR" + s_ticketID;
            FromLocation = fromLocation;
            ToLocation = toLocation;
            TicketPrice = ticketPrice;
        }
        /// <summary>
        /// <see cref="TicketFairDetails"/>constructor used to assign array to properties
        /// </summary>
        /// <param name="ticket"></param>
        public TicketFairDetails(string ticket)
        {
            string[] values = ticket.Split(",");
            TicketID = values[0];
            s_ticketID = int.Parse(values[0].Remove(0, 2));
            FromLocation = values[1];
            ToLocation = values[2];
            TicketPrice = double.Parse(values[3]);
        }
    }
}