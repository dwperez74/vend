using MenuFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    class MainMenu : ConsoleMenu
    {
        public MainMenu()
        {
            AddOption("Display Items", /*function name*/);
            AddOption("Select Item", /*function name*/);
            AddOption("Purchase", /*function name*/);
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

    }
}
