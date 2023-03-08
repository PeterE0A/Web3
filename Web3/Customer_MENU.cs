using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web3
{
    internal class Customer_MENU
    {
        public List<Customer> customer { get; set; }

        public void LoginOrSignup()
        {
            Console.WriteLine("Do you have an account? (y/n)");
            string choice = Console.ReadLine();

            if (choice.ToLower() == "y")
            {
                Console.WriteLine("Please enter your email address:");
                string emailAddress = Console.ReadLine();
                Console.WriteLine("Please enter your password:");
                string password = Console.ReadLine();


                Customer customer = Program.customers.Find(c => c.EmailAddress == emailAddress && c.Password == password);

                if (customer != null && customer.Password == password)
                {
                    Console.WriteLine("Welcome {0} {1}!", customer.FirstName, customer.LastName);
                }
                else
                {
                    Console.WriteLine("Account cannot be Found");
                    Console.ReadLine();
                    Console.Clear();
                    SignUP();

                }

            }
            else
            {


                SignUP();

            }

        }

        public void SignUP()
        {
            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please enter your email address:");
            string emailAddress = Console.ReadLine();
            Console.WriteLine("Please enter your password:");
            string password = Console.ReadLine();
            Console.WriteLine("Please enter your street address:");
            string streetAddress = Console.ReadLine();
            Console.WriteLine("Please enter your city:");
            string city = Console.ReadLine();
            Console.WriteLine("Please enter your state/province:");
            string state = Console.ReadLine();
            Console.WriteLine("Please enter your postal code:");
            string postalCode = Console.ReadLine();
            Console.WriteLine("Please enter your country:");
            string country = Console.ReadLine();

            //Address


            //CreateCustomer(firstName, lastName, emailAddress, password);
            //Customer c = Program.customers.Add(firstName, lastName, emailAddress, password);
            Console.WriteLine("Account created successfully.");


            Console.ReadLine();

        }

        //public void CreateCustomer(string name, string lastname, string email, string password)
        //{

        //    customer.Add(new Customer(name, lastname, email, password));

        //}
    }
}
