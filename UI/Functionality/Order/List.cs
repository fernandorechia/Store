using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.UI.Functionality.Order
{
    internal class List
    {
        public static void ListOrders()
        {
            foreach (Model.Order order in Model.Manager.OrderManager.GetOrders())
            {
                Console.WriteLine($"Venda número ID: {order.OrderId}");
                Console.WriteLine($"Cliente: {order.Customer.Name} {order.Customer.Surname}");
                Console.WriteLine($"Produtos: ");
                Console.WriteLine("");
                float? total = 0;
                List<Model.Product> products = Model.Order.GetOrderProducts(order);
                foreach (Model.Product product in Model.Order.GetOrderProducts(order))
                {
                    if (product != null)
                    {
                        Console.WriteLine($"ID: {product.ProductId}");
                        Console.WriteLine($"Categoria: {product.Category.Name}");
                        Console.WriteLine($"Nome: {product.ProductName}");
                        Console.WriteLine($"Descrição: {product.ProductDescription}");
                        Console.WriteLine($"Preço: {product.ProductPrice}");                       
                        total = total + product.ProductPrice;
                        Console.WriteLine("");
                        
                    }
                }
                Console.WriteLine($"Total da venda: {total}");
            }
            Console.WriteLine("pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            OrderSubMenu.OrderMenu();
        }
    }
}
