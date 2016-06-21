using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerManagement
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

            //panel10 fail flash
            //panel11 user flash
            //panel14 pass flash

            //Declare Admins
            admins = new Dictionary<string, string>();
            admins.Add("bepvallespin", "bev");
            admins.Add("admin", "password");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (admins.ContainsKey(username.Text) && admins[username.Text] == pass.Text)
            {
                Menu menu = new Menu();
                Cursor.Current = Cursors.Default;
                Hide();
                menu.Show();
            }
            else
            {
                Cursor.Current = Cursors.Default;
                username.Text = "";
                pass.Text = "";
                panel10.Show();
                Sorry.Show();
            }
        }

        private void pass_Enter(object sender, EventArgs e)
        {
            panel14.Show();
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            panel14.Hide();
        }

        private void username_Enter(object sender, EventArgs e)
        {
            panel11.Show();
        }

        private void username_Leave(object sender, EventArgs e)
        {
            panel11.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
