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
    public partial class StartNewTransaction : Form
    {
        Record records;
        AddNewCustomer newCustForm;
        Transaction transaction;
        string customer_id;

        public StartNewTransaction()
        {
            InitializeComponent();
            records = Record.getInstance();

            //Autocomplete for customer selection
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

            loadCombobox(); //Load the customers from records
            loadMenu(); //Load menu items into the ListBox
        }

        public AddNewCustomer AddNewCustomer { get { return newCustForm; } }
        public Transaction Transaction { get { return transaction; } }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) //If 'Add new customer...' is selected,
            {                                 //open 'Add new customer' dialog
                newCustForm = new AddNewCustomer();
                newCustForm.ShowDialog();
                comboBox1.SelectedIndex = comboBox1.Items.Count-1;
                loadCombobox();
            }
            else //Get the customer selected 
            {
                string selected_customer = comboBox1.SelectedItem.ToString();
                int start = selected_customer.IndexOf("C");
                customer_id = selected_customer.Substring(start);
            }
        }

        void loadCombobox()
        {
            comboBox1.Items.Clear(); //Avoid duplicate entries and start clean
            comboBox1.Items.Add("Add new customer...");
            foreach (var customer in records.customers) 
                comboBox1.Items.Add(customer.Value.last_name + ", " + customer.Value.first_name + ": " + customer.Value.customer_id);
        }

        void loadMenu()
        {
            shoppingMenu.Items.Add("Burrito");
            shoppingMenu.Items.Add("Nachos");
            shoppingMenu.Items.Add("Enchilada");
            shoppingMenu.Items.Add("Quesadilla");
            shoppingMenu.Items.Add("Fish Taco");
            shoppingMenu.Items.Add("Shrimp Taco");
            shoppingMenu.Items.Add("Taco");
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            transaction = new Transaction(customer_id); // Instantiate a new transaction
            Dictionary<string, int> temp = new Dictionary<string, int>(); //Create a temp dictionary to hold current shopping cart
            foreach (Object item in shoppingCart.Items) // <--- shoppingCart is the ListView
            {
                if (!temp.ContainsKey(item.ToString())) //If item is not already in temp dictionary,
                    temp[item.ToString()] = 1;          //initialize item with quantity of 1
                else //Increment if item is already in the dictionary
                    temp[item.ToString()] += 1;
            }

            //Copy current shopping cart (temp dictionary) to transaction.shopping_cart
            foreach (var item in temp) 
                transaction.shopping_cart.Add(item.Key, item.Value);

            //Add transaction to records
            if (!records.transactions.ContainsKey(transaction.trans_id)) //If records doesn't have a transaction with the same ID
                records.add(transaction);
            else
                MessageBox.Show("Transaction not copmleted because there was a key conflict.");

            this.Close();
        }

        private void addItemToCart_Click(object sender, EventArgs e)
        {
            shoppingCart.Items.Add(shoppingMenu.SelectedItem);
        }

        private void removeItemFromCart_Click(object sender, EventArgs e)
        {
            shoppingCart.Items.Remove(shoppingCart.SelectedItem);
        }

        private void clearCart_Click(object sender, EventArgs e)
        {
            shoppingCart.Items.Clear();
        }
    }
}
