using Oracle.ManagedDataAccess.Client;
using QLNHANVIEN.DAO;
using QLNHANVIEN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNHANVIEN.BUS
{
    public class TaiChinhService
    {
        TaiChinhRepo repo;
        public TaiChinhService(OracleConnection c) { repo = new TaiChinhRepo(c); }

        public OracleConnection GetConnection() { return repo.getConnection(); }
        public void setConnection(OracleConnection conn) { repo.setConnection(conn); }

       /* public DataTable layDSNhanVien()
        {
            return repoNV.getAll();
        }
        public DataTable layDSPhanCong()
        {
            return repoNV.getAll();
        }*/
        public bool capNhatLuongVaPhuCap(NHANVIEN nv)
        {
            return repo.capNhatLuongVaPhuCap(nv);
        }


    }
}
