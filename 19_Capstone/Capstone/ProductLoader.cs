﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone
{
    class ProductLoader
    {
        //Properties

        public List<Product> ProductList { get; set; }

        //StreamReader to Import File

        public ProductLoader(string filePath)
        {
            ProductList = new List<Product>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string eachLine = reader.ReadLine();
                    string[] parameter = eachLine.Split("|");
                    decimal price = decimal.Parse(parameter[2]);
                    Product snacks = new Product(parameter[0], parameter[1], price, parameter[3]);
                    ProductList.Add(snacks);
                }
            }
        }

    }
}
