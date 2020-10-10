using MenuFramework;
using System;
using System.IO;

namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Student\GIT\c-module-1-capstone-team-2\19_Capstone\vendingmachine.csv";
            ProductLoader productLoader = new ProductLoader(filePath);
            VendingMachine vendingMachine = new VendingMachine(productLoader.ProductList);
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();

        }
        


    }

}
