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
    public partial class Form1 : Form
    {
        string fn;
        int x,y;
        Boolean saveflag;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            statusStrip1.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void forColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
            colorDialog1.Color = Color.Red;
            colorDialog1.ShowDialog();
            txtnotepad.ForeColor = colorDialog1.Color;
        
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = txtnotepad.Font;
            fontDialog1.ShowDialog();
            txtnotepad.Font = fontDialog1.Font;
        }

        private void setbk(object sender, EventArgs e)
        {
            txtnotepad.BackColor = Color.FromName(((ToolStripMenuItem)sender).Text);

            foreach (ToolStripMenuItem i in backColorToolStripMenuItem.DropDownItems)
                if (i.Text == ((ToolStripMenuItem)sender).Text)
                    i.Checked = true;
                else
                    i.Checked = false;
          
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.File.WriteAllText(@"c:\layout.txt",txtnotepad.BackColor.Name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"c:\layout.txt") == true)
            {
                string s;
                s = System.IO.File.ReadAllText(@"c:\layout.txt");
                ToolStripMenuItem t = new ToolStripMenuItem();
                t.Text = s;
                setbk(t, null);

            }
            saveflag = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("c:\name");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fn == null)
            {
                saveFileDialog1.ShowDialog();
                fn = saveFileDialog1.FileName;
            
            }
            System.IO.File.WriteAllText(fn, txtnotepad.Text);
            saveflag = true;
            this.Text = fn;


        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveflag == false) {
                DialogResult x;
                x=MessageBox.Show("Do you want to save?", "save...", MessageBoxButtons.YesNo);
                if (x == DialogResult.Yes)
                    saveToolStripMenuItem_Click(null, null);
                            
            }

            txtnotepad.Text = "";
            fn = null;
            this.Text = "My Notepad";
            saveflag = true;
        }

        private void txtnotepad_TextChanged(object sender, EventArgs e)
        {
            saveflag = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(null, null);

            openFileDialog1.ShowDialog();
            fn = openFileDialog1.FileName;
            txtnotepad.Text = System.IO.File.ReadAllText(fn);
            saveflag = true;
            this.Text = fn;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fn = null;
            saveToolStripMenuItem_Click(null, null);
        }

       
    }
}
