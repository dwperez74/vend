using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone
{
    class ProductLoader
    {
        //Properties

        public List<Products> ProductList { get; set; }

        //StreamReader to Import File

        public ProductLoader(string filePath)
        {
            ProductList = new List<Products>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string eachLine = reader.ReadLine();
                    string[] parameter = eachLine.Split("|");
                    decimal price = decimal.Parse(parameter[2]);
                    Products products = new Products(parameter[0], parameter[1], price, parameter[3]);
                    ProductList.Add(products);
                }
            }
        }

    }
}
