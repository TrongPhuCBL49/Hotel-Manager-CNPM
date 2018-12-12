using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class SuDungDichVuDAO
    {
        private static SuDungDichVuDAO instance;

        public static SuDungDichVuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SuDungDichVuDAO();
                return instance;
            }
        }

        private SuDungDichVuDAO() { }

        public DataTable DSDichVu()
        {
            string query = "Select * From DichVu";
            return DataProvider.Instance.getDS(query);
        }
    }
}