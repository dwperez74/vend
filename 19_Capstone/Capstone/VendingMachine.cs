using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachine
    {
        public Dictionary<string, string> Inventory { get; private set; }
        public decimal Balance { get; private set; }
    }
    //method to feed money
    //method for making change
    //method for purchasing snack
    //method for adding funds
}
