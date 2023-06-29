namespace QLNHANVIEN.gui
{
    partial class GrantTableToRoleGUI
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
            this.comboBoxTable = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btGrantTable = new System.Windows.Forms.Button();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.GridViewDSTableRole = new System.Windows.Forms.DataGridView();
            this.comboBoxPrivs = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDSTableRole)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTable
            // 
            this.comboBoxTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTable.FormattingEnabled = true;
            this.comboBoxTable.Location = new System.Drawing.Point(147, 53);
            this.comboBoxTable.Name = "comboBoxTable";
            this.comboBoxTable.Size = new System.Drawing.Size(285, 33);
            this.comboBoxTable.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Table";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Role";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btGrantTable
            // 
            this.btGrantTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGrantTable.Location = new System.Drawing.Point(560, 50);
            this.btGrantTable.Name = "btGrantTable";
            this.btGrantTable.Size = new System.Drawing.Size(117, 39);
            this.btGrantTable.TabIndex = 9;
            this.btGrantTable.Text = "Grant";
            this.btGrantTable.UseVisualStyleBackColor = true;
            this.btGrantTable.Click += new System.EventHandler(this.btGrantTable_Click);
            // 
            // txtRole
            // 
            this.txtRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.Location = new System.Drawing.Point(147, 12);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(285, 30);
            this.txtRole.TabIndex = 8;
            // 
            // GridViewDSTableRole
            // 
            this.GridViewDSTableRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDSTableRole.Location = new System.Drawing.Point(12, 161);
            this.GridViewDSTableRole.Name = "GridViewDSTableRole";
            this.GridViewDSTableRole.RowHeadersWidth = 51;
            this.GridViewDSTableRole.RowTemplate.Height = 24;
            this.GridViewDSTableRole.Size = new System.Drawing.Size(748, 233);
            this.GridViewDSTableRole.TabIndex = 14;
            // 
            // comboBoxPrivs
            // 
            this.comboBoxPrivs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPrivs.FormattingEnabled = true;
            this.comboBoxPrivs.Items.AddRange(new object[] {
            "SELECT",
            "UPDATE",
            "DELETE",
            "INSERT "});
            this.comboBoxPrivs.Location = new System.Drawing.Point(147, 103);
            this.comboBoxPrivs.Name = "comboBoxPrivs";
            this.comboBoxPrivs.Size = new System.Drawing.Size(285, 33);
            this.comboBoxPrivs.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Privs";
            // 
            // GrantTableToRoleGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 405);
            this.Controls.Add(this.comboBoxPrivs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GridViewDSTableRole);
            this.Controls.Add(this.comboBoxTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btGrantTable);
            this.Controls.Add(this.txtRole);
            this.Name = "GrantTableToRoleGUI";
            this.Text = "GrantTableToRoleGUI";
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDSTableRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btGrantTable;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.DataGridView GridViewDSTableRole;
        private System.Windows.Forms.ComboBox comboBoxPrivs;
        private System.Windows.Forms.Label label3;
    }
}