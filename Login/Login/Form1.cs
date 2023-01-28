using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void signIn() {
            String user = "nishita";
            String pass = "roy";
            MessageBox.Show("Welcome");
        }

        private void btn_sign_in_Click(object sender, EventArgs e)
        {
            signIn();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_username_Validating(object sender, CancelEventArgs e)
        {
            if (txt_username.Text == "")
            {
                MessageBox.Show("Username can't be empty.");
                txt_username.Focus();
            }
        }

        private void txt_password_Validating(object sender, CancelEventArgs e)
        {
            if (txt_password.Text == "")
            {
                MessageBox.Show("Password can't be empty.");
                txt_password.Focus();
            }
        }

        private void txt_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                signIn();
            }
        }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && txt_password.Text != "")
            {
                signIn();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {

        }

    }
}
