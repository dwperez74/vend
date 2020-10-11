using MenuFramework;

namespace Capstone
{
    public class SubMenu : ConsoleMenu
    {
        private VendingMachine vendingMachine;

        public SubMenu(VendingMachine vendingMachine)
        {
            vendingMachine = vendingMachine; 
        }
    }
}