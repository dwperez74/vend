using System;
using System.Collections.Generic;
using System.IO;
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
        public VendingMachine(List<Products> productList)
        {
            this.productList = productList;
        }
        static void getData(string[] args)
        {
            //find excel file
            Console.WriteLine(Environment.CurrentDirectory);
            string filePath = @"..\..\vendingmachine.csv";
            //declare dictionary
            Dictionary<string, List<string>> itemDictionary = new Dictionary<string, List<string>>();
            //read excel file
            using (StreamReader stream = new StreamReader(filePath))
            {
                while (!stream.EndOfStream)
                {
                    string line = stream.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(line);
                    Console.ForegroundColor = ConsoleColor.White;

                    //csv data into array
                    string[] array = line.Split('|');

                    //array to dictionary<string, list>
                    string name = array[0];
                    List<string> description = new List<string>();
                    description.Add(array[1]);
                    description.Add(array[2]);
                    description.Add(array[3]);
                    itemDictionary.Add(name, description);
                }
                
            }
        }

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
