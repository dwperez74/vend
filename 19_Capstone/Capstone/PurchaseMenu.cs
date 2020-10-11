using MenuFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class PurchaseMenu : ConsoleMenu
    {
        private VendingMachine vendingMachine;

        public decimal Balance { get; private set; } = 0.00M;
        
        public PurchaseMenu(VendingMachine vendingMachine)
        {
            vendingMachine = vendingMachine;
            AddOption("Feed Money", FeedMoney);
            AddOption("Select Product", SelectProduct);
            AddOption("Finish Transaction", FinishTransaction);
            Console.WriteLine($"Current Money Provided: {Balance:c}");
            //AddOption("Back to Main", Exit);

            Configure(cfg =>
            {
                cfg.ItemForegroundColor = ConsoleColor.Blue;
                cfg.SelectedItemForegroundColor = ConsoleColor.Yellow;
                cfg.Title = "Purchase Menu";                            //TODO: Why doesn't this show up?
            });
        }

        protected override void OnBeforeShow()
        {
            Console.WriteLine("Purchase Menu");
            Console.WriteLine($"Current Money Provided: {Balance:c}");
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
            Console.WriteLine("Enter Dollar Amount: ");
            decimal deposit = decimal.Parse(Console.ReadLine());
            Balance += deposit;     //this.VendingMachine.      //This might need to be added back
            Console.WriteLine($"Your new balance is: {Balance:c} ");
            return MenuOptionResult.WaitAfterMenuSelection;
        }
    }
}
