using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public class FileHandling
    {
        public static void Create()
        {
            if (!Directory.Exists("MetroCardManagement"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("MetroCardManagement");
            }
            if (!File.Exists("MetroCardManagement/UserDetails.csv"))
            {
                System.Console.WriteLine("Creating File UserDetails");
                File.Create("MetroCardManagement/UserDetails.csv").Close();
            }
            if (!File.Exists("MetroCardManagement/TravelDetails.csv"))
            {
                System.Console.WriteLine("Creating File TravelDetails");
                File.Create("MetroCardManagement/TravelDetails.csv").Close();
            }
            if (!File.Exists("MetroCardManagement/TicketFairDetails.csv"))
            {
                System.Console.WriteLine("Creating File TicketFairDetails");
                File.Create("MetroCardManagement/TicketFairDetails.csv").Close();
            }
        }
        public static void WriteToCSV()
        {
            string[] users = new string[Operations.userList.Count];
            for (int i = 0; i < Operations.userList.Count; i++)
            {
                var user = Operations.userList[i];
                users[i] = user.CardNumber + "," + user.UserName + "," + user.PhoneNumber + "," + user.Balance;
            }
            File.WriteAllLines("MetroCardManagement/UserDetails.csv", users);

            string[] travels = new string[Operations.travelList.Count];
            for (int i = 0; i < Operations.travelList.Count; i++)
            {
                var travel = Operations.travelList[i];
                travels[i] = travel.TravelID + "," + travel.CardNumber + "," + travel.FromLocation + "," + travel.ToLocation + "," + travel.Date + "," + travel.TravelCost;
            }
            File.WriteAllLines("MetroCardManagement/TravelDetails.csv", travels);

            string[] tickets = new string[Operations.ticketFairList.Count];
            for (int i = 0; i < Operations.ticketFairList.Count; i++)
            {
                var ticket = Operations.ticketFairList[i];
                tickets[i] = ticket.TicketID + "," + ticket.FromLocation + "," + ticket.ToLocation + "," + ticket.TicketPrice;
            }
            File.WriteAllLines("MetroCardManagement/TicketFairDetails.csv", tickets);
        }
        public static void ReadFromCSV()
        {
            string[] users = File.ReadAllLines("MetroCardManagement/UserDetails.csv");
            for (int i = 0; i < users.Length; i++)
            {
                Operations.userList.Add(new UserDetails(users[i]));
            }

            string[] travels = File.ReadAllLines("MetroCardManagement/TravelDetails.csv");
            for (int i = 0; i < travels.Length; i++)
            {
                Operations.travelList.Add(new TravelDetails(travels[i]));
            }

            string[] tickets = File.ReadAllLines("MetroCardManagement/TicketFairDetails.csv");
            for (int i = 0; i < tickets.Length; i++)
            {
                Operations.ticketFairList.Add(new TicketFairDetails(tickets[i]));
            }
        }
    }
}