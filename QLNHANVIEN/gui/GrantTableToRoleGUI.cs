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
    public partial class GrantTableToRoleGUI : Form
    {
        OtherService otherService;
        public GrantTableToRoleGUI(OracleConnection c,string rolename)
        {
            InitializeComponent();
            otherService = new OtherService(c);
            txtRole.Text = rolename;
            load();
            otherService.update_comboBox(comboBoxTable);

        }

        private void load()
        {
            if (otherService == null) {
                MessageBox.Show("không có kết nối đến Oracle!!");
                return; 
            }
            GridViewDSTableRole.DataSource= otherService.SelectDSRole_Privs(txtRole.Text);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btGrantTable_Click(object sender, EventArgs e)
        {
            if (txtRole.Text != "" && comboBoxPrivs.Text != "" && comboBoxTable.Text != "")
            {
                try
                {
                    if(otherService.grantTableToRole(txtRole.Text, comboBoxTable.Text, comboBoxPrivs.Text) == true)
                    {
                        MessageBox.Show("thành công");
                        load();
                    }
                    else
                    {
                        MessageBox.Show("không thành công");
                    }

                }
                catch
                {
                    MessageBox.Show("không thành công");
                }
            }
            else
            {
                MessageBox.Show("vui lòng nhập đầy đủ thông tin");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
