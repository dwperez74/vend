﻿using MenuFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class PurchaseMenu : ConsoleMenu
    {
        public VendingMachine VendingMachine;
        public PurchaseMenu()
        {

        }
        public PurchaseMenu(VendingMachine vendingMachine)
        {
            AddOption("Feed Money", FeedMoney);
            AddOption("Select Product", SelectProduct);
            AddOption("Finish Transaction", FinishTransaction);
            AddOption("Back to Main", Exit);

            Configure(cfg =>
            {
                cfg.ItemForegroundColor = ConsoleColor.Blue;
                cfg.SelectedItemForegroundColor = ConsoleColor.Yellow;
                cfg.Title = "Purchase Menu";
            });
        }
        private MenuOptionResult FinishTransaction()
        {
            throw new NotImplementedException();
        }

        private MenuOptionResult SelectProduct()
        {
            throw new NotImplementedException();
        }

        private MenuOptionResult FeedMoney()
        {
            Console.WriteLine("Enter Dollar Amount");
            int deposit = int.Parse(Console.ReadLine());
            this.VendingMachine.Balance += deposit;
            Console.WriteLine($"your new balance is");
            return MenuOptionResult.WaitAfterMenuSelection;
        }
    }
}
