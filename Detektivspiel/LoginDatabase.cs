using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Detektivspiel
{
    public partial class LoginDatabase : Form
    {
        // database login default values
        private string _defaultServer = "127.0.0.1";
        private string _defaultUsername = "root";
        private string _defaultPassword = "";
        private string _defaultDatabase = "detektivspiel";
        private string _defaultSslMode = "Preferred";

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

        private void LoginDatabase_Load(object sender, EventArgs e)
        {
            Txt_server.Text = _defaultServer;
            Txt_username.Text = _defaultUsername;
            Txt_database.Text = _defaultDatabase;
        }

        private void Btn_loginDatabase_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Sind alle Ihre Eingaben korrekt?", "Anmelden", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // create MySQL connection object
                MySqlConnection con = new MySqlConnection();

                // database connection information with default values
                server = (Txt_server.Text.Length != 0 ? Txt_server.Text : _defaultServer);
                user_id = (Txt_username.Text.Length != 0 ? Txt_username.Text : _defaultUsername);
                password = (Txt_password.Text.Length != 0 ? Txt_password.Text : _defaultPassword);
                port = Convert.ToInt16(Num_port.Value);
                database = (Txt_database.Text.Length != 0 ? Txt_database.Text : _defaultDatabase);
                ssl_mode = _defaultSslMode;

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
                    Form2 form = new Form2(this);
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
