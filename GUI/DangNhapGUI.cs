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
using System.Data.SqlClient;

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

        List<String> loadDatabase()
        {
            List<String> list = new List<string>();
            string connectionString;
            if (checkbOnline.Checked) {
                connectionString = "Data Source=den1.mssql8.gear.host;User id = NV1;Password=123456@;";
            }
            else
            { 
                connectionString = "Data Source=" + cmbServerIP.Text + ";User id = NV1; " +
               "Password=123;";
            }
            
            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            list.Add(dr[0].ToString());
                        }
                    }
                }
            }
            return list;
        }
        string ipAddress;

        void login()
        {
            if(checkbOnline.Checked) { DangNhapBUS.DANGNHAP("den1.mssql8.gear.host", "nv1"); }
            else { DangNhapBUS.DANGNHAP(cmbServerIP.Text, cmbDatabase.Text); }
            
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

        private void cmbServerIP_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btnKetnoiDB_Click(object sender, EventArgs e)
        {
            cmbDatabase.DataSource = loadDatabase();
            try
            {
                
            }
            catch 
            {
                MessageBox.Show("Lỗi kết nối !");
                cmbDatabase.DataSource = null;
            }
        }
    }
}
