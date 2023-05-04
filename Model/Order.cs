using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Runtime.CompilerServices;
using Store.UI;

namespace Store.Model
{
    internal class Order
    {
        // Fields
        private static int lastAssignedId = 1;

        //Properties
        [Required] public Customer Customer;
        public int OrderId { get; private set; }

        public static List<Product> _orderProducts = new List<Product>();


        //Methods
        //Constructor
        public Order(Customer Customer)
        {
            this.Customer = Customer;
            OrderId = lastAssignedId;
            lastAssignedId++;
        }
        
        public static List<Product> GetOrderProducts(Order order) {        
            return ListProducts._orderProducts;
        }
        public static void AddProduct(Product product)
        {
            ListProducts._orderProducts.Add(product);
        }

    }
    internal class ListProducts
    {
        public static List<Product> _orderProducts = new List<Product>();
    }
}
