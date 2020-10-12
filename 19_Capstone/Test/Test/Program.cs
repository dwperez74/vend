using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //using systems.collections.generic?????
            //find excel file
            Console.WriteLine(Environment.CurrentDirectory);
            string filePath = @"..\..\..\..\..\vendingmachine.csv";
            //Console.WriteLine(File.Exists(filePath));



            //read excel file
            Dictionary<string, string> allItems = new Dictionary<string, string>();
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


                    //store data in dictionary
                    foreach (var items in array)
                    {
                        Console.WriteLine(items);
                    }
                }
            }


            Console.WriteLine("Hello World!");
        }
    }
}
