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
    public partial class Tender : Form
    {
        double cart_amount;
        public Tender(double cart_amount)
        {
            InitializeComponent();
            this.cart_amount = cart_amount;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            double change = Convert.ToDouble(amount.Text) - cart_amount;
            if (Convert.ToDouble(amount.Text) >= cart_amount)
            { 
                MessageBox.Show("Change due: " + change);
                this.Close();
            }
            else
                MessageBox.Show("Insufficient amount tendered.");
        }
    }
}
