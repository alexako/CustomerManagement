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
    public partial class TransactionForm : Form
    {
        RequestHandler request;
        CustomerForm newCustForm;
        string customer_id; 

        public TransactionForm(string custID = null)
        {
            InitializeComponent();
            request = new RequestHandler();

            //Autocomplete for customer selection
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

            //If customer was selected in OLV
            if (custID != null) customer_id = custID;

            loadCombobox(); //Load the customers from records
            loadMenu(); //Load menu items into the ListBox
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) //If 'Add new customer...' is selected,
            {                                 //open 'Add new customer' dialog
                newCustForm = new CustomerForm();
                newCustForm.ShowDialog();
                loadCombobox();
                comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
            }
            else //Get the customer selected 
            {
                string selected_customer = comboBox1.SelectedItem.ToString();
                int start = selected_customer.IndexOf("C");
                customer_id = selected_customer.Substring(start);
            }
            checkFormIsValid(); 
        }

        void loadCombobox()
        {
            comboBox1.Items.Clear(); //Avoid duplicate entries and start clean
            comboBox1.Items.Add("Add new customer...");
            foreach (var customer in request.GetCustomerList) 
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
        
        void checkFormIsValid()
        {
            checkoutButton.Enabled = comboBox1.SelectedIndex > 0 && shoppingCart.Items.Count > 0;
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction(customer_id); // Instantiate a new transaction
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
            if (!request.GetTransactionsList.ContainsKey(transaction.trans_id)) //If records doesn't have a transaction with the same ID
                request.addTransactiontoRecord(transaction);
            else
                MessageBox.Show("Transaction not copmleted because there was a key conflict.");

            this.Close();
        }

        private void addItemToCart_Click(object sender, EventArgs e)
        {
            try { shoppingCart.Items.Add(shoppingMenu.SelectedItem); }
            catch { } //Do nothing
            checkFormIsValid();
        }

        private void removeItemFromCart_Click(object sender, EventArgs e)
        {
            try { shoppingCart.Items.Remove(shoppingCart.SelectedItem); }
            catch { } //Do nothing
            checkFormIsValid();
        }

        private void clearCart_Click(object sender, EventArgs e)
        {
            try { shoppingCart.Items.Clear(); }
            catch { } //Do nothing
            checkFormIsValid(); 
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
