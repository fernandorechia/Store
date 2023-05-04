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

        private static List<Product> OrderProducts { get; set; }




        //Methods
        //Constructor
        public Order(Customer Customer)
        {
            this.Customer = Customer;
            OrderProducts = new List<Product>();
            OrderId = lastAssignedId;
            lastAssignedId++;
        }
        
        public static List<Product>? GetOrderProducts(Order order)
        {
            return OrderProducts;
        }
        public static void AddProduct(Product product)
        {
            OrderProducts.Add(product);
        }

    }
}
