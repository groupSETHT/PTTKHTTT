namespace Presentation_Layer
{
    partial class fDanhSachHocVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnDong = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnQuayLai = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtTimTenHocVien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.btTim = new DevComponents.DotNetBar.ButtonX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbtnHVChinhThuc = new System.Windows.Forms.RadioButton();
            this.rdbtnHVTiemNang = new System.Windows.Forms.RadioButton();
            this.rdbtnAllHV = new System.Windows.Forms.RadioButton();
            this.dtgDSHV = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSHV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(117, 393);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(101, 40);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            // 
            // btnDong
            // 
            this.btnDong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDong.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnDong.Location = new System.Drawing.Point(551, 393);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(101, 40);
            this.btnDong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDong.TabIndex = 16;
            this.btnDong.Text = "Đóng";
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(336, 393);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 40);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuayLai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuayLai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQuayLai.Location = new System.Drawing.Point(576, 41);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(101, 40);
            this.btnQuayLai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuayLai.TabIndex = 9;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(4, 131);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(882, 23);
            this.labelX4.TabIndex = 5;
            this.labelX4.Text = "Danh Sách Học Viên Chính Thức";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // txtTimTenHocVien
            // 
            // 
            // 
            // 
            this.txtTimTenHocVien.Border.Class = "TextBoxBorder";
            this.txtTimTenHocVien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTimTenHocVien.DisabledBackColor = System.Drawing.Color.White;
            this.txtTimTenHocVien.Location = new System.Drawing.Point(223, 49);
            this.txtTimTenHocVien.Name = "txtTimTenHocVien";
            this.txtTimTenHocVien.PreventEnterBeep = true;
            this.txtTimTenHocVien.Size = new System.Drawing.Size(154, 22);
            this.txtTimTenHocVien.TabIndex = 1;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX6.ForeColor = System.Drawing.Color.Black;
            this.labelX6.Location = new System.Drawing.Point(128, 49);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 0;
            this.labelX6.Text = "Tên Học Viên";
            // 
            // btTim
            // 
            this.btTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btTim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btTim.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTim.Location = new System.Drawing.Point(442, 41);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(101, 40);
            this.btTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btTim.TabIndex = 3;
            this.btTim.Text = "Tìm";
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerColorTint = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198))))));
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btnQuayLai);
            this.groupBox2.Controls.Add(this.txtTimTenHocVien);
            this.groupBox2.Controls.Add(this.labelX6);
            this.groupBox2.Controls.Add(this.btTim);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(882, 96);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Học Viên";
            // 
            // rdbtnHVChinhThuc
            // 
            this.rdbtnHVChinhThuc.AutoSize = true;
            this.rdbtnHVChinhThuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rdbtnHVChinhThuc.ForeColor = System.Drawing.Color.Black;
            this.rdbtnHVChinhThuc.Location = new System.Drawing.Point(336, 108);
            this.rdbtnHVChinhThuc.Name = "rdbtnHVChinhThuc";
            this.rdbtnHVChinhThuc.Size = new System.Drawing.Size(127, 17);
            this.rdbtnHVChinhThuc.TabIndex = 19;
            this.rdbtnHVChinhThuc.TabStop = true;
            this.rdbtnHVChinhThuc.Text = "Học viên chính thức";
            this.rdbtnHVChinhThuc.UseVisualStyleBackColor = false;
            this.rdbtnHVChinhThuc.CheckedChanged += new System.EventHandler(this.rdbtnHVChinhThuc_CheckedChanged);
            // 
            // rdbtnHVTiemNang
            // 
            this.rdbtnHVTiemNang.AutoSize = true;
            this.rdbtnHVTiemNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rdbtnHVTiemNang.ForeColor = System.Drawing.Color.Black;
            this.rdbtnHVTiemNang.Location = new System.Drawing.Point(152, 108);
            this.rdbtnHVTiemNang.Name = "rdbtnHVTiemNang";
            this.rdbtnHVTiemNang.Size = new System.Drawing.Size(124, 17);
            this.rdbtnHVTiemNang.TabIndex = 20;
            this.rdbtnHVTiemNang.TabStop = true;
            this.rdbtnHVTiemNang.Text = "Học viên tiềm năng";
            this.rdbtnHVTiemNang.UseVisualStyleBackColor = false;
            this.rdbtnHVTiemNang.CheckedChanged += new System.EventHandler(this.rdbtnHVTiemNang_CheckedChanged);
            // 
            // rdbtnAllHV
            // 
            this.rdbtnAllHV.AutoSize = true;
            this.rdbtnAllHV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rdbtnAllHV.ForeColor = System.Drawing.Color.Black;
            this.rdbtnAllHV.Location = new System.Drawing.Point(536, 108);
            this.rdbtnAllHV.Name = "rdbtnAllHV";
            this.rdbtnAllHV.Size = new System.Drawing.Size(100, 17);
            this.rdbtnAllHV.TabIndex = 21;
            this.rdbtnAllHV.TabStop = true;
            this.rdbtnAllHV.Text = "Tất cả học viên";
            this.rdbtnAllHV.UseVisualStyleBackColor = false;
            this.rdbtnAllHV.CheckedChanged += new System.EventHandler(this.rdbtnAllHV_CheckedChanged);
            // 
            // dtgDSHV
            // 
            this.dtgDSHV.AllowUserToAddRows = false;
            this.dtgDSHV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDSHV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgDSHV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDSHV.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgDSHV.EnableHeadersVisualStyles = false;
            this.dtgDSHV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(252)))));
            this.dtgDSHV.Location = new System.Drawing.Point(4, 160);
            this.dtgDSHV.Name = "dtgDSHV";
            this.dtgDSHV.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDSHV.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgDSHV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDSHV.Size = new System.Drawing.Size(882, 340);
            this.dtgDSHV.TabIndex = 22;
            // 
            // fDanhSachHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = new DevComponents.DotNetBar.Metro.BorderColors(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            this.ClientSize = new System.Drawing.Size(890, 562);
            this.Controls.Add(this.dtgDSHV);
            this.Controls.Add(this.rdbtnAllHV);
            this.Controls.Add(this.rdbtnHVTiemNang);
            this.Controls.Add(this.rdbtnHVChinhThuc);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fDanhSachHocVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DotNetBar Metro App Form";
            this.Load += new System.EventHandler(this.fDanhSachHocVien_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSHV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnDong;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnQuayLai;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimTenHocVien;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.ButtonX btTim;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbtnHVChinhThuc;
        private System.Windows.Forms.RadioButton rdbtnHVTiemNang;
        private System.Windows.Forms.RadioButton rdbtnAllHV;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgDSHV;


    }
}

