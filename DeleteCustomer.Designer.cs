
namespace DemoWinFromProject
{
    partial class DeleteCustomer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCustomer));
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblFind = new System.Windows.Forms.Label();
            this.lblDelLast = new System.Windows.Forms.Label();
            this.lblDelFirst = new System.Windows.Forms.Label();
            this.txtFindLast = new System.Windows.Forms.TextBox();
            this.txtFindFirst = new System.Windows.Forms.TextBox();
            this.rtbFind = new System.Windows.Forms.RichTextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDelete
            // 
            this.lblDelete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDelete.Image = ((System.Drawing.Image)(resources.GetObject("lblDelete.Image")));
            this.lblDelete.Location = new System.Drawing.Point(13, 14);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(176, 109);
            this.lblDelete.TabIndex = 0;
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(10, 132);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(124, 13);
            this.lblFind.TabIndex = 1;
            this.lblFind.Text = "Find Customer To Delete";
            // 
            // lblDelLast
            // 
            this.lblDelLast.AutoSize = true;
            this.lblDelLast.Location = new System.Drawing.Point(11, 162);
            this.lblDelLast.Name = "lblDelLast";
            this.lblDelLast.Size = new System.Drawing.Size(62, 13);
            this.lblDelLast.TabIndex = 2;
            this.lblDelLast.Text = "Last name :";
            // 
            // lblDelFirst
            // 
            this.lblDelFirst.AutoSize = true;
            this.lblDelFirst.Location = new System.Drawing.Point(10, 189);
            this.lblDelFirst.Name = "lblDelFirst";
            this.lblDelFirst.Size = new System.Drawing.Size(57, 13);
            this.lblDelFirst.TabIndex = 3;
            this.lblDelFirst.Text = "First Name";
            // 
            // txtFindLast
            // 
            this.txtFindLast.Location = new System.Drawing.Point(79, 155);
            this.txtFindLast.Name = "txtFindLast";
            this.txtFindLast.Size = new System.Drawing.Size(100, 20);
            this.txtFindLast.TabIndex = 4;
            // 
            // txtFindFirst
            // 
            this.txtFindFirst.Location = new System.Drawing.Point(79, 182);
            this.txtFindFirst.Name = "txtFindFirst";
            this.txtFindFirst.Size = new System.Drawing.Size(100, 20);
            this.txtFindFirst.TabIndex = 5;
            // 
            // rtbFind
            // 
            this.rtbFind.Location = new System.Drawing.Point(79, 218);
            this.rtbFind.Name = "rtbFind";
            this.rtbFind.Size = new System.Drawing.Size(100, 64);
            this.rtbFind.TabIndex = 6;
            this.rtbFind.Text = "Customer to Delete";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(14, 218);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(53, 23);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "Search";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(13, 259);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(54, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DeleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.rtbFind);
            this.Controls.Add(this.txtFindFirst);
            this.Controls.Add(this.txtFindLast);
            this.Controls.Add(this.lblDelFirst);
            this.Controls.Add(this.lblDelLast);
            this.Controls.Add(this.lblFind);
            this.Controls.Add(this.lblDelete);
            this.Name = "DeleteCustomer";
            this.Size = new System.Drawing.Size(200, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.Label lblDelLast;
        private System.Windows.Forms.Label lblDelFirst;
        private System.Windows.Forms.TextBox txtFindLast;
        private System.Windows.Forms.TextBox txtFindFirst;
        private System.Windows.Forms.RichTextBox rtbFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnDelete;
    }
}
