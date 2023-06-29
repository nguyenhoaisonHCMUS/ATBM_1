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
    public partial class NhanSuHomeGUI : MaterialSkin.Controls.MaterialForm
    {
        NhanVienService nhanVienService;
        PhongBanService phongBanService;
        DeAnService deAnService;
        string user;
        string mapb;
        public NhanSuHomeGUI(OracleConnection conn, string user)
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
            loadDSPB();
            loadDSDA();
            this.user = user;

            nhanVienService.update_List_chinhanh(comboBoxChiNhanh);
            nhanVienService.update_List_linhvuc(comboBoxLinhVuc);
            phongBanService.update_List_DSPhong(comboBoxPhong);
            nhanVienService.update_List_VaiTro(comboBoxVaiTro);
        }

        private void loadDSNV()
        {
            dsNhanVien.DataSource = nhanVienService.getAllByNS();
        }

        private void loadDSPB()
        {
            dsPhongBan.DataSource = phongBanService.getAllWithNV();
        }

        private void loadDSDA()
        {
            dataGridViewDSDA.DataSource = deAnService.getAll();
        }

        private void dsNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dsNhanVien.CurrentRow.Index;
            dateTimePicker1.Text = dsNhanVien.Rows[i].Cells[3].Value.ToString();
            diachiNV.Text = dsNhanVien.Rows[i].Cells[4].Value.ToString();
            sdtNV.Text = dsNhanVien.Rows[i].Cells[5].Value.ToString();
        }

        private void ntThayDoiTT_Click(object sender, EventArgs e)
        {
            if (diachiNV.Text != "" && sdtNV.Text != "")
            {
                
                NHANVIEN nv = new NHANVIEN();
                nv.MANV = Convert.ToInt16(txtxManv.Text);
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

        private void dsPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dsPhongBan.CurrentRow.Index;
            tenPB.Text = dsPhongBan.Rows[i].Cells[1].Value.ToString();
            maTrPhong.Text = dsPhongBan.Rows[i].Cells[2].Value.ToString();
            mapb = dsPhongBan.Rows[i].Cells[0].Value.ToString();
        }

        private void btTaoUser_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = new NHANVIEN();
            nv.TENNV = txtTen.Text;
            nv.PHAI = checkedListBoxGT.SelectedIndex.ToString();
            nv.NGAYSINH = dateTimeNS.Value.Date;
            nv.DIACHI = txtDiaChi.Text;
            nv.SODT = txtSDT.Text;
            string phong = phongBanService.getPhongByTen(comboBoxPhong.Text).MAPB.ToString();
            nv.PHG = Convert.ToInt16(phong);
            nv.LINHVUC = comboBoxLinhVuc.Text;
            nv.CHINHANH = comboBoxChiNhanh.Text;
            nv.VAITRO = comboBoxVaiTro.Text;
            try
            {
                nhanVienService.NScreateUser(nv);
                MessageBox.Show("thành công");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDeleteAssign_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateAssign_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAssignment_Click(object sender, EventArgs e)
        {

        }

        private void btnChangeInfor_Click(object sender, EventArgs e)
        {

        }

        private void btnTTBP_Click(object sender, EventArgs e)
        {
            try
            {
                phongBanService.update_PhongBan(mapb,tenPB.Text,maTrPhong.Text);
                MessageBox.Show("thành công");
                loadDSPB();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
