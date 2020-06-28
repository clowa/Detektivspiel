using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Detektivspiel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OK_Button_Willkommenstext_Click(object sender, EventArgs e)
        {
            this.Hide();
            // open database login mask
            LoginDatabase form = new LoginDatabase();
            form.ShowDialog();
            this.Close();
        }
    }
}
