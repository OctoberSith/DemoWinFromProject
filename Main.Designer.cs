
namespace DemoWinFromProject
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblLast = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(9, 210);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(58, 13);
            this.lblLast.TabIndex = 1;
            this.lblLast.Text = "Last Name";
            this.lblLast.Click += new System.EventHandler(this.lblLast_Click);
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(9, 236);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(57, 13);
            this.lblFirst.TabIndex = 2;
            this.lblFirst.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(12, 288);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City";
            // 
            // lblAdd
            // 
            this.lblAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblAdd.Image = ((System.Drawing.Image)(resources.GetObject("lblAdd.Image")));
            this.lblAdd.Location = new System.Drawing.Point(12, 83);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(176, 109);
            this.lblAdd.TabIndex = 0;
            this.lblAdd.Click += new System.EventHandler(this.lblAdd_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Yellow;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(776, 57);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Admin Menu";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(88, 210);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(100, 20);
            this.txtLast.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 288);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 262);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(88, 236);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblAdd);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}