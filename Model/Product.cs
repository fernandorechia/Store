using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Store.Model
{
    internal class Product
    {
        //Fields
        private static int lastAssignedId = 1;
        // Properties

        public Category Category;


        public int ProductId { get; private set; }
        public string? ProductName { get; private set; }
        public string? ProductDescription { get; private set; } = string.Empty;
        public float? ProductPrice { get; private set; }

        // Methods
        // Constructor
        public Product(Category? category, string name, string? description, float? price)
        {
            ProductId = lastAssignedId;
            lastAssignedId++;

            this.Category = category;
            ProductName = name;
            ProductDescription = description;
            ProductPrice = price;
        }

    }
}
