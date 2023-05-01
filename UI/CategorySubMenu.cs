﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.UI
{
    public static class CategorySubMenu
    {
        public static void CategoryMenu()
        {
            var categoryOptions = new List<string> { "Adicionar categoria", "Listar categorias", "Busca por ID", "Remover categoria", "Voltar" };
            var menu = new Menu(categoryOptions);
            int selection = menu.Display();
            Console.WriteLine($"Você selecionou a opção {selection + 1}: {categoryOptions[selection]}");
            if (selection == 0)
            {
                Functionality.AddCategory();
            }
            else if (selection == 1)
            {
                Functionality.ListCategories();
            }
            else if (selection == 2)
            {
                Functionality.ShowCategoryById();
            }
            else if (selection == 3)
            {
                Functionality.RemoveCategory();
            }
            else if (selection == 4)
            {
                MAINMenu.MainMenu();
            }
            else
            {
                Console.WriteLine("Opção inválida");
                CategoryMenu();
            }
        }
    }
}
