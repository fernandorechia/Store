using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    internal class Category
    {
        // Fields
        private static int lastAssignedId = 1;
        // Properties
        public int CategoryId { get; private set; }
        public string? Name { get; private set; }
        public string? Description { get; private set; } = null;

        // Methods
        // Constructor
        public Category(string _name, string? _description) {
            
            CategoryId = lastAssignedId;
            lastAssignedId++;

            Name = _name;
            Description = _description;

        }
    }
}
