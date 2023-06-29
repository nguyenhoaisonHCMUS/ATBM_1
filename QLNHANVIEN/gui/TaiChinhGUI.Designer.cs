namespace QLNHANVIEN.gui
{
    partial class TaiChinhGUI
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
            this.dgvDeAn = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaNV1 = new MaterialSkin.Controls.MaterialTextBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.btnLuu = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhuCap = new MaterialSkin.Controls.MaterialTextBox();
            this.txtLuong = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPhanCong = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ttcnTC = new System.Windows.Forms.DataGridView();
            this.ntThayDoiTT = new System.Windows.Forms.Button();
            this.txtDCtd = new System.Windows.Forms.TextBox();
            this.txtSDTtd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.datagvDeAn = new System.Windows.Forms.DataGridView();
            this.dgvDeAn.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ttcnTC)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvDeAn)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDeAn
            // 
            this.dgvDeAn.Controls.Add(this.tabPage1);
            this.dgvDeAn.Controls.Add(this.tabPage2);
            this.dgvDeAn.Controls.Add(this.tabPage3);
            this.dgvDeAn.Controls.Add(this.tabPage4);
            this.dgvDeAn.Controls.Add(this.tabPage5);
            this.dgvDeAn.Depth = 0;
            this.dgvDeAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeAn.Location = new System.Drawing.Point(3, 64);
            this.dgvDeAn.MouseState = MaterialSkin.MouseState.HOVER;
            this.dgvDeAn.Multiline = true;
            this.dgvDeAn.Name = "dgvDeAn";
            this.dgvDeAn.SelectedIndex = 0;
            this.dgvDeAn.Size = new System.Drawing.Size(1194, 633);
            this.dgvDeAn.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtMaNV1);
            this.tabPage1.Controls.Add(this.dgvNhanVien);
            this.tabPage1.Controls.Add(this.btnLuu);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtPhuCap);
            this.tabPage1.Controls.Add(this.txtLuong);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1186, 604);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tác vụ NHANVIEN";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(854, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "MÃ NV";
            // 
            // txtMaNV1
            // 
            this.txtMaNV1.AnimateReadOnly = false;
            this.txtMaNV1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaNV1.Depth = 0;
            this.txtMaNV1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMaNV1.LeadingIcon = null;
            this.txtMaNV1.Location = new System.Drawing.Point(988, 66);
            this.txtMaNV1.MaxLength = 50;
            this.txtMaNV1.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaNV1.Multiline = false;
            this.txtMaNV1.Name = "txtMaNV1";
            this.txtMaNV1.Size = new System.Drawing.Size(144, 50);
            this.txtMaNV1.TabIndex = 9;
            this.txtMaNV1.Text = "";
            this.txtMaNV1.TrailingIcon = null;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(25, 66);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(789, 496);
            this.dgvNhanVien.TabIndex = 8;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLuu.Depth = 0;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.HighEmphasis = true;
            this.btnLuu.Icon = null;
            this.btnLuu.Location = new System.Drawing.Point(1000, 351);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLuu.Size = new System.Drawing.Size(64, 36);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLuu.UseAccentColor = false;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(854, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "PHỤ CẤP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(854, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "LƯƠNG";
            // 
            // txtPhuCap
            // 
            this.txtPhuCap.AnimateReadOnly = false;
            this.txtPhuCap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhuCap.Depth = 0;
            this.txtPhuCap.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhuCap.LeadingIcon = null;
            this.txtPhuCap.Location = new System.Drawing.Point(988, 245);
            this.txtPhuCap.MaxLength = 50;
            this.txtPhuCap.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPhuCap.Multiline = false;
            this.txtPhuCap.Name = "txtPhuCap";
            this.txtPhuCap.Size = new System.Drawing.Size(144, 50);
            this.txtPhuCap.TabIndex = 4;
            this.txtPhuCap.Text = "";
            this.txtPhuCap.TrailingIcon = null;
            // 
            // txtLuong
            // 
            this.txtLuong.AnimateReadOnly = false;
            this.txtLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLuong.Depth = 0;
            this.txtLuong.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLuong.LeadingIcon = null;
            this.txtLuong.Location = new System.Drawing.Point(988, 152);
            this.txtLuong.MaxLength = 50;
            this.txtLuong.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLuong.Multiline = false;
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(144, 50);
            this.txtLuong.TabIndex = 3;
            this.txtLuong.Text = "";
            this.txtLuong.TrailingIcon = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin bảng Nhân viên";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dgvPhanCong);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1186, 604);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tác vụ PHANCONG";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thông tin bảng Phân Công";
            // 
            // dgvPhanCong
            // 
            this.dgvPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanCong.Location = new System.Drawing.Point(33, 68);
            this.dgvPhanCong.Name = "dgvPhanCong";
            this.dgvPhanCong.RowHeadersWidth = 51;
            this.dgvPhanCong.RowTemplate.Height = 24;
            this.dgvPhanCong.Size = new System.Drawing.Size(1105, 505);
            this.dgvPhanCong.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dateTimePicker1);
            this.tabPage3.Controls.Add(this.ttcnTC);
            this.tabPage3.Controls.Add(this.ntThayDoiTT);
            this.tabPage3.Controls.Add(this.txtDCtd);
            this.tabPage3.Controls.Add(this.txtSDTtd);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1186, 604);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thông tin cá nhân";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(480, 249);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(297, 30);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // ttcnTC
            // 
            this.ttcnTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ttcnTC.Location = new System.Drawing.Point(54, 66);
            this.ttcnTC.Name = "ttcnTC";
            this.ttcnTC.RowHeadersWidth = 51;
            this.ttcnTC.RowTemplate.Height = 24;
            this.ttcnTC.Size = new System.Drawing.Size(1076, 79);
            this.ttcnTC.TabIndex = 17;
            this.ttcnTC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ntThayDoiTT
            // 
            this.ntThayDoiTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntThayDoiTT.Location = new System.Drawing.Point(568, 435);
            this.ntThayDoiTT.Name = "ntThayDoiTT";
            this.ntThayDoiTT.Size = new System.Drawing.Size(116, 35);
            this.ntThayDoiTT.TabIndex = 16;
            this.ntThayDoiTT.Text = "Thay Đổi";
            this.ntThayDoiTT.UseVisualStyleBackColor = true;
            this.ntThayDoiTT.Click += new System.EventHandler(this.ntThayDoiTT_Click);
            // 
            // txtDCtd
            // 
            this.txtDCtd.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDCtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDCtd.Location = new System.Drawing.Point(480, 306);
            this.txtDCtd.Name = "txtDCtd";
            this.txtDCtd.Size = new System.Drawing.Size(297, 30);
            this.txtDCtd.TabIndex = 15;
            // 
            // txtSDTtd
            // 
            this.txtSDTtd.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSDTtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTtd.Location = new System.Drawing.Point(480, 358);
            this.txtSDTtd.Name = "txtSDTtd";
            this.txtSDTtd.Size = new System.Drawing.Size(297, 30);
            this.txtSDTtd.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(317, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Địa Chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(317, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Số Điện Thoại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(317, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ngày Sinh:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Chỉnh Sửa Thông Tin ";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.dgvPhongBan);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1186, 604);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tác vụ PHONGBAN";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(50, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(243, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Thông tin bảng Phòng ban";
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongBan.Location = new System.Drawing.Point(55, 70);
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.RowHeadersWidth = 51;
            this.dgvPhongBan.RowTemplate.Height = 24;
            this.dgvPhongBan.Size = new System.Drawing.Size(1056, 485);
            this.dgvPhongBan.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.datagvDeAn);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1186, 604);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Tác vụ DEAN";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(35, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "Thông tin bảng Đề án";
            // 
            // datagvDeAn
            // 
            this.datagvDeAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvDeAn.Location = new System.Drawing.Point(40, 78);
            this.datagvDeAn.Name = "datagvDeAn";
            this.datagvDeAn.RowHeadersWidth = 51;
            this.datagvDeAn.RowTemplate.Height = 24;
            this.datagvDeAn.Size = new System.Drawing.Size(1113, 469);
            this.datagvDeAn.TabIndex = 0;
            // 
            // TaiChinhGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.dgvDeAn);
            this.DrawerTabControl = this.dgvDeAn;
            this.Name = "TaiChinhGUI";
            this.Text = "Tài Chính";
            this.dgvDeAn.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ttcnTC)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvDeAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl dgvDeAn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialTextBox txtPhuCap;
        private MaterialSkin.Controls.MaterialTextBox txtLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialButton btnLuu;
        private System.Windows.Forms.DataGridView dgvPhanCong;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sODTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHUCAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vAITRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lINHVUCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHINHANHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHOIGIANDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialTextBox txtMaNV1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView ttcnTC;
        private System.Windows.Forms.Button ntThayDoiTT;
        private System.Windows.Forms.TextBox txtDCtd;
        private System.Windows.Forms.TextBox txtSDTtd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvPhongBan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView datagvDeAn;
    }
}