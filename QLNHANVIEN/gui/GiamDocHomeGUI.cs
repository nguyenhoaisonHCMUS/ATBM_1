using MaterialSkin;
using Oracle.ManagedDataAccess.Client;
using QLNHANVIEN.BUS;
using QLNHANVIEN.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNHANVIEN.gui
{
    public partial class GiamDocHomeGUI : MaterialSkin.Controls.MaterialForm
    {
        NhanVienService nhanVienService;
        PhongBanService phongBanService;
        DeAnService deAnService;
        PhanCongService phanCongService;
        ThongBaoService thongBaoService;
        //NHANVIEN curUser = CONST.TaiKhoanConst.getUser();
        public GiamDocHomeGUI(OracleConnection conn)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            nhanVienService = new NhanVienService(conn);
            phongBanService = new PhongBanService(conn);
            deAnService = new DeAnService(conn);
            phanCongService = new PhanCongService(conn);
            thongBaoService = new ThongBaoService(conn);
            //loadMyInfor();
            loadMyStaff();
            loadListDepartment();
            loadListProject();
            loadListAssignment();
            loadListNotification();
        }
        //private void loadMyInfor()
        //{
        //    dgvMyInfo.DataSource = nhanVienService.getMyInfor();
        //}

        private void loadMyStaff()
        {
            dgvListStaff.DataSource = nhanVienService.listStaff();
        }

        private void loadListDepartment()
        {
            dgvListDepartment.DataSource = phongBanService.listDepartment();
        }

        private void loadListProject()
        {
            dgvListProject.DataSource = deAnService.listProject();
        }
        private void loadListAssignment()
        {
            dgvListAssign.DataSource = phanCongService.listAssignment();
        }

        private void loadListNotification()
        {
            dsThongBao.DataSource = thongBaoService.getAll();
        }

        private void dgvMyInfo_CellClick(object sender, EventArgs e)
        {
            int p_manv = Convert.ToInt32(tbEmployeeID.Text);
            DateTime p_ngaysinh = Convert.ToDateTime(dtpDOB.Text);
            string p_diachi = tbAddress.Text;
            string p_sodt = tbPhoneNum.Text;
            nhanVienService.updateMyInfo(p_manv, p_ngaysinh, p_diachi, p_sodt);
            //loadMyInfor();
            MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvListStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMyInfo.CurrentRow.Selected = true;
            tbEmployeeID.Text = dgvMyInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbPhoneNum.Text = dgvMyInfo.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbAddress.Text = dgvMyInfo.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtpDOB.Text = dgvMyInfo.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnGuiThongBao_Click(object sender, EventArgs e)
        {
            if (txtNoiDung.Text != "" && txtVaiTro.Text != "" && txtLinhVuc.Text != "" && txtChiNhanh.Text != "")
            {
                try
                {
                    thongBaoService.insertAssignment(txtNoiDung.Text, txtVaiTro.Text, txtLinhVuc.Text, txtChiNhanh.Text);
                    MessageBox.Show("Gửi thông báo thành công");
                    loadListNotification();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("không được để trống thông tin!!");
            }
        }
    }
}
