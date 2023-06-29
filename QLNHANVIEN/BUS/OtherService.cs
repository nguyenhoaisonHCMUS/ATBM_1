using Oracle.ManagedDataAccess.Client;
using QLNHANVIEN.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNHANVIEN.BUS
{
    public class OtherService
    {
        OtherRepo repo;

        public OtherService() { }

        public OtherService(OracleConnection c) { repo = new OtherRepo(c); }

        public OracleConnection GetConnection() { return repo.getConnection(); }
        public void setConnection(OracleConnection conn)
        {
            repo.setConnection(conn);
        }
        public DataTable updateGridList_Role()
        {
            return repo.updateGridList_Role();
        }
        public DataTable SelectDSRole_Privs(string role)
        {
            return repo.SelectDSRole_Privs(role);
        }

        public bool grantTableToRole(string RoleName, string Table, string priv)
        {
            return repo.grantTableToRole(RoleName, Table, priv);
        }

        public bool revokeTableFromRole(string RoleName, string Table, string priv)
        {
            return repo.revokeTableFromRole(RoleName, Table, priv);
        }

        public void update_comboBox(ComboBox table)
        {
            repo.update_comboBox(table);
        }
        public bool createRole(string role) { return repo.createRole(role); }
        public bool dropRole(string role) { return repo.dropRole(role); }
    }
}
