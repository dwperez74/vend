using MenuFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class MainMenu : ConsoleMenu
    {
        public MainMenu()
        {
            AddOption("Display Items", DisplayName);
            AddOption("Select Item", SelectItem);
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
            //What does a purchase mean?
            //accept payment
            //reduce quantity of selected item by 1
            //make change
            //tell vending machine to dispense item
            return MenuOptionResult.WaitAfterMenuSelection;
        }

        private static MenuOptionResult SelectItem()
        {
            //user selects slot locations
            //user selects quantity
            //increase balance by cost of item/s
            return MenuOptionResult.WaitAfterMenuSelection;
        }

        private static MenuOptionResult DisplayName()
        {
            //Show items available and price for each item
            //foreach (KeyValuePair<string, Product> kvp in VendingMAchine.Inventory)
            //{
            //Console.WriteLine($"{kvp.Key} {kvp.Value.Product} {kvp.Value.Price}");
            //}
            return MenuOptionResult.WaitAfterMenuSelection;
        }
    }
}
