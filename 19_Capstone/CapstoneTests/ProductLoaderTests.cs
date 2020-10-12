using System;
using System.Collections.Generic;
using System.Text;
using Capstone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace CapstoneTests
{
    [TestClass]
    public class ProductLoaderTests
    {
        [TestMethod]
        public void GetDataTest()
        {
            //Arrange create dictionary with csv data manually
            Products productA1 = new Products("A1", "Potato Crisps", decimal.Parse("3.05"), "Chip");
            Products productA2 = new Products("A2", "Stackers", decimal.Parse("1.45"), "Chip");
            Products productA3 = new Products("A3", "Grain Waves", decimal.Parse("2.75"), "Chip");
            Products productA4 = new Products("A4", "Cloud Popcorn", decimal.Parse("3.65"), "Chip");
            Products productB1 = new Products("B1", "Moonpie", decimal.Parse("1.80"), "Candy");
            Products productB2 = new Products("B2", "Cowtales", decimal.Parse("1.50"), "Candy");
            Products productB3 = new Products("B3", "Wonka Bar", decimal.Parse("1.50"), "Candy");
            Products productB4 = new Products("B4", "Crunchie", decimal.Parse("1.75"), "Candy");
            Products productC1 = new Products("C1", "Cola", decimal.Parse("1.25"), "Drink");
            Products productC2 = new Products("C2", "Dr. Salt", decimal.Parse("1.50"), "Drink");
            Products productC3 = new Products("C3", "Mountain Melter", decimal.Parse("1.50"), "Drink");
            Products productC4 = new Products("C4", "Heavy", decimal.Parse("1.50"), "Drink");
            Products productD1 = new Products("D1", "U-Chews", decimal.Parse("0.85"), "Gum");
            Products productD2 = new Products("D2", "Little League Chew", decimal.Parse("0.95"), "Gum");
            Products productD3 = new Products("D3", "Chiclets", decimal.Parse("0.75"), "Gum");
            Products productD4 = new Products("D4", "Triplemint", decimal.Parse("0.75"), "Gum");

            Dictionary<string, Products> testDictionary = new Dictionary<string, Products>();

            testDictionary.Add("A1", productA1);
            testDictionary.Add("A2", productA2);
            testDictionary.Add("A3", productA3);
            testDictionary.Add("A4", productA4);
            testDictionary.Add("B1", productB1);
            testDictionary.Add("B2", productB2);
            testDictionary.Add("B3", productB3);
            testDictionary.Add("B4", productB4);
            testDictionary.Add("C1", productC1);
            testDictionary.Add("C2", productC2);
            testDictionary.Add("C3", productC3);
            testDictionary.Add("C4", productC4);
            testDictionary.Add("D1", productD1);
            testDictionary.Add("D2", productD2);
            testDictionary.Add("D3", productD3);
            testDictionary.Add("D4", productD4);

            //Act initialize dictionary from method GetData
            Dictionary<string, Products> itemDictionary = new Dictionary<string, Products>();

            //read excel file
            using (StreamReader stream = new StreamReader(@"..\..\..\..\vendingmachine.csv"))
            {
                while (!stream.EndOfStream)
                {
                    string line = stream.ReadLine();

                    //csv data into array
                    string[] array = line.Split('|');
                    decimal price = decimal.Parse(array[2]);

                    Products product = new Products(array[0], array[1], price, array[3]);
                    itemDictionary.Add(array[0], product);
                }
                return;

            }
            //Assert use areequal to verify manual dictionary and method dictionary are the same
            Assert.AreEqual(itemDictionary, testDictionary);
        }
    }
}
