namespace Presentation_Layer
{
    partial class fKetQuaThi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.dgvKetQuaThi = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.clmSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaHocVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTenHocVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKetQuaThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIn = new DevComponents.DotNetBar.ButtonX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnDong = new DevComponents.DotNetBar.ButtonX();
            this.lblTenLop = new DevComponents.DotNetBar.LabelX();
            this.cbbKyThi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cbbLoaiKyThi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaThi)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(62, 63);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(502, 23);
            this.labelX5.TabIndex = 11;
            this.labelX5.Text = "Kết Quả Thi Xếp Lớp";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // dgvKetQuaThi
            // 
            this.dgvKetQuaThi.AllowUserToAddRows = false;
            this.dgvKetQuaThi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKetQuaThi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKetQuaThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQuaThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSTT,
            this.clmMaHocVien,
            this.clmTenHocVien,
            this.clmKetQuaThi});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKetQuaThi.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvKetQuaThi.EnableHeadersVisualStyles = false;
            this.dgvKetQuaThi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(252)))));
            this.dgvKetQuaThi.Location = new System.Drawing.Point(62, 92);
            this.dgvKetQuaThi.Name = "dgvKetQuaThi";
            this.dgvKetQuaThi.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKetQuaThi.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvKetQuaThi.RowHeadersVisible = false;
            this.dgvKetQuaThi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKetQuaThi.Size = new System.Drawing.Size(502, 265);
            this.dgvKetQuaThi.TabIndex = 10;
            // 
            // clmSTT
            // 
            this.clmSTT.HeaderText = "STT";
            this.clmSTT.Name = "clmSTT";
            this.clmSTT.ReadOnly = true;
            // 
            // clmMaHocVien
            // 
            this.clmMaHocVien.HeaderText = "Mã Học Viên";
            this.clmMaHocVien.Name = "clmMaHocVien";
            this.clmMaHocVien.ReadOnly = true;
            this.clmMaHocVien.Width = 150;
            // 
            // clmTenHocVien
            // 
            this.clmTenHocVien.HeaderText = "Tên Học Viên";
            this.clmTenHocVien.Name = "clmTenHocVien";
            this.clmTenHocVien.ReadOnly = true;
            this.clmTenHocVien.Width = 150;
            // 
            // clmKetQuaThi
            // 
            this.clmKetQuaThi.HeaderText = "Kết Qủa Thi";
            this.clmKetQuaThi.Name = "clmKetQuaThi";
            this.clmKetQuaThi.ReadOnly = true;
            // 
            // btnIn
            // 
            this.btnIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnIn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnIn.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnIn.Location = new System.Drawing.Point(130, 398);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(100, 46);
            this.btnIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "In";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerColorTint = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198))))));
            // 
            // btnDong
            // 
            this.btnDong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDong.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnDong.Location = new System.Drawing.Point(380, 398);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 46);
            this.btnDong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // lblTenLop
            // 
            this.lblTenLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblTenLop.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTenLop.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLop.ForeColor = System.Drawing.Color.Black;
            this.lblTenLop.Location = new System.Drawing.Point(399, 19);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(165, 22);
            this.lblTenLop.TabIndex = 46;
            this.lblTenLop.Text = "Lớp ";
            // 
            // cbbKyThi
            // 
            this.cbbKyThi.DisplayMember = "Text";
            this.cbbKyThi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbKyThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKyThi.ForeColor = System.Drawing.Color.Black;
            this.cbbKyThi.FormattingEnabled = true;
            this.cbbKyThi.ItemHeight = 16;
            this.cbbKyThi.Location = new System.Drawing.Point(279, 19);
            this.cbbKyThi.Name = "cbbKyThi";
            this.cbbKyThi.Size = new System.Drawing.Size(105, 22);
            this.cbbKyThi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbKyThi.TabIndex = 44;
            this.cbbKyThi.SelectedIndexChanged += new System.EventHandler(this.cbbKyThi_SelectedIndexChanged);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(239, 13);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(34, 34);
            this.labelX1.TabIndex = 45;
            this.labelX1.Text = "Kỳ Thi";
            // 
            // cbbLoaiKyThi
            // 
            this.cbbLoaiKyThi.DisplayMember = "Text";
            this.cbbLoaiKyThi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLoaiKyThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiKyThi.ForeColor = System.Drawing.Color.Black;
            this.cbbLoaiKyThi.FormattingEnabled = true;
            this.cbbLoaiKyThi.ItemHeight = 16;
            this.cbbLoaiKyThi.Location = new System.Drawing.Point(114, 19);
            this.cbbLoaiKyThi.Name = "cbbLoaiKyThi";
            this.cbbLoaiKyThi.Size = new System.Drawing.Size(105, 22);
            this.cbbLoaiKyThi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbLoaiKyThi.TabIndex = 42;
            this.cbbLoaiKyThi.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiKyThi_SelectedIndexChanged);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(53, 18);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(55, 23);
            this.labelX3.TabIndex = 43;
            this.labelX3.Text = "Loại Kỳ Thi";
            // 
            // fKetQuaThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = new DevComponents.DotNetBar.Metro.BorderColors(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            this.ClientSize = new System.Drawing.Size(625, 474);
            this.Controls.Add(this.lblTenLop);
            this.Controls.Add(this.cbbKyThi);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cbbLoaiKyThi);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.dgvKetQuaThi);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnIn);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fKetQuaThi";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DotNetBar Metro App Form";
            this.Load += new System.EventHandler(this.fKetQuaThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvKetQuaThi;
        private DevComponents.DotNetBar.ButtonX btnIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaHocVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenHocVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKetQuaThi;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonX btnDong;
        private DevComponents.DotNetBar.LabelX lblTenLop;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbKyThi;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbLoaiKyThi;
        private DevComponents.DotNetBar.LabelX labelX3;


    }
}

