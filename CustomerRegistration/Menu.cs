using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace CustomerRegistration
{
    public partial class Menu : Form
    {
        Record records;
        CustomerForm newCustForm;
        StartNewTransaction newTransForm;
        viewEdit viewEditForm;

        public Menu()
        {
            InitializeComponent();
            records = Record.getInstance();

            //Load the ListViews
            loadCustomerList();
            loadTransactionList();
        }

        public Record Records { get { return records; } }
        public CustomerForm NewCustomerForm { get { return newCustForm; } }
        public StartNewTransaction StartNewTransaction { get { return newTransForm; } }
        public viewEdit viewEdit { get { return viewEditForm; } }

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

        //Options -> Edit Record entry -> Customer
        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editCustomer();
        }

        //Options -> Edit Record entry -> Transaction
        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Make an edit transaction form
        }

        //File -> Help -> About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("About Page");
        }

        //Help -> Generate -> Customers
        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            records.add(new Customer("Sydney", "Adalin", "sydney@email.com", "555-551-5555", new Address("2134", "Cool street", randomCity(), "MetroManila", "Philippines")));
            Thread.Sleep(1001);
            records.add(new Customer("Li", "Cuña", "li@email.com", "555-552-5555", new Address("2134", "Awesome street", randomCity(), "MetroManila", "Philippines")));
            Thread.Sleep(1001);
            records.add(new Customer("Mira", "Dela Cruz", "mira@email.com", "553-555-5555", new Address("2134", "Groovy street", randomCity(), "MetroManila", "Philippines")));
            Thread.Sleep(1001);
            records.add(new Customer("Alex", "Reyes", "alex@email.com", "555-554-5555", new Address("2134", "American street", randomCity(), "MetroManila", "Philippines")));
            Thread.Sleep(1001);
            records.add(new Customer("Bea", "Vallespin", "bea@email.com", "555-555-5555", new Address("2134", "fake street", randomCity(), "MetroManila", "Philippines")));

            for (int i = 0; i<21; i++)
            {
                records.add(new Customer(randomString(), randomString(), randomString(), "555-" + randomPhone(), new Address("2134", "fake street", randomCity(), "MetroManila", "Philippines")));
                Thread.Sleep(1001);
            }

            loadCustomerList();
        }
        private string randomString()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            var random = new Random();
            return capitalize(new string(Enumerable.Repeat(chars, 5)
              .Select(s => s[random.Next(s.Length)]).ToArray()));
        }
        private string capitalize(string input) { return input.First().ToString().ToUpper() + input.Substring(1); }
        private string randomCity()
        {
            string[] city = { "Manila", "Quezon City", "Ortigas", "Mandaluyong", "Rizal", "Pasig" };
            var random = new Random();
            return city[random.Next(0, city.Length)];
        }
        private string randomPhone()
        {
            string n = "";
            var random = new Random();
            for (int i = 0; i<7; i++)
            {
                n += random.Next(0, 9).ToString();
                if (i == 2)
                    n += "-";
            }
            return n;
        }

        //Help -> Generate -> Transactions
        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int index;
            string[] menu_option = { "Taco", "Burrito", "Enchilada", "Quesadilla", "Fish Taco", "Shrimp Taco", "Nachos" };
            if (records.customers.Count == 0)
            {
                MessageBox.Show("No customers found in record. Add customers to the records or generate a list from the 'Help' menu.");
                return; //Exit before generating customers
            }

            foreach (var customer in records.customers)
            {
                Transaction transaction = new Transaction(customer.Key);
                index = r.Next(0, menu_option.Length-1);
                transaction.shopping_cart[menu_option[index]] = r.Next(1, 4);
                index = r.Next(0, menu_option.Length-1);
                transaction.shopping_cart[menu_option[index]] = r.Next(1, 4);
                records.add(transaction);
                Thread.Sleep(1001);
            }
            loadTransactionList();
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

        private void editCustomerBtn_Click(object sender, EventArgs e)
        { //Load View/Edit form
            editCustomer();
        }

        void addCustomer() //Form
        {
            newCustForm = new CustomerForm();
            newCustForm.ShowDialog();
            loadCustomerList();
            loadTransactionList();
        }
        
        void editCustomer()
        {
            viewEditForm = new viewEdit();
            viewEditForm.ShowDialog();
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
            Console.WriteLine("CustNum: {0}", records.customer_count);
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
            Console.WriteLine("TransNum: {0}", records.transaction_count);
        }
    }
}
