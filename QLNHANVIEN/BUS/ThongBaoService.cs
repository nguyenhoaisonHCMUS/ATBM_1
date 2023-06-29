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
    internal class ThongBaoService
    {
        ThongBaoRepo repo;

        public ThongBaoService(OracleConnection conn) { repo = new ThongBaoRepo(conn); }

        public OracleConnection GetConnection() { return repo.getConnection(); }

        public void setConnection(OracleConnection conn)
        {
            repo.setConnection(conn);
        }

        public DataTable getAll()
        {
            return repo.getAll();
        }

        public void insertAssignment(string noidung, string vaitro, string linhvuc, string chinhanh)
        {
            repo.insertNotification(noidung, vaitro, linhvuc, chinhanh);
        }
    }
}
