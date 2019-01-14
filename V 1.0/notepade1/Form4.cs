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
    public partial class frmgoto : Form
    {   Form1 frm1;
        public frmgoto(Form1 f)
        {   InitializeComponent();
            frm1 = f;}
        private void btncancel_Click(object sender, EventArgs e)
        {   this.Close();}
        private void btnok_Click(object sender, EventArgs e)
        {   frm1.Goto(Convert.ToInt32(txtline.Text));
            this.Close();}}}