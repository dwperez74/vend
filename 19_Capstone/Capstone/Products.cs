using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Product
    {
        public string ProductName {get; set; }
        public string SlotLocation { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public Product(string slotLocation, string product, decimal price, string category)
        {
            ProductName = product;
            Category = category;
            SlotLocation = slotLocation; 
            Quantity = 5;
            Price = price;
        }

        //method quantity sold
        //create new array to hold snack info
        //method to split
    }
}
