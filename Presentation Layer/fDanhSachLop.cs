using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
namespace Presentation_Layer
{
    public partial class fDanhSachLop : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        HocVienBUS _objhocvienbus = new HocVienBUS();
        DataTable _dthocvien;
        ThongTinDangKyBUS _objthongtindangkybus = new ThongTinDangKyBUS();
        KhoaHocBUS _objkhoahocbus = new KhoaHocBUS();
        ChuongTrinhHocBUS _objchuongtrinhhocbus = new ChuongTrinhHocBUS();
        LopBUS _objlopbus = new LopBUS();
        DataTable _dtlop;
       
        public fDanhSachLop()
        {
            InitializeComponent();
        }
      
        public void LoadData()
        {
            _dtlop = _objlopbus.GetAll_CT();
            cbbChonLop.DataSource = _dtlop;
            cbbChonLop.ValueMember = "MaLop";
            cbbChonLop.DisplayMember = "TenLop";
            cbbChonLop.SelectedIndex = -1;

           _dthocvien = _objhocvienbus.GetAllHocVienChinhThuc_ChiTiet();
            dtgDSHVTheoLop.DataSource = _dthocvien;
            dtgDSHVTheoLop.RowHeadersVisible = false;

            //Load DS hoc vien chinh thuc
            dtgDSHVTheoLop.RowHeadersVisible = true;
            dtgDSHVTheoLop.Columns["STT"].DisplayIndex = 0;
            dtgDSHVTheoLop.Columns["STT"].Width = 40;
            dtgDSHVTheoLop.Columns["MaHV"].HeaderText = "Mã Học Viên";
            dtgDSHVTheoLop.Columns["MaHV"].Width = 70;
            dtgDSHVTheoLop.Columns["HoTen"].HeaderText = "Tên Học Viên";
            dtgDSHVTheoLop.Columns["HoTen"].Width = 150;
            dtgDSHVTheoLop.Columns["SDT"].HeaderText = "SĐT";
            dtgDSHVTheoLop.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dtgDSHVTheoLop.Columns["Phai"].Visible = false;
            dtgDSHVTheoLop.Columns["NoHP"].HeaderText = "Nợ học phí";
            dtgDSHVTheoLop.Columns["TenLop"].HeaderText = "Lớp";
            dtgDSHVTheoLop.Columns["TenChuongTrinhHoc"].HeaderText = "Chương trình học";
            dtgDSHVTheoLop.Columns["TenKhoaHoc"].HeaderText = "Khóa học";
            dtgDSHVTheoLop.ClearSelection();
         
        }
        private void fDanhSachLop_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            DataTable _dttimhocvien;
            if(cbbChonLop.Text=="")
            {
                _dttimhocvien = _objhocvienbus.FindTenHV_ChinhThuc(txtTimTenHocVien.Text);
                dtgDSHVTheoLop.DataSource = _dttimhocvien;
            }else
            {
                _dttimhocvien = _objhocvienbus.FindTenHV_ChinhThuc_TheoMaLop_TenHV(_objlopbus.GetMa_TheoTen_LopHoc(cbbChonLop.Text), txtTimTenHocVien.Text);
                dtgDSHVTheoLop.DataSource = _dttimhocvien;
            }
           
            dtgDSHVTheoLop.RowHeadersVisible = false;
            //Load DS hoc vien chinh thuc
            dtgDSHVTheoLop.RowHeadersVisible = true;
            dtgDSHVTheoLop.Columns["STT"].DisplayIndex = 0;
            dtgDSHVTheoLop.Columns["STT"].Width = 40;
            dtgDSHVTheoLop.Columns["MaHV"].HeaderText = "Mã Học Viên";
            dtgDSHVTheoLop.Columns["MaHV"].Width = 70;
            dtgDSHVTheoLop.Columns["HoTen"].HeaderText = "Tên Học Viên";
            dtgDSHVTheoLop.Columns["HoTen"].Width = 150;
            dtgDSHVTheoLop.Columns["SDT"].HeaderText = "SĐT";
            dtgDSHVTheoLop.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dtgDSHVTheoLop.Columns["Phai"].Visible = false;
            dtgDSHVTheoLop.Columns["NoHP"].HeaderText = "Nợ học phí";
            dtgDSHVTheoLop.Columns["TenLop"].HeaderText = "Lớp";
            dtgDSHVTheoLop.Columns["TenChuongTrinhHoc"].HeaderText = "Chương trình học";
            dtgDSHVTheoLop.Columns["TenKhoaHoc"].HeaderText = "Khóa học";
            dtgDSHVTheoLop.ClearSelection();
        }

        private void cbbChonLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblLop.Text = cbbChonLop.Text;
            DataTable _dttimhocvien = _objhocvienbus.FindTenHV_ChinhThuc_TheoMaLop_TenHV(_objlopbus.GetMa_TheoTen_LopHoc(cbbChonLop.Text),"");
            dtgDSHVTheoLop.DataSource = _dttimhocvien;
            dtgDSHVTheoLop.RowHeadersVisible = false;

            //Load DS hoc vien chinh thuc
            dtgDSHVTheoLop.RowHeadersVisible = true;
            dtgDSHVTheoLop.Columns["STT"].DisplayIndex = 0;
            dtgDSHVTheoLop.Columns["STT"].Width = 40;
            dtgDSHVTheoLop.Columns["MaHV"].HeaderText = "Mã Học Viên";
            dtgDSHVTheoLop.Columns["MaHV"].Width = 70;
            dtgDSHVTheoLop.Columns["HoTen"].HeaderText = "Tên Học Viên";
            dtgDSHVTheoLop.Columns["HoTen"].Width = 150;
            dtgDSHVTheoLop.Columns["SDT"].HeaderText = "SĐT";
            dtgDSHVTheoLop.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dtgDSHVTheoLop.Columns["Phai"].Visible = false;
            dtgDSHVTheoLop.Columns["NoHP"].HeaderText = "Nợ học phí";
            dtgDSHVTheoLop.Columns["TenLop"].HeaderText = "Lớp";
            dtgDSHVTheoLop.Columns["TenChuongTrinhHoc"].HeaderText = "Chương trình học";
            dtgDSHVTheoLop.Columns["TenKhoaHoc"].HeaderText = "Khóa học";
            dtgDSHVTheoLop.ClearSelection();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            fDanhSachLop_Load(sender, e);
            txtTimTenHocVien.Text = "";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

    }
}