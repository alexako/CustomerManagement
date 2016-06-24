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
using CustomerRecords;

namespace CustomerManagement
{
    public partial class Menu : Form
    {
        RequestHandler request;
        CustomerForm newCustForm;
        TransactionForm newTransForm;
        EditForm viewEditForm;

        public Menu()
        {
            InitializeComponent();
            request = new RequestHandler();

            //Initialize with default records
            request.addCustomerToRecords(new Customer("Sydney", "Adalin", "", "sydney@email.com", "555-551-5555", new Address(randomAddr(), "Cool street", randomCity(), "MetroManila", "Philippines")));
            Thread.Sleep(1001);
            request.addCustomerToRecords(new Customer("Li", "Cuña", "", "li@email.com", "555-552-5555", new Address(randomAddr(), "Awesome street", randomCity(), "MetroManila", "Philippines")));
            Thread.Sleep(1001);
            request.addCustomerToRecords(new Customer("Mira", "Dela Cruz", "", "mira@email.com", "553-555-5555", new Address(randomAddr(), "Groovy street", randomCity(), "MetroManila", "Philippines")));
            Thread.Sleep(1001);
            request.addCustomerToRecords(new Customer("Alex", "Reyes", "", "alex@email.com", "555-554-5555", new Address(randomAddr(), "American street", randomCity(), "MetroManila", "Philippines")));
            Thread.Sleep(1001);
            request.addCustomerToRecords(new Customer("Bea", "Vallespin", "", "bea@email.com", "555-555-5555", new Address(randomAddr(), "fake street", randomCity(), "MetroManila", "Philippines")));


            //Load the ListViews
            loadCustomerList();
            loadTransactionList();
        }

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
            Application.Exit();
        }

        //Options -> Edit Record entry -> Customer
        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editCustomer(null);
        }

        //File -> Help -> About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CS129L Final Project");
        }

        //Help -> Generate -> Customers
        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            for (int i = 0; i<21; i++)
            {
                request.addCustomerToRecords(new Customer(randomString(),
                    randomString(), randomLetter(), randomString() + "@" + randomString() + ".com",
                    randomPhone(),
                    new Address(randomAddr(), randomString() + " street", randomCity(), "MetroManila", "Philippines")));
                Thread.Sleep(1001);
            }

            loadCustomerList();
            Cursor.Current = Cursors.Default;
        }
        Random random = new Random();
        private string randomLetter()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            return capitalize(new string(Enumerable.Repeat(chars, 1)
              .Select(s => s[random.Next(s.Length)]).ToArray()));
        }
        private string randomString()
        { //Return a random string of characters
            const string chars = "abcdefghijklmnopqrstuvwxyz";
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
        private string randomAddr()
        { //Return random address number
            string n = "";
            var random = new Random();
            for (int i = 0; i < 4; i++)
                n += random.Next(1, 9).ToString();
            return n;
        }

        //Help -> Generate -> Transactions
        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Random random = new Random();
            int index;
            string[] menu_option = { "Taco", "Burrito", "Enchilada", "Quesadilla", "Fish Taco", "Shrimp Taco", "Nachos" };
            if (request.GetCustomerList.Count == 0)
            {
                MessageBox.Show("No customers found in record. Add customers to the records or generate a list from the 'Help' menu.");
                return; //Exit before generating customers
            }

            foreach (var customer in request.GetCustomerList)
            {
                //loop 1: Create random number of tranactions (1-4 transactions)
                for (int i = 0; i < random.Next(1, 4); i++)
                {
                    Transaction transaction = request.createNewTransaction(customer.Key);
                    index = random.Next(0, menu_option.Length - 1);
                    //loop 2: Add random number of items (1-4 items)
                    for(int j = 0; j < random.Next(1, 4); j++)
                        transaction.shopping_cart[menu_option[index]] = random.Next(1, 4);

                    request.addTransactiontoRecord(transaction);
                    Thread.Sleep(1001);
                }
            }
            loadTransactionList();
            Cursor.Current = Cursors.Default;
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

        //Double click on customer -> Open edit form
        private void customersList_DoubleClick(object sender, EventArgs e)
        {
            string selection = customersList.SelectedItem.ToString().Split('{', '}')[1];
            if (selection != null)
                editCustomer(selection);
        }

        //Double click on transaction -> Open edit form
        private void transListView_DoubleClick(object sender, EventArgs e)
        {
            string selection = transListView.SelectedItem.ToString().Split('{', '}')[1];
            if (selection != null)
                editCustomer(selection.Substring(selection.IndexOf("C")));
        }

        void addCustomer() //Form
        {
            newCustForm = new CustomerForm();
            newCustForm.ShowDialog();
            loadCustomerList();
            loadTransactionList();
        }
        
        void editCustomer(string customer_id) //Form
        {
            //Check if a customer or transaction is selected from OLV
            viewEditForm = new EditForm(customer_id);
            viewEditForm.ShowDialog();
            loadCustomerList();
            loadTransactionList();
        }

        void addTransaction() //Form
        {
            string selection;
            //Check if a customer is selected from OLV
            try { selection = customersList.SelectedItem.ToString().Split('{', '}')[1]; }
            catch { selection = null; }
            newTransForm = new TransactionForm();
            newTransForm.ShowDialog();
            loadCustomerList();
            loadTransactionList();
        }

        //Load or Reload customers into ListView (customersList)
        void loadCustomerList()
        {
            customersList.Items.Clear();
            List<CustomerOLVLoader> itemsToAdd = new List<CustomerOLVLoader>();
            foreach (var customer in request.GetCustomerList)
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
            custNumVal.Text = request.GetCustomerList.Count.ToString();
        }

        //Load or Reload transactions into listview (transListView)
        void loadTransactionList()
        {
            transListView.Items.Clear();
            List<TransactionOLVLoader> itemToAdd = new List<TransactionOLVLoader>();
            foreach (var transaction in request.GetTransactionsList)
            {
                string cust_id = transaction.Key.Substring(transaction.Key.IndexOf("C")); //Get customer ID from transaction ID
                string customer_name = request.getCustomer(cust_id).last_name + ", " + request.getCustomer(cust_id).first_name;
                itemToAdd.Add(new TransactionOLVLoader(
                    transaction.Value.trans_id,
                    customer_name,
                    transaction.Value.date_of_trans
                ));
            }
            this.transListView.SetObjects(itemToAdd);
            //Update transactions count
            transNumVal.Text = request.GetTransactionsList.Count.ToString();
        }

        //Object ListView loader
        class CustomerOLVLoader
        {
            /// <summary>
            /// An ObjectListView must be loaded with objects.
            /// This class is for the customer object.
            /// </summary>
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

        //Object ListView loader
        class TransactionOLVLoader
        {
            /// <summary>
            /// An ObjectListView must be loaded with objects.
            /// This class is for the transaction object.
            /// </summary>
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

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadCustomerList();
            loadTransactionList();
        }
    }
}
