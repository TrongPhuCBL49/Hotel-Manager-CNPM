namespace GUI
{
    partial class DangNhapGUI
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
            this.btnCancelDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.linkQuenMatKhau = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnKetnoiDB = new DevExpress.XtraEditors.SimpleButton();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.cmbServerIP = new System.Windows.Forms.ComboBox();
            this.btnLoadIP = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.checkbOnline = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelDangNhap
            // 
            this.btnCancelDangNhap.Location = new System.Drawing.Point(188, 320);
            this.btnCancelDangNhap.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancelDangNhap.Name = "btnCancelDangNhap";
            this.btnCancelDangNhap.Size = new System.Drawing.Size(80, 22);
            this.btnCancelDangNhap.TabIndex = 4;
            this.btnCancelDangNhap.Text = "Cancel";
            this.btnCancelDangNhap.Click += new System.EventHandler(this.btnCancelDangNhap_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(56, 320);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(1);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(80, 22);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "OK";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.linkQuenMatKhau);
            this.groupControl1.Controls.Add(this.txtMatKhau);
            this.groupControl1.Controls.Add(this.txtMaNhanVien);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(15, 183);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(299, 125);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thông tin đăng nhập";
            // 
            // linkQuenMatKhau
            // 
            this.linkQuenMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkQuenMatKhau.Location = new System.Drawing.Point(180, 99);
            this.linkQuenMatKhau.Margin = new System.Windows.Forms.Padding(1);
            this.linkQuenMatKhau.Name = "linkQuenMatKhau";
            this.linkQuenMatKhau.Size = new System.Drawing.Size(78, 13);
            this.linkQuenMatKhau.TabIndex = 2;
            this.linkQuenMatKhau.Text = "Quên mật khẩu?";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.EditValue = "";
            this.txtMatKhau.Location = new System.Drawing.Point(116, 70);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(1);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.PasswordChar = '9';
            this.txtMatKhau.Size = new System.Drawing.Size(147, 20);
            this.txtMatKhau.TabIndex = 2;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.EditValue = "";
            this.txtMaNhanVien.Location = new System.Drawing.Point(116, 33);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(147, 20);
            this.txtMaNhanVien.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 71);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(1);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mật khẩu: ";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 35);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(1);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã nhân viên:";
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.Appearance.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.checkbOnline);
            this.groupControl2.Controls.Add(this.btnKetnoiDB);
            this.groupControl2.Controls.Add(this.cmbDatabase);
            this.groupControl2.Controls.Add(this.cmbServerIP);
            this.groupControl2.Controls.Add(this.btnLoadIP);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Location = new System.Drawing.Point(14, 8);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(1);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(299, 160);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Server";
            // 
            // btnKetnoiDB
            // 
            this.btnKetnoiDB.Location = new System.Drawing.Point(160, 127);
            this.btnKetnoiDB.Margin = new System.Windows.Forms.Padding(1);
            this.btnKetnoiDB.Name = "btnKetnoiDB";
            this.btnKetnoiDB.Size = new System.Drawing.Size(80, 22);
            this.btnKetnoiDB.TabIndex = 7;
            this.btnKetnoiDB.Text = "Lấy Databse";
            this.btnKetnoiDB.Click += new System.EventHandler(this.btnKetnoiDB_Click);
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Location = new System.Drawing.Point(116, 63);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(147, 21);
            this.cmbDatabase.TabIndex = 6;
            // 
            // cmbServerIP
            // 
            this.cmbServerIP.FormattingEnabled = true;
            this.cmbServerIP.Location = new System.Drawing.Point(116, 32);
            this.cmbServerIP.Name = "cmbServerIP";
            this.cmbServerIP.Size = new System.Drawing.Size(147, 21);
            this.cmbServerIP.TabIndex = 5;
            this.cmbServerIP.SelectedValueChanged += new System.EventHandler(this.cmbServerIP_SelectedValueChanged);
            // 
            // btnLoadIP
            // 
            this.btnLoadIP.Location = new System.Drawing.Point(60, 127);
            this.btnLoadIP.Margin = new System.Windows.Forms.Padding(1);
            this.btnLoadIP.Name = "btnLoadIP";
            this.btnLoadIP.Size = new System.Drawing.Size(80, 22);
            this.btnLoadIP.TabIndex = 4;
            this.btnLoadIP.Text = "Load IP";
            this.btnLoadIP.Click += new System.EventHandler(this.btnLoadIP_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 71);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(1);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Database Name";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 35);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(1);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "IP Server";
            // 
            // checkbOnline
            // 
            this.checkbOnline.AutoSize = true;
            this.checkbOnline.Location = new System.Drawing.Point(116, 96);
            this.checkbOnline.Name = "checkbOnline";
            this.checkbOnline.Size = new System.Drawing.Size(105, 17);
            this.checkbOnline.TabIndex = 8;
            this.checkbOnline.Text = "Database Online";
            this.checkbOnline.UseVisualStyleBackColor = true;
            // 
            // DangNhapGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 353);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.btnCancelDangNhap);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.groupControl1);
            this.Name = "DangNhapGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.DangNhapGUI_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DangNhapGUI_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancelDangNhap;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.HyperlinkLabelControl linkQuenMatKhau;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.TextEdit txtMaNhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.ComboBox cmbServerIP;
        private DevExpress.XtraEditors.SimpleButton btnLoadIP;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cmbDatabase;
        private DevExpress.XtraEditors.SimpleButton btnKetnoiDB;
        private System.Windows.Forms.CheckBox checkbOnline;
    }
}

