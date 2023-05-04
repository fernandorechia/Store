using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.UI.Functionality.Product
{
    internal class Add
    {
        public static void AddProduct()
        {
            Console.WriteLine("Nome: ");
            string? name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Nome não pode ficar em branco.");
                Console.WriteLine("Pressione uma tecla para voltar");
                Console.ReadKey();
                Console.Clear();
                ProductSubMenu.ProductMenu();
            }
            Console.WriteLine("Descrição: ");
            string? description = Console.ReadLine();
            Console.WriteLine("Preço: ");
            string? priceString = Console.ReadLine();
            float? price = null;
            try
            {
                price = float.Parse(priceString);


            }
            catch (FormatException)
            {
                Console.WriteLine("Preço inválido.");
                Console.WriteLine("Pressione uma tecla para voltar");
                Console.ReadKey();
                Console.Clear();
                ProductSubMenu.ProductMenu();
            }
            Console.WriteLine("Escolha Categoria pelo ID: ");
            List<Model.Category> _categories = Model.Manager.CategoryManager.GetCategories();
            foreach (Model.Category _category in _categories)
            {
                Console.WriteLine($"ID: {_category.CategoryId}");
                Console.WriteLine($"Nome: {_category.Name}");
                Console.WriteLine($"Descrição: {_category.Description}");
            }
            string? idString = Console.ReadLine();
            int id = 0;
            if (idString == null || idString == "0") {
                Console.WriteLine("Categoria não pode ficar em branco ou ser 0");
                Console.WriteLine("Pressione uma tecla para voltar");
                Console.ReadKey();
                Console.Clear();
                ProductSubMenu.ProductMenu();
            }
            try
            {
                id = int.Parse(idString);
            }
            catch (FormatException)
            {
                Console.WriteLine("ID inválida");
                Console.WriteLine("Pressione uma tecla para voltar");
                Console.ReadKey();
                Console.Clear();
                ProductSubMenu.ProductMenu();
            }
            
            Model.Category categoryToEdit = _categories.FirstOrDefault(c => c.CategoryId == id);
            if (categoryToEdit != null)
            {
                Model.Product product = new Model.Product(categoryToEdit, name, description, price);
                Model.Manager.ProductManager.AddProduct(product);
                Console.WriteLine("Produto adicionado.");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                ProductSubMenu.ProductMenu();
            }
            else
            {
                Console.WriteLine("Categoria não existe");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                ProductSubMenu.ProductMenu();
            }
        }
    }
}
