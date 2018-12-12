using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using DevExpress.XtraEditors;

namespace GUI
{
    public partial class SuDungDichVuGUI : UserControl
    {
        public SuDungDichVuGUI()
        {
            InitializeComponent();
        }

        private void SuDungDichVuGUI_Load(object sender, EventArgs e)
        {
            LoadDanhSachDichVu();
            LoadPhong();
            cboPhong.SelectedIndex = 0;
            txtNhanTenPhong.DataBindings.Add("Text", cboPhong, "Text");
            txtTenNhanVien.Text = "Phòng " + DatPhongBUS.Instance.TenNhanVien(DangNhapGUI.IdNhanVien);
        }

        void LoadDanhSachDichVu()
        {
            List<DichVuDTO> dsDichVu = SuDungDichVuBUS.Instance.DSDichVu();
            foreach (DichVuDTO dichVu in dsDichVu)
            {
                SimpleButton btn = new SimpleButton() { Width = 70, Height = 50 };
                btn.Name = "btn" + dichVu.Ten;
                btn.Text = dichVu.Id.ToString() + ". " + dichVu.Ten;
                btn.Click += Btn_Click;
                fllDSDichVu.Controls.Add(btn);
            }

        }
        void LoadPhong()
        {
            DataTable dtbPhong = PhongBUS.Instance.DSPhong();
            foreach (DataRow row in dtbPhong.Rows)
                if (row["TrangThai"].ToString() == "Chưa đặt")
                    cboPhong.Properties.Items.Add(row["Ten"]);
        }

        private void Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
