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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNHANVIEN.gui
{
    public partial class TaiChinhGUI : MaterialSkin.Controls.MaterialForm
    {
        TaiChinhService taiChinhService;
        NhanVienService nhanVienService;
        PhanCongService phanCongService;
        private DataGridViewRow row = new DataGridViewRow();
        private int maNV;
        private string luong ;
        private string phuCap ;
        string user;
        public TaiChinhGUI(OracleConnection conn, string user)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            taiChinhService = new TaiChinhService(conn);
            nhanVienService = new NhanVienService(conn);
            phanCongService = new PhanCongService(conn);
            loadDefault();
            loadTTNV();
            this.user = user;

            MessageBox.Show(user);
        }

        private void loadDefault()
        {
            dgvNhanVien.DataSource = nhanVienService.getAll();
            dgvPhanCong.DataSource = phanCongService.layDSPhanCong();
            datagvDeAn.DataSource = nhanVienService.getDSDeAn();
            dgvPhongBan.DataSource = nhanVienService.getDSPhongBan();
        }
        private void loadTTNV()
        {
            ttcnTC.DataSource = nhanVienService.getNVByUserTC(user);

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //var ketQua = taiChinhService.capNhatLuongVaPhuCap(maNV, luong, phuCap);
            NHANVIEN nv = new NHANVIEN();
            //int ma= int.Parse(txtMaNV1.Text);

            nv.MANV = (short)11;//Convert.ToInt16(txtMaNV1.Text);
            nv.LUONG=txtLuong.Text;
            nv.PHUCAP=txtPhuCap.Text;
            try {
                taiChinhService.capNhatLuongVaPhuCap(nv);
                loadTTNV();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvNhanVien.CurrentRow.Selected = true;
            row = dgvNhanVien.Rows[e.RowIndex];
            maNV = Convert.ToInt32(row.Cells["MANV"].Value);
            luong = row.Cells["LUONG"].Value.ToString();
            phuCap = row.Cells["PHUCAP"].Value.ToString();
            txtLuong.Text = luong;
            txtPhuCap.Text = phuCap;
            txtMaNV1.Text = maNV.ToString();
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            if (txtSDTtd.Text != "" && txtDCtd.Text != "")
            {
                int manv = int.Parse(nhanVienService.getNVByUser(this.user).MANV.ToString());
                NHANVIEN nv = new NHANVIEN();
                nv.MANV = (short)manv;
                nv.NGAYSINH = dateTimePicker1.Value.Date;
                nv.DIACHI = txtDCtd.Text;
                nv.SODT = txtSDTtd.Text;
                try
                {
                    nhanVienService.updateTTNV(nv);
                    MessageBox.Show("thành công");
                    loadTTNV();
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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ntThayDoiTT_Click(object sender, EventArgs e)
        {

        }
    }
}
