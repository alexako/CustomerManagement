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
        List<Customer> _customers;
        List<Transaction> _transactions;

        private static Record theInstance = null;
        private Record() {
            _customers = new List<Customer>();
            _customer_count = _customers.Count;
            _transactions = new List<Transaction>();
            _transactions_count = _transactions.Count;
        }

        public static Record getInstance()
        {
            if (theInstance == null)
                theInstance = new Record();

            return theInstance;
        }

        public List<Customer> customers { get { return _customers; } }
        public List<Transaction> transactions { get { return _transactions; } }
        public int customer_count { get { return _customer_count; } }
        public int transaction_count { get { return _transactions_count; } }

        public void add(Customer customer)
        {
            if (!_customers.Contains(customer))
                _customers.Add(customer);

            _customer_count = _customers.Count;
        }
        public void add(Transaction transaction)
        {
            if (!_transactions.Contains(transaction))
                _transactions.Add(transaction);

            _transactions_count = _transactions.Count;
        }

        public void delete(Customer customer)
        {
            _customers.Remove(customer);
            _customer_count = _customers.Count;
        }
        public void delete(Transaction transaction)
        {
            _transactions.Remove(transaction);
            _transactions_count = _transactions.Count;
        }

        public Transaction Transaction
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

    }
}
