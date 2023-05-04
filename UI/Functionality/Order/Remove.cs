using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.UI.Functionality.Order
{
    internal class Remove
    {
        public static void RemoveOrder()
        {
            foreach (Model.Order order in Model.Manager.OrderManager.GetOrders())
            {
                float? total = 0;
                Console.WriteLine($"Venda número ID: {order.OrderId}");
                Console.WriteLine($"Cliente: {order.Customer.Name} {order.Customer.Surname}");
                Console.WriteLine($"Produtos: ");
                List<Model.Product> products = Model.Order.GetOrderProducts(order);
                foreach (Model.Product product in Model.Order.GetOrderProducts(order))
                {
                    if (product != null)
                    {
                        //Console.WriteLine($"ID: {product.ProductId}");
                        //Console.WriteLine($"Categoria: {product.Category.Name}");
                        //Console.WriteLine($"Nome: {product.ProductName}");
                        //Console.WriteLine($"Descrição: {product.ProductDescription}");
                        //Console.WriteLine($"Preço: {product.ProductPrice}");
                        total = total + product.ProductPrice;
                        //Console.WriteLine("");

                    }
                }
                Console.WriteLine($"Total da venda: {total}\n");
            }
                Console.WriteLine("Digite o ID da venda a ser removida:");
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
                    OrderSubMenu.OrderMenu();
                }
                Model.Order orderToEdit = Model.Manager.OrderManager.GetOrders().FirstOrDefault(c => c.OrderId == id);
                if (orderToEdit == null)
                {
                    Console.WriteLine("ID não encontrado");
                    Console.WriteLine("Pressione uma tecla para voltar");
                    Console.ReadKey();
                    Console.Clear();
                    OrderSubMenu.OrderMenu();
                }
                else
                {
                    if (Confirmation.GetConfirmation($"Tem certeza que deseja remover venda número {orderToEdit.OrderId}?"))
                    {
                        Model.Manager.OrderManager.Remove(orderToEdit);
                        Console.WriteLine($"Venda número {orderToEdit.OrderId} removida");
                    }
                    else
                    {
                        Console.WriteLine($"Venda número {orderToEdit.OrderId} não removida");
                    }
                }
                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey();
                Console.Clear();
                OrderSubMenu.OrderMenu();
            }
        }
    }


