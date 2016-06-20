﻿using CustomerRegistration;
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

        Dictionary<string, Customer> _customers; //Records of Customers - Key is the customer ID and Value is the Customer Object
        Dictionary<string, Transaction> _transactions; //Records of Transactions - Key is transaction ID and Value is the Transaction Object

        private static Record theInstance = null;
        private Record() {
            _customers = new Dictionary<string, Customer>();
            _transactions = new Dictionary<string, Transaction>();
        }

        public static Record getInstance()
        { //Assures only one instance of the Record class exists
            if (theInstance == null)        //If there is no Record instance 
                theInstance = new Record(); //instantiate here, otherwise do nothing

            return theInstance;
        }

        public Dictionary<string, Customer> customers { get { return _customers; } }
        public Dictionary<string, Transaction> transactions { get { return _transactions; } }

        public void add(Customer customer)
        { //Add customer to records (_customers dictionary [Key: customer ID | Value: customer object])
            if (!_customers.ContainsKey(customer.customer_id)) 
                _customers.Add(customer.customer_id, customer);
        }
        public void add(Transaction transaction)
        { //Add transaction to records (_transaction dictionary [Key: transaction ID | Value: transaction object])
            if (!transactions.ContainsKey(transaction.trans_id)) // Check if transaction already exists in the dictionary
               _transactions.Add(transaction.trans_id, transaction); 
        }

        public void delete(Customer customer)
        {
            _customers.Remove(customer.customer_id);
        }
        public void delete(Transaction transaction)
        {
            _transactions.Remove(transaction.trans_id);
        }
    }
}
