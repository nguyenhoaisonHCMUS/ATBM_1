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
    internal class PhongBanRepo
    {
        //private QLNVienEntities db = new QLNVienEntities();
        private EntitiesDB1 db = new EntitiesDB1();
        private OracleConnection conn;

        public PhongBanRepo() { }
        public PhongBanRepo(OracleConnection conn)
        {
            this.conn = conn;
        }

        public OracleConnection getConnection() { return conn; }
        public void setConnection(OracleConnection conn) { this.conn = conn; }

        public DataTable getAllWithNV()
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = "SELECT pb.* , nv.TENNV, nv.PHAI, nv.NGAYSINH, nv.DIACHI, nv.SODT FROM AD.PhongBan pb join AD.NhanVien nv on nv.MANV = pb.TRPHG";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader reader = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(reader);

            conn.Close();

            return empDT;
        }

        public DataTable getAll()
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = "SELECT * FROM AD.PhongBan";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader reader = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(reader);

            conn.Close();

            return empDT;
        }

        public void update_List_DSPhong(ComboBox pb)
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getVT = conn.CreateCommand();
            getVT.CommandText = "select tenpb from ad.phongban";
            getVT.CommandType = CommandType.Text;
            OracleDataReader reader = getVT.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    pb.Items.Add(reader["tenpb"].ToString());
                }
            }
        }

        public PHONGBAN getPhongByTen(string tenp)
        {
            return db.PHONGBANs.Where(p => p.TENPB.Equals(tenp)).Single();
        }
        public DataTable listDepartment()
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = "select * from ad.PhongBan";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader reader = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(reader);

            conn.Close();

            return empDT;
        }

        public void update_PhongBan(string mapb, string tenpb, string trphg)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "ad.proc_update_PhongBan";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_mapb", mapb);
            cmd.Parameters.Add("p_tenpb", tenpb);
            cmd.Parameters.Add("p_matrphg", trphg);
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
