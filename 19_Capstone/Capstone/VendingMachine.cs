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
        //private Dictionary<string, Products> vendingDictionary = new Dictionary<string, Products>();
        private List<Products> productList;

        public decimal Balance { get; private set; }
        public int Quantity { get; set; }
        public Dictionary<string, Products> ItemsDictionary { get; private set; }
        public VendingMachine(Dictionary<string, Products> itemsDictionary)
        {
            ItemsDictionary = itemsDictionary;
        }

        private ProductLoader productLoader;
        //static void getData(string[] args)
        //{
        ////find excel file
        ////Console.WriteLine(Environment.CurrentDirectory);
        //string filePath = @"..\..\..\..\vendingmachine.csv";

        //    //declare dictionary
        //    //Dictionary<string, List<string>> itemDictionary = new Dictionary<string, List<string>>();
        //    Dictionary<string, List<Products>> itemDictionary = new Dictionary<string, List<Products>>();

        //    //read excel file
        //    using (StreamReader stream = new StreamReader(filePath))
        //    {
        //        while (!stream.EndOfStream)
        //        {
        //            string line = stream.ReadLine();

        //            Console.ForegroundColor = ConsoleColor.Red;
        //            Console.WriteLine(line);
        //            Console.ForegroundColor = ConsoleColor.White;
                    
        //            //csv data into array
        //            string[] array = line.Split('|');

        //            //array to dictionary<string, list>
        //            string slot = array[0];
        //            //List<string> description = new List<string>();
        //            //description.Add(array[1]);
        //            //description.Add(array[2]);
        //            //description.Add(array[3]);
        //            itemDictionary.Add(slot, ProductList);
        //        }
                
        //    }
        //}

        //public void ReadFile()
        //{
        //    string directory = Environment.CurrentDirectory;
        //    string fileName = @"C:\Users\David Perez\Desktop\MyTE\c-module-1-capstone-team-2\19_Capstone\vendingmachine.csv";

        //    string fullPath = Path.Combine(directory, fileName);


        //    //vendingDictionary.add(string[], products)
        //}


        //method to feed money
        //method for making change
        //method for purchasing snack   --**NEED TO GO SOMEWHERE ELSE
        //method for adding funds--**NEED TO GO SOMEWHERE ELSE
    }
}
