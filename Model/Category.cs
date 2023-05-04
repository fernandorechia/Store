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
        // Constructors
        public Category(string name, string? description) {
            
            CategoryId = lastAssignedId;
            lastAssignedId++;

            Name = name;
            Description = description;

        }

    }
}
