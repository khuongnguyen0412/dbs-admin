namespace Admin.Forms
{
    partial class frmAddVersion
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
            this.txbVersion = new System.Windows.Forms.TextBox();
            this.txbNameSoftware = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNameSoftware = new System.Windows.Forms.Label();
            this.btnSave = new Admin.CustomControls.btnCustom();
            this.SuspendLayout();
            // 
            // txbVersion
            // 
            this.txbVersion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbVersion.Location = new System.Drawing.Point(137, 61);
            this.txbVersion.Name = "txbVersion";
            this.txbVersion.Size = new System.Drawing.Size(298, 29);
            this.txbVersion.TabIndex = 7;
            // 
            // txbNameSoftware
            // 
            this.txbNameSoftware.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameSoftware.Location = new System.Drawing.Point(137, 26);
            this.txbNameSoftware.Name = "txbNameSoftware";
            this.txbNameSoftware.Size = new System.Drawing.Size(298, 29);
            this.txbNameSoftware.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Phiên bản:";
            // 
            // lblNameSoftware
            // 
            this.lblNameSoftware.AutoSize = true;
            this.lblNameSoftware.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSoftware.Location = new System.Drawing.Point(16, 29);
            this.lblNameSoftware.Name = "lblNameSoftware";
            this.lblNameSoftware.Size = new System.Drawing.Size(115, 21);
            this.lblNameSoftware.TabIndex = 4;
            this.lblNameSoftware.Text = "Tên phần mềm:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(366, 96);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 40);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 155);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbVersion);
            this.Controls.Add(this.txbNameSoftware);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNameSoftware);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAddVersion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới phần mềm";
            this.Load += new System.EventHandler(this.frmEditVersion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbVersion;
        private System.Windows.Forms.TextBox txbNameSoftware;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNameSoftware;
        private CustomControls.btnCustom btnSave;
    }
}