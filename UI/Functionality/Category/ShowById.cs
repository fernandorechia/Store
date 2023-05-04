using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.UI.Functionality.Category
{
    internal class ShowById
    {
        public static void ShowCategoryById()
        {
            Console.WriteLine("Digite o ID para pesquisa:");
            int id = 0;
            string? idString = Console.ReadLine();
            try
            {
                id = int.Parse(idString);
            }
            catch (FormatException)
            {
                Console.WriteLine("ID inválido.");
                CategorySubMenu.CategoryMenu();
            }
            List<Model.Category> result = Model.Manager.CategoryManager.GetCategories();
            Model.Category categoryToEdit = result.FirstOrDefault(c => c.CategoryId == id);
            if (categoryToEdit == null)
            {
                Console.WriteLine("ID não encontrado.");
                CategorySubMenu.CategoryMenu();
            }
            Console.WriteLine("Resultado da pesquisa: ");
            Console.WriteLine($"ID: {categoryToEdit.CategoryId}");
            Console.WriteLine($"Nome: {categoryToEdit.Name}");
            Console.WriteLine($"Descrição: {categoryToEdit.Description}");
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            CategorySubMenu.CategoryMenu();

        }
    }
}
