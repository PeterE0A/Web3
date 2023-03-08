using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web3
{
    internal class ShoppingCart
    {

        private List<Product> products = new List<Product>();
        private List<int> quantities = new List<int>();
        public void AddProduct(Product product, int quantity)
        {
            int index = products.IndexOf(product);

            if (index != -1)
            {
                quantities[index] += quantity;
            }
            else
            {
                products.Add(product);
                quantities.Add(quantity);
            }
        }

        public void RemoveProduct(Product product, int quantity)
        {
            int index = products.IndexOf(product);

            if (index != -1)
            {
                if (quantities[index] <= quantity)
                {
                    products.RemoveAt(index);
                    quantities.RemoveAt(index);
                }
                else
                {
                    quantities[index] -= quantity;
                }
            }
        }

        public void DisplayContents()
        {
            Console.WriteLine("Shopping Cart Contents:");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine("{0} x {1} - {2:C}", quantities[i], products[i].Name, products[i].Price);
            }
            Console.WriteLine("Total Price: {0:C}", GetTotalPrice());
        }

        public decimal GetTotalPrice()
        {
            decimal totalPrice = 0;
            for (int i = 0; i < products.Count; i++)
            {
                totalPrice += products[i].Price * quantities[i];
            }
            return totalPrice;
        }

        public void AddToCart(List<Product> products, ShoppingCart shoppingCart)
        {
            Console.WriteLine("Please enter the name of the product:");
            string productName = Console.ReadLine();

            Product product = products.Find(p => p.Name == productName);

            if (product == null)
            {
                Console.WriteLine("Product not found.");
                return;
            }

            Console.WriteLine("Please enter the quantity:");
            int quantity;

            while (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 1)
            {
                Console.WriteLine("Invalid quantity. Please try again.");
            }

            shoppingCart.AddProduct(product, quantity);
            Console.WriteLine("{0} {1}(s) added to shopping cart.", quantity, product.Name);
        }


        //public void RemoveFromCart(List<Product> products, ShoppingCart shoppingCart)
        //{
        //    Console.WriteLine("Please enter the name of the product:");
        //    string productName = Console.ReadLine();

        //    Product product = products.Find(p => p.Name == productName);

        //    if (product == null)
        //    {
        //        Console.WriteLine("Product not found.");
        //        return;
        //    }

        //    Console.WriteLine("Please enter the quantity:");
        //    int quantity;

        //    while (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 1)
        //    {
        //        Console.WriteLine("Invalid quantity. Please try again.");
        //    }

        //    if (shoppingCart.RemoveProduct(product, quantity))
        //    {
        //        Console.WriteLine("{0} {1}(s) removed from shopping cart.", quantity, product.Name);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Insufficient quantity of {0} in shopping cart.", product.Name);
        //    }
        //}

    }
}
