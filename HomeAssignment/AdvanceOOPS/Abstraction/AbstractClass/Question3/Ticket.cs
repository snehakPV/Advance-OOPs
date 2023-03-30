using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question3
{
    public abstract class Ticket
    {
        private static int ticketID=100;
        public string TicketID {get;}
        protected string TheaterName;
        protected double TicketPrice;
        public abstract string TicketType {get;}
        public abstract string SeatNumber {get;set;}
        public Ticket(string theaterName,double ticketPrice)
        {
            TicketID="TID"+ticketID;
            TheaterName=theaterName;
            TicketPrice=ticketPrice;
        }
        public abstract void BookTicket();
        public abstract void ShowTicket();
    }
}