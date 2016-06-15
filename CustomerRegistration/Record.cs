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

        public int customer_count { get { return _customer_count; } }
        public List<Customer> customers { get { return _customers; } }

        public void add(Customer customer)
        {
            _customers.Add(customer);
            _customer_count = _customers.Count;
        }
        public void add(Transaction transaction)
        {
            _transactions.Add(transaction);
            _transactions_count = _transactions.Count;
        }

        public void delete(Customer customer)
        {
        }
        public void delete(Transaction tranaction)
        {
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
