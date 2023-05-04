using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.UI.Functionality.Product
{
    internal class Remove
    {
        public static void RemoveProduct()
        {
            List<Model.Product> products = Model.Manager.ProductManager.GetProducts();
            foreach (Model.Product product in products)
            {
                Console.WriteLine($"ID: {product.ProductId}");
                Console.WriteLine($"Nome: {product.ProductName}");
                Console.WriteLine($"Descrição: {product.ProductDescription}");
                Console.WriteLine($"Preço: {product.ProductPrice}");
            }
            Console.WriteLine("Digite o ID do produto a ser removido:");
            int id = 0;
            string idString = Console.ReadLine();
            try
            {
                id = int.Parse(idString);
            }
            catch (FormatException)
            {
                Console.WriteLine("ID inválido.");
                Console.WriteLine("Pressione uma tecla para voltar");
                Console.ReadKey();
                Console.Clear();
                ProductSubMenu.ProductMenu();
            }
            Model.Product productToEdit = products.FirstOrDefault(c => c.ProductId == id);
            if (productToEdit == null)
            {
                Console.WriteLine("ID não encontrado");
                Console.WriteLine("Pressione uma tecla para voltar");
                Console.ReadKey();
                Console.Clear();
                ProductSubMenu.ProductMenu();
            }
            else
            {
                if (Confirmation.GetConfirmation($"Tem certeza que deseja remover {productToEdit.ProductName}?"))
                {
                    Model.Manager.ProductManager.RemoveProduct(productToEdit);
                    Console.WriteLine($"Produto {productToEdit.ProductName} removido");
                } else
                {
                    Console.WriteLine($"Produto {productToEdit.ProductName} não removido");
                }
            }
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            ProductSubMenu.ProductMenu();

        }
    }
}
