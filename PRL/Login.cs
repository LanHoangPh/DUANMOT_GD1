using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PRL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact admin to reset your password.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0'; // Show password
            }
            else
            {
                textBox2.PasswordChar = '*'; // Hide password
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                // Logic for verifying CAPTCHA (if any)
            }
            else
            {
                MessageBox.Show("Bạn cần xác minh không phải là robot");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
