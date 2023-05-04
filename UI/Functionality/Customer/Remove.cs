using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Model;

namespace Store.UI.Functionality.Customer
{
    internal class Remove
    {
        public static void RemoveCustomer()
        {
            List<Model.Customer> customers = Model.Manager.CustomerManager.GetCustomers();
            foreach (Model.Customer customer in customers)
            {
                Console.WriteLine($"ID: {customer.CustomerId}");
                Console.WriteLine($"Nome: {customer.Name}");
                Console.WriteLine($"Sobrenome: {customer.Surname}");
                Console.WriteLine($"Telefone: {customer.Phone}");
            }
            Console.WriteLine("Digite o ID do cliente: ");
            string? idString = Console.ReadLine();
            int id = 0;
            try
            {
                id = int.Parse(idString);
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida. Digite um ID de cliente");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                CustomerSubMenu.CustomerMenu();
            }
            Model.Customer customerToEdit = customers.FirstOrDefault(c => c.CustomerId == id);
            if (customerToEdit == null)
            {
                Console.WriteLine("não foi encontrado cliente com este nome");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                CustomerSubMenu.CustomerMenu();
            }
            else if (Confirmation.GetConfirmation($"Tem certeza que quer excluir o cliente {customerToEdit.Name}?"))
            {
                Model.Manager.CustomerManager.RemoveCustomer(customerToEdit);
                Console.WriteLine($"Cliente {customerToEdit.Name} removido");
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            CustomerSubMenu.CustomerMenu();
        }
    }
}
