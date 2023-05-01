using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.UI
{
    public static class ProductSubMenu
    {
        public static void ProductMenu()
        {
            var productOptions = new List<string> { "Adicionar produto", "Remover produto", "Listar produtos", "Voltar" };
            var menu = new Menu(productOptions);
            int selection = menu.Display();
            Console.WriteLine($"Você selecionou a opção {selection + 1}: {productOptions[selection]}");
            if ( selection == 0 )
            {
                Functionality.AddProduct();
            }
            else if ( selection == 1 )
            {
                Functionality.RemoveProduct();
            }
            else if ( selection == 2 )
            {
                Functionality.ListProducts();
            }
            else if ( selection == 3 ) {
                MAINMenu.MainMenu();
            }
            else {
                Console.WriteLine("Opção inválida");
                    ProductMenu();
            }
        }
    }
}
