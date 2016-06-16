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
            // Gets input from the form
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
