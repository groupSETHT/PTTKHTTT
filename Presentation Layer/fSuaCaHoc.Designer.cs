namespace Presentation_Layer
{
    partial class fSuaCaHoc
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
            this.dtgSuaCaHoc = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.btnDong = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.txtTenCa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.dtpGioKetThuc = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtpGioBatDau = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSuaCaHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpGioKetThuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpGioBatDau)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgSuaCaHoc
            // 
            this.dtgSuaCaHoc.AllowUserToAddRows = false;
            this.dtgSuaCaHoc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgSuaCaHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgSuaCaHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgSuaCaHoc.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgSuaCaHoc.EnableHeadersVisualStyles = false;
            this.dtgSuaCaHoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(252)))));
            this.dtgSuaCaHoc.Location = new System.Drawing.Point(53, 28);
            this.dtgSuaCaHoc.Name = "dtgSuaCaHoc";
            this.dtgSuaCaHoc.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgSuaCaHoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgSuaCaHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSuaCaHoc.Size = new System.Drawing.Size(420, 229);
            this.dtgSuaCaHoc.TabIndex = 31;
            this.dtgSuaCaHoc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgSuaCaHoc_CellMouseClick);
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
            this.labelX8.Location = new System.Drawing.Point(158, 6);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(250, 23);
            this.labelX8.TabIndex = 39;
            this.labelX8.Text = "Danh Sách Các Lịch Học ";
            // 
            // btnDong
            // 
            this.btnDong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDong.BackColor = System.Drawing.Color.DarkRed;
            this.btnDong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDong.Location = new System.Drawing.Point(371, 368);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(102, 47);
            this.btnDong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDong.TabIndex = 36;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.BackColor = System.Drawing.Color.DarkRed;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(211, 368);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 47);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnSua.Location = new System.Drawing.Point(53, 368);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 47);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 38;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtTenCa
            // 
            // 
            // 
            // 
            this.txtTenCa.Border.Class = "TextBoxBorder";
            this.txtTenCa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenCa.DisabledBackColor = System.Drawing.Color.White;
            this.txtTenCa.Location = new System.Drawing.Point(237, 263);
            this.txtTenCa.Name = "txtTenCa";
            this.txtTenCa.PreventEnterBeep = true;
            this.txtTenCa.Size = new System.Drawing.Size(164, 22);
            this.txtTenCa.TabIndex = 41;
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
            this.labelX5.Location = new System.Drawing.Point(137, 263);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(94, 23);
            this.labelX5.TabIndex = 40;
            this.labelX5.Text = "Tên Ca";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerColorTint = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198))))));
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
            this.dtpGioKetThuc.Location = new System.Drawing.Point(237, 332);
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
            this.dtpGioKetThuc.TabIndex = 45;
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
            this.dtpGioBatDau.Location = new System.Drawing.Point(237, 297);
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
            this.dtpGioBatDau.TabIndex = 44;
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
            this.labelX2.Location = new System.Drawing.Point(137, 332);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(94, 23);
            this.labelX2.TabIndex = 43;
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
            this.labelX1.Location = new System.Drawing.Point(137, 296);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(94, 23);
            this.labelX1.TabIndex = 42;
            this.labelX1.Text = "Giờ Bắt Đầu ";
            // 
            // fSuaCaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = new DevComponents.DotNetBar.Metro.BorderColors(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            this.ClientSize = new System.Drawing.Size(536, 437);
            this.Controls.Add(this.dtpGioKetThuc);
            this.Controls.Add(this.dtpGioBatDau);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtTenCa);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.dtgSuaCaHoc);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fSuaCaHoc";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DotNetBar Metro App Form";
            this.Load += new System.EventHandler(this.fSuaCaHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSuaCaHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpGioKetThuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpGioBatDau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtgSuaCaHoc;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.ButtonX btnDong;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenCa;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpGioKetThuc;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpGioBatDau;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;


    }
}

