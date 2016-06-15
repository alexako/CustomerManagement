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

            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

            loadCombobox();
            loadMenu();
        }

        public AddNewCustomer AddNewCustomer { get { return newCustForm; } }
        public Transaction Transaction { get { return transaction; } }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                newCustForm = new AddNewCustomer();
                newCustForm.ShowDialog();
                comboBox1.SelectedIndex = comboBox1.Items.Count-1;
                loadCombobox();
            }
            else
            {
                string selected_customer = comboBox1.SelectedItem.ToString();
                int start = selected_customer.IndexOf("C");
                customer_id = selected_customer.Substring(start);
            }
        }

        void loadCombobox()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Add new customer...");
            //load items into combobox
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
            transaction = new Transaction(customer_id);
            Dictionary<string, int> temp = new Dictionary<string, int>();
            foreach (Object item in shoppingCart.Items)
            {
                if (!temp.ContainsKey(item.ToString()))
                    temp[item.ToString()] = 1;
                else
                    temp[item.ToString()] += 1;
            }

            foreach (var item in temp) 
                transaction.shopping_cart.Add(item.Key, item.Value);

            if(!records.transactions.ContainsKey(transaction.trans_id))
                records.transactions.Add(transaction.trans_id, transaction);

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
