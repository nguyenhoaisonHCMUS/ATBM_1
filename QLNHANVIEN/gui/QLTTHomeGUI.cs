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
    public partial class QLTTHomeGUI : MaterialSkin.Controls.MaterialForm
    {
        NhanVienService nhanVienService;
        PhanCongService phanCongService;
        string user;
        public QLTTHomeGUI(OracleConnection conn, string user)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            nhanVienService = new NhanVienService(conn);
            phanCongService = new PhanCongService(conn);
            loadDefault();
            loadTTNV();
            this.user = user;
        }

        private void loadDefault()
        {
            dgvDSNhanVien.DataSource = nhanVienService.getAll();
            dgvDSPhanCong.DataSource = phanCongService.layDSPhanCong();
            dgvPhongBan.DataSource = nhanVienService.getDSPhongBan();
            dgvDeAn.DataSource = nhanVienService.getDSDeAn();
        }
        private void loadTTNV()
        {
            dataGridView1.DataSource = nhanVienService.getAll();
        }

        private void ntThayDoiTT_Click(object sender, EventArgs e)
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
    }
}
