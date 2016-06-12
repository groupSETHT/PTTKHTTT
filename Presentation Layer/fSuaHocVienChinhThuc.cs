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
    public partial class fSuaHocVienChinhThuc : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        HocVienBUS _objhocvienbus = new HocVienBUS();
        HocVien _objhocvien;
        DataTable _dthocvien;
        ThongTinDangKyBUS _objthongtindangkybus = new ThongTinDangKyBUS();
        KhoaHocBUS _objkhoahocbus = new KhoaHocBUS();
        DataTable _dtkhoahoc;
        ChuongTrinhHocBUS _objchuongtrinhhocbus = new ChuongTrinhHocBUS();
        DataTable _dtchuongtrinhhoc;
        LopBUS _objlopbus = new LopBUS();
        DataTable _dtlop;
        public fSuaHocVienChinhThuc()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                //Load DS hoc vien chinh thuc
                _dthocvien = _objhocvienbus.GetAllHocVienChinhThuc_ChiTiet();
                dtgDSHVChinhThuc.DataSource = _dthocvien;
                dtgDSHVChinhThuc.RowHeadersVisible = true;
                dtgDSHVChinhThuc.Columns["STT"].DisplayIndex = 0;
                dtgDSHVChinhThuc.Columns["STT"].Width = 40;
                dtgDSHVChinhThuc.Columns["MaHV"].HeaderText = "Mã Học Viên";
                dtgDSHVChinhThuc.Columns["MaHV"].Width = 70;
                dtgDSHVChinhThuc.Columns["HoTen"].HeaderText = "Tên Học Viên";
                dtgDSHVChinhThuc.Columns["HoTen"].Width = 150;
                dtgDSHVChinhThuc.Columns["SDT"].HeaderText = "SĐT";
                dtgDSHVChinhThuc.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dtgDSHVChinhThuc.Columns["Phai"].Visible = false;
                dtgDSHVChinhThuc.Columns["NoHP"].HeaderText = "Nợ học phí";
                dtgDSHVChinhThuc.Columns["TenLop"].HeaderText = "Lớp";
                dtgDSHVChinhThuc.Columns["TenChuongTrinhHoc"].HeaderText = "Chương trình học";
                dtgDSHVChinhThuc.Columns["TenKhoaHoc"].HeaderText = "Khóa học";
                dtgDSHVChinhThuc.ClearSelection();
                //Load ccbKhoaHoc
                _dtkhoahoc = _objkhoahocbus.GetMaTenKhoaHoc();
                cbbKhoaHoc.DataSource = _dtkhoahoc;
                cbbKhoaHoc.ValueMember = "MaKhoaHoc";
                cbbKhoaHoc.DisplayMember = "TenKhoaHoc";
                cbbKhoaHoc.Text = "";

                //Load ccbLopHoc
                _dtlop = _objlopbus.GetAll_CT();
                cbbLopHoc.DataSource = _dtlop;
                cbbLopHoc.ValueMember = "MaLop";
                cbbLopHoc.DisplayMember = "TenLop";
                cbbLopHoc.SelectedIndex = -1;
                //Load cbbChuongTrinhHoc
                cbbChuongTrinhHoc.Text = "";
                //Load cbbLopHoc
                cbbLopHoc.Text = "";
                //Load lblHocPhi
                lblHocPhi.Text = "";

            }
            catch
            {
                MessageBox.Show("Load dữ liệu gặp sự cố.Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void resettextbox()
        {
            txtTenHocVien.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            cbbChuongTrinhHoc.Text = "";
            cbbKhoaHoc.Text = "";
            cbbLopHoc.Text = "";
            lblHocPhi.Text = "";
        }
        private void fSuaHocVienChinhThuc_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();

            }
            catch
            {
                MessageBox.Show("Load dữ liệu gặp sự cố.Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btTim_Click(object sender, EventArgs e)
        {
            DataTable _dttimhocvien = _objhocvienbus.FindTenHV_ChinhThuc(txtTimTenHocVien.Text);
            dtgDSHVChinhThuc.DataSource = _dttimhocvien;
            dtgDSHVChinhThuc.RowHeadersVisible = false;

            //Load DS hoc vien chinh thuc
            dtgDSHVChinhThuc.RowHeadersVisible = true;
            dtgDSHVChinhThuc.Columns["STT"].DisplayIndex = 0;
            dtgDSHVChinhThuc.Columns["STT"].Width = 40;
            dtgDSHVChinhThuc.Columns["MaHV"].HeaderText = "Mã Học Viên";
            dtgDSHVChinhThuc.Columns["MaHV"].Width = 70;
            dtgDSHVChinhThuc.Columns["HoTen"].HeaderText = "Tên Học Viên";
            dtgDSHVChinhThuc.Columns["HoTen"].Width = 150;
            dtgDSHVChinhThuc.Columns["SDT"].HeaderText = "SĐT";
            dtgDSHVChinhThuc.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dtgDSHVChinhThuc.Columns["Phai"].Visible = false;
            dtgDSHVChinhThuc.Columns["NoHP"].HeaderText = "Nợ học phí";
            dtgDSHVChinhThuc.Columns["TenLop"].HeaderText = "Lớp";
            dtgDSHVChinhThuc.Columns["TenChuongTrinhHoc"].HeaderText = "Chương trình học";
            dtgDSHVChinhThuc.Columns["TenKhoaHoc"].HeaderText = "Khóa học";
            dtgDSHVChinhThuc.ClearSelection();
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            fSuaHocVienChinhThuc_Load(sender, e);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtTenHocVien.Text == "") || (txtSDT.Text == "") || (txtDiaChi.Text == ""))
                {
                    MessageBox.Show("Bạn còn số liệu chưa nhập ");
                    return;
                }
                string _maHV = dtgDSHVChinhThuc.CurrentRow.Cells[0].Value.ToString();//cbbMaHocVien.Text;
                //Them hoc vien
                _objhocvien = new HocVien(
                    _maHV,
                    txtTenHocVien.Text,//hoten
                    dtgDSHVChinhThuc.CurrentRow.Cells[2].Value.ToString(),//gioitinh
                    txtDiaChi.Text,//diachi
                    txtSDT.Text,//sdt
                   _objlopbus.GetMa_TheoTen_LopHoc(cbbLopHoc.Text),
                    Double.Parse(lblHocPhi.Text));

                if (_objhocvienbus.EditHocVien(_objhocvien))
                {
                    LoadData();
                    MessageBox.Show("Sửa Thành Công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resettextbox();
                }
                else
                    MessageBox.Show("Sửa Thất Bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai thông tin, vui lòng nhập lại  !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgDSHVChinhThuc.CurrentRow.Cells[0].Value.ToString() != "")
            {
                if (_objhocvienbus.DeleteHocVien(dtgDSHVChinhThuc.CurrentRow.Cells[0].Value.ToString()) && _objthongtindangkybus.DeleteThongTinDangKy(dtgDSHVChinhThuc.CurrentRow.Cells[0].Value.ToString()))
                {
                    MessageBox.Show("Xóa thành công");
                    fSuaHocVienChinhThuc_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa tất cả các nội dung liên quán đến học viên trước khi xóa thông tin học viên ! ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Bạn chưa chon dòng cần xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dtgDSHVChinhThuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgDSHVChinhThuc.Rows[e.RowIndex];
                txtTenHocVien.Text = row.Cells[1].Value.ToString();
                txtSDT.Text = row.Cells[4].Value.ToString();
                txtDiaChi.Text = row.Cells[3].Value.ToString();
                cbbKhoaHoc.Text = row.Cells[8].Value.ToString();
                cbbChuongTrinhHoc.Text = row.Cells[7].Value.ToString();
                cbbLopHoc.Text = row.Cells[5].Value.ToString();
                lblHocPhi.Text = String.Format("{0:0,0}", _objchuongtrinhhocbus.GetHocPhi_TheoMaChuongTrinhHoc(cbbChuongTrinhHoc.SelectedValue.ToString()));
                lblSoTienNo.Text = String.Format("{0:0,0}", double.Parse(row.Cells[6].Value.ToString()));
                if (double.Parse(lblSoTienNo.Text) > 0)
                    btnThanhToan.Visible = true;
                else
                    btnThanhToan.Visible = false;
            }
            catch (Exception)
            {

            }
        }
        private void cbbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dtchuongtrinhhoc = _objchuongtrinhhocbus.GetMaTen_TheoKhoa(cbbKhoaHoc.SelectedValue.ToString());

            if (_dtchuongtrinhhoc.Rows.Count != 0)
            {
                cbbChuongTrinhHoc.DataSource = _dtchuongtrinhhoc;
                cbbChuongTrinhHoc.ValueMember = "MaChuongTrinhHoc";
                cbbChuongTrinhHoc.DisplayMember = "TenChuongTrinhHoc";
            }
            else
            {
                cbbChuongTrinhHoc.DataSource = null;
            }
        }
        private void cbbChuongTrinhHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbChuongTrinhHoc.DataSource == null)
                {
                    MessageBox.Show("Chuong trinh hoc hien tai chua co lop.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbbLopHoc.DataSource = null;
                }
                else
                {
                    _dtlop = _objlopbus.GetMaTen_TheoChuongTrinhHoc(cbbChuongTrinhHoc.SelectedValue.ToString());
                    if (_dtlop.Rows.Count != 0)
                    {
                        cbbLopHoc.DataSource = _dtlop;
                        cbbLopHoc.ValueMember = "MaLop";
                        cbbLopHoc.DisplayMember = "TenLop";
                        lblHocPhi.Text = String.Format("{0:0,0}", _objchuongtrinhhocbus.GetHocPhi_TheoMaChuongTrinhHoc(cbbChuongTrinhHoc.SelectedValue.ToString()));
                    }
                    else
                    {
                        cbbChuongTrinhHoc.DataSource = null;
                    }
                }
            }
            catch
            {

            }
        }


    }
}