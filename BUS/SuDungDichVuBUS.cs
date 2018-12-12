using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class SuDungDichVuBUS
    {
        private static SuDungDichVuBUS instance;

        public static SuDungDichVuBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new SuDungDichVuBUS();
                return instance;
            }
        }

        private SuDungDichVuBUS() { }
        public List<DichVuDTO> DSDichVu()
        {
            List<DichVuDTO> DSDichVu = new List<DichVuDTO>();
            DataTable dtb = SuDungDichVuDAO.Instance.DSDichVu();
            foreach (DataRow item in dtb.Rows)
            {
                DichVuDTO dichVu = new DichVuDTO();
                dichVu.Id = (int)item["ID"];
                dichVu.Ten = item["Ten"].ToString();
                dichVu.Gia = (int)item["Gia"];
                DSDichVu.Add(dichVu);
            }
            return DSDichVu;
        }
    }
}