using CustomerRecords;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerManagement
{
    public partial class TransactionForm : Form
    {
        RequestHandler request;
        CustomerForm newCustForm;
        string customer_id;

        public TransactionForm()
        {
            InitializeComponent();
            request = new RequestHandler();

            //Autocomplete for customer selection
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

            //If customer was selected in OLV
            //if (custID != null) customer_id = custID;

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
                if (selected_customer == null ) return; //Just exit/do nothing if selected customer if null
                string[] selection = selected_customer.Split(' ');
                int start = selection[selection.Length-1].IndexOf("C");
                customer_id = selection[selection.Length-1].Substring(start);

            }
            refresh();
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
            List<ShoppingMenuOLVLoader> itemToAdd = new List<ShoppingMenuOLVLoader>();
            foreach (var item in request.GetShoppingMenu)
            {
                itemToAdd.Add(new ShoppingMenuOLVLoader(
                    item.Key, item.Value.ToString()
                ));
            }
            this.shoppingMenu.SetObjects(itemToAdd);
        }

        void refresh()
        {
            total.Text = formatToPHCurrency(getTotal());
            checkoutButton.Enabled = (comboBox1.SelectedIndex > 0 || comboBox1.SelectedItem != null) && shoppingCart.Items.Count > 0;
        }

        double getTotal()
        {
            double total = 0;
            foreach (var item in shoppingCart.Items)
                total += request.GetShoppingMenu[item.ToString()];
            return total;
        }

        string formatToPHCurrency(double amount)
        {
            return amount.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-PH"));
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            Transaction transaction = request.createNewTransaction(customer_id); // Instantiate a new transaction
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
            {
                request.addTransactiontoRecord(transaction);
                MessageBox.Show("Transaction Complete!");
            }
            else
                MessageBox.Show("Transaction not copmleted because there was a key conflict.");

            this.Close();
        }

        private void addItemToCart_Click(object sender, EventArgs e)
        {
            foreach (var item in shoppingMenu.SelectedItems)
                shoppingCart.Items.Add(item.ToString().Split('{', '}')[1]);

            refresh();
        }

        private void removeItemFromCart_Click(object sender, EventArgs e)
        {
            try { shoppingCart.Items.Remove(shoppingCart.SelectedItem); }
            catch { } //Do nothing
            refresh();
        }

        private void clearShoppingCart_Click(object sender, EventArgs e)
        {
            shoppingCart.Items.Clear();
            refresh();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Object ListView loader
        class ShoppingMenuOLVLoader
        {
            /// <summary>
            /// An ObjectListView must be loaded with objects.
            /// </summary>
            public string Item{ get; set; }
            public string Price { get; set; }

            public ShoppingMenuOLVLoader(string menuItem, string price)
            {
                Item = menuItem;
                Price = price;
            }
        }

    }
}
