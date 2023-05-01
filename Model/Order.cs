using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Store.Model
{
    internal class Order
    {
        // Fields
        private static int lastAssignedId = 1;

        //Properties
        [Required] public Customer Customer;
        public int OrderId { get; private set; }
        public int ProductId { get; private set; } = 0;
        public List<Product>? Products { get; private set; }
        public string ProductDescription { get; private set; }
        public string ProductCategory { get; private set; }

        //Methods
        //Constructor
        public Order(int _productId, List<Product>? _productName, string _productDescription)
        {
            
            OrderId = lastAssignedId;
            lastAssignedId++;

            ProductId = _productId;
            Products = _productName;
            ProductDescription = _productDescription;
        }


    }
}
