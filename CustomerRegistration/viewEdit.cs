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
    public partial class viewEdit : Form
    {
        Record records;
        Customer customer;
        ListViewItem selected_transaction;

        public viewEdit(string selected = null)
        {
            InitializeComponent();
            records = Record.getInstance();


            //Autocomplete for customer selection
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

            loadCombobox(); //Load the customers from records

            //If a customer was selected when viewEdit button was pressed, load selected customer
            if (selected != null)
            {
                customer = getCustomer(selected);
                loadCustInfo();
                loadTransView();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            custTransView.Items.Clear(); //Clear transactions list
            string customerID = comboBox1.SelectedItem.ToString().Substring(comboBox1.SelectedItem.ToString().IndexOf("C")); ;
            customer = getCustomer(customerID);
            loadTransView();
            loadCustInfo();
        }

        Customer getCustomer(string customerID)
        {
            foreach (var customer in records.customers)
            {
                if (customerID == customer.Key)
                    return customer.Value;
            }
            return null;
        }
        
        List<Transaction> getTransactions(Customer customer)
        { //Get list of transactions related to customer
            List<Transaction> transactions = new List<Transaction>();
            foreach (var transaction in records.transactions)
            {
                if (transaction.Key.Contains(customer.customer_id))
                    transactions.Add(transaction.Value);
            }
            return transactions;
        }

        Transaction getTransaction()
        { //Get specific transaction based on currently select transaction in ListView
            try { return records.transactions[selected_transaction.Text]; }
            catch { return null; }
        }

        void loadTransView()
        {
            foreach (var transaction in getTransactions(customer))
            {
                string[] row = { transaction.trans_id, customer.last_name + ", " + customer.first_name, transaction.date_of_trans };
                ListViewItem itemToAdd = new ListViewItem(row);
                custTransView.Items.Add(itemToAdd);
            }
        }

        void loadCustInfo() //Load customer info into the form
        {
            firstName.Text = customer.first_name;
            lastName.Text = customer.last_name;
            middleInitial.Text = customer.middle_initial;
            email.Text = customer.email;
            phoneNumber.Text = customer.phone_number;
            address1.Text = customer.Address.addr1;
            address2.Text = customer.Address.addr2;
            city.Text = customer.Address.city;
            province.Text = customer.Address.province;
            country.Text = customer.Address.country;
        }

        void loadCombobox()
        { // Load/Refresh customers into combobox
            comboBox1.Items.Clear(); //Avoid duplicate entries and start clean
            foreach (var customer in records.customers) 
                comboBox1.Items.Add(customer.Value.last_name + ", " + customer.Value.first_name + ": " + customer.Value.customer_id);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        { //Store new values into customer records
            if (customer == null) return; //Do nothing
            
            customer.first_name = firstName.Text;
            customer.last_name = lastName.Text;
            customer.middle_initial = middleInitial.Text;
            customer.email = email.Text;
            customer.phone_number = phoneNumber.Text;
            customer.Address.addr1 = address1.Text;
            customer.Address.addr2 = address2.Text;
            customer.Address.city = city.Text;
            customer.Address.province = province.Text;
            customer.Address.country = country.Text;

            MessageBox.Show("Saved Successfully!");
            loadCombobox();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void custTransView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { selected_transaction = custTransView.SelectedItems[0]; }
            catch { selected_transaction = null; }
        }

        private void viewTransBtn_Click(object sender, EventArgs e)
        { //View selected transaction from ListView
            Transaction transaction = getTransaction();
            if (transaction == null) return; //Escape if a transaction is not selected
            Customer customer = records.customers[transaction.trans_id.Substring(transaction.trans_id.IndexOf("C"))]; //Get Customer from records

            //TODO: Make nicer. Perhaps another winform
            //Build transaction details message
            string trans_details = "";
            trans_details += customer.last_name + ", " + customer.first_name + "\n";
            trans_details += "ID: " + transaction.trans_id + "\n";
            trans_details += "DOP: " + transaction.date_of_trans + "\n\n";
            trans_details += "Items sold:\n";
            foreach (var item in transaction.shopping_cart)
                trans_details += item.Key + ": " + item.Value + "\n";

            MessageBox.Show(trans_details);
        }

        private void deleteCustBtn_Click(object sender, EventArgs e)
        {
            if (customer == null) return; //Exit and do nothing

            string customer_id = customer.customer_id;
            string custName = customer.last_name + ", " + customer.first_name;

            //Confirm
            if (!confirmDelete(custName)) return;

            //Delete customer's transactions from records
            deleteTransctions(customer_id);

            //Delete customer from records
            records.customers.Remove(customer_id);

            MessageBox.Show(custName + " has been successfully deleted from the records");
            this.Close();
        }

        bool confirmDelete(string customer_name)
        {
            DialogResult result = MessageBox.Show("Delete " + customer_name+ "?", "Are you sure?", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                MessageBox.Show("Aborted");
                return false; //Do nothing and exit
            }
            return true;
        }

        void deleteTransctions(string customer_id)
        {
            List<Transaction> removals = new List<Transaction>(); //Create temp list of objects for removals
            foreach(var trans in records.transactions)
            {
                if (trans.Key.Contains(customer_id))
                    removals.Add(trans.Value);
            }
            foreach (var trans in removals) //Remove transaction objects from records
                records.transactions.Remove(trans.trans_id);
        }

    }
}
