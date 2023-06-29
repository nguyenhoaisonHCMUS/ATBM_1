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
    public partial class TruongDeAnHomeGUI : MaterialSkin.Controls.MaterialForm
    {
        NhanVienService nhanVienService;
        PhongBanService phongBanService;
        DeAnService deAnService;
        string user;
        public TruongDeAnHomeGUI(OracleConnection conn, string user)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            nhanVienService = new NhanVienService(conn);
            phongBanService = new PhongBanService(conn);
            deAnService = new DeAnService(conn);
            loadDSNV();
            loadDSDA();
            loadDSPB();
            this.user = user;
        }

        private void ntThayDoiTT_Click(object sender, EventArgs e)
        {
            if (diachiNV.Text != "" && sdtNV.Text != "")
            {
                int manv = int.Parse(nhanVienService.getNVByUser(this.user).MANV.ToString());
                NHANVIEN nv = new NHANVIEN();
                nv.MANV = (short)manv;
                nv.NGAYSINH = dateTimePicker1.Value.Date;
                nv.DIACHI = diachiNV.Text;
                nv.SODT = sdtNV.Text;
                try
                {
                    nhanVienService.updateTTNV(nv);
                    MessageBox.Show("thành công");
                    loadDSNV();
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

        private void loadDSNV()
        {
            infoNV.DataSource = nhanVienService.getAll();
        }

        private void loadDSPB()
        {
            dsPhongBan.DataSource = phongBanService.getAll();
        }

        private void loadDSDA()
        {
            dsDeAn.DataSource = deAnService.getAll();
        }

        private void dsDeAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dsDeAn.CurrentRow.Index;
            maDA.Text = dsDeAn.Rows[i].Cells[0].Value.ToString();
            tenDA.Text = dsDeAn.Rows[i].Cells[1].Value.ToString();
            ngayBDDA.Text = dsDeAn.Rows[i].Cells[2].Value.ToString();
            phongBanDA.Text = dsDeAn.Rows[i].Cells[3].Value.ToString();
        }

        private void btnThayDoiDA_Click(object sender, EventArgs e)
        {
            try
            {
                deAnService.update_DeAn(maDA.Text, tenDA.Text, ngayBDDA.Text, phongBanDA.Text);
                MessageBox.Show("thành công");
                loadDSDA();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnThemDA_Click(object sender, EventArgs e)
        {
            try
            {
                deAnService.insert_DeAn(maDA.Text, tenDA.Text, ngayBDDA.Text, phongBanDA.Text);
                MessageBox.Show("thành công");
                loadDSDA();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
