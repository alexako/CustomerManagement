using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistration
{
    class CustomerBuilder
    {
        private Customer customer = new Customer();
        public CustomerBuilder FirstName(string first_name)
        {
            customer.first_name = first_name;
            return this;
        }

        public CustomerBuilder LastName(string last_name)
        {
            customer.last_name = last_name;
            return this;
        }

        public CustomerBuilder CustomerID(string customer_id)
        {
            customer.customer_id = customer_id;
            return this;
        }

        public CustomerBuilder CustomerAddress(Address address)
        {
            customer.address = address;
            return this;
        }
    }
}
