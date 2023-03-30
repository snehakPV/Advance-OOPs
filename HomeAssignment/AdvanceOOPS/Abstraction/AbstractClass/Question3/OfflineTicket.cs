using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question3
{
    public class OfflineTicket:Ticket
    {
         private string seatNumber;
        public override string TicketType {get;}
        public override string SeatNumber {get{return seatNumber;}set{seatNumber=value;}}
        public OfflineTicket(string theaterName,double ticketPrice):base(theaterName,ticketPrice)
        {
            TicketType="Offline";
        }
        public override void BookTicket()
        {

        }
        public override void ShowTicket()
        {
            System.Console.WriteLine($"TicketID:{this.TicketID},TheaterName:{this.TheaterName},TicketPrice:{this.TicketPrice},TicketType:{this.TicketType},SeatNumber:{this.SeatNumber}");
        }
    }
}