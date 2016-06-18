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
        string selection; //Currently selected customer in OLV

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
            editCustomer(selection);
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
                records.add(new Customer(randomString(), randomString(), randomString() + "@" + randomString() + ".com", randomPhone(), new Address("2134", "fake street", randomCity(), "MetroManila", "Philippines")));
                Thread.Sleep(1001);
            }

            loadCustomerList();
        }
        private string randomString()
        { //Return a random string of characters
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            var random = new Random();
            return capitalize(new string(Enumerable.Repeat(chars, 5)
              .Select(s => s[random.Next(s.Length)]).ToArray()));
        }
        private string capitalize(string input) { return input.First().ToString().ToUpper() + input.Substring(1); }
        private string randomCity()
        { //Return a random city
            string[] city = { "Manila", "Quezon City", "Ortigas", "Mandaluyong", "Rizal", "Pasig" };
            var random = new Random();
            return city[random.Next(0, city.Length)];
        }
        private string randomPhone()
        { //Return random phone number
            string n = "";
            var random = new Random();
            for (int i = 0; i<10; i++)
            {
                n += random.Next(0, 9).ToString();
                if (i == 2) n += "-";
                if (i == 5) n += "-";
            }
            return n;
        }

        //Help -> Generate -> Transactions
        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int index;
            string[] menu_option = { "Taco", "Burrito", "Enchilada", "Quesadilla", "Fish Taco", "Shrimp Taco", "Nachos" };
            if (records.customers.Count == 0)
            {
                MessageBox.Show("No customers found in record. Add customers to the records or generate a list from the 'Help' menu.");
                return; //Exit before generating customers
            }

            foreach (var customer in records.customers)
            {
                //loop 1 to create random number of tranactions
                for (int i = 0; i < random.Next(1, 4); i++)
                {
                    Transaction transaction = new Transaction(customer.Key);
                    index = random.Next(0, menu_option.Length - 1);
                    //loop 2 to add random number of items
                    for(int j = 0; j < random.Next(1, 4); j++)
                        transaction.shopping_cart[menu_option[index]] = random.Next(1, 4);

                    records.add(transaction);
                    Thread.Sleep(1001);
                }
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
            editCustomer(selection);
        }

        void addCustomer() //Form
        {
            newCustForm = new CustomerForm();
            newCustForm.ShowDialog();
            loadCustomerList();
            loadTransactionList();
        }
        
        void editCustomer(string selection)
        { //TODO: Get selected customer from OLV
            selection = customersList.SelectedItem.ToString().Split('{', '}')[1];
            viewEditForm = new viewEdit(selection);
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
            List<CustomerOLVLoader> itemsToAdd = new List<CustomerOLVLoader>();
            foreach (var customer in records.customers)
            {
                itemsToAdd.Add(new CustomerOLVLoader(
                    customer.Value.customer_id,
                    customer.Value.last_name,
                    customer.Value.first_name,
                    customer.Value.email,
                    customer.Value.phone_number,
                    customer.Value.Address.city
                ));
            }
            this.customersList.SetObjects(itemsToAdd);
            //Update customer count
            custNumVal.Text = records.customer_count.ToString(); 
        }

        //Load or Reload transactions into listview (transListView)
        void loadTransactionList()
        {
            transListView.Items.Clear();
            List<TransactionOLVLoader> itemToAdd = new List<TransactionOLVLoader>();
            foreach (var transaction in records.transactions)
            {
                string cust_id = transaction.Key.Substring(transaction.Key.IndexOf("C"));
                string customer_name = records.customers[cust_id].last_name + ", " + records.customers[cust_id].first_name;
                itemToAdd.Add(new TransactionOLVLoader(
                    transaction.Value.trans_id,
                    customer_name,
                    transaction.Value.date_of_trans
                ));
            }
            this.transListView.SetObjects(itemToAdd);
            //Update transactions count
            transNumVal.Text = records.transaction_count.ToString();
        }

        class CustomerOLVLoader
        {
            public string CustomerID { get; set; }
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string City { get; set; }

            public CustomerOLVLoader (string custID, string lastname, string firstname, string email, string phone, string city)
            {
                CustomerID = custID;
                LastName = lastname;
                FirstName = firstname;
                Email = email;
                Phone = phone;
                City = city;
            }
        }

        class TransactionOLVLoader
        {
            public string TransactionID { get; set; }
            public string Customer { get; set; }
            public string Date { get; set; }

            public TransactionOLVLoader (string transID, string custName, string date)
            {
                TransactionID = transID;
                Customer = custName;
                Date = date;
            }
        }
    }
}
