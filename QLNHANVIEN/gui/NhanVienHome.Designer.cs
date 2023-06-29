namespace QLNHANVIEN.gui
{
    partial class fNhanVienHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNhanVienHome));
            this.TabControlNV = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dsNhanVien = new System.Windows.Forms.DataGridView();
            this.ntThayDoiTT = new System.Windows.Forms.Button();
            this.txtDCtd = new System.Windows.Forms.TextBox();
            this.txtSDTtd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewDSPhongBan = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewDSDA = new System.Windows.Forms.DataGridView();
            this.Notification = new System.Windows.Forms.TabPage();
            this.iconTab = new System.Windows.Forms.ImageList(this.components);
            this.dsNotification = new System.Windows.Forms.DataGridView();
            this.TabControlNV.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsNhanVien)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSPhongBan)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSDA)).BeginInit();
            this.Notification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsNotification)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlNV
            // 
            this.TabControlNV.Controls.Add(this.tabPage1);
            this.TabControlNV.Controls.Add(this.tabPage2);
            this.TabControlNV.Controls.Add(this.tabPage3);
            this.TabControlNV.Controls.Add(this.Notification);
            this.TabControlNV.Depth = 0;
            this.TabControlNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlNV.ImageList = this.iconTab;
            this.TabControlNV.Location = new System.Drawing.Point(3, 64);
            this.TabControlNV.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControlNV.Multiline = true;
            this.TabControlNV.Name = "TabControlNV";
            this.TabControlNV.SelectedIndex = 0;
            this.TabControlNV.Size = new System.Drawing.Size(945, 492);
            this.TabControlNV.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.dsNhanVien);
            this.tabPage1.Controls.Add(this.ntThayDoiTT);
            this.tabPage1.Controls.Add(this.txtDCtd);
            this.tabPage1.Controls.Add(this.txtSDTtd);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ImageKey = "user.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(937, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Edit Information ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(333, 187);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(297, 30);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dsNhanVien
            // 
            this.dsNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsNhanVien.Location = new System.Drawing.Point(42, 44);
            this.dsNhanVien.Name = "dsNhanVien";
            this.dsNhanVien.RowHeadersWidth = 51;
            this.dsNhanVien.RowTemplate.Height = 24;
            this.dsNhanVien.Size = new System.Drawing.Size(865, 77);
            this.dsNhanVien.TabIndex = 8;
            // 
            // ntThayDoiTT
            // 
            this.ntThayDoiTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntThayDoiTT.Location = new System.Drawing.Point(421, 373);
            this.ntThayDoiTT.Name = "ntThayDoiTT";
            this.ntThayDoiTT.Size = new System.Drawing.Size(116, 35);
            this.ntThayDoiTT.TabIndex = 7;
            this.ntThayDoiTT.Text = "Thay Đổi";
            this.ntThayDoiTT.UseVisualStyleBackColor = true;
            this.ntThayDoiTT.Click += new System.EventHandler(this.ntThayDoiTT_Click);
            // 
            // txtDCtd
            // 
            this.txtDCtd.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDCtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDCtd.Location = new System.Drawing.Point(333, 244);
            this.txtDCtd.Name = "txtDCtd";
            this.txtDCtd.Size = new System.Drawing.Size(297, 30);
            this.txtDCtd.TabIndex = 6;
            // 
            // txtSDTtd
            // 
            this.txtSDTtd.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSDTtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTtd.Location = new System.Drawing.Point(333, 296);
            this.txtSDTtd.Name = "txtSDTtd";
            this.txtSDTtd.Size = new System.Drawing.Size(297, 30);
            this.txtSDTtd.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(170, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa Chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Điện Thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Sinh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chỉnh Sửa Thông Tin ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dataGridViewDSPhongBan);
            this.tabPage2.ImageKey = "department.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(937, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PhongBan List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Danh Sách Phòng Ban";
            // 
            // dataGridViewDSPhongBan
            // 
            this.dataGridViewDSPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSPhongBan.Location = new System.Drawing.Point(46, 52);
            this.dataGridViewDSPhongBan.Name = "dataGridViewDSPhongBan";
            this.dataGridViewDSPhongBan.RowHeadersWidth = 51;
            this.dataGridViewDSPhongBan.RowTemplate.Height = 24;
            this.dataGridViewDSPhongBan.Size = new System.Drawing.Size(826, 389);
            this.dataGridViewDSPhongBan.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.dataGridViewDSDA);
            this.tabPage3.ImageKey = "to-do-list.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(937, 449);
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
            this.dataGridViewDSDA.Size = new System.Drawing.Size(826, 389);
            this.dataGridViewDSDA.TabIndex = 2;
            // 
            // Notification
            // 
            this.Notification.Controls.Add(this.dsNotification);
            this.Notification.ImageKey = "notification.png";
            this.Notification.Location = new System.Drawing.Point(4, 39);
            this.Notification.Name = "Notification";
            this.Notification.Padding = new System.Windows.Forms.Padding(3);
            this.Notification.Size = new System.Drawing.Size(937, 449);
            this.Notification.TabIndex = 3;
            this.Notification.Text = "Notification";
            this.Notification.UseVisualStyleBackColor = true;
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
            // dsNotification
            // 
            this.dsNotification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsNotification.Location = new System.Drawing.Point(45, 16);
            this.dsNotification.Name = "dsNotification";
            this.dsNotification.RowHeadersWidth = 51;
            this.dsNotification.RowTemplate.Height = 24;
            this.dsNotification.Size = new System.Drawing.Size(811, 416);
            this.dsNotification.TabIndex = 35;
            // 
            // fNhanVienHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 559);
            this.Controls.Add(this.TabControlNV);
            this.DrawerIsOpen = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.TabControlNV;
            this.Name = "fNhanVienHome";
            this.Text = "NhanVien Home";
            this.Load += new System.EventHandler(this.fNhanVienHome_Load);
            this.TabControlNV.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsNhanVien)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSPhongBan)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSDA)).EndInit();
            this.Notification.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsNotification)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControlNV;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewDSPhongBan;
        private System.Windows.Forms.DataGridView dataGridViewDSDA;
        private System.Windows.Forms.Button ntThayDoiTT;
        private System.Windows.Forms.TextBox txtDCtd;
        private System.Windows.Forms.TextBox txtSDTtd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dsNhanVien;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabPage Notification;
        private System.Windows.Forms.ImageList iconTab;
        private System.Windows.Forms.DataGridView dsNotification;
    }
}