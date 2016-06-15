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
    public partial class Menu : Form
    {
        Record records;
        AddNewCustomer newCustForm;

        public Menu()
        {
            InitializeComponent();
            records = Record.getInstance();

            //Create fake customers
            records.add(new Customer("Alex", "Reyes", "fake@email.com", "555-555-5555", new Address("2134", "fake street", "Makati", "MetroManila", "Philippines")));
            records.add(new Customer("aefa", "fefj", "fake@email.com", "555-555-5555", new Address("2134", "fake street", "Makati", "MetroManila", "Philippines")));
            records.add(new Customer("gggggg", "eflai", "fake@email.com", "555-555-5555", new Address("2134", "fake street", "Makati", "MetroManila", "Philippines")));
            records.add(new Customer("eifjd", "dfjaiyes", "fake@email.com", "555-555-5555", new Address("2134", "fake street", "Makati", "MetroManila", "Philippines")));
            records.add(new Customer("ogpdkr", "Res", "fake@email.com", "555-555-5555", new Address("2134", "fake street", "Makati", "MetroManila", "Philippines")));
            records.add(new Customer("a;;ei", "Rfel", "fake@email.com", "555-555-5555", new Address("2134", "fake street", "Makati", "MetroManila", "Philippines")));
            records.add(new Customer("aegfglk", "edfeiyes", "fake@email.com", "555-555-5555", new Address("2134", "fake street", "Makati", "MetroManila", "Philippines")));

            //Load customers into listview
            foreach (Customer customer in records.customers)
            {
                string[] row =
                {
                    customer.customer_id,
                    customer.last_name,
                    customer.first_name,
                    customer.email,
                    customer.phone_number,
                    customer.Address.city
                };
                ListViewItem item = new ListViewItem(row);
                customersList.Items.Add(item);
            }

            custNumVal.Text = records.customer_count.ToString();
            transNumVal.Text = records.customer_count.ToString();
        }

        public Transaction Transaction
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Record Records { get { return records; } }

        public AddNewCustomer NewCustomerForm { get { return newCustForm; } }

        private void addNewCustomer_Click(object sender, EventArgs e)
        {
            addCustomer();
        }

        void addCustomer()
        {
            newCustForm = new AddNewCustomer();
            newCustForm.ShowDialog(this);
            if (DialogResult == DialogResult.OK)
            {
                addCustToRecords();
                addCustToListView();
            }
        }
        void addCustToRecords()
        {
            records.add(new Customer(
                newCustForm.first_name,
                newCustForm.last_name,
                newCustForm.email_address,
                newCustForm.phone_number,
                new Address(
                    newCustForm.addr1,
                    newCustForm.addr2,
                    newCustForm.City,
                    newCustForm.Province,
                    newCustForm.Country
                    )
                )
            );
        }
        void addCustToListView()
        {
            string[] row = {
                records.customers[records.customer_count-1].customer_id,
                records.customers[records.customer_count-1].last_name,
                records.customers[records.customer_count-1].first_name,
                records.customers[records.customer_count-1].email,
                records.customers[records.customer_count-1].phone_number,
                records.customers[records.customer_count-1].Address.city,
                };
            ListViewItem listviewitem = new ListViewItem(row);
            customersList.Items.Add(listviewitem);
            custNumVal.Text = records.customer_count.ToString();
        }

        void addTransToRecords()
        {
        }
        void addTransToListView()
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCustomer();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
