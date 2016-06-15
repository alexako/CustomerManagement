using CustomerRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistration
{
    public class Transaction : IGenerateID
    {
        string _trans_id;
        string _customer_id;

        public Transaction(Customer customer)
        {
            _customer_id = customer.customer_id;
            _trans_id = generateID() + _customer_id;
        }

        public string generateID()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss") + _customer_id;
        }

    }
}
