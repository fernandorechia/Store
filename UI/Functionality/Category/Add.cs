using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Model;

namespace Store.UI.Functionality.Category
{
    internal class Add
    {
        public static void AddCategory()
        {
            Console.WriteLine("Nome: ");
            string? name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Nome não pode ficar em branco.");
                CategorySubMenu.CategoryMenu();
            }
            Console.WriteLine("Descrição: ");
            string? description = Console.ReadLine();
            Model.Category category = new Model.Category(name, description);
            Model.Manager.CategoryManager.Add(category);
            Console.WriteLine("Categoria adicionada.");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            CategorySubMenu.CategoryMenu();
        }
    }
}
