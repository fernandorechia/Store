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
            Console.WriteLine("Menu Clientes");
            List<string> customerOptions = new List<string> { "Adicionar cliente", "Remover cliente", "Listar clientes", "Busca por nome", "Voltar" };
            Menu menu = new Menu(customerOptions);
            int selection = menu.Display();
            Console.WriteLine($"Você selecionou a opção {selection + 1}: {customerOptions[selection]}");
            if (selection == 0)
            {
                Functionality.Customer.Add.AddCustomer();
            }
            else if (selection == 1)
            {
                Functionality.Customer.Remove.RemoveCustomer();
            }
            else if (selection == 2)
            {
                Functionality.Customer.List.ListCustomers();
            }
            else if (selection == 3)
            {
                Functionality.Customer.SearchByName.Search();
            }
            else if (selection == 4)
            {
                MAINMenu.MainMenu();
            }
            }
        }
    }

