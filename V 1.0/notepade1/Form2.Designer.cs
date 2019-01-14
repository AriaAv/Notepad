namespace notepade1
{
    partial class frmfind
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
            this.btncancel = new System.Windows.Forms.Button();
            this.btnfindnext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search for:";
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(25, 48);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(314, 20);
            this.txtfind.TabIndex = 1;
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(364, 17);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(75, 23);
            this.btnfind.TabIndex = 2;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(364, 75);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnfindnext
            // 
            this.btnfindnext.Location = new System.Drawing.Point(364, 46);
            this.btnfindnext.Name = "btnfindnext";
            this.btnfindnext.Size = new System.Drawing.Size(75, 23);
            this.btnfindnext.TabIndex = 6;
            this.btnfindnext.Text = "Find Next";
            this.btnfindnext.UseVisualStyleBackColor = true;
            this.btnfindnext.Click += new System.EventHandler(this.btnfindnext_Click);
            // 
            // frmfind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 108);
            this.ControlBox = false;
            this.Controls.Add(this.btnfindnext);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.txtfind);
            this.Controls.Add(this.label1);
            this.Name = "frmfind";
            this.Text = "Find";
            this.Load += new System.EventHandler(this.frmfind_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnfindnext;
    }
}