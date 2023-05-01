using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model.Manager
{
    internal class CustomerManager
    {
        // Constructor for creating the list of customers

        private static List<Customer> customers = new List<Customer>();

        public static void PopulateDefaultCustomers()
        {
            Customer mario = new Customer("mario", "brothers", "34");
            customers.Add(mario);
            Customer arnold = new Customer("Arnold", "Schwartz", "59839");
            customers.Add(arnold);
            Customer bat = new Customer("Bruce", "Wayne", "35235");
            customers.Add(bat);
        }

        // Add a customer to the list
        public static void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        // Remove a customer from the list
        public static void RemoveCustomer(Customer customer)
        {
            customers.Remove(customer);
        }

        public static List<Customer> GetCustomers()
        {
            return customers;
        }

        public static List<Customer> SearchCustomersByName(string name)
        {
            var query = from customer in customers
                        where customer.Name == name
                        select customer;
            return query.ToList();
        }
    }
}
