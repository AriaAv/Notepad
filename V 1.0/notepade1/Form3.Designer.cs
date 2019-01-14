namespace notepade1
{
    partial class frmreplace
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnfind = new System.Windows.Forms.Button();
            this.btnreplace = new System.Windows.Forms.Button();
            this.btnreplaceall = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find What:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Replace with:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(310, 22);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(75, 23);
            this.btnfind.TabIndex = 4;
            this.btnfind.Text = "Find Next";
            this.btnfind.UseVisualStyleBackColor = true;
            // 
            // btnreplace
            // 
            this.btnreplace.Location = new System.Drawing.Point(310, 45);
            this.btnreplace.Name = "btnreplace";
            this.btnreplace.Size = new System.Drawing.Size(75, 23);
            this.btnreplace.TabIndex = 5;
            this.btnreplace.Text = "Replace";
            this.btnreplace.UseVisualStyleBackColor = true;
            // 
            // btnreplaceall
            // 
            this.btnreplaceall.Location = new System.Drawing.Point(310, 75);
            this.btnreplaceall.Name = "btnreplaceall";
            this.btnreplaceall.Size = new System.Drawing.Size(75, 23);
            this.btnreplaceall.TabIndex = 6;
            this.btnreplaceall.Text = "Replace All";
            this.btnreplaceall.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(310, 105);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmreplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 170);
            this.ControlBox = false;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnreplaceall);
            this.Controls.Add(this.btnreplace);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmreplace";
            this.Text = "Replace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btnreplace;
        private System.Windows.Forms.Button btnreplaceall;
        private System.Windows.Forms.Button button4;
    }
}