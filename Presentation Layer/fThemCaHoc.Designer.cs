namespace Presentation_Layer
{
    partial class fThemCaHoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnCapNhat = new DevComponents.DotNetBar.ButtonX();
            this.btnLuu = new DevComponents.DotNetBar.ButtonX();
            this.dgvDSCaHocDaCo = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dgvDSCaHoc = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.clmSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpGioKetThuc = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtpGioBatDau = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtTenCa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.btnDong = new DevComponents.DotNetBar.ButtonX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCaHocDaCo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCaHoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpGioKetThuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpGioBatDau)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(491, 100);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 37);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCapNhat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCapNhat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhat.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnCapNhat.Location = new System.Drawing.Point(491, 57);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(97, 37);
            this.btnCapNhat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCapNhat.TabIndex = 25;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnLuu.Location = new System.Drawing.Point(244, 413);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(108, 41);
            this.btnLuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuu.TabIndex = 26;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dgvDSCaHocDaCo
            // 
            this.dgvDSCaHocDaCo.AllowUserToAddRows = false;
            this.dgvDSCaHocDaCo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSCaHocDaCo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSCaHocDaCo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSCaHocDaCo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSCaHocDaCo.EnableHeadersVisualStyles = false;
            this.dgvDSCaHocDaCo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(252)))));
            this.dgvDSCaHocDaCo.Location = new System.Drawing.Point(654, 60);
            this.dgvDSCaHocDaCo.Name = "dgvDSCaHocDaCo";
            this.dgvDSCaHocDaCo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSCaHocDaCo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSCaHocDaCo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSCaHocDaCo.Size = new System.Drawing.Size(419, 337);
            this.dgvDSCaHocDaCo.TabIndex = 22;
            // 
            // dgvDSCaHoc
            // 
            this.dgvDSCaHoc.AllowUserToAddRows = false;
            this.dgvDSCaHoc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSCaHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDSCaHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCaHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSTT,
            this.Column1,
            this.clmNgayBatDau,
            this.clmNgayKetThuc});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSCaHoc.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDSCaHoc.EnableHeadersVisualStyles = false;
            this.dgvDSCaHoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(252)))));
            this.dgvDSCaHoc.Location = new System.Drawing.Point(48, 214);
            this.dgvDSCaHoc.Name = "dgvDSCaHoc";
            this.dgvDSCaHoc.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSCaHoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDSCaHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSCaHoc.Size = new System.Drawing.Size(540, 183);
            this.dgvDSCaHoc.TabIndex = 23;
            this.dgvDSCaHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellContentClick);
            this.dgvDSCaHoc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewX1_CellMouseClick);
            // 
            // clmSTT
            // 
            this.clmSTT.HeaderText = "STT";
            this.clmSTT.Name = "clmSTT";
            this.clmSTT.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên Ca Học";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // clmNgayBatDau
            // 
            this.clmNgayBatDau.HeaderText = "Giờ Bắt Đầu";
            this.clmNgayBatDau.Name = "clmNgayBatDau";
            this.clmNgayBatDau.ReadOnly = true;
            this.clmNgayBatDau.Width = 140;
            // 
            // clmNgayKetThuc
            // 
            this.clmNgayKetThuc.HeaderText = "Giờ Kết Thúc";
            this.clmNgayKetThuc.Name = "clmNgayKetThuc";
            this.clmNgayKetThuc.ReadOnly = true;
            this.clmNgayKetThuc.Width = 140;
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(491, 14);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 37);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(723, 24);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(292, 23);
            this.labelX3.TabIndex = 27;
            this.labelX3.Text = "Danh Sách Ca Học Đã Có ";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX8.ForeColor = System.Drawing.Color.Black;
            this.labelX8.Location = new System.Drawing.Point(214, 185);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(209, 23);
            this.labelX8.TabIndex = 28;
            this.labelX8.Text = "Danh Sách Ca Học";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.dtpGioKetThuc);
            this.groupBox1.Controls.Add(this.dtpGioBatDau);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.txtTenCa);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(13, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 155);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Ca Học";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtpGioKetThuc
            // 
            this.dtpGioKetThuc.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.dtpGioKetThuc.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpGioKetThuc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpGioKetThuc.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpGioKetThuc.ButtonDropDown.Visible = true;
            this.dtpGioKetThuc.CustomFormat = "hh:mm";
            this.dtpGioKetThuc.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.TimeSelector;
            this.dtpGioKetThuc.ForeColor = System.Drawing.Color.Black;
            this.dtpGioKetThuc.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtpGioKetThuc.IsPopupCalendarOpen = false;
            this.dtpGioKetThuc.Location = new System.Drawing.Point(231, 106);
            // 
            // 
            // 
            this.dtpGioKetThuc.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpGioKetThuc.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpGioKetThuc.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpGioKetThuc.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpGioKetThuc.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpGioKetThuc.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpGioKetThuc.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpGioKetThuc.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpGioKetThuc.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpGioKetThuc.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpGioKetThuc.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpGioKetThuc.MonthCalendar.DisplayMonth = new System.DateTime(2016, 6, 1, 0, 0, 0, 0);
            this.dtpGioKetThuc.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpGioKetThuc.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpGioKetThuc.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpGioKetThuc.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpGioKetThuc.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpGioKetThuc.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpGioKetThuc.MonthCalendar.TodayButtonVisible = true;
            this.dtpGioKetThuc.MonthCalendar.Visible = false;
            this.dtpGioKetThuc.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpGioKetThuc.Name = "dtpGioKetThuc";
            this.dtpGioKetThuc.Size = new System.Drawing.Size(164, 22);
            this.dtpGioKetThuc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpGioKetThuc.TabIndex = 5;
            this.dtpGioKetThuc.TimeSelectorTimeFormat = DevComponents.Editors.DateTimeAdv.eTimeSelectorFormat.Time24H;
            // 
            // dtpGioBatDau
            // 
            this.dtpGioBatDau.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.dtpGioBatDau.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpGioBatDau.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpGioBatDau.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpGioBatDau.ButtonDropDown.Visible = true;
            this.dtpGioBatDau.CustomFormat = "hh:mm";
            this.dtpGioBatDau.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.TimeSelector;
            this.dtpGioBatDau.ForeColor = System.Drawing.Color.Black;
            this.dtpGioBatDau.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtpGioBatDau.IsPopupCalendarOpen = false;
            this.dtpGioBatDau.Location = new System.Drawing.Point(231, 71);
            // 
            // 
            // 
            this.dtpGioBatDau.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpGioBatDau.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpGioBatDau.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpGioBatDau.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpGioBatDau.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpGioBatDau.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpGioBatDau.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpGioBatDau.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpGioBatDau.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpGioBatDau.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpGioBatDau.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpGioBatDau.MonthCalendar.DisplayMonth = new System.DateTime(2016, 6, 1, 0, 0, 0, 0);
            this.dtpGioBatDau.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpGioBatDau.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpGioBatDau.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpGioBatDau.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpGioBatDau.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpGioBatDau.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpGioBatDau.MonthCalendar.TodayButtonVisible = true;
            this.dtpGioBatDau.MonthCalendar.Visible = false;
            this.dtpGioBatDau.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpGioBatDau.Name = "dtpGioBatDau";
            this.dtpGioBatDau.Size = new System.Drawing.Size(164, 22);
            this.dtpGioBatDau.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpGioBatDau.TabIndex = 5;
            this.dtpGioBatDau.TimeSelectorTimeFormat = DevComponents.Editors.DateTimeAdv.eTimeSelectorFormat.Time24H;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(131, 106);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(94, 23);
            this.labelX2.TabIndex = 32;
            this.labelX2.Text = "Giờ Kết Thúc";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(131, 70);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(94, 23);
            this.labelX1.TabIndex = 30;
            this.labelX1.Text = "Giờ Bắt Đầu ";
            // 
            // txtTenCa
            // 
            this.txtTenCa.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTenCa.Border.Class = "TextBoxBorder";
            this.txtTenCa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenCa.DisabledBackColor = System.Drawing.Color.White;
            this.txtTenCa.ForeColor = System.Drawing.Color.Black;
            this.txtTenCa.Location = new System.Drawing.Point(231, 29);
            this.txtTenCa.Name = "txtTenCa";
            this.txtTenCa.PreventEnterBeep = true;
            this.txtTenCa.Size = new System.Drawing.Size(164, 22);
            this.txtTenCa.TabIndex = 29;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(131, 29);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(94, 23);
            this.labelX5.TabIndex = 28;
            this.labelX5.Text = "Tên Ca ";
            // 
            // btnDong
            // 
            this.btnDong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDong.Location = new System.Drawing.Point(824, 413);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(106, 41);
            this.btnDong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDong.TabIndex = 25;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerColorTint = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198))))));
            // 
            // fThemCaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = new DevComponents.DotNetBar.Metro.BorderColors(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            this.ClientSize = new System.Drawing.Size(1109, 483);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvDSCaHocDaCo);
            this.Controls.Add(this.dgvDSCaHoc);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDong);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fThemCaHoc";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DotNetBar Metro App Form";
            this.Load += new System.EventHandler(this.fThemCaHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCaHocDaCo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCaHoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpGioKetThuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpGioBatDau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnCapNhat;
        private DevComponents.DotNetBar.ButtonX btnLuu;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDSCaHocDaCo;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDSCaHoc;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX8;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnDong;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenCa;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNgayKetThuc;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpGioKetThuc;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpGioBatDau;


    }
}

