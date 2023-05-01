using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model.Manager
{
    internal class ProductManager
    {
        // create a list for the Product objects

        private static List<Product> products = new List<Product>();

        // add a Product instance to the products list

        public static void AddProduct(Product product)
        {
            products.Add(product);
        }

        //remove a Product instance from the products list

        public static void RemoveProduct(Product product)
        {
            products.Remove(product);
        }

        // returns the list of products
        public static List<Product> GetProducts()
        {
            return products;
        }
    }
}
