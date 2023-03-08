using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web3
{
    internal class Order
    {
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
        public List<int> Quantities { get; set; }
        public decimal TotalPrice { get; set; }

        public Order(Customer customer, List<Product> products, List<int> quantities, decimal totalPrice)
        {
            Customer = customer;
            Products = products;
            Quantities = quantities;
            TotalPrice = totalPrice;
        }
    }
}
