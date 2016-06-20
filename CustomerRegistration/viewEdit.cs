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
        RequestHandler request;
        Customer customer;
        ListViewItem selected_transaction;

        public viewEdit(string selected = null)
        {
            InitializeComponent();
            request = new RequestHandler();

            //Autocomplete for customer selection
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

            loadCombobox(); //Load the customers from records

            //If a customer was selected when viewEdit button was pressed, load selected customer
            if (selected != null)
            {
                customer = request.getCustomer(selected);
                loadCustInfo();
                loadTransView();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            custTransView.Items.Clear(); //Clear transactions list
            try
            {
                customer = request.getCustomer(getCustomerID());
                loadCustInfo();
                loadTransView();
            }
            catch { Console.WriteLine("ComboBox in viewEdit: {0}", getCustomerID()); } //Do nothing 
        }

        //Return customer ID from selected item in Combobox
        string getCustomerID()
        {
            string s = comboBox1.SelectedItem.ToString();
            try { return s.Split(' ')[s.Split(' ').Length-1]; }
            catch { return null; }
        }

        //Get specific transaction based on currently select transaction in ListView
        Transaction getTransaction()
        { 
            try { return request.GetTransactionsList[selected_transaction.Text]; }
            catch { return null; }
        }

        void loadTransView()
        {
            foreach (var transaction in request.getTransactions(customer))
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
            foreach (var customer in request.GetCustomerList) 
                comboBox1.Items.Add(customer.Value.last_name + ", " + customer.Value.first_name + ": " + customer.Value.customer_id);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        { //Store new values into customer records
            if (customer == null) return; //Do nothing
            if (checkifNameExists()) return; //Do nothing

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
            //Get Customer from records
            Customer customer = request.getCustomer(transaction.trans_id.Substring(transaction.trans_id.IndexOf("C")));

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

            string customerName = customer.last_name + ", " + customer.first_name;

            //Confirm
            if (!confirmDelete(customerName)) return;

            //Delete customer's transactions from records
            request.deleteTransactions(customer);

            //Delete customer from records
            request.deleteCustomerFromRecords(customer);

            MessageBox.Show(customerName + " has been successfully deleted from the records");
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

        //Return false if name does not already exist in record
        bool checkifNameExists()
        {
           foreach(var cust in request.GetCustomerList)
           {
                if (cust.Value.first_name.Equals(this.firstName.Text) || cust.Value.last_name.Equals(this.lastName.Text))
                {
                    DialogResult result = MessageBox.Show("Sorry, this name is already present in the information system, would you like to create a new one?", "Error", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                        return false;
                    else
                        return true;
                }
            }
            return false;
        }

        //Highlight Effect
        private void groupBox1_Enter(object sender, EventArgs e) { panel4.Show(); }
        private void groupBox1_Leave(object sender, EventArgs e) { panel4.Hide(); }
    }
}
