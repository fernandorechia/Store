using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.UI.Functionality.Category
{
    internal class Remove
    {
        public static void RemoveCategory()
        {
            List<Model.Category> categories = Model.Manager.CategoryManager.GetCategories();
            foreach (Model.Category category in categories)
            {
                Console.WriteLine($"ID: {category.CategoryId}");
                Console.WriteLine($"Nome: {category.Name}");
                Console.WriteLine($"Descrição: {category.Description}");
            }
            Console.WriteLine("Digite o ID da categoria a ser removida:");
            int id = 0;
            string idString = Console.ReadLine();
            try
            {
                id = int.Parse(idString);
            }
            catch (FormatException)
            {
                Console.WriteLine("ID inválido.");
                CategorySubMenu.CategoryMenu();
            }
            Model.Category categoryToEdit = categories.FirstOrDefault(c => c.CategoryId == id);
            if (categoryToEdit == null)
            {
                Console.WriteLine("ID não encontrado");
                CategorySubMenu.CategoryMenu();
            }
            else
            {
                if (Confirmation.GetConfirmation($"Remover categoria {categoryToEdit.Name}?")) ;
                {
                    Model.Manager.CategoryManager.Remove(categoryToEdit);
                    Console.WriteLine($"Categoria {categoryToEdit.Name} removida");
                }
            }
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            CategorySubMenu.CategoryMenu();
        }
    }
}
