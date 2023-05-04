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
            Console.WriteLine("Menu Produtos");
            var productOptions = new List<string> { "Adicionar produto", "Remover produto", "Listar produtos", "Voltar" };
            var menu = new Menu(productOptions);
            int selection = menu.Display();
            Console.WriteLine($"Você selecionou a opção {selection + 1}: {productOptions[selection]}");
            if ( selection == 0 )
            {
                Functionality.Product.Add.AddProduct();
            }
            else if ( selection == 1 )
            {
                Functionality.Product.Remove.RemoveProduct();
            }
            else if ( selection == 2 )
            {
                Functionality.Product.List.ListProducts();
            }
            else if ( selection == 3 ) {
                MAINMenu.MainMenu();
            }           
        }
    }
}
