using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using MenuFramework;

namespace Capstone
{
    public class VendingMachine
    {
        
        //private List<Products> productList;

        public decimal Balance { get; set; } = 0;
        public int Quantity { get; set; }
        public Dictionary<string, Products> ItemsDictionary { get; private set; }
        public decimal TotalAmountDue
        {
            get; set;
            //get
            //{
            //    return Quantity * Products.Price;           //Why cant I reference the products class?
            //}
        }
        public VendingMachine(Dictionary<string, Products> itemsDictionary)
        {
            ItemsDictionary = itemsDictionary;
        }


        //public decimal ReturnChange()
        //{
        //    if (Balance == TotalAmount)
        //    {
        //        return Console.WriteLine("Have a good day!");           //WHAT IS THE ISSUE HERE?
        //    }
        //    else (Balance > TotalAmount)
        //    {
        //        return Console.WriteLine($"Your change is: {Balance - TotalAmount}");
        //    }

        //}

        public Products DispenseProduct(string slotLocation)
        {
            if (!ItemsDictionary.ContainsKey(slotLocation))
            {
                throw new Exception("This item does not exist");
            }

            Products selectedProduct = ItemsDictionary[slotLocation];

            if (selectedProduct.Quantity == 0)
            {
                throw new Exception("Item is out of stock");
            }
            else
            {
                if (Balance < selectedProduct.Price)        //WHY DOES PRICE WORK HERE BUT NOT ABOVE FOR TOTAL AMOUNT?!
                {
                    throw new Exception("Balance insufficient for selected item");
                }
                else
                {
                    Balance -= selectedProduct.Price;           //WORKED AGAIN HERE?!
                    //TotalAmountDue += selectedProduct.Price;
                    selectedProduct.Quantity--;
                    Console.WriteLine(selectedProduct.Message);
                }
            }
            return selectedProduct;         //TODO: This needs more, what do we want to happen/be said when the product dispenses
        
        }

        

        //method to feed money
        //method for making change
        
    }
}
