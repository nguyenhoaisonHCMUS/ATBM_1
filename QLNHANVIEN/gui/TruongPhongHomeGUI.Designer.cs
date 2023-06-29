namespace QLNHANVIEN.gui
{
    partial class TruongPhongHomeGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TruongPhongHomeGUI));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvListMyStaff = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.TabTruongPhong = new MaterialSkin.Controls.MaterialTabControl();
            this.tabListAssignment = new System.Windows.Forms.TabPage();
            this.cbEmployeeID = new System.Windows.Forms.ComboBox();
            this.cbProjectID = new System.Windows.Forms.ComboBox();
            this.btnDeleteAssign = new MaterialSkin.Controls.MaterialButton();
            this.btnUpdateAssign = new MaterialSkin.Controls.MaterialButton();
            this.btnAddAssignment = new MaterialSkin.Controls.MaterialButton();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvListAssignDepartment = new System.Windows.Forms.DataGridView();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tabListDepartment = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvListDepartment = new System.Windows.Forms.DataGridView();
            this.tabListProject = new System.Windows.Forms.TabPage();
            this.dgvListProject = new System.Windows.Forms.DataGridView();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tabMyInfo = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnChangeInfor = new MaterialSkin.Controls.MaterialButton();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPhoneNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMyInfoTruongPhong = new System.Windows.Forms.DataGridView();
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
            this.iconTab = new System.Windows.Forms.ImageList(this.components);
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMyStaff)).BeginInit();
            this.TabTruongPhong.SuspendLayout();
            this.tabListAssignment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAssignDepartment)).BeginInit();
            this.tabListDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDepartment)).BeginInit();
            this.tabListProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProject)).BeginInit();
            this.tabMyInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyInfoTruongPhong)).BeginInit();
            this.Notification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsThongBao)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvListMyStaff);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.ImageKey = "group.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1014, 490);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Staff list by my Department";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvListMyStaff
            // 
            this.dgvListMyStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListMyStaff.Location = new System.Drawing.Point(6, 56);
            this.dgvListMyStaff.Name = "dgvListMyStaff";
            this.dgvListMyStaff.RowHeadersWidth = 51;
            this.dgvListMyStaff.RowTemplate.Height = 24;
            this.dgvListMyStaff.Size = new System.Drawing.Size(895, 428);
            this.dgvListMyStaff.TabIndex = 1;
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
            // TabTruongPhong
            // 
            this.TabTruongPhong.Controls.Add(this.tabPage1);
            this.TabTruongPhong.Controls.Add(this.tabListAssignment);
            this.TabTruongPhong.Controls.Add(this.tabListDepartment);
            this.TabTruongPhong.Controls.Add(this.tabListProject);
            this.TabTruongPhong.Controls.Add(this.tabMyInfo);
            this.TabTruongPhong.Controls.Add(this.Notification);
            this.TabTruongPhong.Depth = 0;
            this.TabTruongPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabTruongPhong.ImageList = this.iconTab;
            this.TabTruongPhong.Location = new System.Drawing.Point(3, 64);
            this.TabTruongPhong.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabTruongPhong.Multiline = true;
            this.TabTruongPhong.Name = "TabTruongPhong";
            this.TabTruongPhong.SelectedIndex = 0;
            this.TabTruongPhong.Size = new System.Drawing.Size(1022, 533);
            this.TabTruongPhong.TabIndex = 2;
            // 
            // tabListAssignment
            // 
            this.tabListAssignment.Controls.Add(this.cbEmployeeID);
            this.tabListAssignment.Controls.Add(this.cbProjectID);
            this.tabListAssignment.Controls.Add(this.btnDeleteAssign);
            this.tabListAssignment.Controls.Add(this.btnUpdateAssign);
            this.tabListAssignment.Controls.Add(this.btnAddAssignment);
            this.tabListAssignment.Controls.Add(this.dtpStartDate);
            this.tabListAssignment.Controls.Add(this.materialLabel6);
            this.tabListAssignment.Controls.Add(this.materialLabel5);
            this.tabListAssignment.Controls.Add(this.materialLabel4);
            this.tabListAssignment.Controls.Add(this.dgvListAssignDepartment);
            this.tabListAssignment.Controls.Add(this.materialLabel3);
            this.tabListAssignment.ImageKey = "to-do-list.png";
            this.tabListAssignment.Location = new System.Drawing.Point(4, 39);
            this.tabListAssignment.Name = "tabListAssignment";
            this.tabListAssignment.Padding = new System.Windows.Forms.Padding(3);
            this.tabListAssignment.Size = new System.Drawing.Size(1014, 490);
            this.tabListAssignment.TabIndex = 4;
            this.tabListAssignment.Text = "List Assignment";
            this.tabListAssignment.UseVisualStyleBackColor = true;
            // 
            // cbEmployeeID
            // 
            this.cbEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmployeeID.FormattingEnabled = true;
            this.cbEmployeeID.Location = new System.Drawing.Point(609, 92);
            this.cbEmployeeID.Name = "cbEmployeeID";
            this.cbEmployeeID.Size = new System.Drawing.Size(292, 33);
            this.cbEmployeeID.TabIndex = 15;
            // 
            // cbProjectID
            // 
            this.cbProjectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProjectID.FormattingEnabled = true;
            this.cbProjectID.Location = new System.Drawing.Point(609, 194);
            this.cbProjectID.Name = "cbProjectID";
            this.cbProjectID.Size = new System.Drawing.Size(292, 33);
            this.cbProjectID.TabIndex = 14;
            // 
            // btnDeleteAssign
            // 
            this.btnDeleteAssign.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteAssign.BackColor = System.Drawing.Color.Red;
            this.btnDeleteAssign.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteAssign.Depth = 0;
            this.btnDeleteAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAssign.HighEmphasis = true;
            this.btnDeleteAssign.Icon = null;
            this.btnDeleteAssign.Location = new System.Drawing.Point(811, 360);
            this.btnDeleteAssign.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteAssign.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteAssign.Name = "btnDeleteAssign";
            this.btnDeleteAssign.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteAssign.Size = new System.Drawing.Size(73, 36);
            this.btnDeleteAssign.TabIndex = 10;
            this.btnDeleteAssign.Text = "Delete";
            this.btnDeleteAssign.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteAssign.UseAccentColor = false;
            this.btnDeleteAssign.UseVisualStyleBackColor = false;
            this.btnDeleteAssign.Click += new System.EventHandler(this.btnDeleteAssign_Click);
            // 
            // btnUpdateAssign
            // 
            this.btnUpdateAssign.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateAssign.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUpdateAssign.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdateAssign.Depth = 0;
            this.btnUpdateAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAssign.HighEmphasis = true;
            this.btnUpdateAssign.Icon = null;
            this.btnUpdateAssign.Location = new System.Drawing.Point(703, 360);
            this.btnUpdateAssign.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdateAssign.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdateAssign.Name = "btnUpdateAssign";
            this.btnUpdateAssign.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdateAssign.Size = new System.Drawing.Size(77, 36);
            this.btnUpdateAssign.TabIndex = 9;
            this.btnUpdateAssign.Text = "Update";
            this.btnUpdateAssign.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdateAssign.UseAccentColor = false;
            this.btnUpdateAssign.UseVisualStyleBackColor = false;
            this.btnUpdateAssign.Click += new System.EventHandler(this.btnUpdateAssign_Click);
            // 
            // btnAddAssignment
            // 
            this.btnAddAssignment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddAssignment.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddAssignment.Depth = 0;
            this.btnAddAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAssignment.HighEmphasis = true;
            this.btnAddAssignment.Icon = null;
            this.btnAddAssignment.Location = new System.Drawing.Point(609, 360);
            this.btnAddAssignment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddAssignment.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddAssignment.Name = "btnAddAssignment";
            this.btnAddAssignment.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddAssignment.Size = new System.Drawing.Size(64, 36);
            this.btnAddAssignment.TabIndex = 8;
            this.btnAddAssignment.Text = "Add";
            this.btnAddAssignment.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddAssignment.UseAccentColor = false;
            this.btnAddAssignment.UseVisualStyleBackColor = true;
            this.btnAddAssignment.Click += new System.EventHandler(this.btnAddAssignment_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(609, 298);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(292, 28);
            this.dtpStartDate.TabIndex = 7;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(606, 255);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(74, 19);
            this.materialLabel6.TabIndex = 6;
            this.materialLabel6.Text = "Start date:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(606, 149);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(73, 19);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "ID Project:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(606, 52);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(93, 19);
            this.materialLabel4.TabIndex = 2;
            this.materialLabel4.Text = "ID Employee:";
            // 
            // dgvListAssignDepartment
            // 
            this.dgvListAssignDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListAssignDepartment.Location = new System.Drawing.Point(6, 52);
            this.dgvListAssignDepartment.Name = "dgvListAssignDepartment";
            this.dgvListAssignDepartment.RowHeadersWidth = 51;
            this.dgvListAssignDepartment.RowTemplate.Height = 24;
            this.dgvListAssignDepartment.Size = new System.Drawing.Size(585, 366);
            this.dgvListAssignDepartment.TabIndex = 1;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(295, 15);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(249, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "List assignment for my department";
            // 
            // tabListDepartment
            // 
            this.tabListDepartment.Controls.Add(this.materialLabel1);
            this.tabListDepartment.Controls.Add(this.dgvListDepartment);
            this.tabListDepartment.ImageKey = "department.png";
            this.tabListDepartment.Location = new System.Drawing.Point(4, 39);
            this.tabListDepartment.Name = "tabListDepartment";
            this.tabListDepartment.Padding = new System.Windows.Forms.Padding(3);
            this.tabListDepartment.Size = new System.Drawing.Size(1014, 490);
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
            this.dgvListDepartment.Size = new System.Drawing.Size(890, 362);
            this.dgvListDepartment.TabIndex = 0;
            // 
            // tabListProject
            // 
            this.tabListProject.Controls.Add(this.dgvListProject);
            this.tabListProject.Controls.Add(this.materialLabel2);
            this.tabListProject.ImageKey = "project.png";
            this.tabListProject.Location = new System.Drawing.Point(4, 39);
            this.tabListProject.Name = "tabListProject";
            this.tabListProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabListProject.Size = new System.Drawing.Size(1014, 490);
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
            this.dgvListProject.Size = new System.Drawing.Size(898, 370);
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
            // tabMyInfo
            // 
            this.tabMyInfo.Controls.Add(this.label5);
            this.tabMyInfo.Controls.Add(this.dtpDOB);
            this.tabMyInfo.Controls.Add(this.btnChangeInfor);
            this.tabMyInfo.Controls.Add(this.tbAddress);
            this.tabMyInfo.Controls.Add(this.tbPhoneNum);
            this.tabMyInfo.Controls.Add(this.label4);
            this.tabMyInfo.Controls.Add(this.label3);
            this.tabMyInfo.Controls.Add(this.label2);
            this.tabMyInfo.Controls.Add(this.label1);
            this.tabMyInfo.Controls.Add(this.dgvMyInfoTruongPhong);
            this.tabMyInfo.ImageKey = "user.png";
            this.tabMyInfo.Location = new System.Drawing.Point(4, 39);
            this.tabMyInfo.Name = "tabMyInfo";
            this.tabMyInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabMyInfo.Size = new System.Drawing.Size(1014, 490);
            this.tabMyInfo.TabIndex = 0;
            this.tabMyInfo.Text = "My Infor";
            this.tabMyInfo.UseVisualStyleBackColor = true;
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
            this.btnChangeInfor.Location = new System.Drawing.Point(683, 361);
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
            this.btnChangeInfor.Click += new System.EventHandler(this.btnChangeInfor_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.BackColor = System.Drawing.SystemColors.Menu;
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(29, 265);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(368, 30);
            this.tbAddress.TabIndex = 14;
            // 
            // tbPhoneNum
            // 
            this.tbPhoneNum.BackColor = System.Drawing.SystemColors.Menu;
            this.tbPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNum.Location = new System.Drawing.Point(538, 264);
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.Size = new System.Drawing.Size(368, 30);
            this.tbPhoneNum.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 237);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(533, 228);
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
            // dgvMyInfoTruongPhong
            // 
            this.dgvMyInfoTruongPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyInfoTruongPhong.Location = new System.Drawing.Point(15, 46);
            this.dgvMyInfoTruongPhong.Name = "dgvMyInfoTruongPhong";
            this.dgvMyInfoTruongPhong.RowHeadersWidth = 51;
            this.dgvMyInfoTruongPhong.RowTemplate.Height = 24;
            this.dgvMyInfoTruongPhong.Size = new System.Drawing.Size(886, 139);
            this.dgvMyInfoTruongPhong.TabIndex = 1;
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
            this.Notification.Size = new System.Drawing.Size(1014, 490);
            this.Notification.TabIndex = 5;
            this.Notification.Text = "Notification";
            this.Notification.UseVisualStyleBackColor = true;
            // 
            // txtLinhVuc
            // 
            this.txtLinhVuc.BackColor = System.Drawing.SystemColors.Menu;
            this.txtLinhVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinhVuc.Location = new System.Drawing.Point(627, 271);
            this.txtLinhVuc.Name = "txtLinhVuc";
            this.txtLinhVuc.Size = new System.Drawing.Size(332, 30);
            this.txtLinhVuc.TabIndex = 38;
            // 
            // txtChiNhanh
            // 
            this.txtChiNhanh.BackColor = System.Drawing.SystemColors.Menu;
            this.txtChiNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiNhanh.Location = new System.Drawing.Point(627, 349);
            this.txtChiNhanh.Name = "txtChiNhanh";
            this.txtChiNhanh.Size = new System.Drawing.Size(332, 30);
            this.txtChiNhanh.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(622, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 25);
            this.label11.TabIndex = 36;
            this.label11.Text = "Lĩnh Vực";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(622, 321);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 25);
            this.label12.TabIndex = 35;
            this.label12.Text = "Chi nhánh";
            // 
            // dsThongBao
            // 
            this.dsThongBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsThongBao.Location = new System.Drawing.Point(5, 37);
            this.dsThongBao.Name = "dsThongBao";
            this.dsThongBao.RowHeadersWidth = 51;
            this.dsThongBao.RowTemplate.Height = 24;
            this.dsThongBao.Size = new System.Drawing.Size(574, 416);
            this.dsThongBao.TabIndex = 34;
            // 
            // btnGuiThongBao
            // 
            this.btnGuiThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiThongBao.Location = new System.Drawing.Point(715, 400);
            this.btnGuiThongBao.Name = "btnGuiThongBao";
            this.btnGuiThongBao.Size = new System.Drawing.Size(161, 53);
            this.btnGuiThongBao.TabIndex = 33;
            this.btnGuiThongBao.Text = "Gửi thông báo";
            this.btnGuiThongBao.UseVisualStyleBackColor = true;
            this.btnGuiThongBao.Click += new System.EventHandler(this.btnGuiThongBao_Click);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(627, 105);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(332, 30);
            this.txtNoiDung.TabIndex = 32;
            // 
            // txtVaiTro
            // 
            this.txtVaiTro.BackColor = System.Drawing.SystemColors.Menu;
            this.txtVaiTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVaiTro.Location = new System.Drawing.Point(627, 183);
            this.txtVaiTro.Name = "txtVaiTro";
            this.txtVaiTro.Size = new System.Drawing.Size(332, 30);
            this.txtVaiTro.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(622, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Nội dung:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(622, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 25);
            this.label9.TabIndex = 29;
            this.label9.Text = "Vai trò:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(721, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 25);
            this.label10.TabIndex = 28;
            this.label10.Text = "Thêm thông báo";
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
            // TruongPhongHomeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 600);
            this.Controls.Add(this.TabTruongPhong);
            this.DrawerIsOpen = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.TabTruongPhong;
            this.Name = "TruongPhongHomeGUI";
            this.Text = "Trưởng phòng";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMyStaff)).EndInit();
            this.TabTruongPhong.ResumeLayout(false);
            this.tabListAssignment.ResumeLayout(false);
            this.tabListAssignment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAssignDepartment)).EndInit();
            this.tabListDepartment.ResumeLayout(false);
            this.tabListDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDepartment)).EndInit();
            this.tabListProject.ResumeLayout(false);
            this.tabListProject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProject)).EndInit();
            this.tabMyInfo.ResumeLayout(false);
            this.tabMyInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyInfoTruongPhong)).EndInit();
            this.Notification.ResumeLayout(false);
            this.Notification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsThongBao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvListMyStaff;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialTabControl TabTruongPhong;
        private System.Windows.Forms.TabPage tabListAssignment;
        private System.Windows.Forms.ComboBox cbEmployeeID;
        private System.Windows.Forms.ComboBox cbProjectID;
        private MaterialSkin.Controls.MaterialButton btnDeleteAssign;
        private MaterialSkin.Controls.MaterialButton btnUpdateAssign;
        private MaterialSkin.Controls.MaterialButton btnAddAssignment;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.DataGridView dgvListAssignDepartment;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TabPage tabListDepartment;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView dgvListDepartment;
        private System.Windows.Forms.TabPage tabListProject;
        private System.Windows.Forms.DataGridView dgvListProject;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TabPage tabMyInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private MaterialSkin.Controls.MaterialButton btnChangeInfor;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPhoneNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMyInfoTruongPhong;
        private System.Windows.Forms.ImageList iconTab;
        private System.Windows.Forms.TabPage Notification;
        private System.Windows.Forms.TextBox txtLinhVuc;
        private System.Windows.Forms.TextBox txtChiNhanh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dsThongBao;
        private System.Windows.Forms.Button btnGuiThongBao;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtVaiTro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}