using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Model;

namespace Store.UI.Functionality.Category
{
    internal class List
    {
        public static void ListCategories()
        {
            foreach (Model.Category category in Model.Manager.CategoryManager.GetCategories())
            {
                Console.WriteLine($"ID: {category.CategoryId}");
                Console.WriteLine($"Nome: {category.Name}");
                Console.WriteLine($"Descrição: {category.Description}");
            }
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            CategorySubMenu.CategoryMenu();
        }
    }
}
