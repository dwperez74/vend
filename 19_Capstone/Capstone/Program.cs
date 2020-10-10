using MenuFramework;
using System;
using System.IO;
using System.Collections.Generic;

namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Products> itemsDictionary = ProductLoader.getData(@"..\..\..\..\vendingmachine.csv");
            VendingMachine vendingMachine = new VendingMachine(itemsDictionary);
            MainMenu mainMenu = new MainMenu(vendingMachine);
            mainMenu.Show();

        }
        


    }

}
