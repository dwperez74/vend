using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Products
    {
        public string ProductName {get; set; }
        public string SlotLocation { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public Products(string slotLocation, string product, decimal price, string category)
        {
            ProductName = product;
            Category = category;
            SlotLocation = slotLocation; 
            Quantity = 5;
            Price = price;
        }

        public string Message
        {
            get
            {
                if (Category == "Gum")
                {
                    return "Chew, Chew, Yum!";
                }
                if (Category == "Drink")
                {
                    return "Glug, Glub, Yum!";
                }
                if (Category == "Chip")
                {
                    return "Crunch, Cruch, Yum!";
                }
                else if (Category == "Candy")
                {
                    return "Munch, Munch, Yum!";
                }
                return "";
            }
        }


















        //method quantity sold
        //create new array to hold snack info
        //method to split
    }
}
