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

            loadCustomerList();
            loadTransactionList();
        }

        public Transaction Transaction
        {
            get
            {
                return null;
            }
        }

        public Record Records { get { return records; } }

        public AddNewCustomer NewCustomerForm { get { return newCustForm; } }

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

        void addCustomer() //To records
        {
            newCustForm = new AddNewCustomer();
            newCustForm.ShowDialog();
            loadCustomerList();
            loadTransactionList();
        }
        void addTransaction() //To records
        {
            newTransForm = new StartNewTransaction();
            newTransForm.ShowDialog();
            loadCustomerList();
            loadTransactionList();
        }


        //Load customers into listview
        void loadCustomerList()
        {
            customersList.Items.Clear();
            foreach (Customer customer in records.customers)
            {
                string[] row =
                {
                    customer.customer_id,
                    customer.last_name,
                    customer.first_name,
                    customer.email,
                    customer.phone_number,
                    customer.Address.city
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

        //Load transactions into listview
        void loadTransactionList()
        {
            foreach (Transaction transaction in records.transactions)
            {
                string[] row =
                {
                    " "
                };
                ListViewItem item = new ListViewItem(row);
                if (!transListView.Items.Contains(item))
                    transListView.Items.Add(item); 
            }
            transNumVal.Text = records.transaction_count.ToString();
        }
    }
}
