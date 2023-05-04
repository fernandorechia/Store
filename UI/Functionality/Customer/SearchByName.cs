using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.UI.Functionality.Customer
{
    internal class SearchByName
    {
        public static void Search()
        {
            Console.WriteLine("Digite o nome do cliente: ");
            string? name = Console.ReadLine();
            List<Model.Customer> result = Model.Manager.CustomerManager.SearchCustomersByName(name);
            foreach (Model.Customer customer in result)
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
