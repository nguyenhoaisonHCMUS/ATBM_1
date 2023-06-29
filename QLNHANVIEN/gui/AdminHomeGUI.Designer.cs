namespace QLNHANVIEN.gui
{
    partial class AdminHomeGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHomeGUI));
            this.TabControlAdmin = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.btRevokeRole = new System.Windows.Forms.Button();
            this.BTGrantRole = new System.Windows.Forms.Button();
            this.gribDSNV = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btCreateRole = new System.Windows.Forms.Button();
            this.btRevokeTable = new System.Windows.Forms.Button();
            this.btnDropRole = new System.Windows.Forms.Button();
            this.btgrantTableToRole = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.gridDSRole = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtPC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.comboBoxPhong = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.comboBoxChiNhanh = new System.Windows.Forms.ComboBox();
            this.comboBoxLinhVuc = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimeNS = new System.Windows.Forms.DateTimePicker();
            this.btTaoUser = new System.Windows.Forms.Button();
            this.comboBoxVaiTro = new System.Windows.Forms.ComboBox();
            this.checkedListBoxGT = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.iconTab = new System.Windows.Forms.ImageList(this.components);
            this.TabControlAdmin.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gribDSNV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSRole)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlAdmin
            // 
            this.TabControlAdmin.Controls.Add(this.tabPage1);
            this.TabControlAdmin.Controls.Add(this.tabPage2);
            this.TabControlAdmin.Controls.Add(this.tabPage3);
            this.TabControlAdmin.Depth = 0;
            this.TabControlAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlAdmin.ImageList = this.iconTab;
            this.TabControlAdmin.Location = new System.Drawing.Point(3, 64);
            this.TabControlAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControlAdmin.Multiline = true;
            this.TabControlAdmin.Name = "TabControlAdmin";
            this.TabControlAdmin.SelectedIndex = 0;
            this.TabControlAdmin.Size = new System.Drawing.Size(945, 492);
            this.TabControlAdmin.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtMaNV);
            this.tabPage1.Controls.Add(this.btRevokeRole);
            this.tabPage1.Controls.Add(this.BTGrantRole);
            this.tabPage1.Controls.Add(this.gribDSNV);
            this.tabPage1.ImageKey = "group.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(937, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User Management";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(162, 33);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(205, 30);
            this.txtMaNV.TabIndex = 11;
            // 
            // btRevokeRole
            // 
            this.btRevokeRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRevokeRole.Location = new System.Drawing.Point(681, 33);
            this.btRevokeRole.Name = "btRevokeRole";
            this.btRevokeRole.Size = new System.Drawing.Size(150, 33);
            this.btRevokeRole.TabIndex = 10;
            this.btRevokeRole.Text = "Revoke Role";
            this.btRevokeRole.UseVisualStyleBackColor = true;
            this.btRevokeRole.Click += new System.EventHandler(this.btRevokeRole_Click_1);
            // 
            // BTGrantRole
            // 
            this.BTGrantRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTGrantRole.Location = new System.Drawing.Point(468, 33);
            this.BTGrantRole.Name = "BTGrantRole";
            this.BTGrantRole.Size = new System.Drawing.Size(150, 33);
            this.BTGrantRole.TabIndex = 9;
            this.BTGrantRole.Text = "Grant Role";
            this.BTGrantRole.UseVisualStyleBackColor = true;
            this.BTGrantRole.Click += new System.EventHandler(this.BTGrantRole_Click_1);
            // 
            // gribDSNV
            // 
            this.gribDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gribDSNV.Location = new System.Drawing.Point(17, 104);
            this.gribDSNV.Name = "gribDSNV";
            this.gribDSNV.RowHeadersWidth = 51;
            this.gribDSNV.RowTemplate.Height = 24;
            this.gribDSNV.Size = new System.Drawing.Size(898, 353);
            this.gribDSNV.TabIndex = 8;
            this.gribDSNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gribDSNV_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btCreateRole);
            this.tabPage2.Controls.Add(this.btRevokeTable);
            this.tabPage2.Controls.Add(this.btnDropRole);
            this.tabPage2.Controls.Add(this.btgrantTableToRole);
            this.tabPage2.Controls.Add(this.labelUser);
            this.tabPage2.Controls.Add(this.txtRole);
            this.tabPage2.Controls.Add(this.gridDSRole);
            this.tabPage2.ImageIndex = 2;
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(937, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Role Management ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btCreateRole
            // 
            this.btCreateRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreateRole.Location = new System.Drawing.Point(400, 57);
            this.btCreateRole.Name = "btCreateRole";
            this.btCreateRole.Size = new System.Drawing.Size(148, 37);
            this.btCreateRole.TabIndex = 45;
            this.btCreateRole.Text = "Create";
            this.btCreateRole.UseVisualStyleBackColor = true;
            this.btCreateRole.Click += new System.EventHandler(this.btCreateRole_Click);
            // 
            // btRevokeTable
            // 
            this.btRevokeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRevokeTable.Location = new System.Drawing.Point(752, 34);
            this.btRevokeTable.Name = "btRevokeTable";
            this.btRevokeTable.Size = new System.Drawing.Size(167, 37);
            this.btRevokeTable.TabIndex = 44;
            this.btRevokeTable.Text = "Revoke Table";
            this.btRevokeTable.UseVisualStyleBackColor = true;
            this.btRevokeTable.Click += new System.EventHandler(this.btRevokeTable_Click);
            // 
            // btnDropRole
            // 
            this.btnDropRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDropRole.Location = new System.Drawing.Point(400, 6);
            this.btnDropRole.Name = "btnDropRole";
            this.btnDropRole.Size = new System.Drawing.Size(148, 37);
            this.btnDropRole.TabIndex = 43;
            this.btnDropRole.Text = "Drop";
            this.btnDropRole.UseVisualStyleBackColor = true;
            this.btnDropRole.Click += new System.EventHandler(this.btnDropRole_Click);
            // 
            // btgrantTableToRole
            // 
            this.btgrantTableToRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btgrantTableToRole.Location = new System.Drawing.Point(569, 34);
            this.btgrantTableToRole.Name = "btgrantTableToRole";
            this.btgrantTableToRole.Size = new System.Drawing.Size(160, 37);
            this.btgrantTableToRole.TabIndex = 42;
            this.btgrantTableToRole.Text = "Grant Table";
            this.btgrantTableToRole.UseVisualStyleBackColor = true;
            this.btgrantTableToRole.Click += new System.EventHandler(this.btgrantTableToRole_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(17, 42);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(111, 25);
            this.labelUser.TabIndex = 41;
            this.labelUser.Text = "Role name:";
            // 
            // txtRole
            // 
            this.txtRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.Location = new System.Drawing.Point(134, 39);
            this.txtRole.Name = "txtRole";
            this.txtRole.ReadOnly = true;
            this.txtRole.Size = new System.Drawing.Size(244, 30);
            this.txtRole.TabIndex = 40;
            // 
            // gridDSRole
            // 
            this.gridDSRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDSRole.Location = new System.Drawing.Point(21, 102);
            this.gridDSRole.Name = "gridDSRole";
            this.gridDSRole.ReadOnly = true;
            this.gridDSRole.RowHeadersWidth = 51;
            this.gridDSRole.RowTemplate.Height = 24;
            this.gridDSRole.Size = new System.Drawing.Size(898, 353);
            this.gridDSRole.TabIndex = 38;
            this.gridDSRole.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDSRole_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtPC);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txtLuong);
            this.tabPage3.Controls.Add(this.comboBoxPhong);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.txtSDT);
            this.tabPage3.Controls.Add(this.comboBoxChiNhanh);
            this.tabPage3.Controls.Add(this.comboBoxLinhVuc);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.dateTimeNS);
            this.tabPage3.Controls.Add(this.btTaoUser);
            this.tabPage3.Controls.Add(this.comboBoxVaiTro);
            this.tabPage3.Controls.Add(this.checkedListBoxGT);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txtDiaChi);
            this.tabPage3.Controls.Add(this.txtTen);
            this.tabPage3.ImageIndex = 4;
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(937, 449);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Create User";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // txtPC
            // 
            this.txtPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPC.Location = new System.Drawing.Point(644, 156);
            this.txtPC.Name = "txtPC";
            this.txtPC.Size = new System.Drawing.Size(260, 30);
            this.txtPC.TabIndex = 73;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(523, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 25);
            this.label9.TabIndex = 72;
            this.label9.Text = "Phụ Cấp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(523, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 25);
            this.label10.TabIndex = 71;
            this.label10.Text = "Lương";
            // 
            // txtLuong
            // 
            this.txtLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuong.Location = new System.Drawing.Point(644, 96);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(260, 30);
            this.txtLuong.TabIndex = 70;
            // 
            // comboBoxPhong
            // 
            this.comboBoxPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPhong.FormattingEnabled = true;
            this.comboBoxPhong.Location = new System.Drawing.Point(186, 345);
            this.comboBoxPhong.Name = "comboBoxPhong";
            this.comboBoxPhong.Size = new System.Drawing.Size(271, 33);
            this.comboBoxPhong.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 68;
            this.label6.Text = "Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 67;
            this.label4.Text = "Số Điện Thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(186, 284);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(271, 30);
            this.txtSDT.TabIndex = 66;
            // 
            // comboBoxChiNhanh
            // 
            this.comboBoxChiNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChiNhanh.FormattingEnabled = true;
            this.comboBoxChiNhanh.Location = new System.Drawing.Point(644, 284);
            this.comboBoxChiNhanh.Name = "comboBoxChiNhanh";
            this.comboBoxChiNhanh.Size = new System.Drawing.Size(260, 33);
            this.comboBoxChiNhanh.TabIndex = 65;
            // 
            // comboBoxLinhVuc
            // 
            this.comboBoxLinhVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLinhVuc.FormattingEnabled = true;
            this.comboBoxLinhVuc.Location = new System.Drawing.Point(645, 219);
            this.comboBoxLinhVuc.Name = "comboBoxLinhVuc";
            this.comboBoxLinhVuc.Size = new System.Drawing.Size(259, 33);
            this.comboBoxLinhVuc.TabIndex = 64;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(523, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 25);
            this.label11.TabIndex = 63;
            this.label11.Text = "Chi Nhánh";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(523, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 25);
            this.label12.TabIndex = 62;
            this.label12.Text = "Lĩnh Vực";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 25);
            this.label7.TabIndex = 57;
            this.label7.Text = "Ngày Sinh";
            // 
            // dateTimeNS
            // 
            this.dateTimeNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNS.Location = new System.Drawing.Point(186, 227);
            this.dateTimeNS.Name = "dateTimeNS";
            this.dateTimeNS.Size = new System.Drawing.Size(271, 30);
            this.dateTimeNS.TabIndex = 56;
            // 
            // btTaoUser
            // 
            this.btTaoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaoUser.Location = new System.Drawing.Point(598, 387);
            this.btTaoUser.Name = "btTaoUser";
            this.btTaoUser.Size = new System.Drawing.Size(138, 44);
            this.btTaoUser.TabIndex = 53;
            this.btTaoUser.Text = "Tạo Mới";
            this.btTaoUser.UseVisualStyleBackColor = true;
            this.btTaoUser.Click += new System.EventHandler(this.btTaoUser_Click_1);
            // 
            // comboBoxVaiTro
            // 
            this.comboBoxVaiTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVaiTro.FormattingEnabled = true;
            this.comboBoxVaiTro.Location = new System.Drawing.Point(186, 166);
            this.comboBoxVaiTro.Name = "comboBoxVaiTro";
            this.comboBoxVaiTro.Size = new System.Drawing.Size(271, 33);
            this.comboBoxVaiTro.TabIndex = 52;
            // 
            // checkedListBoxGT
            // 
            this.checkedListBoxGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxGT.FormattingEnabled = true;
            this.checkedListBoxGT.Items.AddRange(new object[] {
            "nam",
            "nu"});
            this.checkedListBoxGT.Location = new System.Drawing.Point(645, 19);
            this.checkedListBoxGT.Name = "checkedListBoxGT";
            this.checkedListBoxGT.Size = new System.Drawing.Size(113, 54);
            this.checkedListBoxGT.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(514, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "Vai Trò";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Địa Chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 25);
            this.label8.TabIndex = 46;
            this.label8.Text = "Họ Tên";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(186, 102);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(271, 30);
            this.txtDiaChi.TabIndex = 44;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(186, 43);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(271, 30);
            this.txtTen.TabIndex = 43;
            // 
            // iconTab
            // 
            this.iconTab.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconTab.ImageStream")));
            this.iconTab.TransparentColor = System.Drawing.Color.Transparent;
            this.iconTab.Images.SetKeyName(0, "department.png");
            this.iconTab.Images.SetKeyName(1, "group.png");
            this.iconTab.Images.SetKeyName(2, "project.png");
            this.iconTab.Images.SetKeyName(3, "to-do-list.png");
            this.iconTab.Images.SetKeyName(4, "user.png");
            this.iconTab.Images.SetKeyName(5, "notification.png");
            // 
            // AdminHomeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 559);
            this.Controls.Add(this.TabControlAdmin);
            this.DrawerIsOpen = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.TabControlAdmin;
            this.Name = "AdminHomeGUI";
            this.Text = "Admin Home";
            this.TabControlAdmin.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gribDSNV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSRole)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControlAdmin;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btRevokeRole;
        private System.Windows.Forms.Button BTGrantRole;
        private System.Windows.Forms.DataGridView gribDSNV;
        private System.Windows.Forms.Button btRevokeTable;
        private System.Windows.Forms.Button btnDropRole;
        private System.Windows.Forms.Button btgrantTableToRole;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.DataGridView gridDSRole;
        private System.Windows.Forms.Button btCreateRole;
        private System.Windows.Forms.ComboBox comboBoxChiNhanh;
        private System.Windows.Forms.ComboBox comboBoxLinhVuc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimeNS;
        private System.Windows.Forms.Button btTaoUser;
        private System.Windows.Forms.ComboBox comboBoxVaiTro;
        private System.Windows.Forms.CheckedListBox checkedListBoxGT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.ComboBox comboBoxPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtPC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.ImageList iconTab;
    }
}