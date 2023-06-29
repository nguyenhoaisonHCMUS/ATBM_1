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
    public partial class CreateUserGUI : Form
    {
        NhanVienService nhanVienService;
        public CreateUserGUI(OracleConnection c)
        {
            nhanVienService = new NhanVienService(c);
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
