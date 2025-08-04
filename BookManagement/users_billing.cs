using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Book_Store_Management_System
{
    public partial class users_billing : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=root;database=bsms");

        public users_billing()
        {
            InitializeComponent();
        }

        private void users_billing_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadBooks();
            SetupCartGrid();

            dgvCart.CellValueChanged += dgvCart_CellValueChanged;
            dgvCart.EditingControlShowing += dgvCart_EditingControlShowing;
        }

        private void LoadUsers()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT username FROM users", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbUsers.Items.Add(reader["username"].ToString());
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private void LoadBooks()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT title FROM books", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbBooks.Items.Add(reader["title"].ToString());
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
            }
        }

        private List<string> GetBookTitles()
        {
            List<string> titles = new List<string>();
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT title FROM books", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    titles.Add(reader["title"].ToString());
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading book titles: " + ex.Message);
            }
            return titles;
        }

        private void SetupCartGrid()
        {
            dgvCart.Columns.Clear();

            var bookColumn = new DataGridViewComboBoxColumn();
            bookColumn.HeaderText = "Book";
            bookColumn.Name = "Book";
            bookColumn.DataSource = GetBookTitles();
            dgvCart.Columns.Add(bookColumn);

            dgvCart.Columns.Add("Qty", "Qty");
            dgvCart.Columns.Add("Price", "Price");
            dgvCart.Columns.Add("Total", "Total");

            dgvCart.Columns["Price"].ReadOnly = true;
            dgvCart.Columns["Total"].ReadOnly = true;
        }

        private double GetPrice(string book)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT price FROM books WHERE title=@title", con);
            cmd.Parameters.AddWithValue("@title", book);
            object result = cmd.ExecuteScalar();
            con.Close();

            return result != null ? Convert.ToDouble(result) : 0;
        }

        private void dgvCart_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCart.Columns[e.ColumnIndex].Name == "Book")
            {
                var book = dgvCart.Rows[e.RowIndex].Cells["Book"].Value != null
                           ? dgvCart.Rows[e.RowIndex].Cells["Book"].Value.ToString() : "";
                if (book != "")
                {
                    double price = GetPrice(book);
                    dgvCart.Rows[e.RowIndex].Cells["Price"].Value = price;

                    var qtyVal = dgvCart.Rows[e.RowIndex].Cells["Qty"].Value;
                    int qty;
                    if (qtyVal != null && int.TryParse(qtyVal.ToString(), out qty))
                    {
                        dgvCart.Rows[e.RowIndex].Cells["Total"].Value = price * qty;
                        UpdateTotal();
                    }
                }
            }

            if (e.RowIndex >= 0 && dgvCart.Columns[e.ColumnIndex].Name == "Qty")
            {
                var row = dgvCart.Rows[e.RowIndex];
                var qtyVal = row.Cells["Qty"].Value;
                var priceVal = row.Cells["Price"].Value;

                int qty;
                if (qtyVal != null && priceVal != null && int.TryParse(qtyVal.ToString(), out qty))
                {
                    double price = Convert.ToDouble(priceVal);
                    row.Cells["Total"].Value = price * qty;
                    UpdateTotal();
                }
            }
        }

        private void dgvCart_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvCart.CurrentCell.ColumnIndex == dgvCart.Columns["Qty"].Index && e.Control is TextBox)
            {
                TextBox tb = (TextBox)e.Control;
                tb.KeyPress -= new KeyPressEventHandler(Qty_KeyPress);
                tb.KeyPress += new KeyPressEventHandler(Qty_KeyPress);
            }
        }

        private void Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void UpdateTotal()
        {
            double sum = 0;
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.Cells["Total"].Value != null)
                    sum += Convert.ToDouble(row.Cells["Total"].Value);
            }
            txtTotal.Text = sum.ToString("0.00");
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedItem == null || dgvCart.Rows.Count == 0 || txtClientName.Text == "")
            {
                MessageBox.Show("Please select user, enter client name, and add books.");
                return;
            }

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO transactions (date_time, client_name, username, total_amount) VALUES (@dt, @client, @user, @total)", con);
                cmd.Parameters.AddWithValue("@dt", DateTime.Now);
                cmd.Parameters.AddWithValue("@client", txtClientName.Text.Trim());
                cmd.Parameters.AddWithValue("@user", cmbUsers.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@total", double.Parse(txtTotal.Text));
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Transaction Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvCart.Rows.Clear();
                txtTotal.Text = "";
                txtClientName.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during checkout: " + ex.Message);
                con.Close();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Print functionality is under construction.");
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbBooks.SelectedItem == null || txtQty.Text == "")
            {
                MessageBox.Show("Please select a book and enter quantity.");
                return;
            }

            int qty;
            if (!int.TryParse(txtQty.Text, out qty) || qty <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            string book = cmbBooks.SelectedItem.ToString();
            double price = GetPrice(book);
            double total = price * qty;

            dgvCart.Rows.Add(book, qty, price, total);
            txtQty.Text = "";
            UpdateTotal();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged Out Successfully...");
            User_Login al = new User_Login();
            al.Show();
            this.Close();
        }
    }
}
