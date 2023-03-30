using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    public class FoodDetails
    {
        //field
        private static int s_foodID = 100;
        //property
        public string FoodID { get; set; }
        public string FoodName { get; set; }
        public double FoodPrice { get; set; }
        public int AvailableQuantity { get; set; }
        //constructor
        public FoodDetails(string foodName, double foodPrice, int availableQuantity)
        {
            s_foodID++;
            FoodID = "FID" + s_foodID;
            FoodName = foodName;
            FoodPrice = foodPrice;
            AvailableQuantity = availableQuantity;
        }
        public FoodDetails(string food)
        {
            string [] values=food.Split(",");
            FoodID=values[0];
            s_foodID=int.Parse(values[0].Remove(0,3));
            FoodName=values[1];
            FoodPrice=double.Parse(values[2]);
            AvailableQuantity=int.Parse(values[3]);
        }    
    }
}