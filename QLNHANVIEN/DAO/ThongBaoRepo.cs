using Oracle.ManagedDataAccess.Client;
using QLNHANVIEN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNHANVIEN.DAO
{
    internal class ThongBaoRepo
    {
        private EntitiesDB1 db = new EntitiesDB1();
        private OracleConnection conn;

        public ThongBaoRepo() { }
        public ThongBaoRepo(OracleConnection conn)
        {
            this.conn = conn;
        }

        public OracleConnection getConnection() { return conn; }
        public void setConnection(OracleConnection conn) { this.conn = conn; }

        public DataTable getAll()
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = "SELECT NOIDUNG, THOIGIAN, VAITRO, LINHVUC, CHINHANH FROM AD.THONGBAO";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader reader = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(reader);

            conn.Close();

            return empDT;
        }

        public void insertNotification(string noidung, string vaitro, string linhvuc, string chinhanh)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "ad.proc_send_notification";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_noidung", noidung);
            cmd.Parameters.Add("p_vaitro", vaitro);
            cmd.Parameters.Add("p_linhvuc", linhvuc);
            cmd.Parameters.Add("p_chinhanh", chinhanh);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng kiểm tra lại.");

            }
        }
    }
}
