using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace notepade1
{
    public partial class frmfind : Form
    {
        Form1 frm1;
        public frmfind(Form1 t)
        {
            InitializeComponent();
            frm1 = t;
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            frm1.functionfind(txtfind.Text);
        }

        private void btnfindnext_Click(object sender, EventArgs e)
        {
            frm1.functionfindnext(txtfind.Text);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmfind_Load(object sender, EventArgs e)
        {

        }
    }
}
