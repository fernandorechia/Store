using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Store.UI.Functionality.Order
{
    internal class Add
    {
        public static void AddOrder()
        {
            List<Model.Customer> customers = Model.Manager.CustomerManager.GetCustomers();
            foreach (Model.Customer customer in customers)
            {
                Console.WriteLine($"ID: {customer.CustomerId}");
                Console.WriteLine($"Nome: {customer.Name}");
                Console.WriteLine($"Sobrenome: {customer.Surname}");
                Console.WriteLine($"Telefone: {customer.Phone}");
            }
            Console.WriteLine("Selecione o cliente pelo ID:");
            string? idString = Console.ReadLine();
            int id = 0;
            try
            {
                id = int.Parse(idString);
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida. Digite um ID de cliente");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
            Model.Customer customerToEdit = customers.FirstOrDefault(c => c.CustomerId == id);
            if (customerToEdit == null)
            {
                Console.WriteLine("não foi encontrado cliente com este ID");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                OrderSubMenu.OrderMenu();
            }
            else
            {
                Model.Order order = new Model.Order(customerToEdit);
                Model.Manager.OrderManager.Add(order);
                Console.WriteLine($"Compra ID: {order.OrderId} adicionada ao cliente: {customerToEdit.Name}");
                Console.WriteLine("");
                string idProduct = "1";
                while (idProduct != "0")
                {

                    List<Model.Product> products = Model.Manager.ProductManager.GetProducts();
                    foreach (Model.Product product in products)
                    {
                        Console.WriteLine($"Produto ID: {product.ProductId}");
                        Console.WriteLine($"Categoria: {product.Category.Name}");
                        Console.WriteLine($"Nome: {product.ProductName}");
                        Console.WriteLine($"Descrição: {product.ProductDescription}");
                        Console.WriteLine($"Preço: {product.ProductPrice}");
                    }
                    Console.WriteLine("Adicione Produtos a essa compra pelo ID do produto (0 = sair):");
                    int idInt = 0;
                    idProduct = Console.ReadLine();
                    try
                    {
                        idInt = int.Parse(idProduct);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("ID inválido. Tente novamente.");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    Model.Product productToEdit = products.FirstOrDefault(c => c.ProductId == idInt);
                    if (productToEdit != null)
                    {
                        Model.Order.AddProduct(productToEdit);                        
                        Console.WriteLine($"Produto {productToEdit.ProductName} adicionado à venda ID {order.OrderId} para o cliente {customerToEdit.Name}");
                        Console.WriteLine("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            OrderSubMenu.OrderMenu();
        }
    }
}
