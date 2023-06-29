using Oracle.ManagedDataAccess.Client;
using QLNHANVIEN.BUS;
using QLNHANVIEN.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace QLNHANVIEN.gui
{
    public partial class DangNhapGUI : Form
    {
        NhanVienService nhanVienService;
        OtherService other;

        ConnectOracle connect = new ConnectOracle();
        OracleConnection conn;
        public DangNhapGUI()
        {
            //this.conn = nvservice.GetConnection();
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "" || txtPassword.Text != "")
            {
                conn = connect.connectOracle(txtUser.Text, txtPassword.Text);
                if (conn != null)
                {
                    if (txtUser.Text == "AD" || txtUser.Text == "ad")
                    {
                        AdminHomeGUI adminHomeGUI = new AdminHomeGUI(conn);
                        adminHomeGUI.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        nhanVienService = new NhanVienService(conn);
                        string vaitro = nhanVienService.getRoleByUser(txtUser.Text);
                        if (vaitro == "NhanVien")
                        {
                            fNhanVienHome nhanVienHome = new fNhanVienHome(conn,txtUser.Text);
                            nhanVienHome.Show();
                            this.Visible = false;
                        }
                        else if (vaitro == "NhanSu")
                        {
                            NhanSuHomeGUI nhansuHome = new NhanSuHomeGUI(conn,txtUser.Text);
                            nhansuHome.Show();
                            this.Visible = false;
                        }
                        else if (vaitro == "TruongDeAn")
                        {
                            TruongDeAnHomeGUI truongdeanhome = new TruongDeAnHomeGUI(conn,txtUser.Text);
                            truongdeanhome.Show();
                            this.Visible = false;
                        }
                        else if (vaitro == "TaiChinh")
                        {
                            TaiChinhGUI taichinhgui = new TaiChinhGUI(conn, txtUser.Text);
                            taichinhgui.Show();
                            this.Visible = false;
                        }
                        else if (vaitro == "QLTrucTiep")
                        {
                            QLTTHomeGUI taichinhgui = new QLTTHomeGUI(conn, txtUser.Text);
                            taichinhgui.Show();
                            this.Visible = false;
                        }
                        else if (vaitro == "GiamDoc" || vaitro == "TongGiamDoc")
                        {
                            GiamDocHomeGUI giamdocgui = new GiamDocHomeGUI(conn);
                            giamdocgui.Show();
                            this.Visible = false;
                        }
                        else if (vaitro == "TruongPhong")
                        {
                            TruongPhongHomeGUI truongphonggui = new TruongPhongHomeGUI(conn,txtUser.Text);
                            truongphonggui.Show();
                            this.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("không thể đăng nhập");
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("vui long nhap tai khoan hoac mat khau");
            }

        }
    }
}