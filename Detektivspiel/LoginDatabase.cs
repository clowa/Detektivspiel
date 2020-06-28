using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Detektivspiel
{
    public partial class LoginDatabase : Form
    {
        // make logging information accessible
        public string server { get; private set; }
        public string user_id { get; private set; }
        public string password { get; private set; }
        public short port { get; private set; }
        public string database { get; private set; }
        public string ssl_mode { get; private set;  }

        public LoginDatabase()
        {
            InitializeComponent();
        }

        private void Btn_loginDatabase_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Sind alle Ihre Eingaben korrekt?", "Anmelden", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // create MySQL connection object
                MySqlConnection con = new MySqlConnection();

                // database connection information with default values
                server = (Txt_server.Text.Length != 0 ? Txt_server.Text : "127.0.0.1");
                user_id = (Txt_username.Text.Length != 0 ? Txt_username.Text : "root");
                password = (Txt_password.Text.Length != 0 ? Txt_password.Text : "");
                port = Convert.ToInt16(Num_port.Value);
                database = (Txt_database.Text.Length != 0 ? Txt_database.Text : "detektivspiel");
                ssl_mode = "Preferred";

                // create connectionstring
                con.ConnectionString =
                        $"server={server};" +
                        $"user id={user_id};" +
                        $"password={password};" +
                        $"port={port};" +
                        $"database={database};" +
                        $"SslMode={ssl_mode}";

                // try to connect
                // on success open next form
                try
                {
                    con.Open();
                    con.Close();
                    this.Hide();
                    Form2 form = new Form2(server, user_id, password, port, database, ssl_mode);
                    form.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LoginDatabase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // pressing the Enter key corresponds to clicking on "Login"
                Btn_loginDatabase.PerformClick();
            }
        }
    }
}
