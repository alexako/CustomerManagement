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
