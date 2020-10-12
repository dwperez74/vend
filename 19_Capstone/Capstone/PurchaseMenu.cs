using MenuFramework;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Capstone
{
    public class PurchaseMenu : ConsoleMenu
    {
        private VendingMachine vendingMachine;

        //private Dictionary<string, Products> itemsDictionary;
        //VendingMachine vendingMachine = new VendingMachine(itemsDictionary);

        //public decimal Balance { get; private set; }
        
        public PurchaseMenu(VendingMachine vendingMachine)
        {
            this.vendingMachine = vendingMachine;
            AddOption("Feed Money", FeedMoney);
            AddOption("Select Product", SelectProduct);
            AddOption("Finish Transaction", FinishTransaction);
            Console.WriteLine($"Current Money Provided: {Balance:c}");
            AddOption("Back to Main", Exit);

            Configure(cfg =>
            {
                cfg.ItemForegroundColor = ConsoleColor.Blue;
                cfg.SelectedItemForegroundColor = ConsoleColor.Yellow;
                cfg.Title = "Purchase Menu";                            //TODO: Why doesn't this show up?
            });
        }

        protected override void OnBeforeShow()
        {
            Console.WriteLine("\tPurchase Menu");
            Console.WriteLine($"Current Money Provided: {this.vendingMachine.Balance:c}");
        }
        private MenuOptionResult FinishTransaction()    //TODO: Balance keeps getting reset and thus is giving improper change. Also, we need to add an exit option once the change has been "given"
        {
            decimal startingBalance = this.vendingMachine.Balance;
            int quarters = (int)(vendingMachine.Balance / .25M);
            vendingMachine.Balance -= (quarters * .25M);
            int dimes = (int)(vendingMachine.Balance / .10M);
            vendingMachine.Balance -= (dimes * .10M);
            int nickels = (int)(vendingMachine.Balance / .05M);
            vendingMachine.Balance -= (nickels * .05M);
            vendingMachine.WriteLog("GIVE CHANGE:", startingBalance);
            Console.WriteLine($"Your change is {quarters} quarters, {dimes} dimes, {nickels} nickels, and the balance is now: {vendingMachine.Balance:c}.");
            return MenuOptionResult.CloseMenuAfterSelection;
            
        }

        private MenuOptionResult SelectProduct()
        {
            decimal startingBalance = this.vendingMachine.Balance;
            this.vendingMachine = vendingMachine;
            //VendingMachine vendingMachine = new VendingMachine(itemsDictionary);
            //Show list of items for user to choose from
            foreach (KeyValuePair<string, Products> kvp in vendingMachine.ItemsDictionary)
            {
                Console.WriteLine($"{kvp.Key}\t {kvp.Value.ProductName}\t {kvp.Value.Price:c}\t Quantity Remaining: {kvp.Value.Quantity}");
            }
            //Prompt user to enter 2-digit code/Slot Location
            Console.WriteLine("Please enter the two-digit code of the product you would like to purchase and press \"Enter\". ");

            string userSelection = Console.ReadLine();

            try
            {
                Products selectedProduct = vendingMachine.DispenseProduct(userSelection);
                Console.WriteLine($"You have purchased {selectedProduct.ProductName} for {selectedProduct.Price:c} and have a remaining balance of {this.vendingMachine.Balance:c}.");
                vendingMachine.WriteLog($"{selectedProduct.ProductName} {selectedProduct.SlotLocation}", startingBalance);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return MenuOptionResult.WaitAfterMenuSelection;
        }

        private MenuOptionResult FeedMoney()
        {
            decimal startingBalance = this.vendingMachine.Balance;
            Console.WriteLine("Enter Dollar Amount: ");
            decimal deposit = decimal.Parse(Console.ReadLine());
            this.vendingMachine.Balance += deposit;     //this.VendingMachine.      //This might need to be added back
            vendingMachine.WriteLog("FEED MONEY: ", startingBalance);
            Console.WriteLine($"Your new balance is: {this.vendingMachine.Balance:c} ");
            return MenuOptionResult.WaitAfterMenuSelection;
        }
    }
}
