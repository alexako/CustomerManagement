using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerRegistration
{
    public partial class Menu : Form
    {
        Record records;
        AddNewCustomer newCustForm;
        StartNewTransaction newTransForm;

        public Menu()
        {
            InitializeComponent();
            records = Record.getInstance();

            //Create fake customers
            records.add(new Customer("Alex", "Reyes", "fake@email.com", "555-555-5555", new Address("2134", "fake street", "Makati", "MetroManila", "Philippines")));
            records.add(new Customer("aefa", "fefj", "fake@email.com", "555-555-5555", new Address("2134", "fake street", "Makati", "MetroManila", "Philippines")));
            records.add(new Customer("gggggg", "eflai", "fake@email.com", "555-555-5555", new Address("2134", "fake street", "Makati", "MetroManila", "Philippines")));
            records.add(new Customer("eifjd", "dfjaiyes", "fake@email.com", "555-555-5555", new Address("2134", "fake street", "Makati", "MetroManila", "Philippines")));
            records.add(new Customer("ogpdkr", "Res", "fake@email.com", "555-555-5555", new Address("2134", "fake street", "Makati", "MetroManila", "Philippines")));
            records.add(new Customer("a;;ei", "Rfel", "fake@email.com", "555-555-5555", new Address("2134", "fake street", "Makati", "MetroManila", "Philippines")));
            records.add(new Customer("aegfglk", "edfeiyes", "fake@email.com", "555-555-5555", new Address("2134", "fake street", "Makati", "MetroManila", "Philippines")));

            //Load the ListViews
            loadCustomerList();
            loadTransactionList();
        }

        public Record Records { get { return records; } }
        public AddNewCustomer NewCustomerForm { get { return newCustForm; } }
        public StartNewTransaction StartNewTransaction { get { return newTransForm; } }

        //File -> Add new Customer
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCustomer();
        }

        //File -> Add new Transaction
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addTransaction();
        }

        //File -> Exit
        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Button - Start Transaction
        private void startNewTrans_Click(object sender, EventArgs e)
        {
            addTransaction();
        }

        //Button - Add new Customer
        private void addNewCustomer_Click(object sender, EventArgs e)
        {
            addCustomer();
        }

        void addCustomer() //Form
        {
            newCustForm = new AddNewCustomer();
            newCustForm.ShowDialog();
            loadCustomerList();
            loadTransactionList();
        }
        void addTransaction() //Form
        {
            newTransForm = new StartNewTransaction();
            newTransForm.ShowDialog();
            loadCustomerList();
            loadTransactionList();
        }


        //Load or Reload customers into ListView (customersList)
        void loadCustomerList()
        {
            customersList.Items.Clear();
            foreach (var customer in records.customers)
            {
                string[] row =
                {
                    customer.Value.customer_id,
                    customer.Value.last_name,
                    customer.Value.first_name,
                    customer.Value.email,
                    customer.Value.phone_number,
                    customer.Value.Address.city
                };
                ListViewItem itemToAdd = new ListViewItem(row);
                bool alreadyExists = false;
                foreach (ListViewItem item in customersList.Items)
                {
                    if (item == itemToAdd)
                        alreadyExists = true;
                }
                if (!alreadyExists)
                    customersList.Items.Add(itemToAdd);
            }
            custNumVal.Text = records.customer_count.ToString();
        }

        //Load or Reload transactions into listview (transListView)
        void loadTransactionList()
        {
            transListView.Items.Clear();
            foreach (var transaction in records.transactions)
            {
                string cust_id = transaction.Key.Substring(transaction.Key.IndexOf("C"));
                string customer_name = records.customers[cust_id].last_name + ", " + records.customers[cust_id].first_name;
                string[] row = { transaction.Key, customer_name, transaction.Value.date_of_trans};
                ListViewItem itemToAdd = new ListViewItem(row);
                transListView.Items.Add(itemToAdd);
            }
            transNumVal.Text = records.transaction_count.ToString();
        }
    }
}
