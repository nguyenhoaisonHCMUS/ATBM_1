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
    public partial class GrantRoleToUserGUI : Form
    {
        NhanVienService nhanvienservice;
        public GrantRoleToUserGUI(OracleConnection conn, string user)
        {
            nhanvienservice = new NhanVienService(conn);
            
            InitializeComponent();
            txtManv.Text = user;
            nhanvienservice.update_List_Role(comboBoxRole);
            if (comboBoxRole.Text == null)
            {
                MessageBox.Show("xx");
            }
            
            load();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxRole.Text != "" && txtManv.Text!="")
            {
                try
                {
                    nhanvienservice.grantRoleToUser(comboBoxRole.Text, txtManv.Text);
                    load();
                    MessageBox.Show("cap quyen thanh cong");
                }
                catch (Exception)
                {
                    MessageBox.Show("khong thanh cong");
                }
                
                
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }

        void load()
        {
            dataGridViewDSPrivsOfU.DataSource = nhanvienservice.selectPrivsRoleOfUser(txtManv.Text);   
        }
    }
}
