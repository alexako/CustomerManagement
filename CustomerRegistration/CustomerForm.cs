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
        { //Check if customer exists
            addCustToRecords();
            this.Close(); 
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        void addCustToRecords()
        {
            //Call checkifNameExists() here
            //if true: ask user if they want to use customer already in record
            //    if yes: return/exit do nothing stop here
            //    if no: continue 
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

        void checkifNameExists() //Should return a boolean
        {
           foreach(var cust in records.customers)
            {
                if (records.customers.ContainsKey(this.firstName.Text) || records.customers.ContainsKey(this.lastName.Text))
                {
                    string firstName = this.firstName.Text;
                    string lastName = this.lastName.Text;
                    MessageBox.Show("Sorry, this name is already present in the information system, would you like to create a new one?", "Error", MessageBoxButtons.YesNo);
                    if (DialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show("Please input a new name"); //Nowhere to input new name
                        if (firstName != this.firstName.Text || lastName != this.lastName.Text)
                        { //TODO: Does not prevent another name conflict
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
                            this.country.Text)));
                        }
                    }
                    else if (DialogResult == DialogResult.No)
                    { //Easier just to escape and let the calling function finish
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
                         this.country.Text)));
                    }

                    break;
                }

                else
                { //Easier just to escape and let the calling function finish
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
                        this.country.Text)));
                }
            }
        }
    }
}
