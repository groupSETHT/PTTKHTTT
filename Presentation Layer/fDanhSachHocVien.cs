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
    public partial class fDanhSachHocVien : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        HocVienBUS _objhocvienbus = new HocVienBUS();
        DataTable _dthocvien;
        public fDanhSachHocVien()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                dtgDSHV.DataSource = null; 
                //Load DS hoc vien tim nang
                _dthocvien = _objhocvienbus.GetAllHocVien_ChiTiet();
                dtgDSHV.DataSource = _dthocvien;
                dtgDSHV.RowHeadersVisible = true;
                dtgDSHV.Columns["STT"].DisplayIndex = 0;
                dtgDSHV.Columns["STT"].Width = 40;
                dtgDSHV.Columns["MaHV"].HeaderText = "Mã Học Viên";
                dtgDSHV.Columns["MaHV"].Width = 70;
                dtgDSHV.Columns["HoTen"].HeaderText = "Tên Học Viên";
                dtgDSHV.Columns["HoTen"].Width = 150;
                dtgDSHV.Columns["SDT"].HeaderText = "SĐT";
                dtgDSHV.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dtgDSHV.Columns["Phai"].HeaderText = "Giới tính";
                dtgDSHV.Columns["NoHP"].Visible = false;
                dtgDSHV.Columns["MaLop"].Visible = false;
                dtgDSHV.Columns["NgayDangKy"].Visible = false;
                dtgDSHV.Columns["TrangThai"].Visible = false;
                dtgDSHV.Columns["SoLuongCuocHen"].Visible = false;
                dtgDSHV.Columns["DanhSachNgay"].HeaderText = "Ngày Rảnh";
                dtgDSHV.Columns["TenCa"].HeaderText = "Ca Rảnh";
                dtgDSHV.Columns["MaTrinhDoHienTai"].HeaderText = "Trình Độ Hiện Tại";
                dtgDSHV.Columns["MaTrinhDoMuonHoc"].HeaderText = "Trình Độ Muốn Học";
                dtgDSHV.Columns["MaTrinhDoDuocHoc"].HeaderText = "Trình Độ Được Học";
                dtgDSHV.Columns["MaKiThiXepLop"].Visible = false;
                dtgDSHV.ClearSelection();
            }
            catch
            {
                MessageBox.Show("Load dữ liệu gặp sự cố.Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadData_HVChinhThuc()
        {
            try
            {
                dtgDSHV.DataSource = null; 
                //Load DS hoc vien chinh thuc
                _dthocvien = _objhocvienbus.GetAllHocVienChinhThuc_ChiTiet();
                dtgDSHV.DataSource = _dthocvien;
                dtgDSHV.RowHeadersVisible = true;
                dtgDSHV.Columns["STT"].DisplayIndex = 0;
                dtgDSHV.Columns["STT"].Width = 40;
                dtgDSHV.Columns["MaHV"].HeaderText = "Mã Học Viên";
                dtgDSHV.Columns["MaHV"].Width = 70;
                dtgDSHV.Columns["HoTen"].HeaderText = "Tên Học Viên";
                dtgDSHV.Columns["HoTen"].Width = 150;
                dtgDSHV.Columns["SDT"].HeaderText = "SĐT";
                dtgDSHV.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dtgDSHV.Columns["Phai"].HeaderText = "Giới tính";
                dtgDSHV.Columns["NoHP"].HeaderText = "Nợ học phí";
                dtgDSHV.Columns["TenLop"].HeaderText = "Lớp";
                dtgDSHV.Columns["TenChuongTrinhHoc"].HeaderText = "Chương trình học";
                dtgDSHV.Columns["TenKhoaHoc"].HeaderText = "Khóa học";
                dtgDSHV.ClearSelection();

            }
            catch
            {
                MessageBox.Show("Load dữ liệu gặp sự cố.Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadData_HVTiemNang()
        {
            try
            {
                dtgDSHV.DataSource = null; 
                //Load DS hoc vien tim nang
                _dthocvien = _objhocvienbus.GetAllHocVienTiemNang_ChiTiet();
                dtgDSHV.DataSource = _dthocvien;
                dtgDSHV.RowHeadersVisible = true;
                dtgDSHV.Columns["STT"].DisplayIndex = 0;
                dtgDSHV.Columns["STT"].Width = 40;
                dtgDSHV.Columns["MaHV"].HeaderText = "Mã Học Viên";
                dtgDSHV.Columns["MaHV"].Width = 70;
                dtgDSHV.Columns["HoTen"].HeaderText = "Tên Học Viên";
                dtgDSHV.Columns["HoTen"].Width = 150;
                dtgDSHV.Columns["SDT"].HeaderText = "SĐT";
                dtgDSHV.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dtgDSHV.Columns["Phai"].HeaderText = "Giới tính";
                dtgDSHV.Columns["NoHP"].Visible = false;
                dtgDSHV.Columns["MaLop"].Visible = false;
                dtgDSHV.Columns["NgayDangKy"].Visible = false;
                dtgDSHV.Columns["TrangThai"].Visible = false;
                dtgDSHV.Columns["SoLuongCuocHen"].Visible = false;
                dtgDSHV.Columns["DanhSachNgay"].HeaderText = "Ngày Rảnh";
                dtgDSHV.Columns["TenCa"].HeaderText = "Ca Rảnh";
                dtgDSHV.Columns["MaTrinhDoHienTai"].HeaderText = "Trình Độ Hiện Tại";
                dtgDSHV.Columns["MaTrinhDoMuonHoc"].HeaderText = "Trình Độ Muốn Học";
                dtgDSHV.Columns["MaTrinhDoDuocHoc"].HeaderText = "Trình Độ Được Học";
                dtgDSHV.Columns["MaKiThiXepLop"].Visible = false;
                dtgDSHV.ClearSelection();
            }
            catch
            {
                MessageBox.Show("Load dữ liệu gặp sự cố.Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void fDanhSachHocVien_Load(object sender, EventArgs e)
        {
            LoadData();
            rdbtnAllHV.Checked = true;
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            if(rdbtnAllHV.Checked)
            {
                DataTable _dttimhocvien = _objhocvienbus.FindTenHV(txtTimTenHocVien.Text);
                dtgDSHV.DataSource = _dttimhocvien;
                dtgDSHV.RowHeadersVisible = false;

                //Load DS hoc vien 
                dtgDSHV.Columns["STT"].DisplayIndex = 0;
                dtgDSHV.Columns["MaHV"].HeaderText = "Mã Học Viên";
                dtgDSHV.Columns["HoTen"].HeaderText = "Tên Học Viên";
                dtgDSHV.Columns["SDT"].HeaderText = "SĐT";
                dtgDSHV.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dtgDSHV.Columns["Phai"].HeaderText = "Giới tính";
                dtgDSHV.Columns["NoHP"].Visible = false;
                dtgDSHV.Columns["MaLop"].Visible = false;
                dtgDSHV.Columns["NgayDangKy"].Visible = false;
                dtgDSHV.Columns["TrangThai"].Visible = false;
                dtgDSHV.Columns["SoLuongCuocHen"].Visible = false;
                dtgDSHV.Columns["DanhSachNgay"].HeaderText = "Ngày Rảnh";
                dtgDSHV.Columns["TenCa"].HeaderText = "Ca Rảnh";
                dtgDSHV.Columns["MaTrinhDoHienTai"].HeaderText = "Trình Độ Hiện Tại";
                dtgDSHV.Columns["MaTrinhDoMuonHoc"].HeaderText = "Trình Độ Muốn Học";
                dtgDSHV.Columns["MaTrinhDoDuocHoc"].HeaderText = "Trình Độ Được Học";
                dtgDSHV.Columns["MaKiThiXepLop"].Visible = false;
                dtgDSHV.ClearSelection();
            }
            if(rdbtnHVChinhThuc.Checked)
            {
                DataTable _dttimhocvien = _objhocvienbus.FindTenHV_ChinhThuc(txtTimTenHocVien.Text);
                dtgDSHV.DataSource = _dttimhocvien;
                dtgDSHV.RowHeadersVisible = false;

                //Load DS hoc vien chinh thuc
                dtgDSHV.RowHeadersVisible = true;
                dtgDSHV.Columns["STT"].DisplayIndex = 0;
                dtgDSHV.Columns["STT"].Width = 40;
                dtgDSHV.Columns["MaHV"].HeaderText = "Mã Học Viên";
                dtgDSHV.Columns["MaHV"].Width = 70;
                dtgDSHV.Columns["HoTen"].HeaderText = "Tên Học Viên";
                dtgDSHV.Columns["HoTen"].Width = 150;
                dtgDSHV.Columns["SDT"].HeaderText = "SĐT";
                dtgDSHV.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dtgDSHV.Columns["Phai"].Visible = false;
                dtgDSHV.Columns["NoHP"].HeaderText = "Nợ học phí";
                dtgDSHV.Columns["TenLop"].HeaderText = "Lớp";
                dtgDSHV.Columns["TenChuongTrinhHoc"].HeaderText = "Chương trình học";
                dtgDSHV.Columns["TenKhoaHoc"].HeaderText = "Khóa học";
                dtgDSHV.ClearSelection();
            }
           if(rdbtnHVTiemNang.Checked)
           {
               DataTable _dttimhocvien = _objhocvienbus.FindTenHV_TiemNang(txtTimTenHocVien.Text);
               dtgDSHV.DataSource = _dttimhocvien;
               dtgDSHV.RowHeadersVisible = false;

               //Load DS hoc vien tim nang
               dtgDSHV.Columns["STT"].DisplayIndex = 0;
               dtgDSHV.Columns["MaHV"].HeaderText = "Mã Học Viên";
               dtgDSHV.Columns["HoTen"].HeaderText = "Tên Học Viên";
               dtgDSHV.Columns["SDT"].HeaderText = "SĐT";
               dtgDSHV.Columns["DiaChi"].HeaderText = "Địa Chỉ";
               dtgDSHV.Columns["Phai"].HeaderText = "Giới tính";
               dtgDSHV.Columns["NoHP"].Visible = false;
               dtgDSHV.Columns["MaLop"].Visible = false;
               dtgDSHV.Columns["NgayDangKy"].Visible = false;
               dtgDSHV.Columns["TrangThai"].Visible = false;
               dtgDSHV.Columns["SoLuongCuocHen"].Visible = false;
               dtgDSHV.Columns["DanhSachNgay"].HeaderText = "Ngày Rảnh";
               dtgDSHV.Columns["TenCa"].HeaderText = "Ca Rảnh";
               dtgDSHV.Columns["MaTrinhDoHienTai"].HeaderText = "Trình Độ Hiện Tại";
               dtgDSHV.Columns["MaTrinhDoMuonHoc"].HeaderText = "Trình Độ Muốn Học";
               dtgDSHV.Columns["MaTrinhDoDuocHoc"].HeaderText = "Trình Độ Được Học";
               dtgDSHV.Columns["MaKiThiXepLop"].Visible = false;
               dtgDSHV.ClearSelection();
           }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            fDanhSachHocVien_Load(sender,e);
            txtTimTenHocVien.Text = "";
        }

        private void rdbtnHVChinhThuc_CheckedChanged(object sender, EventArgs e)
        {
            LoadData_HVChinhThuc();
        }

        private void rdbtnHVTiemNang_CheckedChanged(object sender, EventArgs e)
        {
            LoadData_HVTiemNang();
        }

        private void rdbtnAllHV_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}