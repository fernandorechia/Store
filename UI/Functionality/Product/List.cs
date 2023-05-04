using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.UI.Functionality.Product
{
    internal class List
    {
        public static void ListProducts()
        {
            List<Model.Product> products = Model.Manager.ProductManager.GetProducts();
            foreach (Model.Product product in products)
            {
                Console.WriteLine($"ID: {product.ProductId}");
                Console.WriteLine($"Categoria: {product.Category.Name}");
                Console.WriteLine($"Nome: {product.ProductName}");
                Console.WriteLine($"Descrição: {product.ProductDescription}");
                Console.WriteLine($"Preço: {product.ProductPrice}");
            }
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            ProductSubMenu.ProductMenu();
        }
    }
}
