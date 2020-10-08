using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Snacks
    {
        public string Name { get; set; }
        public string Catagory { get; set; }
        public string SlotLocation { get; set; }
        public int Quantity { get; set; } = 5;
        public decimal Price { get; set; }

        public Snacks(string name, string catagory, string slotLocation, int quantity, decimal price)
        {
            Name = name;
            Catagory = catagory;
            SlotLocation = slotLocation;
            Quantity = quantity;
            Price = price;
        }

        //method quantity sold
        //create new array to hold snack info
        //method to split
    }
}
