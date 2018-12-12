using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace DAO
{
    public class DataProvider
    {
        public static string _IP { get; set; }
        public static string _DATABASE { set; get; }
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            } 
        }

        SqlConnection con;
        SqlDataAdapter dap;
        SqlCommand cmd;

        private DataProvider()
        {
            connectDB();
        }

        public static void _DANGNHAP(string ip, string database)
        {
            _IP = ip;
            _DATABASE = database;
        }
        public static List<String> ListIP;
        public static string ipAddress;
        public static List<String> QuetIP()
        {
            ListIP = new List<string>();
            string ipBase = "";

            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipBase = ip.ToString();
                    ipAddress = ipBase;
                }
            }

            String[] ipPart = ipBase.Split('.');
            ipBase = ipPart[0] + "." + ipPart[1] + "." + ipPart[2] + ".";

            for (int i = 0; i < 255; i++)
            {
                string ip = ipBase + i.ToString();

                Ping p = new Ping();
                p.PingCompleted += new PingCompletedEventHandler(P_PingCompleted);
                p.SendAsync(ip, 100, ip);
            }
            ListIP.Add(ipAddress);
            return ListIP;
        }

        public static void P_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            PingReply pr = e.Reply;
            if (e.Reply.Address.ToString() != "0.0.0.0" && e.Reply.Address.ToString() != ipAddress)
            {
                ListIP.Add(e.Reply.Address.ToString());
            }
        }

        //Kết nối
        public void connectDB()
        {
            string strCon;
            if (_IP== "den1.mssql8.gear.host") {
                strCon = "Data Source=" + _IP + ";" +
                "Initial Catalog=" + _DATABASE + ";" +
                //"Integrated Security=True;";
                "User id=NV1;" +
                "Password=123456@;";
            }
            else {
                strCon = "Data Source=" + _IP + ";" +
                         "Initial Catalog=" + _DATABASE + ";" +
                         //"Integrated Security=True;";
                         "User id=NV1;" +
                         "Password=123;";
            }
            
            //"Integrated Security=True";
            con = new SqlConnection(strCon);
            cmd = con.CreateCommand();
            try
            {
                con.Open();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                con.Dispose();
            }
        }

        //Thực hiện câu lệnh sql trả về bảng dữ liệu
        public DataTable getDS(string sql)
        {
            DataTable tbl = new DataTable();
            dap = new SqlDataAdapter(sql, con);
            dap.Fill(tbl);
            return tbl;
        }
        public object ExecuteScalar(string strSQL, CommandType ct)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            object Data = cmd.ExecuteScalar();
            return Data;
        }

        //Thực thi lệnh sql chèn, xóa, sửa
        public bool ExecuteNonQueryPara(string sql, string[] parameters, object[] value)
        {
            int num = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cmd = new SqlCommand(sql, con);
                SqlParameter p;
                for (int i = 0; i < parameters.Length; i++)
                {
                    p = new SqlParameter(parameters[i], value[i]);
                    cmd.Parameters.Add(p);
                }
                num = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            if (num > 0)
                return true;
            else
                return false;
        }

        public bool ExecuteQuery(string sql)
        {
            int num = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cmd = new SqlCommand(sql, con);
                num = (int)cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            if (num > 0)
                return true;
            else
                return false;
        }

        //Kiểm tra sự tồn tại
        public bool checkExist(string tblName, string field, string value)
        {
            string sql = "Select Count (*) From " + tblName + " where " + field + "='" + value + "'";
            cmd = new SqlCommand(sql, con);
            int num = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                num = (int)cmd.ExecuteScalar();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            if (num > 0)
                return true;
            else
                return false;
        }

        // Lấy mã cuối cùng
        public string GetLastID(string nameTable, string nameFiled)
        {
            string sql = "SELECT TOP (1) " + nameFiled + " FROM " + nameTable + " ORDER BY " + nameFiled + " DESC";
            return getDS(sql).Rows[0][nameFiled].ToString();
        }
    }
}
