namespace Book_Store_Management_System
{
    partial class dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.panel4 = new System.Windows.Forms.Panel();
            this.cardBooks = new System.Windows.Forms.Panel();
            this.labelBooks = new System.Windows.Forms.Label();
            this.cardUsers = new System.Windows.Forms.Panel();
            this.labelUsers = new System.Windows.Forms.Label();
            this.cardRevenue = new System.Windows.Forms.Panel();
            this.labelRevenue = new System.Windows.Forms.Label();
            this.transactionsGrid = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.cardBooks.SuspendLayout();
            this.cardUsers.SuspendLayout();
            this.cardRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGrid)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.cardBooks);
            this.panel4.Controls.Add(this.cardUsers);
            this.panel4.Controls.Add(this.cardRevenue);
            this.panel4.Controls.Add(this.transactionsGrid);
            this.panel4.Location = new System.Drawing.Point(215, 109);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(721, 509);
            this.panel4.TabIndex = 3;
            // 
            // cardBooks
            // 
            this.cardBooks.BackColor = System.Drawing.Color.SeaGreen;
            this.cardBooks.Controls.Add(this.labelBooks);
            this.cardBooks.Location = new System.Drawing.Point(40, 20);
            this.cardBooks.Name = "cardBooks";
            this.cardBooks.Size = new System.Drawing.Size(200, 120);
            this.cardBooks.TabIndex = 0;
            // 
            // labelBooks
            // 
            this.labelBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBooks.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelBooks.ForeColor = System.Drawing.Color.White;
            this.labelBooks.Location = new System.Drawing.Point(0, 0);
            this.labelBooks.Name = "labelBooks";
            this.labelBooks.Size = new System.Drawing.Size(200, 120);
            this.labelBooks.TabIndex = 0;
            this.labelBooks.Text = "Books\n0";
            this.labelBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardUsers
            // 
            this.cardUsers.BackColor = System.Drawing.Color.Orange;
            this.cardUsers.Controls.Add(this.labelUsers);
            this.cardUsers.Location = new System.Drawing.Point(260, 20);
            this.cardUsers.Name = "cardUsers";
            this.cardUsers.Size = new System.Drawing.Size(200, 120);
            this.cardUsers.TabIndex = 1;
            // 
            // labelUsers
            // 
            this.labelUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUsers.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelUsers.ForeColor = System.Drawing.Color.White;
            this.labelUsers.Location = new System.Drawing.Point(0, 0);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(200, 120);
            this.labelUsers.TabIndex = 0;
            this.labelUsers.Text = "Users\n0";
            this.labelUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardRevenue
            // 
            this.cardRevenue.BackColor = System.Drawing.Color.SteelBlue;
            this.cardRevenue.Controls.Add(this.labelRevenue);
            this.cardRevenue.Location = new System.Drawing.Point(480, 20);
            this.cardRevenue.Name = "cardRevenue";
            this.cardRevenue.Size = new System.Drawing.Size(200, 120);
            this.cardRevenue.TabIndex = 2;
            // 
            // labelRevenue
            // 
            this.labelRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRevenue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelRevenue.ForeColor = System.Drawing.Color.White;
            this.labelRevenue.Location = new System.Drawing.Point(0, 0);
            this.labelRevenue.Name = "labelRevenue";
            this.labelRevenue.Size = new System.Drawing.Size(200, 120);
            this.labelRevenue.TabIndex = 0;
            this.labelRevenue.Text = "Revenue\n₹0";
            this.labelRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // transactionsGrid
            // 
            this.transactionsGrid.AllowUserToAddRows = false;
            this.transactionsGrid.AllowUserToDeleteRows = false;
            this.transactionsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transactionsGrid.BackgroundColor = System.Drawing.Color.White;
            this.transactionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsGrid.Location = new System.Drawing.Point(40, 160);
            this.transactionsGrid.Name = "transactionsGrid";
            this.transactionsGrid.ReadOnly = true;
            this.transactionsGrid.Size = new System.Drawing.Size(640, 320);
            this.transactionsGrid.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(232, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(704, 109);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(160, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 38);
            this.label1.TabIndex = 21;
            this.label1.Text = "Book Shop Management System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 618);
            this.panel1.TabIndex = 4;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Maroon;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(-1, 337);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(232, 51);
            this.button10.TabIndex = 10;
            this.button10.Text = "Logout";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(231, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(705, 124);
            this.panel2.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Maroon;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(235, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(232, 51);
            this.button4.TabIndex = 10;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(236, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 51);
            this.button3.TabIndex = 9;
            this.button3.Text = "Dashboard";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(235, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 51);
            this.button2.TabIndex = 8;
            this.button2.Text = "Users";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(235, -49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "Books";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Maroon;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(0, 276);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(233, 51);
            this.button11.TabIndex = 9;
            this.button11.Text = "Dashboard";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Maroon;
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(-1, 165);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(233, 51);
            this.button13.TabIndex = 7;
            this.button13.Text = "Books";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(-1, 220);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(233, 51);
            this.button12.TabIndex = 8;
            this.button12.Text = "Employees";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(936, 618);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel4.ResumeLayout(false);
            this.cardBooks.ResumeLayout(false);
            this.cardUsers.ResumeLayout(false);
            this.cardRevenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel cardBooks;
        private System.Windows.Forms.Panel cardUsers;
        private System.Windows.Forms.Panel cardRevenue;
        private System.Windows.Forms.Label labelBooks;
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.Label labelRevenue;
        private System.Windows.Forms.DataGridView transactionsGrid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
    }
}
