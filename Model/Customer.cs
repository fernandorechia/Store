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
        public Customer(string _name, string? _surname, string? _phone)
        {
            // increment last assigned ID and assign to current instance


            CustomerId = lastAssignedId;
            lastAssignedId++;

            
            Name = _name;
            Surname = _surname;
            Phone = _phone;
        }

    }
}
