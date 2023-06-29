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
    public partial class TruongPhongHomeGUI : MaterialSkin.Controls.MaterialForm
    {
        NhanVienService nhanVienService;
        PhongBanService phongBanService;
        DeAnService deAnService;
        PhanCongService phanCongService;
        ThongBaoService thongBaoService;
        string user;
        //NHANVIEN curUser = CONST.TaiKhoanConst.getUser();
        public TruongPhongHomeGUI(OracleConnection conn,string user )
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
            this.user = user;
            //loadMyInfor();
            loadMyStaff();
            loadListDepartment();
            loadListProject();
            loadListAssignment();
            loadListNotification();
            loadInfo();
            // show combobox
            cbEmployeeID.ValueMember = "MaNV";
            cbEmployeeID.DataSource = nhanVienService.listStaff();
            cbProjectID.ValueMember = "MaDA";
            cbProjectID.DataSource = deAnService.listProject();
        }
        //private void loadMyInfor()
        //{
        //    dgvMyInfoTruongPhong.DataSource = nhanVienService.getMyInfor();
        //}

        private void loadMyStaff()
        {
            dgvListMyStaff.DataSource = nhanVienService.listStaff();
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
            dgvListAssignDepartment.DataSource = phanCongService.listAssignment();
        }

        private void loadListNotification()
        {
            dsThongBao.DataSource = thongBaoService.getAll();
        }
        private void loadInfo()
        {
            dgvMyInfoTruongPhong.DataSource = nhanVienService.getNVByUserTC(user);
        }


        private void dgvListAssignDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvListAssignDepartment.CurrentRow.Selected = true;
            cbEmployeeID.Text = dgvListAssignDepartment.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbProjectID.Text = dgvListAssignDepartment.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dgvMyInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMyInfoTruongPhong.CurrentRow.Selected = true;
            tbPhoneNum.Text = dgvMyInfoTruongPhong.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbAddress.Text = dgvMyInfoTruongPhong.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtpDOB.Text = dgvMyInfoTruongPhong.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnChangeInfor_Click(object sender, EventArgs e)
        {
            if (tbAddress.Text != "" && tbPhoneNum.Text != "")
            {
                int manv = int.Parse(nhanVienService.getNVByUser(this.user).MANV.ToString());
                NHANVIEN nv = new NHANVIEN();
                nv.MANV = (short)manv;
                nv.NGAYSINH = dtpDOB.Value.Date;
                nv.DIACHI = tbAddress.Text;
                nv.SODT = tbPhoneNum.Text;
                try
                {
                    nhanVienService.updateTTNV(nv);
                    MessageBox.Show("thành công");
                    loadInfo();
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

        private void btnAddAssignment_Click(object sender, EventArgs e)
        {
            int p_manv = Convert.ToInt32(cbEmployeeID.Text);
            int p_mada = Convert.ToInt32(cbProjectID.Text);
            DateTime p_ngaybatdau = Convert.ToDateTime(dtpStartDate.Text);
            phanCongService.insertAssignment(p_manv, p_mada, p_ngaybatdau);
            loadListAssignment();
            //MessageBox.Show("Thêm phân công thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdateAssign_Click(object sender, EventArgs e)
        {
            int p_manv = Convert.ToInt32(cbEmployeeID.Text);
            int p_mada = Convert.ToInt32(cbProjectID.Text);
            DateTime p_ngaybatdau = Convert.ToDateTime(dtpStartDate.Text);
            phanCongService.updateAssignment(p_manv, p_mada, p_ngaybatdau);
            loadListAssignment();
            //MessageBox.Show("Cập nhật phân công thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnDeleteAssign_Click(object sender, EventArgs e)
        {
            int p_manv = Convert.ToInt32(cbEmployeeID.Text);
            int p_mada = Convert.ToInt32(cbProjectID.Text);
            phanCongService.deleteAssignment(p_manv, p_mada);
            loadListAssignment();
            //MessageBox.Show("Xoá phân công thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvListAssignDepartment_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dgvListAssignDepartment.CurrentRow.Selected = true;
            cbEmployeeID.Text = dgvListAssignDepartment.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbProjectID.Text = dgvListAssignDepartment.Rows[e.RowIndex].Cells[1].Value.ToString();
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
