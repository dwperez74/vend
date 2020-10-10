using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone
{
    public class VendingMachine
    {
        //    public Dictionary<string, string> Inventory { get; private set; }
        //    public decimal Balance { get; private set; }
        private List<Product> productList;

        public VendingMachine(List<Product> productList)
        {
            this.productList = productList;
        }
    }
    //public Dictionary<string, string> inv = new Dictionary<string, string>();
    //public void ReadFile()
    //{
    //    string directory = Environment.CurrentDirectory;
    //    string fileName = @"C:\Users\David Perez\Desktop\MyTE\c-module-1-capstone-team-2\19_Capstone\vendingmachine.csv";

    //    string fullPath = Path.Combine(directory, fileName);


    //    //worddictionary.add(string[], string[])
    //}


    //method to feed money
    //method for making change
    //method for purchasing snack
    //method for adding funds
}
