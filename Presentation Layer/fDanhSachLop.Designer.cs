namespace Presentation_Layer
{
    partial class fDanhSachLop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnQuayLai = new DevComponents.DotNetBar.ButtonX();
            this.txtTimTenHocVien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbbChonLop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.lblLop = new DevComponents.DotNetBar.LabelX();
            this.btTim = new DevComponents.DotNetBar.ButtonX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgDSHVTheoLop = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSHVTheoLop)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerColorTint = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198))))));
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuayLai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuayLai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQuayLai.Location = new System.Drawing.Point(816, 21);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(101, 40);
            this.btnQuayLai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuayLai.TabIndex = 13;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // txtTimTenHocVien
            // 
            this.txtTimTenHocVien.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTimTenHocVien.Border.Class = "TextBoxBorder";
            this.txtTimTenHocVien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTimTenHocVien.DisabledBackColor = System.Drawing.Color.White;
            this.txtTimTenHocVien.ForeColor = System.Drawing.Color.Black;
            this.txtTimTenHocVien.Location = new System.Drawing.Point(463, 29);
            this.txtTimTenHocVien.Name = "txtTimTenHocVien";
            this.txtTimTenHocVien.PreventEnterBeep = true;
            this.txtTimTenHocVien.Size = new System.Drawing.Size(154, 22);
            this.txtTimTenHocVien.TabIndex = 11;
            // 
            // cbbChonLop
            // 
            this.cbbChonLop.DisplayMember = "Text";
            this.cbbChonLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbChonLop.ForeColor = System.Drawing.Color.Black;
            this.cbbChonLop.FormattingEnabled = true;
            this.cbbChonLop.ItemHeight = 16;
            this.cbbChonLop.Location = new System.Drawing.Point(126, 30);
            this.cbbChonLop.Name = "cbbChonLop";
            this.cbbChonLop.Size = new System.Drawing.Size(112, 22);
            this.cbbChonLop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbChonLop.TabIndex = 23;
            this.cbbChonLop.SelectedIndexChanged += new System.EventHandler(this.cbbChonLop_SelectedIndexChanged);
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
            this.labelX6.Location = new System.Drawing.Point(368, 29);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 10;
            this.labelX6.Text = "Tên Học Viên";
            // 
            // lblLop
            // 
            this.lblLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblLop.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblLop.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLop.ForeColor = System.Drawing.Color.Black;
            this.lblLop.Location = new System.Drawing.Point(633, 86);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(117, 23);
            this.lblLop.TabIndex = 24;
            // 
            // btTim
            // 
            this.btTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btTim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btTim.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTim.Location = new System.Drawing.Point(682, 21);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(101, 40);
            this.btTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btTim.TabIndex = 12;
            this.btTim.Text = "Tìm";
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX7.ForeColor = System.Drawing.Color.Black;
            this.labelX7.Location = new System.Drawing.Point(88, 29);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(32, 23);
            this.labelX7.TabIndex = 22;
            this.labelX7.Text = "Lớp";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btnQuayLai);
            this.groupBox2.Controls.Add(this.txtTimTenHocVien);
            this.groupBox2.Controls.Add(this.cbbChonLop);
            this.groupBox2.Controls.Add(this.labelX6);
            this.groupBox2.Controls.Add(this.labelX7);
            this.groupBox2.Controls.Add(this.btTim);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(992, 76);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Tên Học Viên";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dtgDSHVTheoLop
            // 
            this.dtgDSHVTheoLop.AllowUserToAddRows = false;
            this.dtgDSHVTheoLop.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDSHVTheoLop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgDSHVTheoLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDSHVTheoLop.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgDSHVTheoLop.EnableHeadersVisualStyles = false;
            this.dtgDSHVTheoLop.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(252)))));
            this.dtgDSHVTheoLop.Location = new System.Drawing.Point(4, 115);
            this.dtgDSHVTheoLop.Name = "dtgDSHVTheoLop";
            this.dtgDSHVTheoLop.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDSHVTheoLop.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgDSHVTheoLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDSHVTheoLop.Size = new System.Drawing.Size(992, 354);
            this.dtgDSHVTheoLop.TabIndex = 15;
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX10.ForeColor = System.Drawing.Color.Black;
            this.labelX10.Location = new System.Drawing.Point(372, 86);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(255, 23);
            this.labelX10.TabIndex = 20;
            this.labelX10.Text = "Danh Sách Học Viên Học Lớp";
            this.labelX10.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // fDanhSachLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = new DevComponents.DotNetBar.Metro.BorderColors(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            this.ClientSize = new System.Drawing.Size(1000, 554);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtgDSHVTheoLop);
            this.Controls.Add(this.lblLop);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fDanhSachLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DotNetBar Metro App Form";
            this.Load += new System.EventHandler(this.fDanhSachLop_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSHVTheoLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonX btnQuayLai;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimTenHocVien;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbChonLop;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX lblLop;
        private DevComponents.DotNetBar.ButtonX btTim;
        private DevComponents.DotNetBar.LabelX labelX7;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgDSHVTheoLop;
        private DevComponents.DotNetBar.LabelX labelX10;


    }
}

