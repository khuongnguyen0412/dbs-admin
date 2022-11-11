namespace Admin
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.lblNameSoftware = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabShowInfor = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cboChooseInformationType = new ComboTreeBox();
            this.lblChooseComputer = new System.Windows.Forms.Label();
            this.lblChooseTypeInfor = new System.Windows.Forms.Label();
            this.btnShowInfor = new Admin.CustomControls.btnCustom();
            this.cboChooseComputer = new System.Windows.Forms.ComboBox();
            this.treeInformation = new System.Windows.Forms.TreeView();
            this.tabWarning = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tvBefore = new System.Windows.Forms.TreeView();
            this.tvCurrent = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboChooseComputerWarning = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new Admin.CustomControls.btnCustom();
            this.btnShowWarrning = new Admin.CustomControls.btnCustom();
            this.tabStatistic = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.lvwStatistic = new System.Windows.Forms.ListView();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.btnManage = new Admin.CustomControls.btnCustom();
            this.lblChooseFormStatistic = new System.Windows.Forms.Label();
            this.cboChooseStatisticType = new System.Windows.Forms.ComboBox();
            this.btnShow = new Admin.CustomControls.btnCustom();
            this.lblManage = new System.Windows.Forms.Label();
            this.btnAddCSV = new Admin.CustomControls.btnCustom();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.tab.SuspendLayout();
            this.tabShowInfor.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabWarning.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tabStatistic.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNameSoftware
            // 
            this.lblNameSoftware.AutoSize = true;
            this.lblNameSoftware.BackColor = System.Drawing.Color.White;
            this.lblNameSoftware.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameSoftware.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNameSoftware.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(183)))), ((int)(((byte)(92)))));
            this.lblNameSoftware.Location = new System.Drawing.Point(493, 0);
            this.lblNameSoftware.Name = "lblNameSoftware";
            this.lblNameSoftware.Size = new System.Drawing.Size(730, 68);
            this.lblNameSoftware.TabIndex = 1;
            this.lblNameSoftware.Text = "PHẦN MỀM THU THẬP THÔNG TIN MÁY TÍNH";
            this.lblNameSoftware.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(3, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(484, 62);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.tab);
            this.pnlMain.Controls.Add(this.lblManage);
            this.pnlMain.Controls.Add(this.btnAddCSV);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(3, 77);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1226, 669);
            this.pnlMain.TabIndex = 7;
            // 
            // tab
            // 
            this.tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab.Controls.Add(this.tabShowInfor);
            this.tab.Controls.Add(this.tabWarning);
            this.tab.Controls.Add(this.tabStatistic);
            this.tab.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tab.ItemSize = new System.Drawing.Size(100, 30);
            this.tab.Location = new System.Drawing.Point(3, 75);
            this.tab.Multiline = true;
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1206, 583);
            this.tab.TabIndex = 8;
            // 
            // tabShowInfor
            // 
            this.tabShowInfor.Controls.Add(this.tableLayoutPanel3);
            this.tabShowInfor.Location = new System.Drawing.Point(4, 34);
            this.tabShowInfor.Name = "tabShowInfor";
            this.tabShowInfor.Padding = new System.Windows.Forms.Padding(3);
            this.tabShowInfor.Size = new System.Drawing.Size(1198, 545);
            this.tabShowInfor.TabIndex = 0;
            this.tabShowInfor.Text = "HIỂN THỊ";
            this.tabShowInfor.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.treeInformation, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1192, 539);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(173)))), ((int)(((byte)(71)))));
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.72727F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.54545F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel4.Controls.Add(this.cboChooseInformationType, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblChooseComputer, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblChooseTypeInfor, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnShowInfor, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.cboChooseComputer, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1186, 37);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // cboChooseInformationType
            // 
            this.cboChooseInformationType.AllowDrop = true;
            this.cboChooseInformationType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboChooseInformationType.DroppedDown = false;
            this.cboChooseInformationType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboChooseInformationType.Location = new System.Drawing.Point(540, 3);
            this.cboChooseInformationType.Name = "cboChooseInformationType";
            this.cboChooseInformationType.SelectedNode = null;
            this.cboChooseInformationType.Size = new System.Drawing.Size(533, 31);
            this.cboChooseInformationType.TabIndex = 5;
            // 
            // lblChooseComputer
            // 
            this.lblChooseComputer.AutoSize = true;
            this.lblChooseComputer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChooseComputer.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChooseComputer.ForeColor = System.Drawing.Color.White;
            this.lblChooseComputer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblChooseComputer.Location = new System.Drawing.Point(3, 0);
            this.lblChooseComputer.Name = "lblChooseComputer";
            this.lblChooseComputer.Size = new System.Drawing.Size(144, 37);
            this.lblChooseComputer.TabIndex = 1;
            this.lblChooseComputer.Text = "Chọn máy tính:";
            this.lblChooseComputer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChooseTypeInfor
            // 
            this.lblChooseTypeInfor.AutoSize = true;
            this.lblChooseTypeInfor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChooseTypeInfor.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChooseTypeInfor.ForeColor = System.Drawing.Color.White;
            this.lblChooseTypeInfor.Location = new System.Drawing.Point(368, 0);
            this.lblChooseTypeInfor.Name = "lblChooseTypeInfor";
            this.lblChooseTypeInfor.Size = new System.Drawing.Size(166, 37);
            this.lblChooseTypeInfor.TabIndex = 2;
            this.lblChooseTypeInfor.Text = "Chọn loại thông tin:";
            this.lblChooseTypeInfor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowInfor
            // 
            this.btnShowInfor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(183)))), ((int)(((byte)(92)))));
            this.btnShowInfor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(183)))), ((int)(((byte)(92)))));
            this.btnShowInfor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(126)))), ((int)(((byte)(50)))));
            this.btnShowInfor.BorderRadius = 20;
            this.btnShowInfor.BorderSize = 2;
            this.btnShowInfor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowInfor.FlatAppearance.BorderSize = 0;
            this.btnShowInfor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowInfor.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnShowInfor.ForeColor = System.Drawing.Color.White;
            this.btnShowInfor.Location = new System.Drawing.Point(1079, 3);
            this.btnShowInfor.Name = "btnShowInfor";
            this.btnShowInfor.Size = new System.Drawing.Size(104, 31);
            this.btnShowInfor.TabIndex = 4;
            this.btnShowInfor.Text = "Hiển thị";
            this.btnShowInfor.TextColor = System.Drawing.Color.White;
            this.btnShowInfor.UseVisualStyleBackColor = false;
            this.btnShowInfor.Click += new System.EventHandler(this.btnShowInfor_Click);
            // 
            // cboChooseComputer
            // 
            this.cboChooseComputer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboChooseComputer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChooseComputer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboChooseComputer.FormattingEnabled = true;
            this.cboChooseComputer.Location = new System.Drawing.Point(153, 3);
            this.cboChooseComputer.Name = "cboChooseComputer";
            this.cboChooseComputer.Size = new System.Drawing.Size(209, 29);
            this.cboChooseComputer.TabIndex = 6;
            // 
            // treeInformation
            // 
            this.treeInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeInformation.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.treeInformation.Location = new System.Drawing.Point(3, 46);
            this.treeInformation.Name = "treeInformation";
            this.treeInformation.Size = new System.Drawing.Size(1186, 490);
            this.treeInformation.TabIndex = 1;
            // 
            // tabWarning
            // 
            this.tabWarning.Controls.Add(this.tableLayoutPanel5);
            this.tabWarning.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabWarning.Location = new System.Drawing.Point(4, 34);
            this.tabWarning.Name = "tabWarning";
            this.tabWarning.Padding = new System.Windows.Forms.Padding(3);
            this.tabWarning.Size = new System.Drawing.Size(1198, 545);
            this.tabWarning.TabIndex = 1;
            this.tabWarning.Text = "CẢNH BÁO";
            this.tabWarning.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1192, 539);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.tvBefore, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tvCurrent, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 89);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 447F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1186, 447);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // tvBefore
            // 
            this.tvBefore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvBefore.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tvBefore.ForeColor = System.Drawing.Color.DarkGreen;
            this.tvBefore.Location = new System.Drawing.Point(3, 3);
            this.tvBefore.Name = "tvBefore";
            this.tvBefore.Size = new System.Drawing.Size(587, 441);
            this.tvBefore.TabIndex = 4;
            // 
            // tvCurrent
            // 
            this.tvCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvCurrent.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tvCurrent.ForeColor = System.Drawing.Color.DarkGreen;
            this.tvCurrent.Location = new System.Drawing.Point(596, 3);
            this.tvCurrent.Name = "tvCurrent";
            this.tvCurrent.Size = new System.Drawing.Size(587, 441);
            this.tvCurrent.TabIndex = 4;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 46);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1186, 37);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(587, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thông tin trước";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(596, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(587, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thông tin hiện tại";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(173)))), ((int)(((byte)(71)))));
            this.tableLayoutPanel8.ColumnCount = 5;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.85149F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.80198F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.84158F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.60396F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.90099F));
            this.tableLayoutPanel8.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.cboChooseComputerWarning, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnConfirm, 4, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnShowWarrning, 2, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1186, 37);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn máy tính:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboChooseComputerWarning
            // 
            this.cboChooseComputerWarning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboChooseComputerWarning.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChooseComputerWarning.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboChooseComputerWarning.FormattingEnabled = true;
            this.cboChooseComputerWarning.Items.AddRange(new object[] {
            "UUID - PC001"});
            this.cboChooseComputerWarning.Location = new System.Drawing.Point(179, 3);
            this.cboChooseComputerWarning.Name = "cboChooseComputerWarning";
            this.cboChooseComputerWarning.Size = new System.Drawing.Size(228, 29);
            this.cboChooseComputerWarning.TabIndex = 7;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(183)))), ((int)(((byte)(92)))));
            this.btnConfirm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(183)))), ((int)(((byte)(92)))));
            this.btnConfirm.BorderColor = System.Drawing.Color.Green;
            this.btnConfirm.BorderRadius = 30;
            this.btnConfirm.BorderSize = 1;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(1069, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(110, 30);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.TextColor = System.Drawing.Color.White;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnShowWarrning
            // 
            this.btnShowWarrning.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnShowWarrning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(183)))), ((int)(((byte)(92)))));
            this.btnShowWarrning.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(183)))), ((int)(((byte)(92)))));
            this.btnShowWarrning.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(126)))), ((int)(((byte)(50)))));
            this.btnShowWarrning.BorderRadius = 20;
            this.btnShowWarrning.BorderSize = 2;
            this.btnShowWarrning.FlatAppearance.BorderSize = 0;
            this.btnShowWarrning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowWarrning.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnShowWarrning.ForeColor = System.Drawing.Color.White;
            this.btnShowWarrning.Location = new System.Drawing.Point(413, 3);
            this.btnShowWarrning.Name = "btnShowWarrning";
            this.btnShowWarrning.Size = new System.Drawing.Size(105, 31);
            this.btnShowWarrning.TabIndex = 4;
            this.btnShowWarrning.Text = "Hiển thị";
            this.btnShowWarrning.TextColor = System.Drawing.Color.White;
            this.btnShowWarrning.UseVisualStyleBackColor = false;
            this.btnShowWarrning.Click += new System.EventHandler(this.btnShowWarrning_Click);
            // 
            // tabStatistic
            // 
            this.tabStatistic.Controls.Add(this.tableLayoutPanel9);
            this.tabStatistic.Location = new System.Drawing.Point(4, 34);
            this.tabStatistic.Name = "tabStatistic";
            this.tabStatistic.Size = new System.Drawing.Size(1198, 545);
            this.tabStatistic.TabIndex = 2;
            this.tabStatistic.Text = "THỐNG KÊ";
            this.tabStatistic.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.lvwStatistic, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(1198, 545);
            this.tableLayoutPanel9.TabIndex = 15;
            // 
            // lvwStatistic
            // 
            this.lvwStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwStatistic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lvwStatistic.FullRowSelect = true;
            this.lvwStatistic.GridLines = true;
            this.lvwStatistic.HideSelection = false;
            this.lvwStatistic.Location = new System.Drawing.Point(3, 46);
            this.lvwStatistic.Name = "lvwStatistic";
            this.lvwStatistic.Size = new System.Drawing.Size(1192, 496);
            this.lvwStatistic.TabIndex = 9;
            this.lvwStatistic.UseCompatibleStateImageBehavior = false;
            this.lvwStatistic.View = System.Windows.Forms.View.Details;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(173)))), ((int)(((byte)(71)))));
            this.tableLayoutPanel10.ColumnCount = 5;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.23261F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.91973F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.63281F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.26562F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.94922F));
            this.tableLayoutPanel10.Controls.Add(this.btnManage, 4, 0);
            this.tableLayoutPanel10.Controls.Add(this.lblChooseFormStatistic, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.cboChooseStatisticType, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.btnShow, 2, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(1192, 37);
            this.tableLayoutPanel10.TabIndex = 10;
            // 
            // btnManage
            // 
            this.btnManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(183)))), ((int)(((byte)(92)))));
            this.btnManage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(183)))), ((int)(((byte)(92)))));
            this.btnManage.BorderColor = System.Drawing.Color.Green;
            this.btnManage.BorderRadius = 20;
            this.btnManage.BorderSize = 1;
            this.btnManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnManage.FlatAppearance.BorderSize = 0;
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnManage.ForeColor = System.Drawing.Color.White;
            this.btnManage.Location = new System.Drawing.Point(1003, 3);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(186, 31);
            this.btnManage.TabIndex = 11;
            this.btnManage.Text = "Quản lý phiên bản";
            this.btnManage.TextColor = System.Drawing.Color.White;
            this.btnManage.UseVisualStyleBackColor = false;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // lblChooseFormStatistic
            // 
            this.lblChooseFormStatistic.AutoSize = true;
            this.lblChooseFormStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChooseFormStatistic.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChooseFormStatistic.ForeColor = System.Drawing.Color.White;
            this.lblChooseFormStatistic.Location = new System.Drawing.Point(3, 0);
            this.lblChooseFormStatistic.Name = "lblChooseFormStatistic";
            this.lblChooseFormStatistic.Size = new System.Drawing.Size(211, 37);
            this.lblChooseFormStatistic.TabIndex = 6;
            this.lblChooseFormStatistic.Text = "Chọn hình thức thống kê";
            this.lblChooseFormStatistic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboChooseStatisticType
            // 
            this.cboChooseStatisticType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboChooseStatisticType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChooseStatisticType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboChooseStatisticType.FormattingEnabled = true;
            this.cboChooseStatisticType.Location = new System.Drawing.Point(220, 3);
            this.cboChooseStatisticType.Name = "cboChooseStatisticType";
            this.cboChooseStatisticType.Size = new System.Drawing.Size(398, 28);
            this.cboChooseStatisticType.TabIndex = 7;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(183)))), ((int)(((byte)(92)))));
            this.btnShow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(183)))), ((int)(((byte)(92)))));
            this.btnShow.BorderColor = System.Drawing.Color.Green;
            this.btnShow.BorderRadius = 10;
            this.btnShow.BorderSize = 1;
            this.btnShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(624, 3);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(120, 31);
            this.btnShow.TabIndex = 13;
            this.btnShow.Text = "Hiển thị";
            this.btnShow.TextColor = System.Drawing.Color.White;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblManage
            // 
            this.lblManage.AutoSize = true;
            this.lblManage.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblManage.ForeColor = System.Drawing.Color.Red;
            this.lblManage.Location = new System.Drawing.Point(10, 16);
            this.lblManage.Name = "lblManage";
            this.lblManage.Size = new System.Drawing.Size(133, 37);
            this.lblManage.TabIndex = 6;
            this.lblManage.Text = "QUẢN LÝ";
            // 
            // btnAddCSV
            // 
            this.btnAddCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(183)))), ((int)(((byte)(92)))));
            this.btnAddCSV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(183)))), ((int)(((byte)(92)))));
            this.btnAddCSV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(126)))), ((int)(((byte)(50)))));
            this.btnAddCSV.BorderRadius = 30;
            this.btnAddCSV.BorderSize = 2;
            this.btnAddCSV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(126)))), ((int)(((byte)(50)))));
            this.btnAddCSV.FlatAppearance.BorderSize = 0;
            this.btnAddCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCSV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddCSV.ForeColor = System.Drawing.Color.White;
            this.btnAddCSV.Location = new System.Drawing.Point(1036, 6);
            this.btnAddCSV.Name = "btnAddCSV";
            this.btnAddCSV.Size = new System.Drawing.Size(162, 69);
            this.btnAddCSV.TabIndex = 7;
            this.btnAddCSV.Text = "Thêm CSV";
            this.btnAddCSV.TextColor = System.Drawing.Color.White;
            this.btnAddCSV.UseVisualStyleBackColor = false;
            this.btnAddCSV.Click += new System.EventHandler(this.btnAddCSV_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlMain, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1232, 749);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.lblNameSoftware, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.picLogo, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1226, 68);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm thu thập thông tin máy tính (Admin)";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.tab.ResumeLayout(false);
            this.tabShowInfor.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabWarning.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tabStatistic.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNameSoftware;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabShowInfor;
        private ComboTreeBox cboChooseInformationType;
        private CustomControls.btnCustom btnShowInfor;
        private System.Windows.Forms.Label lblChooseComputer;
        private System.Windows.Forms.Label lblChooseTypeInfor;
        private System.Windows.Forms.TabPage tabWarning;
        private CustomControls.btnCustom btnShowWarrning;
        private System.Windows.Forms.Label label1;
        private CustomControls.btnCustom btnConfirm;
        private System.Windows.Forms.TabPage tabStatistic;
        private CustomControls.btnCustom btnShow;
        private System.Windows.Forms.ComboBox cboChooseStatisticType;
        private System.Windows.Forms.Label lblChooseFormStatistic;
        private CustomControls.btnCustom btnManage;
        private System.Windows.Forms.ListView lvwStatistic;
        private System.Windows.Forms.Label lblManage;
        private CustomControls.btnCustom btnAddCSV;
        private System.Windows.Forms.TreeView treeInformation;
        private System.Windows.Forms.ComboBox cboChooseComputer;
        private System.Windows.Forms.ComboBox cboChooseComputerWarning;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView tvCurrent;
        private System.Windows.Forms.TreeView tvBefore;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
    }
}

