namespace GUI
{
    partial class SuDungDichVuGUI
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
            this.grpDanhSachDichVu = new DevExpress.XtraEditors.GroupControl();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.grpDanhSachSuDung = new DevExpress.XtraEditors.GroupControl();
            this.cboPhong = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtNhanTenPhong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.fllDSDichVu = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvDSSuDung = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grpDanhSachDichVu)).BeginInit();
            this.grpDanhSachDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDanhSachSuDung)).BeginInit();
            this.grpDanhSachSuDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSuDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDanhSachDichVu
            // 
            this.grpDanhSachDichVu.Controls.Add(this.fllDSDichVu);
            this.grpDanhSachDichVu.Location = new System.Drawing.Point(19, 175);
            this.grpDanhSachDichVu.Name = "grpDanhSachDichVu";
            this.grpDanhSachDichVu.Size = new System.Drawing.Size(884, 827);
            this.grpDanhSachDichVu.TabIndex = 0;
            this.grpDanhSachDichVu.Text = "Danh sách dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nhân viên:";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Enabled = false;
            this.txtTenNhanVien.Location = new System.Drawing.Point(351, 30);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(361, 50);
            this.txtTenNhanVien.TabIndex = 18;
            // 
            // grpDanhSachSuDung
            // 
            this.grpDanhSachSuDung.Controls.Add(this.btnHuy);
            this.grpDanhSachSuDung.Controls.Add(this.dgvDSSuDung);
            this.grpDanhSachSuDung.Controls.Add(this.btnLuu);
            this.grpDanhSachSuDung.Controls.Add(this.label2);
            this.grpDanhSachSuDung.Controls.Add(this.textEdit1);
            this.grpDanhSachSuDung.Location = new System.Drawing.Point(909, 175);
            this.grpDanhSachSuDung.Name = "grpDanhSachSuDung";
            this.grpDanhSachSuDung.Size = new System.Drawing.Size(797, 827);
            this.grpDanhSachSuDung.TabIndex = 0;
            this.grpDanhSachSuDung.Text = "Danh sách sử dụng";
            // 
            // cboPhong
            // 
            this.cboPhong.Location = new System.Drawing.Point(421, 100);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPhong.Size = new System.Drawing.Size(291, 50);
            this.cboPhong.TabIndex = 22;
            // 
            // txtNhanTenPhong
            // 
            this.txtNhanTenPhong.AutoSize = true;
            this.txtNhanTenPhong.Font = new System.Drawing.Font("Tahoma", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanTenPhong.Location = new System.Drawing.Point(1105, 50);
            this.txtNhanTenPhong.Name = "txtNhanTenPhong";
            this.txtNhanTenPhong.Size = new System.Drawing.Size(197, 64);
            this.txtNhanTenPhong.TabIndex = 20;
            this.txtNhanTenPhong.Text = "Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Chọn phòng:";
            // 
            // textEdit1
            // 
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(514, 754);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(264, 50);
            this.textEdit1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 761);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 34);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tổng:";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(18, 744);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(136, 62);
            this.btnLuu.TabIndex = 23;
            this.btnLuu.Text = "Lưu";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(211, 742);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(136, 62);
            this.btnHuy.TabIndex = 23;
            this.btnHuy.Text = "Hủy";
            // 
            // fllDSDichVu
            // 
            this.fllDSDichVu.Location = new System.Drawing.Point(23, 69);
            this.fllDSDichVu.Name = "fllDSDichVu";
            this.fllDSDichVu.Size = new System.Drawing.Size(840, 735);
            this.fllDSDichVu.TabIndex = 0;
            // 
            // dgvDSSuDung
            // 
            this.dgvDSSuDung.Location = new System.Drawing.Point(6, 51);
            this.dgvDSSuDung.MainView = this.gridView1;
            this.dgvDSSuDung.Name = "dgvDSSuDung";
            this.dgvDSSuDung.Size = new System.Drawing.Size(785, 663);
            this.dgvDSSuDung.TabIndex = 0;
            this.dgvDSSuDung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvDSSuDung;
            this.gridView1.Name = "gridView1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.cboPhong);
            this.groupBox1.Controls.Add(this.txtNhanTenPhong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenNhanVien);
            this.groupBox1.Location = new System.Drawing.Point(19, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1687, 169);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // SuDungDichVuGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpDanhSachSuDung);
            this.Controls.Add(this.grpDanhSachDichVu);
            this.Name = "SuDungDichVuGUI";
            this.Size = new System.Drawing.Size(1721, 1022);
            this.Load += new System.EventHandler(this.SuDungDichVuGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpDanhSachDichVu)).EndInit();
            this.grpDanhSachDichVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDanhSachSuDung)).EndInit();
            this.grpDanhSachSuDung.ResumeLayout(false);
            this.grpDanhSachSuDung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSuDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpDanhSachDichVu;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtTenNhanVien;
        private DevExpress.XtraEditors.GroupControl grpDanhSachSuDung;
        private DevExpress.XtraEditors.ComboBoxEdit cboPhong;
        private System.Windows.Forms.Label txtNhanTenPhong;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private System.Windows.Forms.FlowLayoutPanel fllDSDichVu;
        private DevExpress.XtraGrid.GridControl dgvDSSuDung;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
