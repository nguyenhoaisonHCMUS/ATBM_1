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
    public class TaiChinhRepo
    {
        private EntitiesDB1 db = new EntitiesDB1();
        private OracleConnection conn;

        public TaiChinhRepo() { }
        public TaiChinhRepo(OracleConnection conn)
        {
            this.conn = conn;
        }

        public OracleConnection getConnection() { return conn; }
        public void setConnection(OracleConnection conn) { this.conn = conn; }

        public bool capNhatLuongVaPhuCap(NHANVIEN nv)
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "ad.TG_CAPNHATXEPHANG";
            MessageBox.Show(cmd.CommandText);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("manvv", nv.MANV);
            cmd.Parameters.Add("dauvaoLUONG", nv.LUONG);
            cmd.Parameters.Add("dauvaoPC", nv.PHUCAP);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw new Exception(e.Message);
                return false;
            }
        }
    }
}
