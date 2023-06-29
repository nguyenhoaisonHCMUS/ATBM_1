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
    public partial class RevokeTableFromRole : Form
    {
        OtherService otherservice;
        public RevokeTableFromRole(OracleConnection o,string rolename)
        {
            InitializeComponent();
            txtRole.Text = rolename;
            otherservice=new OtherService(o);
            otherservice.update_comboBox(comboBoxTable);
            load();
        }

        private void load()
        {
            dataGridView1.DataSource=otherservice.SelectDSRole_Privs(txtRole.Text);
        }
        private void btRevokeTatblefromRole_Click(object sender, EventArgs e)
        {
            try
            {
                if (otherservice.revokeTableFromRole(txtRole.Text, comboBoxTable.Text, comboBoxPrivs.Text) == true)
                {
                    load();
                    MessageBox.Show("phân quyền thành công");
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

        private void RevokeTableFromRole_Load(object sender, EventArgs e)
        {

        }
    }
}
