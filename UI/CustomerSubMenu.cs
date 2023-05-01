using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.UI
{
    public static class CustomerSubMenu
    {
        public static void CustomerMenu()
        {
            var customerOptions = new List<string> { "Adicionar cliente", "Remover cliente", "Listar clientes", "Busca por nome", "Voltar" };
            var menu = new Menu(customerOptions);
            int selection = menu.Display();
            Console.WriteLine($"Você selecionou a opção {selection + 1}: {customerOptions[selection]}");
            if (selection == 0)
            {
                Functionality.AddCustomer();
            }
            else if (selection == 1)
            {
                Functionality.RemoveCustomer();
            }
            else if (selection == 2)
            {
                Functionality.ListCustomers();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                CustomerMenu();
            }
            else if (selection == 3)
            {
                Console.WriteLine("Digite o nome do cliente: ");
                string? _name = Console.ReadLine();
                List<Customer> result = Model.Manager.CustomerManager.SearchCustomersByName( _name );
                foreach (Customer customer in result)
                {
                    Console.WriteLine($"ID: {customer.CustomerId}");
                    Console.WriteLine($"Nome: {customer.Name}");
                    Console.WriteLine($"Sobrenome: {customer.Surname}");
                    Console.WriteLine($"Telefone: {customer.Phone}");
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                CustomerMenu();
            }
            else if (selection == 4)
            {
                MAINMenu.MainMenu();
            }
            else { Console.WriteLine("Opção inválida!"); }


            }
        }
    }

