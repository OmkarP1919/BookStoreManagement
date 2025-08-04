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
    public partial class Admin_Screen : Form
    {
        string cs = "";
        MySqlConnection c1;
        MySqlDataReader dr;
        MySqlCommand cmd;
        string bt="",author_name="";
        int quantity;
        double price;
        string category;
        public Admin_Screen()
        {
            InitializeComponent();
        }
        private void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = -1;
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            users_screen us = new users_screen();
            us.Show();
            this.Close();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged Out Successfully...");
            Admin_Login al = new Admin_Login();
            al.Show();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dashboard d1 = new dashboard();
            d1.Show();
            this.Close();
        }

        private void Admin_Screen_Load(object sender, EventArgs e)
        {
            cs = "Server=localhost;Database=bsms;uid=root;pwd=root";
            c1 = new MySqlConnection(cs);
            //MessageBox.Show("database connected successfully..");
            c1.Open();
            string q = "Select * from books";
            cmd = new MySqlCommand(q, c1);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            c1.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cs = "Server=localhost;Database=bsms;uid=root;pwd=root";
            c1 = new MySqlConnection(cs);
            bt = textBox1.Text;
            author_name = textBox2.Text;
            category = comboBox1.Text;
            quantity = Convert.ToInt16(textBox3.Text);
            price=Convert.ToDouble(textBox4.Text);
            c1.Open();
            try
            {
                string q = "insert into books values('" + bt + "','" + author_name + "','" + category + "'," + quantity + "," + price + ")";
                cmd = new MySqlCommand(q, c1);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Added Successfully");
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
        private void button7_Click(object sender, EventArgs e)
        {

            cs = "Server=localhost;Database=bsms;uid=root;pwd=root";
            c1 = new MySqlConnection(cs);
            bt = textBox1.Text;
            c1.Open();
            try
            {
                string q = "delete from books where title='" + bt+"'";
                cmd = new MySqlCommand(q, c1);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Sucessfully...");
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

        private void button6_Click(object sender, EventArgs e)
        {
            cs = "Server=localhost;Database=bsms;uid=root;pwd=root";
            c1 = new MySqlConnection(cs);
            bt = textBox1.Text;
            author_name = textBox2.Text;
            category = comboBox1.Text;
            quantity = Convert.ToInt32(textBox3.Text);
            price = Convert.ToDouble(textBox4.Text);
            c1.Open();
            try
            {
                string q = "Update books set author='" + author_name + "',category='"+category+"',quantity='"+quantity+"',price='"+price+"' where title='"+bt+"'";
                cmd = new MySqlCommand(q, c1);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Sucessfully...");
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
            string q = "Select * from books";
            cmd = new MySqlCommand(q, c1);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            c1.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
