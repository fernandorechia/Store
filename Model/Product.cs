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

        [Required]
        public Category Category;
        public int ProductId { get; private set; }
        public string? ProductName { get; private set; }
        public string? ProductDescription { get; private set; } = string.Empty;
        public float? ProductPrice { get; private set; }

        // Methods
        // Constructor
        public Product(Category category, string _name, string? _description, float? _price)
        {
            ProductId = lastAssignedId;
            lastAssignedId++;

            this.Category = category;
            ProductName = _name;
            ProductDescription = _description;
            ProductPrice = _price;
        }

    }
}
