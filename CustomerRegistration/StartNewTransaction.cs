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

        public StartNewTransaction()
        {
            InitializeComponent();
            records = Record.getInstance();

            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

            loadCombobox();
        }

        public AddNewCustomer AddNewCustomer { get { return newCustForm; } }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                newCustForm = new AddNewCustomer();
                newCustForm.ShowDialog();

                loadCombobox();
            }
        }

        void loadCombobox()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Add new customer...");
            //load items into combobox
            foreach (var customer in records.customers)
                comboBox1.Items.Add(customer.last_name + ", " + customer.first_name + ": " + customer.customer_id);
        }
    }
}
