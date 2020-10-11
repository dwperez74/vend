using MenuFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Checkout : ConsoleMenu
    {
        public VendingMachine VendingMachine;

        public decimal TotalDue { get; set; }       //set?
    }
}
