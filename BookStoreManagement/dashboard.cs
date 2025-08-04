using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Book_Store_Management_System
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            string cs = "Server=localhost;Database=bsms;uid=root;pwd=root";
            MySqlConnection c1 = new MySqlConnection(cs);

            try
            {
                c1.Open();

                // Total books
                string q = "SELECT COUNT(*) FROM books";
                MySqlCommand cmd = new MySqlCommand(q, c1);
                int stock = Convert.ToInt32(cmd.ExecuteScalar());
                labelBooks.Text = "Books\n" + stock;

                // Total users
                string q1 = "SELECT COUNT(*) FROM users";
                cmd = new MySqlCommand(q1, c1);
                int users = Convert.ToInt32(cmd.ExecuteScalar());
                labelUsers.Text = "Users\n" + users;

                // Total revenue
                string q2 = "SELECT SUM(total_amount) FROM transactions";
                cmd = new MySqlCommand(q2, c1);
                object totalObj = cmd.ExecuteScalar();
                int total = (totalObj != DBNull.Value) ? Convert.ToInt32(totalObj) : 0;
                labelRevenue.Text = "Revenue\nRs. " + total;

                // Last 5 transactions
                string q3 = "SELECT order_id, date_time, client_name, username, total_amount FROM transactions ORDER BY date_time DESC LIMIT 5";
                MySqlDataAdapter da = new MySqlDataAdapter(q3, c1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                transactionsGrid.DataSource = dt;

                // Optional column headers
                transactionsGrid.Columns["order_id"].HeaderText = "Order ID";
                transactionsGrid.Columns["date_time"].HeaderText = "Date & Time";
                transactionsGrid.Columns["client_name"].HeaderText = "Client";
                transactionsGrid.Columns["username"].HeaderText = "User";
                transactionsGrid.Columns["total_amount"].HeaderText = "Amount";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard:\n" + ex.Message);
            }
            finally
            {
                c1.Close();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Admin_Screen a1 = new Admin_Screen();
            a1.Show();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            users_screen u1 = new users_screen();
            u1.Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Admin_Login a1 = new Admin_Login();
            a1.Show();
            this.Close();
        }
    }
}
