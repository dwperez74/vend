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

        public decimal Balance { get; set; } 
        public int Quantity { get; set; }
        public Dictionary<string, Products> ItemsDictionary { get; private set; }
        public decimal TotalAmountDue
        {
            get; set;
        }
        public VendingMachine(Dictionary<string, Products> itemsDictionary)
        {
            ItemsDictionary = itemsDictionary;
        }

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
                if (Balance < selectedProduct.Price)        
                {
                    throw new Exception("Balance insufficient for selected item");
                }
                else
                {
                    Balance -= selectedProduct.Price;           
                    //TotalAmountDue += selectedProduct.Price;
                    selectedProduct.Quantity--;
                    Console.WriteLine(selectedProduct.Message);

                    //TODO: Create Audit StreamWriter for Log.txt
                }
            }
            return selectedProduct;         //TODO: This needs more, what do we want to happen/be said when the product dispenses
        
        }

        

       
        //method for making change
        
    }
}
