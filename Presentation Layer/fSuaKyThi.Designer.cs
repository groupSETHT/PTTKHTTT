namespace Presentation_Layer
{
    partial class fSuaKyThi
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
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtGioThi = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtNgayThi = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cbbPhongThi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbbLop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbbDeThi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtTenKyThi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbbLoaiDeThi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cbbLoaiKyThi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvDSKyThi = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.lblLoaiKyThi = new DevComponents.DotNetBar.LabelX();
            this.btnDong = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGioThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKyThi)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerColorTint = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198))))));
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.dtGioThi);
            this.groupBox1.Controls.Add(this.dtNgayThi);
            this.groupBox1.Controls.Add(this.cbbPhongThi);
            this.groupBox1.Controls.Add(this.cbbLop);
            this.groupBox1.Controls.Add(this.cbbDeThi);
            this.groupBox1.Controls.Add(this.labelX8);
            this.groupBox1.Controls.Add(this.labelX7);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.txtTenKyThi);
            this.groupBox1.Controls.Add(this.cbbLoaiDeThi);
            this.groupBox1.Controls.Add(this.labelX6);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(35, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 151);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Kỳ Thi";
            // 
            // dtGioThi
            // 
            this.dtGioThi.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.dtGioThi.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtGioThi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtGioThi.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtGioThi.ButtonDropDown.Visible = true;
            this.dtGioThi.ForeColor = System.Drawing.Color.Black;
            this.dtGioThi.Format = DevComponents.Editors.eDateTimePickerFormat.ShortTime;
            this.dtGioThi.IsPopupCalendarOpen = false;
            this.dtGioThi.Location = new System.Drawing.Point(350, 55);
            // 
            // 
            // 
            this.dtGioThi.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtGioThi.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtGioThi.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtGioThi.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtGioThi.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtGioThi.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtGioThi.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtGioThi.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtGioThi.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtGioThi.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtGioThi.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtGioThi.MonthCalendar.DisplayMonth = new System.DateTime(2016, 6, 1, 0, 0, 0, 0);
            this.dtGioThi.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtGioThi.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtGioThi.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtGioThi.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtGioThi.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtGioThi.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtGioThi.MonthCalendar.TodayButtonVisible = true;
            this.dtGioThi.MonthCalendar.Visible = false;
            this.dtGioThi.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtGioThi.Name = "dtGioThi";
            this.dtGioThi.Size = new System.Drawing.Size(164, 22);
            this.dtGioThi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtGioThi.TabIndex = 32;
            // 
            // dtNgayThi
            // 
            this.dtNgayThi.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.dtNgayThi.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtNgayThi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayThi.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtNgayThi.ButtonDropDown.Visible = true;
            this.dtNgayThi.ForeColor = System.Drawing.Color.Black;
            this.dtNgayThi.IsPopupCalendarOpen = false;
            this.dtNgayThi.Location = new System.Drawing.Point(350, 27);
            // 
            // 
            // 
            this.dtNgayThi.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtNgayThi.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayThi.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtNgayThi.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtNgayThi.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtNgayThi.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtNgayThi.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtNgayThi.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtNgayThi.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtNgayThi.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtNgayThi.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayThi.MonthCalendar.DisplayMonth = new System.DateTime(2016, 6, 1, 0, 0, 0, 0);
            this.dtNgayThi.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtNgayThi.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtNgayThi.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtNgayThi.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtNgayThi.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtNgayThi.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayThi.MonthCalendar.TodayButtonVisible = true;
            this.dtNgayThi.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtNgayThi.Name = "dtNgayThi";
            this.dtNgayThi.Size = new System.Drawing.Size(164, 22);
            this.dtNgayThi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtNgayThi.TabIndex = 32;
            // 
            // cbbPhongThi
            // 
            this.cbbPhongThi.DisplayMember = "Text";
            this.cbbPhongThi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbPhongThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPhongThi.FormattingEnabled = true;
            this.cbbPhongThi.ItemHeight = 16;
            this.cbbPhongThi.Location = new System.Drawing.Point(350, 82);
            this.cbbPhongThi.Name = "cbbPhongThi";
            this.cbbPhongThi.Size = new System.Drawing.Size(164, 22);
            this.cbbPhongThi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbPhongThi.TabIndex = 29;
            // 
            // cbbLop
            // 
            this.cbbLop.DisplayMember = "Text";
            this.cbbLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.ItemHeight = 16;
            this.cbbLop.Location = new System.Drawing.Point(81, 111);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(164, 22);
            this.cbbLop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbLop.TabIndex = 29;
            // 
            // cbbDeThi
            // 
            this.cbbDeThi.DisplayMember = "Text";
            this.cbbDeThi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbDeThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDeThi.FormattingEnabled = true;
            this.cbbDeThi.ItemHeight = 16;
            this.cbbDeThi.Location = new System.Drawing.Point(81, 83);
            this.cbbDeThi.Name = "cbbDeThi";
            this.cbbDeThi.Size = new System.Drawing.Size(164, 22);
            this.cbbDeThi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbDeThi.TabIndex = 29;
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX8.ForeColor = System.Drawing.Color.Black;
            this.labelX8.Location = new System.Drawing.Point(9, 110);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(54, 23);
            this.labelX8.TabIndex = 28;
            this.labelX8.Text = "Lớp";
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
            this.labelX7.Location = new System.Drawing.Point(278, 83);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(66, 23);
            this.labelX7.TabIndex = 28;
            this.labelX7.Text = "Phòng Thi";
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
            this.labelX5.Location = new System.Drawing.Point(9, 82);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(54, 23);
            this.labelX5.TabIndex = 28;
            this.labelX5.Text = "Đề Thi";
            // 
            // txtTenKyThi
            // 
            // 
            // 
            // 
            this.txtTenKyThi.Border.Class = "TextBoxBorder";
            this.txtTenKyThi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenKyThi.DisabledBackColor = System.Drawing.Color.White;
            this.txtTenKyThi.Location = new System.Drawing.Point(81, 27);
            this.txtTenKyThi.Name = "txtTenKyThi";
            this.txtTenKyThi.PreventEnterBeep = true;
            this.txtTenKyThi.Size = new System.Drawing.Size(164, 22);
            this.txtTenKyThi.TabIndex = 27;
            // 
            // cbbLoaiDeThi
            // 
            this.cbbLoaiDeThi.DisplayMember = "Text";
            this.cbbLoaiDeThi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLoaiDeThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiDeThi.FormattingEnabled = true;
            this.cbbLoaiDeThi.ItemHeight = 16;
            this.cbbLoaiDeThi.Location = new System.Drawing.Point(81, 55);
            this.cbbLoaiDeThi.Name = "cbbLoaiDeThi";
            this.cbbLoaiDeThi.Size = new System.Drawing.Size(164, 22);
            this.cbbLoaiDeThi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbLoaiDeThi.TabIndex = 29;
            this.cbbLoaiDeThi.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiDeThi_SelectedIndexChanged);
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
            this.labelX6.Location = new System.Drawing.Point(278, 56);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(66, 23);
            this.labelX6.TabIndex = 28;
            this.labelX6.Text = "Giờ Thi";
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
            this.labelX2.Location = new System.Drawing.Point(278, 26);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(66, 23);
            this.labelX2.TabIndex = 26;
            this.labelX2.Text = "Ngày Thi";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(9, 54);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(66, 23);
            this.labelX3.TabIndex = 28;
            this.labelX3.Text = "Loại Đề Thi";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(9, 25);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(66, 23);
            this.labelX4.TabIndex = 26;
            this.labelX4.Text = "Tên Kỳ Thi";
            // 
            // cbbLoaiKyThi
            // 
            this.cbbLoaiKyThi.DisplayMember = "Text";
            this.cbbLoaiKyThi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLoaiKyThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiKyThi.FormattingEnabled = true;
            this.cbbLoaiKyThi.ItemHeight = 16;
            this.cbbLoaiKyThi.Location = new System.Drawing.Point(152, 18);
            this.cbbLoaiKyThi.Name = "cbbLoaiKyThi";
            this.cbbLoaiKyThi.Size = new System.Drawing.Size(178, 22);
            this.cbbLoaiKyThi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbLoaiKyThi.TabIndex = 32;
            this.cbbLoaiKyThi.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiKyThi_SelectedIndexChanged);
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
            this.labelX1.Location = new System.Drawing.Point(80, 17);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(66, 23);
            this.labelX1.TabIndex = 31;
            this.labelX1.Text = "Loại Kỳ Thi";
            // 
            // dgvDSKyThi
            // 
            this.dgvDSKyThi.AllowUserToAddRows = false;
            this.dgvDSKyThi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSKyThi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDSKyThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSKyThi.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDSKyThi.EnableHeadersVisualStyles = false;
            this.dgvDSKyThi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(252)))));
            this.dgvDSKyThi.Location = new System.Drawing.Point(35, 75);
            this.dgvDSKyThi.Name = "dgvDSKyThi";
            this.dgvDSKyThi.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSKyThi.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDSKyThi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSKyThi.Size = new System.Drawing.Size(540, 227);
            this.dgvDSKyThi.TabIndex = 33;
            this.dgvDSKyThi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSKyThi_CellClick);
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX9.ForeColor = System.Drawing.Color.Black;
            this.labelX9.Location = new System.Drawing.Point(116, 46);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(158, 23);
            this.labelX9.TabIndex = 34;
            this.labelX9.Text = "Danh Sách Kỳ Thi";
            // 
            // lblLoaiKyThi
            // 
            this.lblLoaiKyThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblLoaiKyThi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblLoaiKyThi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoaiKyThi.ForeColor = System.Drawing.Color.Black;
            this.lblLoaiKyThi.Location = new System.Drawing.Point(280, 46);
            this.lblLoaiKyThi.Name = "lblLoaiKyThi";
            this.lblLoaiKyThi.Size = new System.Drawing.Size(195, 23);
            this.lblLoaiKyThi.TabIndex = 35;
            this.lblLoaiKyThi.Text = "lbLoaiKyThi";
            this.lblLoaiKyThi.Visible = false;
            // 
            // btnDong
            // 
            this.btnDong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDong.BackColor = System.Drawing.Color.DarkRed;
            this.btnDong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDong.Location = new System.Drawing.Point(413, 478);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(102, 40);
            this.btnDong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDong.TabIndex = 39;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.BackColor = System.Drawing.Color.DarkRed;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(249, 478);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 40);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 40;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnSua.Location = new System.Drawing.Point(80, 478);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 40);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 41;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // fSuaKyThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = new DevComponents.DotNetBar.Metro.BorderColors(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            this.ClientSize = new System.Drawing.Size(625, 522);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.lblLoaiKyThi);
            this.Controls.Add(this.dgvDSKyThi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbLoaiKyThi);
            this.Controls.Add(this.labelX1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fSuaKyThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DotNetBar Metro App Form";
            this.Load += new System.EventHandler(this.fSuaKyThi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGioThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKyThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtGioThi;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtNgayThi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbPhongThi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbLop;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbDeThi;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenKyThi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbLoaiDeThi;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbLoaiKyThi;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDSKyThi;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX lblLoaiKyThi;
        private DevComponents.DotNetBar.ButtonX btnDong;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnSua;

    }
}

