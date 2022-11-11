namespace Admin.Forms
{
    partial class frmManageVersion
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
            this.lvwVersion = new System.Windows.Forms.ListView();
            this.btnDeleteVersion = new Admin.CustomControls.btnCustom();
            this.btnUpdateVersion = new Admin.CustomControls.btnCustom();
            this.btnAddVersion = new Admin.CustomControls.btnCustom();
            this.SuspendLayout();
            // 
            // lvwVersion
            // 
            this.lvwVersion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwVersion.FullRowSelect = true;
            this.lvwVersion.HideSelection = false;
            this.lvwVersion.Location = new System.Drawing.Point(3, 90);
            this.lvwVersion.Name = "lvwVersion";
            this.lvwVersion.Size = new System.Drawing.Size(777, 268);
            this.lvwVersion.TabIndex = 7;
            this.lvwVersion.UseCompatibleStateImageBehavior = false;
            this.lvwVersion.View = System.Windows.Forms.View.Details;
            this.lvwVersion.Click += new System.EventHandler(this.lvwVersion_Click);
            // 
            // btnDeleteVersion
            // 
            this.btnDeleteVersion.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDeleteVersion.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDeleteVersion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDeleteVersion.BorderRadius = 20;
            this.btnDeleteVersion.BorderSize = 0;
            this.btnDeleteVersion.FlatAppearance.BorderSize = 0;
            this.btnDeleteVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteVersion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteVersion.ForeColor = System.Drawing.Color.White;
            this.btnDeleteVersion.Location = new System.Drawing.Point(268, 24);
            this.btnDeleteVersion.Name = "btnDeleteVersion";
            this.btnDeleteVersion.Size = new System.Drawing.Size(93, 44);
            this.btnDeleteVersion.TabIndex = 10;
            this.btnDeleteVersion.Text = "Xóa";
            this.btnDeleteVersion.TextColor = System.Drawing.Color.White;
            this.btnDeleteVersion.UseVisualStyleBackColor = false;
            this.btnDeleteVersion.Click += new System.EventHandler(this.btnDeleteVersion_Click);
            // 
            // btnUpdateVersion
            // 
            this.btnUpdateVersion.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnUpdateVersion.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnUpdateVersion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpdateVersion.BorderRadius = 20;
            this.btnUpdateVersion.BorderSize = 0;
            this.btnUpdateVersion.FlatAppearance.BorderSize = 0;
            this.btnUpdateVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateVersion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateVersion.ForeColor = System.Drawing.Color.White;
            this.btnUpdateVersion.Location = new System.Drawing.Point(144, 24);
            this.btnUpdateVersion.Name = "btnUpdateVersion";
            this.btnUpdateVersion.Size = new System.Drawing.Size(93, 44);
            this.btnUpdateVersion.TabIndex = 9;
            this.btnUpdateVersion.Text = "Cập nhật";
            this.btnUpdateVersion.TextColor = System.Drawing.Color.White;
            this.btnUpdateVersion.UseVisualStyleBackColor = false;
            this.btnUpdateVersion.Click += new System.EventHandler(this.btnUpdateVersion_Click);
            // 
            // btnAddVersion
            // 
            this.btnAddVersion.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddVersion.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddVersion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddVersion.BorderRadius = 20;
            this.btnAddVersion.BorderSize = 0;
            this.btnAddVersion.FlatAppearance.BorderSize = 0;
            this.btnAddVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVersion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVersion.ForeColor = System.Drawing.Color.White;
            this.btnAddVersion.Location = new System.Drawing.Point(15, 24);
            this.btnAddVersion.Name = "btnAddVersion";
            this.btnAddVersion.Size = new System.Drawing.Size(93, 44);
            this.btnAddVersion.TabIndex = 8;
            this.btnAddVersion.Text = "Thêm";
            this.btnAddVersion.TextColor = System.Drawing.Color.White;
            this.btnAddVersion.UseVisualStyleBackColor = false;
            this.btnAddVersion.Click += new System.EventHandler(this.btnAddVersion_Click_1);
            // 
            // frmManageVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.btnDeleteVersion);
            this.Controls.Add(this.btnUpdateVersion);
            this.Controls.Add(this.btnAddVersion);
            this.Controls.Add(this.lvwVersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmManageVersion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageVersion";
            this.Load += new System.EventHandler(this.frmManageVersion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.btnCustom btnDeleteVersion;
        private CustomControls.btnCustom btnUpdateVersion;
        private CustomControls.btnCustom btnAddVersion;
        private System.Windows.Forms.ListView lvwVersion;
    }
}