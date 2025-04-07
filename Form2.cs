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
    public partial class Form2 : Form
    {
        public Form2()
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
                txtStudentPass.PasswordChar = '\0';
            }
            else
            {
                txtStudentPass.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text == "123456" && txtStudentPass.Text == "123456")
            {
                Form4 Form4 = new Form4();
                Form4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Student ID or Password is Incorrect!");
                txtStudentID.Clear();
                txtStudentPass.Clear();
                chkShowPass.Checked = false;
            }
        }

    }
}
