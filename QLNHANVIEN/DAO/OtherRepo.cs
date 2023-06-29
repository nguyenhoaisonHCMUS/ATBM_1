using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNHANVIEN.DAO
{
    public class OtherRepo
    {
        private OracleConnection conn;
        public OtherRepo() { }
        public OtherRepo(OracleConnection c) { this.conn = c; }

        public OracleConnection getConnection() { return conn; }
        public void setConnection(OracleConnection conn) { this.conn = conn; }


        public DataTable updateGridList_Role()
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = "select GRANTED_ROLE ROLE, USERNAME ADMIN  from USER_ROLE_PRIVS WHERE ADMIN_OPTION = 'YES'";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader reader = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(reader);
            conn.Close();

            return empDT;
        }

        public DataTable SelectDSRole_Privs(string role)
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = "SELECT * from ROLE_TAB_PRIVS where role='"+role+"'";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader reader = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(reader);

            conn.Close();

            return empDT;
        }

        public bool grantTableToRole(string RoleName, string Table,string priv)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "sp_Grant_Permission_User_Role";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("p_permission", priv);
            cmd.Parameters.Add("p_object", Table);
            cmd.Parameters.Add("p_grantee", RoleName);

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

        public bool revokeTableFromRole(string RoleName, string Table, string priv)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "sp_Revoke_Permission_User_Role";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("p_permission", priv);
            cmd.Parameters.Add("p_object", Table);
            cmd.Parameters.Add("p_grantee", RoleName);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                
                return false;
            }

            return false;
        }


        public void update_comboBox(ComboBox table)
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getRole = conn.CreateCommand();
            getRole.CommandText = "select TABLE_NAME from dba_tables where owner='AD'";
            getRole.CommandType = CommandType.Text;
            OracleDataReader reader = getRole.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    table.Items.Add(reader["TABLE_NAME"].ToString());
                    
                }

            }
            
        }

        public bool createRole(string role)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            Console.WriteLine(role);
            cmd.CommandText = "sp_Create_Role";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("role_name", role);


            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public bool dropRole(string role)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "sp_Drop_Role";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("role_name", role);


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

            return false;
        }
    }
}
