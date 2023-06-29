using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using MaterialSkin;
using Oracle.ManagedDataAccess.Client;
using QLNHANVIEN.BUS;
using QLNHANVIEN.DTO;

namespace QLNHANVIEN.gui
{
    public partial class AdminHomeGUI : MaterialSkin.Controls.MaterialForm
    {
        NhanVienService nvservice;
        OtherService otherservice;
        string username;
        PhongBanService phongbanService;
        public AdminHomeGUI(OracleConnection conn)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            nvservice=new NhanVienService(conn);
            otherservice=new OtherService(conn);
            phongbanService=new PhongBanService(conn);
            loadDSNV();
            loadDSRole();
            nvservice.update_List_chinhanh(comboBoxChiNhanh);
            nvservice.update_List_linhvuc(comboBoxLinhVuc);
            phongbanService.update_List_DSPhong(comboBoxPhong);
            nvservice.update_List_VaiTro(comboBoxVaiTro);
        }

        private void loadDSNV()
        {
            gribDSNV.DataSource= nvservice.getAll();
        }

        private void loadDSRole()
        {
            gridDSRole.DataSource = otherservice.updateGridList_Role();
        }


        private void gribDSNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = gribDSNV.CurrentRow.Index;
            txtMaNV.Text = gribDSNV.Rows[i].Cells[0].Value.ToString();
            username = gribDSNV.Rows[i].Cells[11].Value.ToString();
        }

        private void BTGrantRole_Click_1(object sender, EventArgs e)
        {
            GrantRoleToUserGUI grantRoleToUserGUI = new GrantRoleToUserGUI(nvservice.GetConnection(), username);
            grantRoleToUserGUI.Show();
        }

        private void btRevokeRole_Click_1(object sender, EventArgs e)
        {
            RevokeRoleFromUserGUI revoke = new RevokeRoleFromUserGUI(nvservice.GetConnection(), username);
            revoke.Show();
        }

        private void btnDropRole_Click(object sender, EventArgs e)
        {
            try {
                MessageBox.Show("role đã xóa thành công!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            loadDSRole();
        }

        private void btgrantTableToRole_Click(object sender, EventArgs e)
        {
            GrantTableToRoleGUI grantTable = new GrantTableToRoleGUI(otherservice.GetConnection(), txtRole.Text);
            grantTable.Show();
        }

        private void btRevokeTable_Click(object sender, EventArgs e)
        {
            RevokeTableFromRole revoke = new RevokeTableFromRole(otherservice.GetConnection(), txtRole.Text);
            revoke.Show();
        }

        private void gridDSRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = gridDSRole.CurrentRow.Index;
            txtRole.Text = gridDSRole.Rows[i].Cells[0].Value.ToString();
        }

        private void btCreateRole_Click(object sender, EventArgs e)
        {
            CreateRoleGUI create = new CreateRoleGUI(otherservice.GetConnection());
            create.Show();
            loadDSRole();
        }

        private void btTaoUser_Click(object sender, EventArgs e)
        {
            
        }

        private void btTaoUser_Click_1(object sender, EventArgs e)
        {
            NHANVIEN nv = new NHANVIEN();
            nv.TENNV = txtTen.Text;
            nv.PHAI = checkedListBoxGT.SelectedIndex.ToString();
            nv.NGAYSINH = dateTimeNS.Value.Date;
            nv.DIACHI = txtDiaChi.Text;
            nv.SODT = txtSDT.Text;
            nv.LUONG=txtLuong.Text;
            nv.PHUCAP = txtPC.Text;
            nv.CHINHANH=comboBoxChiNhanh.Text;
            string phong = phongbanService.getPhongByTen(comboBoxPhong.Text).MAPB.ToString();
            nv.PHG = Convert.ToInt16(phong);
            nv.LINHVUC = comboBoxLinhVuc.Text;
            nv.CHINHANH = comboBoxChiNhanh.Text;
            nv.VAITRO = comboBoxVaiTro.Text;
            try
            {
                nvservice.AdcreateUser(nv);
                MessageBox.Show("thành công");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
