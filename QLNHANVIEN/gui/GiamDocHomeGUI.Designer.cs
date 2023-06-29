namespace QLNHANVIEN.gui
{
    partial class GiamDocHomeGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiamDocHomeGUI));
            this.iconTab = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabListAssignment = new System.Windows.Forms.TabPage();
            this.dgvListAssign = new System.Windows.Forms.DataGridView();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tbPhoneNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvListStaff = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tabListDepartment = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvListDepartment = new System.Windows.Forms.DataGridView();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tabListProject = new System.Windows.Forms.TabPage();
            this.dgvListProject = new System.Windows.Forms.DataGridView();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tb1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnChangeInfor = new MaterialSkin.Controls.MaterialButton();
            this.tabMyInfo = new System.Windows.Forms.TabPage();
            this.tbEmployeeID = new System.Windows.Forms.TextBox();
            this.dgvMyInfo = new System.Windows.Forms.DataGridView();
            this.TabGiamDoc = new MaterialSkin.Controls.MaterialTabControl();
            this.Notification = new System.Windows.Forms.TabPage();
            this.txtLinhVuc = new System.Windows.Forms.TextBox();
            this.txtChiNhanh = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dsThongBao = new System.Windows.Forms.DataGridView();
            this.btnGuiThongBao = new System.Windows.Forms.Button();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtVaiTro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabListAssignment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAssign)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStaff)).BeginInit();
            this.tabListDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDepartment)).BeginInit();
            this.tabListProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProject)).BeginInit();
            this.tabMyInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyInfo)).BeginInit();
            this.TabGiamDoc.SuspendLayout();
            this.Notification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsThongBao)).BeginInit();
            this.SuspendLayout();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(470, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Phone number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fix information";
            // 
            // tabListAssignment
            // 
            this.tabListAssignment.Controls.Add(this.dgvListAssign);
            this.tabListAssignment.Controls.Add(this.materialLabel3);
            this.tabListAssignment.ImageKey = "to-do-list.png";
            this.tabListAssignment.Location = new System.Drawing.Point(4, 39);
            this.tabListAssignment.Name = "tabListAssignment";
            this.tabListAssignment.Padding = new System.Windows.Forms.Padding(3);
            this.tabListAssignment.Size = new System.Drawing.Size(1030, 490);
            this.tabListAssignment.TabIndex = 4;
            this.tabListAssignment.Text = "List Assignment";
            this.tabListAssignment.UseVisualStyleBackColor = true;
            // 
            // dgvListAssign
            // 
            this.dgvListAssign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListAssign.Location = new System.Drawing.Point(6, 52);
            this.dgvListAssign.Name = "dgvListAssign";
            this.dgvListAssign.RowHeadersWidth = 51;
            this.dgvListAssign.RowTemplate.Height = 24;
            this.dgvListAssign.Size = new System.Drawing.Size(890, 432);
            this.dgvListAssign.TabIndex = 1;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(368, 12);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(115, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "List Assignment";
            // 
            // tbPhoneNum
            // 
            this.tbPhoneNum.BackColor = System.Drawing.SystemColors.Menu;
            this.tbPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNum.Location = new System.Drawing.Point(475, 367);
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.Size = new System.Drawing.Size(368, 30);
            this.tbPhoneNum.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(470, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date of birth:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvListStaff);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.ImageKey = "group.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1030, 490);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Staff list";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvListStaff
            // 
            this.dgvListStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListStaff.Location = new System.Drawing.Point(6, 56);
            this.dgvListStaff.Name = "dgvListStaff";
            this.dgvListStaff.RowHeadersWidth = 51;
            this.dgvListStaff.RowTemplate.Height = 24;
            this.dgvListStaff.Size = new System.Drawing.Size(883, 428);
            this.dgvListStaff.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(359, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "List my staff";
            // 
            // tabListDepartment
            // 
            this.tabListDepartment.Controls.Add(this.materialLabel1);
            this.tabListDepartment.Controls.Add(this.dgvListDepartment);
            this.tabListDepartment.ImageKey = "department.png";
            this.tabListDepartment.Location = new System.Drawing.Point(4, 39);
            this.tabListDepartment.Name = "tabListDepartment";
            this.tabListDepartment.Padding = new System.Windows.Forms.Padding(3);
            this.tabListDepartment.Size = new System.Drawing.Size(1030, 490);
            this.tabListDepartment.TabIndex = 1;
            this.tabListDepartment.Text = "List Department";
            this.tabListDepartment.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(316, 17);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(114, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "List Department";
            // 
            // dgvListDepartment
            // 
            this.dgvListDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListDepartment.Location = new System.Drawing.Point(6, 56);
            this.dgvListDepartment.Name = "dgvListDepartment";
            this.dgvListDepartment.RowHeadersWidth = 51;
            this.dgvListDepartment.RowTemplate.Height = 24;
            this.dgvListDepartment.Size = new System.Drawing.Size(866, 428);
            this.dgvListDepartment.TabIndex = 0;
            // 
            // tbAddress
            // 
            this.tbAddress.BackColor = System.Drawing.SystemColors.Menu;
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(475, 283);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(368, 30);
            this.tbAddress.TabIndex = 14;
            // 
            // tabListProject
            // 
            this.tabListProject.Controls.Add(this.dgvListProject);
            this.tabListProject.Controls.Add(this.materialLabel2);
            this.tabListProject.ImageKey = "project.png";
            this.tabListProject.Location = new System.Drawing.Point(4, 39);
            this.tabListProject.Name = "tabListProject";
            this.tabListProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabListProject.Size = new System.Drawing.Size(1030, 490);
            this.tabListProject.TabIndex = 2;
            this.tabListProject.Text = "List Project";
            this.tabListProject.UseVisualStyleBackColor = true;
            // 
            // dgvListProject
            // 
            this.dgvListProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListProject.Location = new System.Drawing.Point(6, 48);
            this.dgvListProject.Name = "dgvListProject";
            this.dgvListProject.RowHeadersWidth = 51;
            this.dgvListProject.RowTemplate.Height = 24;
            this.dgvListProject.Size = new System.Drawing.Size(832, 436);
            this.dgvListProject.TabIndex = 1;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(339, 12);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(80, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "List Project";
            // 
            // tb1
            // 
            this.tb1.AutoSize = true;
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(24, 245);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(129, 25);
            this.tb1.TabIndex = 18;
            this.tb1.Text = "Employee ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(310, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "Account information";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Location = new System.Drawing.Point(29, 367);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(368, 30);
            this.dtpDOB.TabIndex = 16;
            // 
            // btnChangeInfor
            // 
            this.btnChangeInfor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChangeInfor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnChangeInfor.Depth = 0;
            this.btnChangeInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeInfor.HighEmphasis = true;
            this.btnChangeInfor.Icon = null;
            this.btnChangeInfor.Location = new System.Drawing.Point(763, 430);
            this.btnChangeInfor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnChangeInfor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChangeInfor.Name = "btnChangeInfor";
            this.btnChangeInfor.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnChangeInfor.Size = new System.Drawing.Size(77, 36);
            this.btnChangeInfor.TabIndex = 15;
            this.btnChangeInfor.Text = "Update";
            this.btnChangeInfor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnChangeInfor.UseAccentColor = false;
            this.btnChangeInfor.UseVisualStyleBackColor = true;
            this.btnChangeInfor.Click += new System.EventHandler(this.dgvMyInfo_CellClick);
            // 
            // tabMyInfo
            // 
            this.tabMyInfo.Controls.Add(this.tbEmployeeID);
            this.tabMyInfo.Controls.Add(this.tb1);
            this.tabMyInfo.Controls.Add(this.label5);
            this.tabMyInfo.Controls.Add(this.dtpDOB);
            this.tabMyInfo.Controls.Add(this.btnChangeInfor);
            this.tabMyInfo.Controls.Add(this.tbAddress);
            this.tabMyInfo.Controls.Add(this.tbPhoneNum);
            this.tabMyInfo.Controls.Add(this.label4);
            this.tabMyInfo.Controls.Add(this.label3);
            this.tabMyInfo.Controls.Add(this.label2);
            this.tabMyInfo.Controls.Add(this.label1);
            this.tabMyInfo.Controls.Add(this.dgvMyInfo);
            this.tabMyInfo.ImageKey = "user.png";
            this.tabMyInfo.Location = new System.Drawing.Point(4, 39);
            this.tabMyInfo.Name = "tabMyInfo";
            this.tabMyInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabMyInfo.Size = new System.Drawing.Size(1030, 490);
            this.tabMyInfo.TabIndex = 0;
            this.tabMyInfo.Text = "My Infor";
            this.tabMyInfo.UseVisualStyleBackColor = true;
            // 
            // tbEmployeeID
            // 
            this.tbEmployeeID.BackColor = System.Drawing.SystemColors.Menu;
            this.tbEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmployeeID.Location = new System.Drawing.Point(29, 283);
            this.tbEmployeeID.Name = "tbEmployeeID";
            this.tbEmployeeID.ReadOnly = true;
            this.tbEmployeeID.Size = new System.Drawing.Size(368, 30);
            this.tbEmployeeID.TabIndex = 19;
            // 
            // dgvMyInfo
            // 
            this.dgvMyInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyInfo.Location = new System.Drawing.Point(15, 46);
            this.dgvMyInfo.Name = "dgvMyInfo";
            this.dgvMyInfo.RowHeadersWidth = 51;
            this.dgvMyInfo.RowTemplate.Height = 24;
            this.dgvMyInfo.Size = new System.Drawing.Size(828, 139);
            this.dgvMyInfo.TabIndex = 1;
            // 
            // TabGiamDoc
            // 
            this.TabGiamDoc.Controls.Add(this.tabPage1);
            this.TabGiamDoc.Controls.Add(this.tabListAssignment);
            this.TabGiamDoc.Controls.Add(this.tabListDepartment);
            this.TabGiamDoc.Controls.Add(this.tabListProject);
            this.TabGiamDoc.Controls.Add(this.tabMyInfo);
            this.TabGiamDoc.Controls.Add(this.Notification);
            this.TabGiamDoc.Depth = 0;
            this.TabGiamDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabGiamDoc.ImageList = this.iconTab;
            this.TabGiamDoc.Location = new System.Drawing.Point(3, 64);
            this.TabGiamDoc.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabGiamDoc.Multiline = true;
            this.TabGiamDoc.Name = "TabGiamDoc";
            this.TabGiamDoc.SelectedIndex = 0;
            this.TabGiamDoc.Size = new System.Drawing.Size(1038, 533);
            this.TabGiamDoc.TabIndex = 3;
            // 
            // Notification
            // 
            this.Notification.Controls.Add(this.txtLinhVuc);
            this.Notification.Controls.Add(this.txtChiNhanh);
            this.Notification.Controls.Add(this.label11);
            this.Notification.Controls.Add(this.label12);
            this.Notification.Controls.Add(this.dsThongBao);
            this.Notification.Controls.Add(this.btnGuiThongBao);
            this.Notification.Controls.Add(this.txtNoiDung);
            this.Notification.Controls.Add(this.txtVaiTro);
            this.Notification.Controls.Add(this.label8);
            this.Notification.Controls.Add(this.label9);
            this.Notification.Controls.Add(this.label10);
            this.Notification.ImageKey = "notification.png";
            this.Notification.Location = new System.Drawing.Point(4, 39);
            this.Notification.Name = "Notification";
            this.Notification.Padding = new System.Windows.Forms.Padding(3);
            this.Notification.Size = new System.Drawing.Size(1030, 490);
            this.Notification.TabIndex = 5;
            this.Notification.Text = "Notification";
            this.Notification.UseVisualStyleBackColor = true;
            // 
            // txtLinhVuc
            // 
            this.txtLinhVuc.BackColor = System.Drawing.SystemColors.Menu;
            this.txtLinhVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinhVuc.Location = new System.Drawing.Point(642, 280);
            this.txtLinhVuc.Name = "txtLinhVuc";
            this.txtLinhVuc.Size = new System.Drawing.Size(332, 30);
            this.txtLinhVuc.TabIndex = 27;
            // 
            // txtChiNhanh
            // 
            this.txtChiNhanh.BackColor = System.Drawing.SystemColors.Menu;
            this.txtChiNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiNhanh.Location = new System.Drawing.Point(642, 358);
            this.txtChiNhanh.Name = "txtChiNhanh";
            this.txtChiNhanh.Size = new System.Drawing.Size(332, 30);
            this.txtChiNhanh.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(637, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "Lĩnh Vực";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(637, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 25);
            this.label12.TabIndex = 24;
            this.label12.Text = "Chi nhánh";
            // 
            // dsThongBao
            // 
            this.dsThongBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsThongBao.Location = new System.Drawing.Point(20, 46);
            this.dsThongBao.Name = "dsThongBao";
            this.dsThongBao.RowHeadersWidth = 51;
            this.dsThongBao.RowTemplate.Height = 24;
            this.dsThongBao.Size = new System.Drawing.Size(574, 416);
            this.dsThongBao.TabIndex = 21;
            // 
            // btnGuiThongBao
            // 
            this.btnGuiThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiThongBao.Location = new System.Drawing.Point(730, 409);
            this.btnGuiThongBao.Name = "btnGuiThongBao";
            this.btnGuiThongBao.Size = new System.Drawing.Size(161, 53);
            this.btnGuiThongBao.TabIndex = 20;
            this.btnGuiThongBao.Text = "Gửi thông báo";
            this.btnGuiThongBao.UseVisualStyleBackColor = true;
            this.btnGuiThongBao.Click += new System.EventHandler(this.btnGuiThongBao_Click);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(642, 114);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(332, 30);
            this.txtNoiDung.TabIndex = 19;
            // 
            // txtVaiTro
            // 
            this.txtVaiTro.BackColor = System.Drawing.SystemColors.Menu;
            this.txtVaiTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVaiTro.Location = new System.Drawing.Point(642, 192);
            this.txtVaiTro.Name = "txtVaiTro";
            this.txtVaiTro.Size = new System.Drawing.Size(332, 30);
            this.txtVaiTro.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(637, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nội dung:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(637, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Vai trò:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(736, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "Thêm thông báo";
            // 
            // GiamDocHomeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 600);
            this.Controls.Add(this.TabGiamDoc);
            this.DrawerIsOpen = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.TabGiamDoc;
            this.Name = "GiamDocHomeGUI";
            this.Text = "Giám đốc";
            this.tabListAssignment.ResumeLayout(false);
            this.tabListAssignment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAssign)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStaff)).EndInit();
            this.tabListDepartment.ResumeLayout(false);
            this.tabListDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDepartment)).EndInit();
            this.tabListProject.ResumeLayout(false);
            this.tabListProject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProject)).EndInit();
            this.tabMyInfo.ResumeLayout(false);
            this.tabMyInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyInfo)).EndInit();
            this.TabGiamDoc.ResumeLayout(false);
            this.Notification.ResumeLayout(false);
            this.Notification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsThongBao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList iconTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabListAssignment;
        private System.Windows.Forms.DataGridView dgvListAssign;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TextBox tbPhoneNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvListStaff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabListDepartment;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView dgvListDepartment;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TabPage tabListProject;
        private System.Windows.Forms.DataGridView dgvListProject;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Label tb1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private MaterialSkin.Controls.MaterialButton btnChangeInfor;
        private System.Windows.Forms.TabPage tabMyInfo;
        private System.Windows.Forms.TextBox tbEmployeeID;
        private System.Windows.Forms.DataGridView dgvMyInfo;
        private MaterialSkin.Controls.MaterialTabControl TabGiamDoc;
        private System.Windows.Forms.TabPage Notification;
        private System.Windows.Forms.DataGridView dsThongBao;
        private System.Windows.Forms.Button btnGuiThongBao;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtVaiTro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLinhVuc;
        private System.Windows.Forms.TextBox txtChiNhanh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}