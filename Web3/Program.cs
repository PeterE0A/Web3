using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web3
{
    internal class Program
    {
        public static List<Customer> customers = new List<Customer>();
        public static List<Product> products = new List<Product>();
        static void Main(string[] args)
        {
            products.Add(new Product("Product 1", "Description 1", 10.00m, 5));
            products.Add(new Product("Product 2", "Description 2", 20.00m, 10));
            products.Add(new Product("Product 3", "Description 3", 30.00m, 15));

            ShoppingCart shoppingCart = new ShoppingCart();
            Customer customer = new Customer();
            Menu menu = new Menu();
            Customer_MENU cuSTOMER = new Customer_MENU();

            Console.WriteLine("Welcome to our webshop!");
            Console.WriteLine("Please sign in or create an account:");

            cuSTOMER.LoginOrSignup();


            while (true)
            {

                menu.menu();

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        shoppingCart.AddToCart(products, shoppingCart);
                        break;
                    case "2":
                        // RemoveFromCart(products, shoppingCart);
                        break;
                    case "3":
                        shoppingCart.DisplayContents();
                        break;
                    case "4":
                        // ViewPreviousOrders(customer);
                        break;
                    case "5":
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

        }
    }
}
