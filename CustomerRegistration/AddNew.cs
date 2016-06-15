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
        public AddNewCustomer()
        {
            InitializeComponent();
        }

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

        private void submitButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }


    }
}
