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
    public partial class Form1 : Form
    {
        string fn;
        Boolean saveflag;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void setbk(object sender, EventArgs e)
        {
            txtnotepad.BackColor = Color.FromName(((ToolStripMenuItem)sender).Text);
            foreach (ToolStripMenuItem x in backcolorToolStripMenuItem.DropDownItems)
                if (x.Text == ((ToolStripMenuItem)sender).Text)
                    x.Checked = true;
                else
                    x.Checked = false;
        }

        private void foreColorToolStripMenuItem_Click(object sender, EventArgs e)

        {
            colorDialog1.FullOpen = true;
            colorDialog1.ShowDialog();
            txtnotepad.ForeColor = colorDialog1.Color;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = txtnotepad.Font;
            fontDialog1.ShowDialog();
            txtnotepad.Font = fontDialog1.Font;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtnotepad.SelectedText);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtnotepad.SelectedText = "";
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtnotepad.SelectedText = Clipboard.GetText();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtnotepad.SelectedText);
            txtnotepad.SelectedText = "";
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtnotepad.SelectAll();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fn==null){
                DialogResult r;
            saveFileDialog1.DefaultExt= "txt";
            r=saveFileDialog1.ShowDialog();
            if (r == DialogResult.Cancel)
                return;
            fn = saveFileDialog1.FileName;
            }
            System.IO.File.WriteAllText(fn, txtnotepad.Text);
        saveflag = true;
        this.Text=fn;}

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveflag==false){
                DialogResult r;
                r=MessageBox.Show("Save?","save",MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                    saveToolStripMenuItem_Click(null, null);
            }
            txtnotepad.Text="";
            saveflag=true;
            fn=null;
            this.Text="MyNotpad";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = openFileDialog1.ShowDialog();
            if (r == DialogResult.Cancel)
                return;
            fn = openFileDialog1.FileName;
            newToolStripMenuItem_Click(null, null);
            openFileDialog1.Filter = "Text file|*.txt|Document|*.doc|All file|*.*";
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

        private void txtnotepad_TextChanged(object sender, EventArgs e)
        {
            saveflag = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.File.WriteAllText("d:\\layout.txt", txtnotepad.BackColor.Name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(System.IO.File.Exists("d:\\layout.txt")==true)
            {
                ToolStripMenuItem x =new ToolStripMenuItem();
                x.Text = System.IO.File.ReadAllText("d:\\layout.txt");
                    setbk(x,null);
                    saveflag = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            newToolStripMenuItem_Click(null, null);
        }

        //********************************
        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmfind f = new frmfind(this);
            f.Show(this);
        }

        public void functionfind(string s)
        {
            int i;
            i = txtnotepad.Text.IndexOf(s, 0);
            if (i == -1)
                MessageBox.Show("not Found");
            else
            {
                txtnotepad.SelectionStart = i;
                txtnotepad.SelectionLength = s.Length;
                this.Focus();
            }
        }
        public void functionfindnext(string s)
        {
            int i, j = txtnotepad.SelectionStart;
            if (j >= txtnotepad.TextLength)
                j = 0;
            else if (txtnotepad.SelectionLength > 0)
                j++;
            i = txtnotepad.Text.IndexOf(s, j);
            if (i == -1)
                MessageBox.Show("not Found");
            else
            {
                txtnotepad.SelectionStart = i;
                txtnotepad.SelectionLength = s.Length;
                this.Focus();
            }
        }
        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmfind f = new frmfind(this);
            f.Show(this);
        }
        //********************************************

        private void gotoToolStripMenuItem_Click(object sender, EventArgs e)
        {   frmgoto f = new frmgoto(this);
            f.Show(this);}
        public void Goto(int s)  
        {   int index;
            index = txtnotepad.GetFirstCharIndexFromLine(s - 1);
            txtnotepad.Select(index, 0);}

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
