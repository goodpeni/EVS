using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Voting_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {
                txtAdminPass.PasswordChar = '\0';
            }
            else
            {
                txtAdminPass.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtAdminID.Text == "root" && txtAdminPass.Text == "admin")
            {
                Form7 Form7 = new Form7();
                Form7.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Admin ID or Password is Incorrect!");
                txtAdminID.Clear();
                txtAdminPass.Clear();
                chkShowPass.Checked = false;
            }
        }
    }
}
