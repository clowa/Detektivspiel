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
    public partial class MsgBox : Form
    {
        public MsgBox()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }


        public string Content { 
            get
            {
                return lbl_msgbox.Text;
            }
            set{
                lbl_msgbox.Text = value;
            } }

        
           public string Title { 
            get
            {
                return this.Text;
            }
            set{
                this.Text = value;
            } }

        
    }
}
