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
    public class PhanCongService
    {
        PhanCongRepo repo;
        public PhanCongService(OracleConnection con) { repo = new PhanCongRepo(con); }
        public OracleConnection GetConnection() { return repo.getConnection(); }
        public void setConnection(OracleConnection conn)
        {
            repo.setConnection(conn);
        }

        public DataTable layDSPhanCong()
        {
            return repo.layDSPhanCong();
        }
        public DataTable listAssignment()
        {
            return repo.listAssignment();
        }
        public void updateAssignment(int maNV, int maDA, DateTime thoiGian)
        {
            repo.updateAssignment(maNV, maDA, thoiGian);
        }
        public void insertAssignment(int maNV, int maDA, DateTime thoiGian)
        {
            repo.insertAssignment(maNV, maDA, thoiGian);
        }
        public void deleteAssignment(int maNV, int maDA)
        {
            repo.deleteAssignment(maNV, maDA);
        }
    }
}
