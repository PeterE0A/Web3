using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web3
{
    internal class Menu
    {
        public void menu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add product to shopping cart");
            Console.WriteLine("2. Remove product from shopping cart");
            Console.WriteLine("3. Display shopping cart contents");
            Console.WriteLine("4. View previous orders");
            Console.WriteLine("5. Sign out");
        }
    }
}
