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
    public partial class CustomerForm : Form
    {
        Record records;

        public CustomerForm()
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

        void addCustToRecords()
        {
            CustomerForm f = new CustomerForm();
            if (checkifNameExists()) { f.ShowDialog(); return; } //Return to new CustomerForm 
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

        bool checkifNameExists()
        {
           foreach(var cust in records.customers)
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
    }
}
