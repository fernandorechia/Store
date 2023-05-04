using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Model;

namespace Store.UI.Functionality.Customer
{
    internal class List
    {
        public static void ListCustomers()
        {
            List<Model.Customer> customers = Model.Manager.CustomerManager.GetCustomers();
            foreach (Model.Customer customer in customers)
            {
                Console.WriteLine($"ID: {customer.CustomerId}");
                Console.WriteLine($"Nome: {customer.Name}");
                Console.WriteLine($"Sobrenome: {customer.Surname}");
                Console.WriteLine($"Telefone: {customer.Phone}");
            }
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            CustomerSubMenu.CustomerMenu();
        }
    }
}
