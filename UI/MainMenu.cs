using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.UI
{
    public static class MAINMenu
    {
        public static void MainMenu()
        {
            Console.WriteLine("Menu principal");
            var mainOptions = new List<string> { "Clientes", "Produtos", "Categorias", "Vendas", "Sair" };
            var menu = new Menu(mainOptions);
            int selection = menu.Display();
            Console.WriteLine($"Você selecionou a opção {selection + 1}: {mainOptions[selection]}");

            switch (selection)
            {
                case 0:
                    CustomerSubMenu.CustomerMenu();
                    break;
                case 1:
                    ProductSubMenu.ProductMenu();
                    break;
                case 2:
                    CategorySubMenu.CategoryMenu();
                     break;
                case 3:
                    OrderSubMenu.OrderMenu();
                     break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:                   
                    break;
            }
        }
    }
}
