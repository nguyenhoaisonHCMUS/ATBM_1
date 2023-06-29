using Oracle.ManagedDataAccess.Client;
using QLNHANVIEN.BUS;
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
    public partial class RevokeRoleFromUserGUI : Form
    {
        NhanVienService nhanVienService;

        public RevokeRoleFromUserGUI(OracleConnection conn, string user)
        {
            nhanVienService = new NhanVienService(conn);
            InitializeComponent();
            txtMaNV.Text = user;
            nhanVienService.update_List_Role(comboBoxRole);
            load();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxRole.Text != "" && txtMaNV.Text != "")
            {
                try
                {
                    nhanVienService.revokeRoleToUser(comboBoxRole.Text, txtMaNV.Text);
                    load();
                    MessageBox.Show("thu hồi quyền thành công");
                }
                catch (Exception)
                {
                    MessageBox.Show("không thành công");
                }


            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }

        void load()
        {
            GridViewDSTableRole.DataSource = nhanVienService.selectPrivsRoleOfUser(txtMaNV.Text);
        }
    }
}
