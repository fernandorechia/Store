using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Customer
    {
        // Fields
        private static int lastAssignedId = 1;

        // Properties
        public int CustomerId { get; private set; }
        public string Name { get; private set; }
        public string? Surname { get; private set; } = string.Empty;
        public string? Phone { get; private set; } = string.Empty;


        // Methods
        // Constructor
        public Customer(string name, string? surname, string? phone)
        {
            // increment last assigned ID and assign to current instance


            CustomerId = lastAssignedId;
            lastAssignedId++;

            
            Name = name;
            Surname = surname;
            Phone = phone;
        }

    }
}
