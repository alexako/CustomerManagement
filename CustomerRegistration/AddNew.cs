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
    public partial class AddNewCustomer : Form
    {
        Record records;

        public AddNewCustomer()
        {
            InitializeComponent();
            records = Record.getInstance();
        }
/*
        public string first_name { get { return this.firstName.Text; } }
        public string last_name { get { return this.lastName.Text; } }
        public string middle_init {  get { return this.middleInitial.Text; } }
        public string email_address { get { return this.email.Text; } }
        public string phone_number { get { return this.phoneNumber.Text; } }

        public string addr1 { get { return this.address1.Text; } }
        public string addr2 { get { return this.address2.Text; } }
        public string City { get { return this.city.Text; } }
        public string Province { get { return this.province.Text; } }
        public string Country { get { return this.country.Text; } }
*/
        private void submitButton_Click(object sender, EventArgs e)
        {
            addCustToRecords();
            this.Close(); 
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        void addCustomer()
        {
            if (DialogResult == DialogResult.OK)
            {
                addCustToRecords();
            }
        }
        void addCustToRecords()
        {
            //TODO: Check if customer not in records
            records.add(new Customer(
                this.firstName.Text,
                this.lastName.Text,
                this.email.Text,
                this.phoneNumber.Text,
                new Address(
                    this.address1.Text,
                    this.address2.Text,
                    this.city.Text,
                    this.province.Text,
                    this.country.Text
                    )
                )
            );
        }
    }
}
