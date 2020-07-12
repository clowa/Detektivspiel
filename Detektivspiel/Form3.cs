using System;
using System.Windows.Forms;

namespace Detektivspiel
{
    public partial class MsgBox : Form
    {
        public string Content
        {
            get{ return lbl_msgbox.Text; }
            set{ lbl_msgbox.Text = value; }
        }

        public string Title
        {
            get{ return this.Text; }
            set{ this.Text = value; }
        }

        public MsgBox()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
