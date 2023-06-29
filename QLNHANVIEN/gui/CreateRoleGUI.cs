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

namespace QLNHANVIEN.gui
{
    public partial class CreateRoleGUI : Form
    {
        OtherService other;
        public CreateRoleGUI(OracleConnection conn)
        {
            InitializeComponent();
            other=new OtherService(conn);
        }

        private void CreateRoleGUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (other.createRole(txtRoleName.Text) == true)
            {
                MessageBox.Show("role đã tạo thành công!");
            }
            else
            {
                MessageBox.Show("không thể tạo role!");
            }
        }
    }
}
