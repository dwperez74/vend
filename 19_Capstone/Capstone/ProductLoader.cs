using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace Capstone
{
    public class ProductLoader
    {

        public static Dictionary<string, Products> getData(string FilePath)
        {
            Dictionary<string, Products> itemDictionary = new Dictionary<string, Products>();

            //read excel file
            using (StreamReader stream = new StreamReader(FilePath))
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
                return itemDictionary;
            }

        }
    }

}

