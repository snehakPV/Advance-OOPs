using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public partial class Operations
    {
      //Creating List to store Data
        public static List<UserDetails> userList=new List<UserDetails>();
        public static List<TravelDetails> travelList=new List<TravelDetails>();
        public static List<TicketFairDetails> ticketFairList=new List<TicketFairDetails>();
       //Creating object and storing default data inside List
       public static void UserDefault()
       {
         UserDetails userDetails1=new UserDetails("Ravi","98488",1000);
         UserDetails userDetails2=new UserDetails("Baskaran","99488",1000);
         userList.Add(userDetails1);
         userList.Add(userDetails2);
       }
       public static void TravelDefault()
       {
        TravelDetails travelDetails1=new TravelDetails("CMRL101","Airport","Egmore",new DateTime(2022,10,10),55);
        TravelDetails travelDetails2=new TravelDetails("CMRL101","Egmore","Koyambedu",new DateTime(2022,10,10),32);
        TravelDetails travelDetails3=new TravelDetails("CMRL102","Alandur","Koyambedu",new DateTime(2022,11,10),25);
        TravelDetails travelDetails4=new TravelDetails("CMRL102","Egmore","Thirumangalam",new DateTime(2022,11,10),25);
        travelList.Add(travelDetails1);
        travelList.Add(travelDetails2);
        travelList.Add(travelDetails3);
        travelList.Add(travelDetails4);
       }
       public static void TicketFairDefault()
       {
        TicketFairDetails ticketFairDetails1=new TicketFairDetails("Airport","Egmore",55);
        TicketFairDetails ticketFairDetails2=new TicketFairDetails("Airport","Koyambedu",25);
        TicketFairDetails ticketFairDetails3=new TicketFairDetails("Alandur","Koyambedu",25);
        TicketFairDetails ticketFairDetails4=new TicketFairDetails("Koyambedu","Egmore",32);
        TicketFairDetails ticketFairDetails5=new TicketFairDetails("Vadapalani","Egmore",45);
        TicketFairDetails ticketFairDetails6=new TicketFairDetails("Arumbakkam","Egmore",25);
        TicketFairDetails ticketFairDetails7=new TicketFairDetails("Vadapalani","Koyambedu",25);
        TicketFairDetails ticketFairDetails8=new TicketFairDetails("Arumbakkam","Koyambedu",16);
        ticketFairList.Add(ticketFairDetails1);
        ticketFairList.Add(ticketFairDetails2);
        ticketFairList.Add(ticketFairDetails3);
        ticketFairList.Add(ticketFairDetails4);
        ticketFairList.Add(ticketFairDetails5);
        ticketFairList.Add(ticketFairDetails6);
        ticketFairList.Add(ticketFairDetails7);
        ticketFairList.Add(ticketFairDetails8);
       }

    }
}