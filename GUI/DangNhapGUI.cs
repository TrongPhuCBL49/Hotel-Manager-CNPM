using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using BUS;

namespace GUI
{
    public partial class DangNhapGUI : DevExpress.XtraEditors.XtraForm
    {
        public static string IdNhanVien = "";
        public static int IdChucDanh = -1;
        public DangNhapGUI()
        {
            InitializeComponent();
            LoadIP();
            txtMaNhanVien.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            login();
        }

        List<String> IPServer;
        private void LoadIP()
        {
            IPServer = DangNhapBUS.Instance.GetIP();
            cmbServerIP.DataSource = IPServer;
        }
        string ipAddress;

        void login()
        {
            DangNhapBUS.DANGNHAP(cmbServerIP.SelectedItem.ToString(), txtDatabase.Text);
            if (DangNhapBUS.Instance.KiemTraUser(txtMaNhanVien.Text, txtMatKhau.Text))
            {
                IdNhanVien = txtMaNhanVien.Text;
                IdChucDanh = DangNhapBUS.Instance.IdChucDanh(IdNhanVien);
                Form f = new MainGUI();
                //Xử lý khi đóng form con thì sẽ chạy event show lại form này
                f.FormClosed += F_FormClosed;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
                this.Hide();
                txtMaNhanVien.Text = "";
                txtMatKhau.Text = "";
            }
            else
                MessageBox.Show("Mã nhân viên hoặc mật khẩu không đúng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnCancelDangNhap_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DangNhapGUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                login();
        }

        private void DangNhapGUI_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadIP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đa quét IP thành công!");
            List<String> temp = new List<string>();
            temp.Add("");
            cmbServerIP.DataSource = temp;
            cmbServerIP.DataSource = IPServer;
        }
    }
}
