using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    //Created partial class to split the application in several files
    public partial class Operations
    {
        //creating BalanceCheck method to check the current user balance
        public static void BalanceCheck()
        {
            System.Console.WriteLine("Your Balance: " + currentUser.Balance);
        }
        //creating Recharge method to get amount from current user and to add it with balance
        public static void Recharge()
        {
            System.Console.WriteLine("Enter the amount to be recharged.");
            double amount = double.Parse(Console.ReadLine());
            //calling RechargeBalance method to recharge the amount and storing it to balance
            double Balance = currentUser.RechargeBalance(amount);
            System.Console.WriteLine("Balance: " + Balance);
        }
        //creating TravelHistory method to show the travel history of user
        public static void TravelHistory()
        {
            foreach (TravelDetails travel in travelList)
            {
                System.Console.WriteLine($"{travel.TravelID}|{travel.CardNumber}|{travel.FromLocation}|{travel.ToLocation}|{travel.Date}|{travel.TravelCost}");
            }
        }
        //Travel method is used to create Travel ID
        public static void Travel()
        {
            //Traversing ticketFairList to show the ticket fair for each location
            foreach (TicketFairDetails ticketFair in ticketFairList)
            {
                System.Console.WriteLine($"{ticketFair.TicketID}|{ticketFair.FromLocation}|{ticketFair.ToLocation}|{ticketFair.TicketPrice}");
            }
            //Getting TicketID from user
            System.Console.WriteLine("Enter your Ticket ID:");
            string ticketID = Console.ReadLine();
            //boolean flag for checking condition - whether ticket ID valid or not
            bool flag = true;
            foreach (TicketFairDetails ticketFair in ticketFairList)
            {
                //Comparing ticket ID given by user with ticket ID in ticketFairList 
                if (ticketID == ticketFair.TicketID)
                {
                    flag = false;
                    //checking whether the user has enough balance
                    if (currentUser.Balance >= ticketFair.TicketPrice)
                    {
                        //Entering into condition if user has enough balance and deducting amount 
                        currentUser.DeductAmount(ticketFair.TicketPrice);
                        //storing travel details in travelDetails object
                        TravelDetails travelDetails = new TravelDetails(currentUser.CardNumber, ticketFair.FromLocation, ticketFair.ToLocation, DateTime.Now, ticketFair.TicketPrice);
                        //storing the object inside travelList                       
                        travelList.Add(travelDetails);
                        System.Console.WriteLine("Ticket Booked!\nYour Travel ID: " + travelDetails.TravelID);
                    }
                    else
                    {
                        //if condition not satisfied, display - Insufficient balance
                        System.Console.WriteLine("Insufficient Balance!");
                    }
                }
            }
            //if flag=true then display - Invalid TicketID
            if (flag)
            {
                System.Console.WriteLine("Invalid TicketID!");
            }
        }
    }
}