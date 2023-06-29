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
    public partial class fNhanVienHome : MaterialSkin.Controls.MaterialForm
    {
        NhanVienService nhanVienService;
        PhongBanService phongBanService;
        ThongBaoService thongBaoService;
        string user;
        public fNhanVienHome(OracleConnection conn,string user)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            nhanVienService = new NhanVienService(conn);
            phongBanService = new PhongBanService(conn);
            thongBaoService = new ThongBaoService(conn);
            loadDSDA();
            loadDSPB();
            loadTTNV();
            loadListNotification();
            this.user = user;
        }

        private void fNhanVienHome_Load(object sender, EventArgs e)
        {
           
        }
        private void loadDSPB()
        {
            dataGridViewDSPhongBan.DataSource = nhanVienService.getDSPhongBan();
        }

        private void loadDSDA()
        {
            dataGridViewDSDA.DataSource = nhanVienService.getDSDeAn();
        }

        private void loadTTNV()
        {
            dsNhanVien.DataSource = nhanVienService.getAll();
        }
        private void loadListNotification()
        {
            dsNotification.DataSource = thongBaoService.getAll();
        }
        private void ntThayDoiTT_Click(object sender, EventArgs e)
        {
            if(txtSDTtd.Text != "" && txtDCtd.Text != "")
            {
                int manv=int.Parse(nhanVienService.getNVByUser(this.user).MANV.ToString());
                NHANVIEN nv = new NHANVIEN();
                nv.MANV = (short)manv;
                nv.NGAYSINH = dateTimePicker1.Value.Date;
                nv.DIACHI=txtDCtd.Text;
                nv.SODT = txtSDTtd.Text;
                try {
                    nhanVienService.updateTTNV(nv);
                    MessageBox.Show("thành công");
                    loadTTNV();
                }catch(Exception ex)
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
