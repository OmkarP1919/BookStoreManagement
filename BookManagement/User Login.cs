using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Book_Store_Management_System
{
    public partial class User_Login : Form
    {
        public User_Login()
        {
            InitializeComponent();
        }

        // Exit the application
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Open Admin Login form
        private void label4_Click(object sender, EventArgs e)
        {
            Admin_Login a1 = new Admin_Login();
            a1.Show();
            this.Close();
        }

        // Optional: label1 click (required to avoid design error)
        private void label1_Click(object sender, EventArgs e)
        {
            // This can be used later for navigation or info
        }

        // Login button click
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            string connectionString = "server=localhost;user id=root;password=root;database=bsms;";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 1)
                    {
                        users_billing ub = new users_billing();
                        ub.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox1.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to database:\n" + ex.Message);
                }
            }
        }
    }
}
