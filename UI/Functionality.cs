using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Store.UI
{
    internal class Functionality
    {

        public static void ListCategories()
        {
            List<Category> categories = Model.Manager.CategoryManager.GetCategories();
            foreach (Category category in categories)
            {
                Console.WriteLine($"ID: {category.CategoryId}");
                Console.WriteLine($"Nome: {category.Name}");
                Console.WriteLine($"Descrição: {category.Description}");
            }
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            CategorySubMenu.CategoryMenu();
        }

        public static void RemoveCategory()
        {
            List<Category> categories = Model.Manager.CategoryManager.GetCategories();
            foreach (Category category in categories)
            {
                Console.WriteLine($"ID: {category.CategoryId}");
                Console.WriteLine($"Nome: {category.Name}");
                Console.WriteLine($"Descrição: {category.Description}");
            }
            Console.WriteLine("Digite o ID da categoria a ser removida:");
            int _id = 0;
            string _idString = Console.ReadLine();
            try
            {
                _id = int.Parse(_idString);
            }
            catch (FormatException)
            {
                Console.WriteLine("ID inválido.");
                CategorySubMenu.CategoryMenu();
            }
            Category categoryToEdit = categories.FirstOrDefault(c => c.CategoryId == _id);
            if (categoryToEdit == null)
            {
                Console.WriteLine("ID não encontrado");
                CategorySubMenu.CategoryMenu();
            }
            else
            {
                Model.Manager.CategoryManager.Remove(categoryToEdit);
                Console.WriteLine("removido");
            }
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            CategorySubMenu.CategoryMenu();
        }


        public static void ShowCategoryById()
        {
            Console.WriteLine("Digite o ID para pesquisa:");
            int _id = 0;
            string? _idString = Console.ReadLine();
            try
            {
                _id = int.Parse(_idString);
            }
            catch (FormatException)
            {
                Console.WriteLine("ID inválido.");
                CategorySubMenu.CategoryMenu();
            }
            List<Category> result = Model.Manager.CategoryManager.GetCategories();
            Category categoryToEdit = result.FirstOrDefault(c => c.CategoryId == _id);
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
            CategorySubMenu.CategoryMenu();

        }
        public static void ListCustomers()
        {
            List<Customer> customers = Model.Manager.CustomerManager.GetCustomers();
            foreach (Customer customer in customers)
            {
                Console.WriteLine($"ID: {customer.CustomerId}");
                Console.WriteLine($"Nome: {customer.Name}");
                Console.WriteLine($"Sobrenome: {customer.Surname}");
                Console.WriteLine($"Telefone: {customer.Phone}");
            }
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            CustomerSubMenu.CustomerMenu();
        }
        public static void AddCustomer()
        {
            Console.WriteLine("Nome: ");
            string? _name = Console.ReadLine();
            if (string.IsNullOrEmpty(_name))
            {
                Console.WriteLine("Nome não pode ficar em branco.");
                CustomerSubMenu.CustomerMenu();
            }
            Console.WriteLine("Sobrenome: ");
            string? _surname = Console.ReadLine();
            Console.WriteLine("Telefone: ");
            string? _phone = Console.ReadLine();
            Customer customer = new Customer(_name, _surname, _phone);
            Model.Manager.CustomerManager.AddCustomer(customer);
            Console.WriteLine("Cliente adicionado.");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            CustomerSubMenu.CustomerMenu();
        }
        public static void RemoveCustomer()
        {
            Console.WriteLine("Digite o nome do cliente: ");
            string? _name = Console.ReadLine();
            List<Customer> result = Model.Manager.CustomerManager.SearchCustomersByName(_name);
            foreach (Customer customer in result)
            {
                Console.WriteLine($"ID: {customer.CustomerId}");
                Console.WriteLine($"Nome: {customer.Name}");
                Console.WriteLine($"Sobrenome: {customer.Surname}");
                Console.WriteLine($"Telefone: {customer.Phone}");
            }
            Customer customerToEdit = result.FirstOrDefault(c => c.Name == _name);
            if (customerToEdit == null)
            {
                Console.WriteLine("não foi encontrado cliente com este nome");
            }
            else if (GetConfirmation($"Tem certeza que quer excluir o cliente {customerToEdit.Name}?"))
            {
                Model.Manager.CustomerManager.RemoveCustomer(customerToEdit);
                Console.WriteLine("removido");
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            CustomerSubMenu.CustomerMenu();
        }

        public static bool GetConfirmation(string message)
        {
            Console.Write($"{message} (s/n)");
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.KeyChar != 's' && key.KeyChar != 'n')
            {
                Console.Write("\nEntrada inválida. Digite 's' ou 'n': ");
                key = Console.ReadKey();
            }
            Console.WriteLine();

            return (key.KeyChar == 's');
        }
        public static void AddProduct()
        {
            Console.WriteLine("Nome: ");
            string? _name = Console.ReadLine();
            if (string.IsNullOrEmpty(_name))
            {
                Console.WriteLine("Nome não pode ficar em branco.");
                ProductSubMenu.ProductMenu();
            }
            Console.WriteLine("Categoria: ");
            string? _category = Console.ReadLine();
            if (string.IsNullOrEmpty(_category))
            {
                Console.WriteLine("Categoria não pode ficar em branco.");
                ProductSubMenu.ProductMenu();
            }
            Console.WriteLine("Descrição: ");
            string? _description = Console.ReadLine();
            Console.WriteLine("Preço: ");
            string? _priceString = Console.ReadLine();
            float? _price = null;
            try
            {
                _price = float.Parse(_priceString);


            }
            catch (FormatException)
            {
                Console.WriteLine("Preço inválido.");
                ProductSubMenu.ProductMenu();
            }

            List<Category> _categories = Model.Manager.CategoryManager.GetCategories();
            Category categoryToEdit = _categories.FirstOrDefault();
            Product product = new Product(categoryToEdit, _name, _description, _price);

            Model.Manager.ProductManager.AddProduct(product);
            Console.WriteLine("Produto adicionado.");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            ProductSubMenu.ProductMenu();
        }
        public static void AddCategory()
        {
            Console.WriteLine("Nome: ");
            string? _name = Console.ReadLine();
            if (string.IsNullOrEmpty(_name))
            {
                Console.WriteLine("Nome não pode ficar em branco.");
                CategorySubMenu.CategoryMenu();
            }
            Console.WriteLine("Descrição: ");
            string? _description = Console.ReadLine();
            Category category = new Category(_name, _description);
            Model.Manager.CategoryManager.Add(category);
            Console.WriteLine("Categoria adicionada.");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            CustomerSubMenu.CustomerMenu();
        }
        public static void RemoveProduct()
        {
            List<Product> products = Model.Manager.ProductManager.GetProducts();
            foreach (Product product in products)
            {
                Console.WriteLine($"ID: {product.ProductId}");
                Console.WriteLine($"Nome: {product.ProductName}");
                Console.WriteLine($"Descrição: {product.ProductDescription}");
                Console.WriteLine($"Preço: {product.ProductPrice}");
            }
            Console.WriteLine("Digite o ID do produto a ser removido:");
            int _id = 0;
            string _idString = Console.ReadLine();
            try
            {
                _id = int.Parse(_idString);
            }
            catch (FormatException)
            {
                Console.WriteLine("ID inválido.");
                CategorySubMenu.CategoryMenu();
            }
            Product productToEdit = products.FirstOrDefault(c => c.ProductId == _id);
            if (productToEdit == null)
            {
                Console.WriteLine("ID não encontrado");
                CategorySubMenu.CategoryMenu();
            }
            else
            {
                Model.Manager.ProductManager.RemoveProduct(productToEdit);
                Console.WriteLine("removido");
            }
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            ProductSubMenu.ProductMenu();

        }
        public static void ListProducts()
        {
            List<Product> products = Model.Manager.ProductManager.GetProducts();
            foreach (Product product in products)
            {
                Console.WriteLine($"ID: {product.ProductId}");
                Console.WriteLine($"Nome: {product.ProductName}");
                Console.WriteLine($"Descrição: {product.ProductDescription}");
                Console.WriteLine($"Preço: {product.ProductPrice}");
            }
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            ProductSubMenu.ProductMenu();
        }
    }
}
