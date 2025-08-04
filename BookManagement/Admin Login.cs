using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Book_Store_Management_System
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            User_Login l1 = new User_Login();
            l1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("root") && textBox2.Text.Equals("root"))
            {
                Admin_Screen ai = new Admin_Screen();
                ai.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Enter correct username/password");
                textBox1.Focus();
            }
        }
    }
}
