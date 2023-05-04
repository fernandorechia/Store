using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.UI
{
    internal class OrderSubMenu
    {
        public static void OrderMenu()
        {
            Console.WriteLine("Menu Vendas");
            List<string> orderOptions = new List<string> { "Adicionar venda", "Remover venda", "Listar vendas", "Voltar" };
            Menu menu = new Menu(orderOptions);
            int selection = menu.Display();
            Console.WriteLine($"Você selecionou a opção {selection + 1}: {orderOptions[selection]}");
            if (selection == 0)
            {
                Functionality.Order.Add.AddOrder();
            }
            else if (selection == 1)
            {
                Functionality.Order.Remove.RemoveOrder();
            }
            else if (selection == 2)
            {
                Functionality.Order.List.ListOrders();
            }
            else if (selection == 3)
            {
                MAINMenu.MainMenu();
            }
            else if (selection == 4)
            {
                MAINMenu.MainMenu();
            }
        }
    }
}

