using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mynotepad3
{
    public partial class Frmfind : Form
    {
        Form1 frm1;
        public Frmfind(Form1 t)
        {
            InitializeComponent();
            frm1 = t;
        }

        

        private void btnfindnext_Click(object sender, EventArgs e)
        {
            
            frm1.fuctionfind(txtfind.Text);
            //frm1.Text = "this title is changed from frmfind.";
            //MessageBox.Show(frm1.txtnotepad.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnfindnext_Click_1(object sender, EventArgs e)
        {
            if (rbtdown.Checked == true)
                frm1.fuctionfindnext(txtfind.Text);
            else if (rbtup.Checked == true)
                frm1.fuctionfindnextup(txtfind.Text);

        }

        private void btnreplace_Click(object sender, EventArgs e)
        {
            frm1.txtnotepad.SelectedText = txtreplace.Text;
        }

        private void btnreplaceall_Click(object sender, EventArgs e)
        {
            while (frm1.fuctionfind(txtfind.Text) == true) 
            frm1.txtnotepad.SelectedText = txtreplace.Text;     
        }

      
    }
}
