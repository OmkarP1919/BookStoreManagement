using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Book_Store_Management_System
{
    public partial class users_screen : Form
    {
        string cs = "";
        MySqlConnection c1;
        MySqlDataReader dr;
        MySqlCommand cmd;
        string username = "",address="",password="";
        long mobile;
        public users_screen()
        {
            InitializeComponent();
        }
        private void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Screen asc=new Admin_Screen();
            asc.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged Out Successfully...");
            Admin_Login al = new Admin_Login();
            al.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dashboard d1 = new dashboard();
            d1.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cs = "Server=localhost;Database=bsms;uid=root;pwd=root";
            c1 = new MySqlConnection(cs);
            username = textBox1.Text;
            mobile = Convert.ToInt64(textBox2.Text);
            password = textBox4.Text;
            address = textBox3.Text;

            c1.Open();
            try
            {
                string q = "insert into users values('" + username + "'," + mobile + ",'" + address + "','" + password + "')";
                cmd = new MySqlCommand(q, c1);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Added Successfully");
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Saving Exception:\n" + ex);
            }
            finally
            {
                c1.Close();
            }
        }

        private void users_screen_Load(object sender, EventArgs e)
        {
            cs = "Server=localhost;Database=bsms;uid=root;pwd=root";
            c1 = new MySqlConnection(cs);
            //MessageBox.Show("database connected successfully..");
            c1.Open();
            string q = "Select * from users";
            cmd = new MySqlCommand(q, c1);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            c1.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cs = "Server=localhost;Database=bsms;uid=root;pwd=root";
            c1 = new MySqlConnection(cs);
            username = textBox1.Text;
            mobile = Convert.ToInt64(textBox2.Text);
            password = textBox4.Text;
            address = textBox3.Text;

            c1.Open();
            try
            {
                string q = "Update users set mobile=" + mobile + ",address='" + address + "',password='" + password + "'"; 
                cmd = new MySqlCommand(q, c1);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Updated Successfully");
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Updating Exception:\n" + ex);
            }
            finally
            {
                c1.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cs = "Server=localhost;Database=bsms;uid=root;pwd=root";
            c1 = new MySqlConnection(cs);
            username = textBox1.Text;
            c1.Open();
            try
            {
                string q = "delete from users where username='" + username + "'";
                cmd = new MySqlCommand(q, c1);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Deleted Successfully");
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deletion Exception:\n" + ex);
            }
            finally
            {
                c1.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cs = "Server=localhost;Database=bsms;uid=root;pwd=root";
            c1 = new MySqlConnection(cs);
            //MessageBox.Show("database connected successfully..");
            c1.Open();
            string q = "Select * from users";
            cmd = new MySqlCommand(q, c1);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            c1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
}
