﻿using MenuFramework;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Capstone
{
    public class MainMenu : ConsoleMenu
    {
        private VendingMachine vendingMachine;
        public MainMenu(VendingMachine vendingMachine)
        {
            this.vendingMachine = vendingMachine;
            AddOption("(1) Display Vending Machine Items", DisplayName);
            AddOption("(2) Purchase", PurchaseMenu);
            AddOption("(3) Exit", Exit);                
            //add call change method
            //call vending machine method
            

            Configure(cfg =>
            {
                cfg.ItemForegroundColor = ConsoleColor.Blue;
                cfg.SelectedItemForegroundColor = ConsoleColor.Yellow;
                cfg.Title = "Main Menu";
            });
        }

        private MenuOptionResult PurchaseMenu()
        {
            PurchaseMenu purchaseMenu = new PurchaseMenu(vendingMachine);
            purchaseMenu.Show();
            return MenuOptionResult.WaitAfterMenuSelection;
        }

        private MenuOptionResult DisplayName()
        {
            //Show items available and price for each item
            foreach (KeyValuePair<string, Products> kvp in vendingMachine.ItemsDictionary)
            {
                Console.WriteLine($"{kvp.Key}\t {kvp.Value.ProductName}\t {kvp.Value.Price:c}\t Quantity Remaining: {kvp.Value.Quantity, 10}");
            }
            return MenuOptionResult.WaitAfterMenuSelection;
        }
    }
}
