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
    public class PhanCongRepo
    {
        private EntitiesDB1 db = new EntitiesDB1();
        private OracleConnection conn;

        public PhanCongRepo() { }
        public PhanCongRepo(OracleConnection conn)
        {
            this.conn = conn;
        }
        public OracleConnection getConnection() { return conn; }
        public void setConnection(OracleConnection conn) { this.conn = conn; }

        public DataTable layDSPhanCong()
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = "SELECT * FROM AD.PHANCONG";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader reader = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(reader);

            conn.Close();

            return empDT;
        }
        public DataTable listAssignment()
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = "select * from ad.PhanCong";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader reader = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(reader);

            conn.Close();

            return empDT;
        }
        public void updateAssignment(int maNV, int maDA, DateTime thoiGian)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "ad.proc_update_PhanCong";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_manv", maNV);
            cmd.Parameters.Add("p_mada", maDA);
            cmd.Parameters.Add("p_thoigian", thoiGian);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật phân công thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng kiểm tra lại.");

            }
        }
        public void insertAssignment(int maNV, int maDA, DateTime thoiGian)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "ad.proc_insert_PhanCong";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_manv", maNV);
            cmd.Parameters.Add("p_mada", maDA);
            cmd.Parameters.Add("p_thoigian", thoiGian);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm phân công thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng kiểm tra lại.");

            }
        }
        public void deleteAssignment(int maNV, int maDA)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "ad.proc_delete_PhanCong";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_manv", maNV);
            cmd.Parameters.Add("p_mada", maDA);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xoá phân công thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng kiểm tra lại.");

            }
        }
    }
}
