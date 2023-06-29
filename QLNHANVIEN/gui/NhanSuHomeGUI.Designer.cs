namespace QLNHANVIEN.gui
{
    partial class NhanSuHomeGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanSuHomeGUI));
            this.Information = new MaterialSkin.Controls.MaterialTabControl();
            this.NhanVienList = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDSNV = new System.Windows.Forms.Label();
            this.dsNhanVien = new System.Windows.Forms.DataGridView();
            this.btnThayDoiTT = new System.Windows.Forms.Button();
            this.diachiNV = new System.Windows.Forms.TextBox();
            this.sdtNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PhongBanList = new System.Windows.Forms.TabPage();
            this.btnTTBP = new System.Windows.Forms.Button();
            this.maTrPhong = new System.Windows.Forms.TextBox();
            this.tenPB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dsPhongBan = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewDSDA = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.comboBoxChiNhanh = new System.Windows.Forms.ComboBox();
            this.comboBoxLinhVuc = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimeNS = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPhong = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btTaoUser = new System.Windows.Forms.Button();
            this.comboBoxVaiTro = new System.Windows.Forms.ComboBox();
            this.checkedListBoxGT = new System.Windows.Forms.CheckedListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.iconTab = new System.Windows.Forms.ImageList(this.components);
            this.txtxManv = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Information.SuspendLayout();
            this.NhanVienList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsNhanVien)).BeginInit();
            this.PhongBanList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPhongBan)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSDA)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Information
            // 
            this.Information.Controls.Add(this.NhanVienList);
            this.Information.Controls.Add(this.PhongBanList);
            this.Information.Controls.Add(this.tabPage3);
            this.Information.Controls.Add(this.tabPage4);
            this.Information.Depth = 0;
            this.Information.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Information.ImageList = this.iconTab;
            this.Information.Location = new System.Drawing.Point(3, 64);
            this.Information.MouseState = MaterialSkin.MouseState.HOVER;
            this.Information.Multiline = true;
            this.Information.Name = "Information";
            this.Information.SelectedIndex = 0;
            this.Information.Size = new System.Drawing.Size(1194, 633);
            this.Information.TabIndex = 1;
            // 
            // NhanVienList
            // 
            this.NhanVienList.Controls.Add(this.txtxManv);
            this.NhanVienList.Controls.Add(this.label19);
            this.NhanVienList.Controls.Add(this.dateTimePicker1);
            this.NhanVienList.Controls.Add(this.label2);
            this.NhanVienList.Controls.Add(this.labelDSNV);
            this.NhanVienList.Controls.Add(this.dsNhanVien);
            this.NhanVienList.Controls.Add(this.btnThayDoiTT);
            this.NhanVienList.Controls.Add(this.diachiNV);
            this.NhanVienList.Controls.Add(this.sdtNV);
            this.NhanVienList.Controls.Add(this.label4);
            this.NhanVienList.Controls.Add(this.label3);
            this.NhanVienList.Controls.Add(this.label1);
            this.NhanVienList.ImageKey = "group.png";
            this.NhanVienList.Location = new System.Drawing.Point(4, 39);
            this.NhanVienList.Name = "NhanVienList";
            this.NhanVienList.Padding = new System.Windows.Forms.Padding(3);
            this.NhanVienList.Size = new System.Drawing.Size(1186, 590);
            this.NhanVienList.TabIndex = 0;
            this.NhanVienList.Text = "NhanVien List";
            this.NhanVienList.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(834, 201);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(297, 30);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(833, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ngày Sinh:";
            // 
            // labelDSNV
            // 
            this.labelDSNV.AutoSize = true;
            this.labelDSNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDSNV.Location = new System.Drawing.Point(23, 18);
            this.labelDSNV.Name = "labelDSNV";
            this.labelDSNV.Size = new System.Drawing.Size(207, 25);
            this.labelDSNV.TabIndex = 9;
            this.labelDSNV.Text = "Danh Sách Nhân Viên";
            // 
            // dsNhanVien
            // 
            this.dsNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsNhanVien.Location = new System.Drawing.Point(28, 57);
            this.dsNhanVien.Name = "dsNhanVien";
            this.dsNhanVien.RowHeadersWidth = 51;
            this.dsNhanVien.RowTemplate.Height = 24;
            this.dsNhanVien.Size = new System.Drawing.Size(752, 503);
            this.dsNhanVien.TabIndex = 8;
            this.dsNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsNhanVien_CellContentClick);
            // 
            // btnThayDoiTT
            // 
            this.btnThayDoiTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThayDoiTT.Location = new System.Drawing.Point(921, 397);
            this.btnThayDoiTT.Name = "btnThayDoiTT";
            this.btnThayDoiTT.Size = new System.Drawing.Size(116, 35);
            this.btnThayDoiTT.TabIndex = 7;
            this.btnThayDoiTT.Text = "Thay Đổi";
            this.btnThayDoiTT.UseVisualStyleBackColor = true;
            this.btnThayDoiTT.Click += new System.EventHandler(this.ntThayDoiTT_Click);
            // 
            // diachiNV
            // 
            this.diachiNV.BackColor = System.Drawing.SystemColors.Menu;
            this.diachiNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diachiNV.Location = new System.Drawing.Point(833, 272);
            this.diachiNV.Name = "diachiNV";
            this.diachiNV.Size = new System.Drawing.Size(297, 30);
            this.diachiNV.TabIndex = 6;
            // 
            // sdtNV
            // 
            this.sdtNV.BackColor = System.Drawing.SystemColors.Menu;
            this.sdtNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdtNV.Location = new System.Drawing.Point(833, 350);
            this.sdtNV.Name = "sdtNV";
            this.sdtNV.Size = new System.Drawing.Size(297, 30);
            this.sdtNV.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(832, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa Chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(832, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Điện Thoại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(819, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chỉnh Sửa Thông Tin ";
            // 
            // PhongBanList
            // 
            this.PhongBanList.Controls.Add(this.btnTTBP);
            this.PhongBanList.Controls.Add(this.maTrPhong);
            this.PhongBanList.Controls.Add(this.tenPB);
            this.PhongBanList.Controls.Add(this.label7);
            this.PhongBanList.Controls.Add(this.label9);
            this.PhongBanList.Controls.Add(this.label10);
            this.PhongBanList.Controls.Add(this.label6);
            this.PhongBanList.Controls.Add(this.dsPhongBan);
            this.PhongBanList.ImageKey = "department.png";
            this.PhongBanList.Location = new System.Drawing.Point(4, 39);
            this.PhongBanList.Name = "PhongBanList";
            this.PhongBanList.Padding = new System.Windows.Forms.Padding(3);
            this.PhongBanList.Size = new System.Drawing.Size(1186, 590);
            this.PhongBanList.TabIndex = 1;
            this.PhongBanList.Text = "PhongBan List";
            this.PhongBanList.UseVisualStyleBackColor = true;
            // 
            // btnTTBP
            // 
            this.btnTTBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTBP.Location = new System.Drawing.Point(954, 382);
            this.btnTTBP.Name = "btnTTBP";
            this.btnTTBP.Size = new System.Drawing.Size(116, 35);
            this.btnTTBP.TabIndex = 15;
            this.btnTTBP.Text = "Thay Đổi";
            this.btnTTBP.UseVisualStyleBackColor = true;
            this.btnTTBP.Click += new System.EventHandler(this.btnTTBP_Click);
            // 
            // maTrPhong
            // 
            this.maTrPhong.BackColor = System.Drawing.SystemColors.Menu;
            this.maTrPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maTrPhong.Location = new System.Drawing.Point(861, 317);
            this.maTrPhong.Name = "maTrPhong";
            this.maTrPhong.Size = new System.Drawing.Size(297, 30);
            this.maTrPhong.TabIndex = 14;
            // 
            // tenPB
            // 
            this.tenPB.BackColor = System.Drawing.SystemColors.Menu;
            this.tenPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenPB.Location = new System.Drawing.Point(861, 237);
            this.tenPB.Name = "tenPB";
            this.tenPB.Size = new System.Drawing.Size(297, 30);
            this.tenPB.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(860, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mã trường phòng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(860, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tên phòng ban:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(901, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "Chỉnh Sửa Thông Tin ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Danh Sách Phòng Ban";
            // 
            // dsPhongBan
            // 
            this.dsPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsPhongBan.Location = new System.Drawing.Point(18, 55);
            this.dsPhongBan.Name = "dsPhongBan";
            this.dsPhongBan.RowHeadersWidth = 51;
            this.dsPhongBan.RowTemplate.Height = 24;
            this.dsPhongBan.Size = new System.Drawing.Size(787, 517);
            this.dsPhongBan.TabIndex = 1;
            this.dsPhongBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsPhongBan_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.dataGridViewDSDA);
            this.tabPage3.ImageKey = "to-do-list.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1186, 590);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DeAn List";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Danh Sách Đề Án";
            // 
            // dataGridViewDSDA
            // 
            this.dataGridViewDSDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSDA.Location = new System.Drawing.Point(46, 52);
            this.dataGridViewDSDA.Name = "dataGridViewDSDA";
            this.dataGridViewDSDA.RowHeadersWidth = 51;
            this.dataGridViewDSDA.RowTemplate.Height = 24;
            this.dataGridViewDSDA.Size = new System.Drawing.Size(828, 219);
            this.dataGridViewDSDA.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.comboBoxChiNhanh);
            this.tabPage4.Controls.Add(this.comboBoxLinhVuc);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.dateTimeNS);
            this.tabPage4.Controls.Add(this.comboBoxPhong);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.btTaoUser);
            this.tabPage4.Controls.Add(this.comboBoxVaiTro);
            this.tabPage4.Controls.Add(this.checkedListBoxGT);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.txtSDT);
            this.tabPage4.Controls.Add(this.txtDiaChi);
            this.tabPage4.Controls.Add(this.txtTen);
            this.tabPage4.ImageKey = "user.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1186, 590);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Add NhanVien";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // comboBoxChiNhanh
            // 
            this.comboBoxChiNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChiNhanh.FormattingEnabled = true;
            this.comboBoxChiNhanh.Location = new System.Drawing.Point(738, 316);
            this.comboBoxChiNhanh.Name = "comboBoxChiNhanh";
            this.comboBoxChiNhanh.Size = new System.Drawing.Size(240, 33);
            this.comboBoxChiNhanh.TabIndex = 84;
            // 
            // comboBoxLinhVuc
            // 
            this.comboBoxLinhVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLinhVuc.FormattingEnabled = true;
            this.comboBoxLinhVuc.Location = new System.Drawing.Point(739, 251);
            this.comboBoxLinhVuc.Name = "comboBoxLinhVuc";
            this.comboBoxLinhVuc.Size = new System.Drawing.Size(239, 33);
            this.comboBoxLinhVuc.TabIndex = 83;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(617, 324);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 25);
            this.label11.TabIndex = 82;
            this.label11.Text = "Chi Nhánh";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(617, 259);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 25);
            this.label12.TabIndex = 81;
            this.label12.Text = "Lĩnh Vực";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(129, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 25);
            this.label8.TabIndex = 80;
            this.label8.Text = "Ngày Sinh";
            // 
            // dateTimeNS
            // 
            this.dateTimeNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNS.Location = new System.Drawing.Point(280, 259);
            this.dateTimeNS.Name = "dateTimeNS";
            this.dateTimeNS.Size = new System.Drawing.Size(271, 30);
            this.dateTimeNS.TabIndex = 79;
            // 
            // comboBoxPhong
            // 
            this.comboBoxPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPhong.FormattingEnabled = true;
            this.comboBoxPhong.Location = new System.Drawing.Point(739, 189);
            this.comboBoxPhong.Name = "comboBoxPhong";
            this.comboBoxPhong.Size = new System.Drawing.Size(239, 33);
            this.comboBoxPhong.TabIndex = 78;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(587, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 25);
            this.label13.TabIndex = 77;
            this.label13.Text = "Phòng";
            // 
            // btTaoUser
            // 
            this.btTaoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaoUser.Location = new System.Drawing.Point(469, 421);
            this.btTaoUser.Name = "btTaoUser";
            this.btTaoUser.Size = new System.Drawing.Size(138, 44);
            this.btTaoUser.TabIndex = 76;
            this.btTaoUser.Text = "Tạo Mới";
            this.btTaoUser.UseVisualStyleBackColor = true;
            this.btTaoUser.Click += new System.EventHandler(this.btTaoUser_Click);
            // 
            // comboBoxVaiTro
            // 
            this.comboBoxVaiTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVaiTro.FormattingEnabled = true;
            this.comboBoxVaiTro.Location = new System.Drawing.Point(280, 198);
            this.comboBoxVaiTro.Name = "comboBoxVaiTro";
            this.comboBoxVaiTro.Size = new System.Drawing.Size(271, 33);
            this.comboBoxVaiTro.TabIndex = 75;
            // 
            // checkedListBoxGT
            // 
            this.checkedListBoxGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxGT.FormattingEnabled = true;
            this.checkedListBoxGT.Items.AddRange(new object[] {
            "nam",
            "nu"});
            this.checkedListBoxGT.Location = new System.Drawing.Point(739, 51);
            this.checkedListBoxGT.Name = "checkedListBoxGT";
            this.checkedListBoxGT.Size = new System.Drawing.Size(113, 54);
            this.checkedListBoxGT.TabIndex = 74;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(608, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 25);
            this.label14.TabIndex = 73;
            this.label14.Text = "Giới Tính";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(587, 129);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 25);
            this.label15.TabIndex = 72;
            this.label15.Text = "Số Điện Thoại";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(129, 198);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 25);
            this.label16.TabIndex = 71;
            this.label16.Text = "Vai Trò";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(129, 133);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 25);
            this.label17.TabIndex = 70;
            this.label17.Text = "Địa Chỉ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(128, 77);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 25);
            this.label18.TabIndex = 69;
            this.label18.Text = "Họ Tên";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(739, 128);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(239, 30);
            this.txtSDT.TabIndex = 68;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(280, 134);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(271, 30);
            this.txtDiaChi.TabIndex = 67;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(280, 75);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(271, 30);
            this.txtTen.TabIndex = 66;
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
            // 
            // txtxManv
            // 
            this.txtxManv.BackColor = System.Drawing.SystemColors.Menu;
            this.txtxManv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxManv.Location = new System.Drawing.Point(834, 121);
            this.txtxManv.Name = "txtxManv";
            this.txtxManv.Size = new System.Drawing.Size(297, 30);
            this.txtxManv.TabIndex = 16;
            this.txtxManv.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(833, 93);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(137, 25);
            this.label19.TabIndex = 15;
            this.label19.Text = "Mã Nhân Viên";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // NhanSuHomeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.Information);
            this.DrawerIsOpen = true;
            this.DrawerTabControl = this.Information;
            this.Name = "NhanSuHomeGUI";
            this.Text = "Nhan Su Home";
            this.Information.ResumeLayout(false);
            this.NhanVienList.ResumeLayout(false);
            this.NhanVienList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsNhanVien)).EndInit();
            this.PhongBanList.ResumeLayout(false);
            this.PhongBanList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPhongBan)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSDA)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl Information;
        private System.Windows.Forms.TabPage NhanVienList;
        private System.Windows.Forms.Button btnThayDoiTT;
        private System.Windows.Forms.TextBox diachiNV;
        private System.Windows.Forms.TextBox sdtNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage PhongBanList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dsPhongBan;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewDSDA;
        private System.Windows.Forms.DataGridView dsNhanVien;
        private System.Windows.Forms.Label labelDSNV;
        private System.Windows.Forms.Button btnTTBP;
        private System.Windows.Forms.TextBox maTrPhong;
        private System.Windows.Forms.TextBox tenPB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxChiNhanh;
        private System.Windows.Forms.ComboBox comboBoxLinhVuc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimeNS;
        private System.Windows.Forms.ComboBox comboBoxPhong;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btTaoUser;
        private System.Windows.Forms.ComboBox comboBoxVaiTro;
        private System.Windows.Forms.CheckedListBox checkedListBoxGT;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.ImageList iconTab;
        private System.Windows.Forms.TextBox txtxManv;
        private System.Windows.Forms.Label label19;
    }
}