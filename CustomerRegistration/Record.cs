using CustomerRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistration
{
    public class Record
    {
        /* Implements Singleton design pattern */

        int _customer_count, _transactions_count;
        Dictionary<string, Customer> _customers;
        Dictionary<string, Transaction> _transactions;

        private static Record theInstance = null;
        private Record() {
            _customers = new Dictionary<string, Customer>();
            _customer_count = _customers.Count;
            _transactions = new Dictionary<string, Transaction>();
            _transactions_count = _transactions.Count;
        }

        public static Record getInstance()
        {
            if (theInstance == null)
                theInstance = new Record();

            return theInstance;
        }

        public Dictionary<string, Customer> customers { get { return _customers; } }
        public Dictionary<string, Transaction> transactions { get { return _transactions; } }
        public int customer_count { get { return _customer_count; } }
        public int transaction_count { get { return _transactions_count; } }

        public void add(Customer customer)
        {
            if (!_customers.ContainsKey(customer.customer_id))
                _customers.Add(customer.customer_id, customer);

            _customer_count = _customers.Count;
        }
        public void add(Transaction transaction)
        {
            if (!transactions.ContainsKey(transaction.trans_id))
                transactions.Add(transaction.trans_id, transaction);

            _transactions_count = _transactions.Count;
        }

        public void delete(Customer customer)
        {
            _customers.Remove(customer.customer_id);
            _customer_count = _customers.Count;
        }
        public void delete(Transaction transaction)
        {
            _transactions.Remove(transaction.trans_id);
            _transactions_count = _transactions.Count;
        }
    }
}
