using MenuFramework;
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
            AddOption("Display Items", DisplayName);
            //AddOption("Select Item", SelectItem);
            AddOption("Purchase", Purchase);
            AddOption("Exit", Exit);
            //add call change method
            //call vending machine method
            

            Configure(cfg =>
            {
                cfg.ItemForegroundColor = ConsoleColor.Blue;
                cfg.SelectedItemForegroundColor = ConsoleColor.Yellow;
                cfg.Title = "Main Menu";
            });



        }

        

        private MenuOptionResult Purchase()
        {
            PurchaseMenu purchaseMenu = new PurchaseMenu();
            purchaseMenu.Show();
            return MenuOptionResult.DoNotWaitAfterMenuSelection;
            //What does a purchase mean?
            //accept payment
            //reduce quantity of selected item by 1
            //make change
            //tell vending machine to dispense item
            //return MenuOptionResult.WaitAfterMenuSelection;
        }

        private MenuOptionResult SelectItem()
        {

            //user selects slot locations
            //user selects quantity
            //increase balance by cost of item/s
            return MenuOptionResult.WaitAfterMenuSelection;
        }

        private MenuOptionResult DisplayName()
        {
            //Show items available and price for each item
            foreach (KeyValuePair<string, Products> kvp in vendingMachine.ItemsDictionary)
            {
                Console.WriteLine($"{kvp.Key} {kvp.Value.ProductName} {kvp.Value.Price:c}");
            }
            return MenuOptionResult.WaitAfterMenuSelection;
        }
    }
}
