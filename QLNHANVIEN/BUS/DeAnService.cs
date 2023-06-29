using Oracle.ManagedDataAccess.Client;
using QLNHANVIEN.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNHANVIEN.BUS
{
    internal class DeAnService
    {
        DeAnRepo repo;

        public DeAnService(OracleConnection conn) { repo = new DeAnRepo(conn); }

        public OracleConnection GetConnection() { return repo.getConnection(); }

        public void setConnection(OracleConnection conn)
        {
            repo.setConnection(conn);
        }

        public DataTable getAll()
        {
            return repo.getAll();
        }
        public DataTable listProject()
        {
            return repo.listProject();
        }

        public void update_DeAn(string mada, string tenda, string ngaybd, string phong)
        {
            repo.update_DeAn(mada, tenda, ngaybd, phong);
        }

        public void insert_DeAn(string mada, string tenda, string ngaybd, string phong)
        {
            repo.insert_DeAn(mada, tenda, ngaybd, phong);
        }
    }
}
