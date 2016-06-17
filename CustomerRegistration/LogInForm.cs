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
    public partial class LogInForm : Form
    {
        Dictionary<string, string> admins;
        public LogInForm()
        {
            InitializeComponent();
            panel10.Hide();
            Sorry.Hide();
            panel14.Hide();
            this.pass.PasswordChar = '\u25CF';

            //panel10 flash
            //panel11 user flash
            //panel14 pass flash

            //Declare Admins
            admins = new Dictionary<string, string>();
            admins.Add("bepvallespin", "bev");
            admins.Add("admin", "password");
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            panel11.Hide();
            panel14.Show();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            panel11.Show();
            panel14.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void username_MouseClick(object sender, MouseEventArgs e)
        {
            panel11.Show();
            panel14.Hide();
        }

        private void pass_MouseClick(object sender, MouseEventArgs e)
        {
            panel11.Hide();
            panel14.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (admins.ContainsKey(username.Text) && admins[username.Text] == pass.Text)
            {
                Menu menu = new Menu();
                Hide();
                menu.Show();
            }
            else
            {
                username.Text = "";
                pass.Text = "";
                panel10.Show();
                Sorry.Show();
            }
        }
    }
}
