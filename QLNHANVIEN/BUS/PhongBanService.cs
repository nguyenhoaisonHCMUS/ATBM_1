using Oracle.ManagedDataAccess.Client;
using QLNHANVIEN.DAO;
using QLNHANVIEN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNHANVIEN.BUS
{
    internal class PhongBanService
    {
        PhongBanRepo repo;

        public PhongBanService(OracleConnection c) { repo = new PhongBanRepo(c); }

        public OracleConnection GetConnection() { return repo.getConnection(); }

        public void setConnection(OracleConnection conn)
        {
            repo.setConnection(conn);
        }

        public DataTable getAll()
        {
            return repo.getAll();
        }

        public DataTable getAllWithNV()
        {
            return repo.getAllWithNV();
        }

        public void update_List_DSPhong(ComboBox pb) { repo.update_List_DSPhong(pb); }

        public PHONGBAN getPhongByTen(string tenp) { return repo.getPhongByTen(tenp); }
        public DataTable listDepartment()
        {
            return repo.listDepartment();
        }

        public void update_PhongBan(string mapb, string tenpb, string trphg)
        {
            repo.update_PhongBan(mapb, tenpb, trphg);
        }
    }
}
