using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool isDotUsed = false;
        bool isOperator(char c)
        {
            if (c == '+' || c == '-' || c == 'x' || c == '/')
                return true;
            return false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (lbl_query.Text == "0")
                lbl_query.Text = "";
            lbl_query.Text += '1';
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lbl_query.Text == "0")
                lbl_query.Text = "";
            lbl_query.Text += '2';
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lbl_query.Text == "0")
                lbl_query.Text = "";
            lbl_query.Text += '3';
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lbl_query.Text == "0")
                lbl_query.Text = "";
            lbl_query.Text += '4';
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lbl_query.Text == "0")
                lbl_query.Text = "";
            lbl_query.Text += '5';
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lbl_query.Text == "0")
                lbl_query.Text = "";
            lbl_query.Text += '6';
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lbl_query.Text == "0")
                lbl_query.Text = "";
            lbl_query.Text += '7';
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lbl_query.Text == "0")
                lbl_query.Text = "";
            lbl_query.Text += '8';
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lbl_query.Text == "0")
                lbl_query.Text = "";
            lbl_query.Text += '9';
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lbl_query.Text != "0")
                lbl_query.Text += "0";
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            if (!isDotUsed)
            {
                isDotUsed = true;
                lbl_query.Text += '.';
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int length = lbl_query.Text.Length;
            char lastChar = lbl_query.Text[length - 1];
            if (isOperator(lastChar))
                lbl_query.Text = lbl_query.Text.Remove(length-1,1);

            lbl_query.Text += '+';
            isDotUsed = false;
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            int length = lbl_query.Text.Length;
            char lastChar = lbl_query.Text[length - 1];
            if (isOperator(lastChar))
                lbl_query.Text = lbl_query.Text.Remove(length - 1, 1);

            lbl_query.Text += '-';
            isDotUsed = false;

        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            int length = lbl_query.Text.Length;
            char lastChar = lbl_query.Text[length - 1];
            if (isOperator(lastChar))
                lbl_query.Text = lbl_query.Text.Remove(length - 1, 1);

            lbl_query.Text += 'x';
            isDotUsed = false;

        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            int length = lbl_query.Text.Length;
            char lastChar = lbl_query.Text[length - 1];
            if (isOperator(lastChar))
                lbl_query.Text = lbl_query.Text.Remove(length - 1, 1);

            lbl_query.Text += '/';
            isDotUsed = false;

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            lbl_query.Text = "0";
            isDotUsed = false;
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            int length = lbl_query.Text.Length;
            char lastChar = lbl_query.Text[length - 1];
            if (!isOperator(lastChar))
            {
                DataTable dt = new DataTable();
                string query = lbl_query.Text.Replace('x','*');
                lbl_query.Text = dt.Compute(query,"").ToString();
            }
        }
    }
}
