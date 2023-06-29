using Oracle.ManagedDataAccess.Client;
using QLNHANVIEN.DAO;
using QLNHANVIEN.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNHANVIEN.BUS
{
    public class NhanVienService
    {
        NhanVienRepo repo;

        public NhanVienService(OracleConnection c) { repo = new NhanVienRepo(c); }

        public OracleConnection GetConnection() { return repo.getConnection(); }
        public void setConnection(OracleConnection conn)
        {
            repo.setConnection(conn);
        }


        public DataTable getAll()
        {
            return repo.getAll();
        }

        public DataTable getAllByNS()
        {
            return repo.getAllByNS();
        }

        //login
        public string getRoleByUser(string user)
        {
            return repo.getRoleByUser(user);
        }
        ////////////////////////////////////////

        public void update_List_Role(ComboBox Role)
        {
            repo.update_List_Role(Role);
        }
        public bool grantRoleToUser(string RoleName, string User)
        {
            return repo.grantRoleToUser(RoleName, User);
        }

        public bool revokeRoleToUser(string RoleName, string User)
        {
            return repo.revoleRoleToUser(RoleName, User);
        }

        public void update_List_VaiTro(ComboBox vaitro)
        {
            repo.update_List_VaiTro(vaitro);
        }

        public DataTable selectPrivsRoleOfUser(string manv)
        {
            return repo.selectPrivsRoleOfUser(manv);
        }


        public DataTable getDSDeAn()
        {
            return repo.getDSDeAn();
        }

        public DataTable getDSPhongBan()
        { return repo.getDSPhongBan(); }
        public void updateTTNV(NHANVIEN nv) { repo.updateTTNV(nv); }

        public NHANVIEN getNVByUser(string user) { return repo.getNVByUser(user); }

        public void update_List_chinhanh(ComboBox chinhanh) { repo.update_List_chinhanh(chinhanh); }
        public void update_List_linhvuc(ComboBox linhvuc) { repo.update_List_LinhVuc(linhvuc); }


        public bool AdcreateUser(NHANVIEN nv)
        {
            return repo.AdcreateUser(nv);
        }

        public bool NScreateUser(NHANVIEN nv) { return repo.NScreateUser(nv); }
        public DataTable listStaff()
        {
            return repo.listStaff();
        }
        public NHANVIEN findByUsername(String username)
        { return repo.findByUsername(username); }
        public DataTable getDSNhanVien()
        { return repo.getDSNhanVien(); }
        public void updateMyInfo(int maNV, DateTime ngaySinh, string diaChi, string sodt)
        {
            repo.updateMyInfo(maNV, ngaySinh, diaChi, sodt);
        }


        public DataTable getNVByUserTC(string user) { return repo.getNVByUserTC(user); }
    }
}
