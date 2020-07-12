namespace Detektivspiel
{
    partial class LoginDatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginDatabase));
            this.Lbl_databaseHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_server = new System.Windows.Forms.Label();
            this.Lbl_username = new System.Windows.Forms.Label();
            this.Lbl_password = new System.Windows.Forms.Label();
            this.Lbl_port = new System.Windows.Forms.Label();
            this.Lbl_database = new System.Windows.Forms.Label();
            this.Txt_server = new System.Windows.Forms.TextBox();
            this.Txt_username = new System.Windows.Forms.TextBox();
            this.Txt_database = new System.Windows.Forms.TextBox();
            this.Txt_password = new System.Windows.Forms.TextBox();
            this.Num_port = new System.Windows.Forms.NumericUpDown();
            this.Btn_loginDatabase = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_port)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_databaseHeader
            // 
            this.Lbl_databaseHeader.AutoSize = true;
            this.Lbl_databaseHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Lbl_databaseHeader.Location = new System.Drawing.Point(14, 14);
            this.Lbl_databaseHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_databaseHeader.Name = "Lbl_databaseHeader";
            this.Lbl_databaseHeader.Size = new System.Drawing.Size(179, 16);
            this.Lbl_databaseHeader.TabIndex = 0;
            this.Lbl_databaseHeader.Text = "Please login to the database";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Lbl_server, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Lbl_username, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Lbl_password, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Lbl_port, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Lbl_database, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Txt_server, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Txt_username, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Txt_database, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Txt_password, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Num_port, 1, 3);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 36);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(344, 156);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Lbl_server
            // 
            this.Lbl_server.AutoSize = true;
            this.Lbl_server.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_server.Location = new System.Drawing.Point(2, 0);
            this.Lbl_server.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_server.Name = "Lbl_server";
            this.Lbl_server.Size = new System.Drawing.Size(106, 31);
            this.Lbl_server.TabIndex = 0;
            this.Lbl_server.Text = "Server:";
            this.Lbl_server.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Lbl_username
            // 
            this.Lbl_username.AutoSize = true;
            this.Lbl_username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_username.Location = new System.Drawing.Point(2, 31);
            this.Lbl_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_username.Name = "Lbl_username";
            this.Lbl_username.Size = new System.Drawing.Size(106, 31);
            this.Lbl_username.TabIndex = 0;
            this.Lbl_username.Text = "Username:";
            this.Lbl_username.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Lbl_password
            // 
            this.Lbl_password.AutoSize = true;
            this.Lbl_password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_password.Location = new System.Drawing.Point(2, 62);
            this.Lbl_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_password.Name = "Lbl_password";
            this.Lbl_password.Size = new System.Drawing.Size(106, 31);
            this.Lbl_password.TabIndex = 0;
            this.Lbl_password.Text = "Password";
            this.Lbl_password.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Lbl_port
            // 
            this.Lbl_port.AutoSize = true;
            this.Lbl_port.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_port.Location = new System.Drawing.Point(2, 93);
            this.Lbl_port.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_port.Name = "Lbl_port";
            this.Lbl_port.Size = new System.Drawing.Size(106, 31);
            this.Lbl_port.TabIndex = 0;
            this.Lbl_port.Text = "Port:";
            this.Lbl_port.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Lbl_database
            // 
            this.Lbl_database.AutoSize = true;
            this.Lbl_database.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_database.Location = new System.Drawing.Point(2, 124);
            this.Lbl_database.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_database.Name = "Lbl_database";
            this.Lbl_database.Size = new System.Drawing.Size(106, 32);
            this.Lbl_database.TabIndex = 0;
            this.Lbl_database.Text = "Database:";
            this.Lbl_database.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Txt_server
            // 
            this.Txt_server.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Txt_server.Location = new System.Drawing.Point(110, 9);
            this.Txt_server.Margin = new System.Windows.Forms.Padding(0);
            this.Txt_server.MaxLength = 255;
            this.Txt_server.Name = "Txt_server";
            this.Txt_server.Size = new System.Drawing.Size(234, 22);
            this.Txt_server.TabIndex = 1;
            // 
            // Txt_username
            // 
            this.Txt_username.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Txt_username.Location = new System.Drawing.Point(110, 40);
            this.Txt_username.Margin = new System.Windows.Forms.Padding(0);
            this.Txt_username.MaxLength = 255;
            this.Txt_username.Name = "Txt_username";
            this.Txt_username.Size = new System.Drawing.Size(234, 22);
            this.Txt_username.TabIndex = 2;
            // 
            // Txt_database
            // 
            this.Txt_database.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Txt_database.Location = new System.Drawing.Point(110, 134);
            this.Txt_database.Margin = new System.Windows.Forms.Padding(0);
            this.Txt_database.MaxLength = 255;
            this.Txt_database.Name = "Txt_database";
            this.Txt_database.Size = new System.Drawing.Size(234, 22);
            this.Txt_database.TabIndex = 5;
            // 
            // Txt_password
            // 
            this.Txt_password.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Txt_password.Location = new System.Drawing.Point(110, 71);
            this.Txt_password.Margin = new System.Windows.Forms.Padding(0);
            this.Txt_password.MaxLength = 255;
            this.Txt_password.Name = "Txt_password";
            this.Txt_password.PasswordChar = '*';
            this.Txt_password.Size = new System.Drawing.Size(234, 22);
            this.Txt_password.TabIndex = 3;
            this.Txt_password.UseSystemPasswordChar = true;
            // 
            // Num_port
            // 
            this.Num_port.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Num_port.Location = new System.Drawing.Point(110, 102);
            this.Num_port.Margin = new System.Windows.Forms.Padding(0);
            this.Num_port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Num_port.Name = "Num_port";
            this.Num_port.Size = new System.Drawing.Size(234, 22);
            this.Num_port.TabIndex = 4;
            this.Num_port.Value = new decimal(new int[] {
            3306,
            0,
            0,
            0});
            // 
            // Btn_loginDatabase
            // 
            this.Btn_loginDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_loginDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_loginDatabase.Location = new System.Drawing.Point(292, 198);
            this.Btn_loginDatabase.Name = "Btn_loginDatabase";
            this.Btn_loginDatabase.Size = new System.Drawing.Size(68, 24);
            this.Btn_loginDatabase.TabIndex = 6;
            this.Btn_loginDatabase.Text = "Login";
            this.Btn_loginDatabase.UseVisualStyleBackColor = true;
            this.Btn_loginDatabase.Click += new System.EventHandler(this.Btn_loginDatabase_Click);
            // 
            // LoginDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 230);
            this.Controls.Add(this.Btn_loginDatabase);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Lbl_databaseHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database login";
            this.Load += new System.EventHandler(this.LoginDatabase_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginDatabase_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_databaseHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Lbl_server;
        private System.Windows.Forms.Label Lbl_username;
        private System.Windows.Forms.Label Lbl_password;
        private System.Windows.Forms.Label Lbl_port;
        private System.Windows.Forms.Label Lbl_database;
        private System.Windows.Forms.TextBox Txt_username;
        private System.Windows.Forms.TextBox Txt_database;
        private System.Windows.Forms.TextBox Txt_password;
        private System.Windows.Forms.NumericUpDown Num_port;
        private System.Windows.Forms.Button Btn_loginDatabase;
        private System.Windows.Forms.TextBox Txt_server;
    }
}