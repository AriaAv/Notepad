﻿namespace mynotepad3
{
    partial class Frmfind
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.btnfind = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rbtup = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rbtdown = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnfindnext = new System.Windows.Forms.Button();
            this.btnreplace = new System.Windows.Forms.Button();
            this.btnreplaceall = new System.Windows.Forms.Button();
            this.txtreplace = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find what";
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(93, 27);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(199, 20);
            this.txtfind.TabIndex = 1;
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(329, 22);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(75, 23);
            this.btnfind.TabIndex = 2;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfindnext_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(329, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbtup
            // 
            this.rbtup.AutoSize = true;
            this.rbtup.Location = new System.Drawing.Point(6, 19);
            this.rbtup.Name = "rbtup";
            this.rbtup.Size = new System.Drawing.Size(39, 17);
            this.rbtup.TabIndex = 4;
            this.rbtup.Text = "Up";
            this.rbtup.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 130);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Match case";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // rbtdown
            // 
            this.rbtdown.AutoSize = true;
            this.rbtdown.Checked = true;
            this.rbtdown.Location = new System.Drawing.Point(81, 19);
            this.rbtdown.Name = "rbtdown";
            this.rbtdown.Size = new System.Drawing.Size(53, 17);
            this.rbtdown.TabIndex = 6;
            this.rbtdown.TabStop = true;
            this.rbtdown.Text = "Down";
            this.rbtdown.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtdown);
            this.groupBox1.Controls.Add(this.rbtup);
            this.groupBox1.Location = new System.Drawing.Point(127, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 54);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            // 
            // btnfindnext
            // 
            this.btnfindnext.Location = new System.Drawing.Point(329, 51);
            this.btnfindnext.Name = "btnfindnext";
            this.btnfindnext.Size = new System.Drawing.Size(75, 23);
            this.btnfindnext.TabIndex = 8;
            this.btnfindnext.Text = "Find Next";
            this.btnfindnext.UseVisualStyleBackColor = true;
            this.btnfindnext.Click += new System.EventHandler(this.btnfindnext_Click_1);
            // 
            // btnreplace
            // 
            this.btnreplace.Location = new System.Drawing.Point(329, 83);
            this.btnreplace.Name = "btnreplace";
            this.btnreplace.Size = new System.Drawing.Size(75, 23);
            this.btnreplace.TabIndex = 9;
            this.btnreplace.Text = "Replace";
            this.btnreplace.UseVisualStyleBackColor = true;
            this.btnreplace.Click += new System.EventHandler(this.btnreplace_Click);
            // 
            // btnreplaceall
            // 
            this.btnreplaceall.Location = new System.Drawing.Point(329, 112);
            this.btnreplaceall.Name = "btnreplaceall";
            this.btnreplaceall.Size = new System.Drawing.Size(75, 23);
            this.btnreplaceall.TabIndex = 10;
            this.btnreplaceall.Text = "Replace All";
            this.btnreplaceall.UseVisualStyleBackColor = true;
            this.btnreplaceall.Click += new System.EventHandler(this.btnreplaceall_Click);
            // 
            // txtreplace
            // 
            this.txtreplace.Location = new System.Drawing.Point(93, 63);
            this.txtreplace.Name = "txtreplace";
            this.txtreplace.Size = new System.Drawing.Size(199, 20);
            this.txtreplace.TabIndex = 11;
            // 
            // Frmfind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 172);
            this.Controls.Add(this.txtreplace);
            this.Controls.Add(this.btnreplaceall);
            this.Controls.Add(this.btnreplace);
            this.Controls.Add(this.btnfindnext);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.txtfind);
            this.Controls.Add(this.label1);
            this.Name = "Frmfind";
            this.Text = "Frmfind";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbtup;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton rbtdown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnfindnext;
        private System.Windows.Forms.Button btnreplace;
        private System.Windows.Forms.Button btnreplaceall;
        private System.Windows.Forms.TextBox txtreplace;
    }
}