using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Model;

namespace Store.UI.Functionality.Customer

{
    internal class Add
    {
        public static void AddCustomer()
        {
            Console.WriteLine("Nome: ");
            string? name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Nome não pode ficar em branco.");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                CustomerSubMenu.CustomerMenu();
            }
            Console.WriteLine("Sobrenome: ");
            string? surname = Console.ReadLine();
            Console.WriteLine("Telefone: ");
            string? phone = Console.ReadLine();
            Model.Customer customer = new Model.Customer(name, surname, phone);
            Model.Manager.CustomerManager.AddCustomer(customer);
            Console.WriteLine("Cliente adicionado.");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            CustomerSubMenu.CustomerMenu();
        }
    }
}
