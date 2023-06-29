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
    internal class DeAnRepo
    {
        private EntitiesDB1 db = new EntitiesDB1();
        private OracleConnection conn;

        public DeAnRepo() { }
        public DeAnRepo(OracleConnection conn)
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
            getEmps.CommandText = "SELECT da.*, pb.TENPB FROM AD.DeAn da join AD.PhongBan pb ON da.PHONG = pb.MAPB";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader reader = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(reader);

            conn.Close();

            return empDT;
        }
        public DataTable listProject()
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = "select * from ad.DeAn";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader reader = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(reader);

            conn.Close();

            return empDT;
        }

        public void update_DeAn(string mada, string tenda, string ngaybd, string phong)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "ad.proc_update_DeAn";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_mada", mada);
            cmd.Parameters.Add("p_tenda", tenda);
            cmd.Parameters.Add("p_ngaybd", ngaybd);
            cmd.Parameters.Add("p_phong", phong);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng kiểm tra lại.");

            }
        }

        public void insert_DeAn(string mada, string tenda, string ngaybd, string phong)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "ad.proc_insert_DeAn";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_mada", mada);
            cmd.Parameters.Add("p_tenda", tenda);
            cmd.Parameters.Add("p_ngaybd", ngaybd);
            cmd.Parameters.Add("p_phong", phong);
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
