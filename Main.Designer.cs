
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbxUser = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewCust = new System.Windows.Forms.DataGridView();
            this.flowLayoutCust = new System.Windows.Forms.FlowLayoutPanel();
            this.lblGraphic = new System.Windows.Forms.Label();
            this.gbxUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCust)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblTitle.Location = new System.Drawing.Point(10, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(544, 50);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Customer Administration Menu";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxUser
            // 
            this.gbxUser.BackColor = System.Drawing.Color.Black;
            this.gbxUser.Controls.Add(this.btnDelete);
            this.gbxUser.Controls.Add(this.btnAdd);
            this.gbxUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUser.Location = new System.Drawing.Point(560, 9);
            this.gbxUser.Name = "gbxUser";
            this.gbxUser.Size = new System.Drawing.Size(106, 138);
            this.gbxUser.TabIndex = 12;
            this.gbxUser.TabStop = false;
            this.gbxUser.Text = "Menu ";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(6, 83);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 31);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Customer";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.Location = new System.Drawing.Point(6, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 31);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Customer";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridViewCust
            // 
            this.dataGridViewCust.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCust.Location = new System.Drawing.Point(10, 382);
            this.dataGridViewCust.Name = "dataGridViewCust";
            this.dataGridViewCust.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCust.Size = new System.Drawing.Size(544, 370);
            this.dataGridViewCust.TabIndex = 13;
            // 
            // flowLayoutCust
            // 
            this.flowLayoutCust.BackColor = System.Drawing.Color.Black;
            this.flowLayoutCust.Location = new System.Drawing.Point(10, 63);
            this.flowLayoutCust.Name = "flowLayoutCust";
            this.flowLayoutCust.Size = new System.Drawing.Size(544, 313);
            this.flowLayoutCust.TabIndex = 14;
            // 
            // lblGraphic
            // 
            this.lblGraphic.BackColor = System.Drawing.Color.White;
            this.lblGraphic.Image = ((System.Drawing.Image)(resources.GetObject("lblGraphic.Image")));
            this.lblGraphic.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblGraphic.Location = new System.Drawing.Point(560, 154);
            this.lblGraphic.Name = "lblGraphic";
            this.lblGraphic.Size = new System.Drawing.Size(106, 598);
            this.lblGraphic.TabIndex = 15;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 757);
            this.Controls.Add(this.lblGraphic);
            this.Controls.Add(this.flowLayoutCust);
            this.Controls.Add(this.dataGridViewCust);
            this.Controls.Add(this.gbxUser);
            this.Controls.Add(this.lblTitle);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.gbxUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCust)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbxUser;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewCust;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutCust;
        private System.Windows.Forms.Label lblGraphic;
    }
}