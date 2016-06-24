using CustomerRecords;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerManagement
{
    public partial class CustomerForm : Form
    {
        RequestHandler request;

        public CustomerForm()
        {
            InitializeComponent();
            request = new RequestHandler();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (firstName.Text == "" || lastName.Text == "" || email.Text == "")
                MessageBox.Show("Name and email address fields are required");
            else
            {
                addCustToRecords();
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        void addCustToRecords()
        {
            CustomerForm f = new CustomerForm();
            if (checkifNameExists()) { f.ShowDialog(); return; } //Return to new CustomerForm 
            request.addCustomerToRecords(new Customer(
                this.firstName.Text,
                this.lastName.Text,
                this.middleInitial.Text,
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
            MessageBox.Show(this.lastName.Text + ", " + this.firstName.Text + " was successfully added to records.");
        }

        bool checkifNameExists()
        {
           foreach(var cust in request.GetCustomerList)
           {
                if (cust.Value.first_name.Equals(this.firstName.Text) || cust.Value.last_name.Equals(this.lastName.Text))
                {
                    DialogResult result = MessageBox.Show("Sorry, " + cust.Value.first_name + " " + cust.Value.last_name
                        + " is already present in the records, would you like to create a new one?", "Error", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                        return false;
                    else
                        return true;
                }
            }
            return false;
        }

        //Error Handling
        private void firstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void lastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsSymbol(e.KeyChar))
                e.Handled = true;
          
        }

        private void middleInitial_KeyPress(object sender, KeyPressEventArgs e)
        {
            middleInitial.MaxLength = 2;

            if (Char.IsNumber(e.KeyChar) || Char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void city_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void province_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void country_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }
    }
}
