using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using QLNHANVIEN.DTO;
using System.Data;
using QLNHANVIEN.BUS;
using QLNHANVIEN.gui;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks.Sources;

namespace QLNHANVIEN.DAO
{
    public class NhanVienRepo
    {

        private EntitiesDB1 db = new EntitiesDB1();
        private OracleConnection conn;

        public NhanVienRepo(){ }
        public NhanVienRepo( OracleConnection conn)
        {
            this.conn = conn;
        }


        //public static NhanVienRepo getInstance() { return instance; }
        public OracleConnection getConnection(){ return conn; }
        public void setConnection(OracleConnection conn) { this.conn = conn; }


        public DataTable getAll()
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = "SELECT * FROM AD.xem_NHANVIEN";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader reader = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(reader);
            
            conn.Close();

            return empDT;
        }

        public DataTable getAllByNS()
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = "SELECT * FROM AD.NhanVien";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader reader = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(reader);

            conn.Close();

            return empDT;
        }

        public string getRoleByUser(string user) 
        {
            return db.NHANVIENs.Where(p => p.USERNAME.Equals(user)).Single().VAITRO.ToString();
        }
        public NHANVIEN getNVByUser(string user)
        {
            return db.NHANVIENs.Where(p => p.USERNAME.Equals(user)).Single();
        }



        //grant role to user 
        public void update_List_Role(ComboBox Role)
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getRole = conn.CreateCommand();
            getRole.CommandText = "SELECT GRANTED_ROLE FROM USER_ROLE_PRIVS WHERE ADMIN_OPTION = 'YES'";
            getRole.CommandType = CommandType.Text;
            OracleDataReader reader = getRole.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    Role.Items.Add(reader["GRANTED_ROLE"].ToString());
                    
                }

            }
            
        }

        public DataTable selectPrivsRoleOfUser(string username)
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = "select * from dba_role_privs where grantee= upper('"+ username+"')";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader reader = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(reader);

            conn.Close();

            return empDT;
        }
        public bool grantRoleToUser(string RoleName,string User)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "sp_Grant_Role_TO_User";

            MessageBox.Show(cmd.CommandText);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("username", User);
            cmd.Parameters.Add("rolename", RoleName);
            

            try
            {
                cmd.ExecuteNonQuery();
                return true;
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng kiểm tra lại.");
                return false;
            }

            
        }

        //
        public bool revoleRoleToUser(string RoleName, string User)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "sp_Revoke_Role_from_User";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("rolename", RoleName);
            cmd.Parameters.Add("username", User);           

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng kiểm tra lại.");
                return false;
            }

            return false;
        }

        public void update_List_VaiTro(ComboBox vaitro)
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getVT = conn.CreateCommand();
            getVT.CommandText = "select distinct vaitro from ad.nhanvien";
            getVT.CommandType = CommandType.Text;
            OracleDataReader reader = getVT.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    vaitro.Items.Add(reader["vaitro"].ToString());

                }

            }


        }

        public DataTable getDSDeAn()
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = "SELECT * from ad.dean";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader reader = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(reader);

            conn.Close();

            return empDT;
        }

        public DataTable getDSPhongBan()
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = "SELECT * from ad.phongban";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader reader = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(reader);

            conn.Close();

            return empDT;
        }

        public bool updateTTNV(NHANVIEN nv)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "ad.proc_update_NhanVien";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("p_manv", nv.MANV);
                cmd.Parameters.Add("p_ngaysinh", nv.NGAYSINH);
                cmd.Parameters.Add("p_diachi", nv.DIACHI);
                cmd.Parameters.Add("p_sodt", nv.SODT);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw new Exception(e.Message);
                return false;
            }
            conn.Close();
        }

        public void update_List_LinhVuc(ComboBox linhvuc)
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getVT = conn.CreateCommand();
            getVT.CommandText = "select distinct linhvuc from ad.nhanvien";
            getVT.CommandType = CommandType.Text;
            OracleDataReader reader = getVT.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    linhvuc.Items.Add(reader["linhvuc"].ToString());
                }
            }
        }

        public void update_List_chinhanh(ComboBox chinhanh)
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getVT = conn.CreateCommand();
            getVT.CommandText = "select distinct chinhanh from ad.nhanvien";
            getVT.CommandType = CommandType.Text;
            OracleDataReader reader = getVT.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    chinhanh.Items.Add(reader["chinhanh"].ToString());
                }
            }
        }


        public bool AdcreateUser(NHANVIEN nv) {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "ad.sp_ThemNhanVien_AD";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("P_TENNV", nv.TENNV);
            cmd.Parameters.Add("P_PHAI", nv.PHAI);
            cmd.Parameters.Add("P_NGAYSINH", nv.NGAYSINH);
            cmd.Parameters.Add("P_DIACHI", nv.DIACHI);
            cmd.Parameters.Add("P_SODT", nv.SODT);
            cmd.Parameters.Add("P_LUONG", nv.LUONG);
            cmd.Parameters.Add("P_PHUCAP", nv.PHUCAP);
            cmd.Parameters.Add("P_VAITRO", nv.VAITRO);
            cmd.Parameters.Add("P_PHG", nv.PHG);
            cmd.Parameters.Add("P_LINHVUC", nv.LINHVUC);
            cmd.Parameters.Add("P_CHINHANH", nv.CHINHANH);


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
            conn.Close();

        }


        public bool NScreateUser(NHANVIEN nv)
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "ad.sp_ThemNhanVien_NhanSu";
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.Add("P_TENNV", nv.TENNV);
            cmd.Parameters.Add("P_PHAI", nv.PHAI);
            cmd.Parameters.Add("P_NGAYSINH", nv.NGAYSINH);
            cmd.Parameters.Add("P_DIACHI", nv.DIACHI);
            cmd.Parameters.Add("P_SODT", nv.SODT);
            cmd.Parameters.Add("P_VAITRO", nv.VAITRO);
            cmd.Parameters.Add("P_PHG", nv.PHG);
            cmd.Parameters.Add("P_LINHVUC", nv.LINHVUC);
            cmd.Parameters.Add("P_CHINHANH", nv.CHINHANH);


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
            conn.Close();

        }
        public DataTable listStaff()
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = "select * from ad.nhanvien";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader reader = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(reader);

            conn.Close();

            return empDT;
        }

        public void updateMyInfo(int maNV, DateTime ngaySinh, string diaChi, string sodt)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "ad.proc_update_NhanVien";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_manv", maNV);
            cmd.Parameters.Add("p_ngaysinh", ngaySinh);
            cmd.Parameters.Add("p_diachi", diaChi);
            cmd.Parameters.Add("p_sodt", sodt);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng kiểm tra lại.");

            }
        }
        public NHANVIEN findByUsername(String username)
        {
            try
            {
                return db.NHANVIENs.Where(p => p.USERNAME.Equals(username)).Single();
            }
            catch (Exception e)
            {
                throw new MissingManifestResourceException("username: " + username + " not found");
            }
        }
        public DataTable getDSNhanVien()
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = "select * from ad.nhanvien";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader reader = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(reader);

            conn.Close();

            return empDT;
        }


        public DataTable getNVByUserTC(string user)
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = "select * from ad.xem_nhanvien where username='"+user+"'";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader reader = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(reader);

            conn.Close();

            return empDT;
        }



    }
}
