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
    public partial class fThemHocVienChinhThuc : DevComponents.DotNetBar.Metro.MetroAppForm
    {


        HocVienBUS _objhocvienbus = new HocVienBUS();
        HocVien _objhocvien;
        DataTable _dthocvien;
        ThongTinDangKyBUS _objthongtindangkybus = new ThongTinDangKyBUS();
        ThongTinDangKy _objthongtindangky;
        KhoaHocBUS _objkhoahocbus = new KhoaHocBUS();
        DataTable _dtkhoahoc;
        ChuongTrinhHocBUS _objchuongtrinhhocbus = new ChuongTrinhHocBUS();
        DataTable _dtchuongtrinhhoc;
        LopBUS _objlopbus = new LopBUS();
        DataTable _dtlop;

        public fThemHocVienChinhThuc()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                //Load DS hoc vien tim nang
                _dthocvien = _objhocvienbus.GetAllHocVienTiemNang_ChiTiet();
                dtgDSHVTiemNang.DataSource = _dthocvien;
                dtgDSHVTiemNang.RowHeadersVisible = true;
                dtgDSHVTiemNang.Columns["STT"].DisplayIndex = 0;
                dtgDSHVTiemNang.Columns["STT"].Width = 40;
                dtgDSHVTiemNang.Columns["MaHV"].HeaderText = "Mã Học Viên";
                dtgDSHVTiemNang.Columns["MaHV"].Width = 70;
                dtgDSHVTiemNang.Columns["HoTen"].HeaderText = "Tên Học Viên";
                dtgDSHVTiemNang.Columns["HoTen"].Width = 150;
                dtgDSHVTiemNang.Columns["SDT"].HeaderText = "SĐT";
                dtgDSHVTiemNang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dtgDSHVTiemNang.Columns["Phai"].HeaderText = "Giới tính";
                dtgDSHVTiemNang.Columns["NoHP"].Visible = false;
                dtgDSHVTiemNang.Columns["MaLop"].Visible = false;
                dtgDSHVTiemNang.Columns["NgayDangKy"].Visible = false;
                dtgDSHVTiemNang.Columns["TrangThai"].Visible = false;
                dtgDSHVTiemNang.Columns["SoLuongCuocHen"].Visible = false;
                dtgDSHVTiemNang.Columns["DanhSachNgay"].HeaderText = "Ngày Rảnh";
                dtgDSHVTiemNang.Columns["TenCa"].HeaderText = "Ca Rảnh";
                dtgDSHVTiemNang.Columns["MaTrinhDoHienTai"].HeaderText = "Trình Độ Hiện Tại";
                dtgDSHVTiemNang.Columns["MaTrinhDoMuonHoc"].HeaderText = "Trình Độ Muốn Học";
                dtgDSHVTiemNang.Columns["MaTrinhDoDuocHoc"].HeaderText = "Trình Độ Được Học";
                dtgDSHVTiemNang.Columns["MaKiThiXepLop"].Visible = false;
                dtgDSHVTiemNang.ClearSelection();
                //Load ccbKhoaHoc
                _dtkhoahoc = _objkhoahocbus.GetMaTenKhoaHoc();
                cbbKhoaHoc.DataSource = _dtkhoahoc;
                cbbKhoaHoc.ValueMember = "MaKhoaHoc";
                cbbKhoaHoc.DisplayMember = "TenKhoaHoc";
                cbbKhoaHoc.Text = "";
                //Load ccbChonLop
                _dtlop = _objlopbus.GetAll_CT();
                cbbChonLop.DataSource = _dtlop;
                cbbChonLop.ValueMember = "MaLop";
                cbbChonLop.DisplayMember = "TenLop";
                cbbChonLop.SelectedIndex = -1;
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
        public void LoadDSHVTheoLop(string malop)
        {
            //Load DS hoc vien theo lop
            _dthocvien = _objhocvienbus.GetAllHocVienTheoMaLop(malop);
            //_dthocvien = _objhocvienbus.GetAllHocVien_ChiTiet();
            dtgDSHVTheoLop.DataSource = _dthocvien;
            dtgDSHVTheoLop.RowHeadersVisible = true;
            dtgDSHVTheoLop.Columns["STT"].DisplayIndex = 0;
            dtgDSHVTheoLop.Columns["STT"].Width = 40;
            dtgDSHVTheoLop.Columns["MaHV"].HeaderText = "Mã Học Viên";
            dtgDSHVTheoLop.Columns["MaHV"].Width = 70;
            dtgDSHVTheoLop.Columns["HoTen"].HeaderText = "Tên Học Viên";
            dtgDSHVTheoLop.Columns["HoTen"].Width = 150;
            dtgDSHVTheoLop.Columns["SDT"].HeaderText = "SĐT";
            dtgDSHVTheoLop.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dtgDSHVTheoLop.Columns["Phai"].HeaderText = "Giới tính";
            dtgDSHVTheoLop.Columns["NoHP"].Visible = false;
            dtgDSHVTheoLop.Columns["MaLop"].Visible = false;
            dtgDSHVTheoLop.Columns["NgayDangKy"].Visible = false;
            dtgDSHVTheoLop.Columns["TrangThai"].Visible = false;
            dtgDSHVTheoLop.Columns["SoLuongCuocHen"].Visible = false;
            dtgDSHVTheoLop.Columns["DanhSachNgay"].HeaderText = "Ngày Rảnh";
            dtgDSHVTheoLop.Columns["TenCa"].HeaderText = "Ca Rảnh";
            dtgDSHVTheoLop.Columns["MaTrinhDoHienTai"].HeaderText = "Trình Độ Hiện Tại";
            dtgDSHVTheoLop.Columns["MaTrinhDoMuonHoc"].HeaderText = "Trình Độ Muốn Học";
            dtgDSHVTheoLop.Columns["MaTrinhDoDuocHoc"].HeaderText = "Trình Độ Được Học";
            dtgDSHVTheoLop.Columns["MaKiThiXepLop"].Visible = false;
            dtgDSHVTheoLop.ClearSelection();

        }
        public void resettextbox()
        {
            txtTenHocVien.Text = "";
            cbbChuongTrinhHoc.Text = "";
            cbbKhoaHoc.Text = "";
            cbbLopHoc.Text = "";
            lblHocPhi.Text = "";
        }
        private void fThemHocVienChinhThuc_Load(object sender, EventArgs e)
        {
            LoadData();
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
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            fThemHocVienChinhThuc_Load(sender, e);
        }
        private void btTim_Click(object sender, EventArgs e)
        {
            DataTable _dttimhocvien = _objhocvienbus.FindTenHV_TiemNang(txtTimTenHocVien.Text);
            dtgDSHVTiemNang.DataSource = _dttimhocvien;
            dtgDSHVTiemNang.RowHeadersVisible = false;

            //Load DS hoc vien tim nang
            dtgDSHVTiemNang.Columns["STT"].DisplayIndex = 0;
            dtgDSHVTiemNang.Columns["MaHV"].HeaderText = "Mã Học Viên";
            dtgDSHVTiemNang.Columns["HoTen"].HeaderText = "Tên Học Viên";
            dtgDSHVTiemNang.Columns["SDT"].HeaderText = "SĐT";
            dtgDSHVTiemNang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dtgDSHVTiemNang.Columns["Phai"].HeaderText = "Giới tính";
            dtgDSHVTiemNang.Columns["NoHP"].Visible = false;
            dtgDSHVTiemNang.Columns["MaLop"].Visible = false;
            dtgDSHVTiemNang.Columns["NgayDangKy"].Visible = false;
            dtgDSHVTiemNang.Columns["TrangThai"].Visible = false;
            dtgDSHVTiemNang.Columns["SoLuongCuocHen"].Visible = false;
            dtgDSHVTiemNang.Columns["DanhSachNgay"].HeaderText = "Ngày Rảnh";
            dtgDSHVTiemNang.Columns["TenCa"].HeaderText = "Ca Rảnh";
            dtgDSHVTiemNang.Columns["MaTrinhDoHienTai"].HeaderText = "Trình Độ Hiện Tại";
            dtgDSHVTiemNang.Columns["MaTrinhDoMuonHoc"].HeaderText = "Trình Độ Muốn Học";
            dtgDSHVTiemNang.Columns["MaTrinhDoDuocHoc"].HeaderText = "Trình Độ Được Học";
            dtgDSHVTiemNang.Columns["MaKiThiXepLop"].Visible = false;
            dtgDSHVTiemNang.ClearSelection();
        }
        private void dtgDSHVTiemNang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgDSHVTiemNang.Rows[e.RowIndex];
                txtTenHocVien.Text = row.Cells[1].Value.ToString();
                dtNgayDK.Text = row.Cells[7].Value.ToString();
            }
            catch (Exception)
            {

            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtTenHocVien.Text == "") || (cbbKhoaHoc.Text == "") || (cbbChuongTrinhHoc.Text == "") || (cbbLopHoc.Text == ""))
                {
                    MessageBox.Show("Bạn còn số liệu chưa nhập ");
                    return;
                }
                for (int i = 0; i < dtgDSHVDangKy.Rows.Count; i++)
                {
                    if (dtgDSHVTiemNang.CurrentRow.Cells[0].Value.ToString() == dtgDSHVDangKy.Rows[i].Cells[1].Value.ToString())
                    {
                        MessageBox.Show("Học viên đã được thêm vào danh sách đăng ký.");
                        return;
                    }
                }

                dtgDSHVDangKy.Rows.Add(
                    dtgDSHVDangKy.Rows.Count + 1,
                    dtgDSHVTiemNang.CurrentRow.Cells[0].Value.ToString(),
                    txtTenHocVien.Text,
                    cbbKhoaHoc.Text,
                    cbbChuongTrinhHoc.Text,
                    cbbLopHoc.Text,
                    lblHocPhi.Text,
                    dtgDSHVTiemNang.CurrentRow.Cells[2].Value.ToString(),//Gioi tinh
                    dtgDSHVTiemNang.CurrentRow.Cells[3].Value.ToString(),//SĐT
                    dtgDSHVTiemNang.CurrentRow.Cells[4].Value.ToString(),//Địa chỉ
                     dtgDSHVTiemNang.CurrentRow.Cells[7].Value.ToString());//Ngày đăng ký
                dtgDSHVDangKy.ClearSelection();
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai thông tin, vui lòng nhập lại  !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtTenHocVien.Text == "") || (cbbKhoaHoc.Text == "") || (cbbChuongTrinhHoc.Text == "") || (cbbLopHoc.Text == ""))
                {
                    MessageBox.Show("Bạn còn số liệu chưa nhập ");
                    return;
                }
                dtgDSHVDangKy.CurrentRow.Cells[3].Value = cbbKhoaHoc.Text;
                dtgDSHVDangKy.CurrentRow.Cells[4].Value = cbbChuongTrinhHoc.Text;
                dtgDSHVDangKy.CurrentRow.Cells[5].Value = cbbLopHoc.Text;
                dtgDSHVDangKy.CurrentRow.Cells[6].Value = lblHocPhi.Text;
                resettextbox();
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai thông tin, vui lòng nhập lại  !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int icountSelectedRow = dtgDSHVDangKy.SelectedRows.Count;
            if (icountSelectedRow > 0)
            {
                foreach (DataGridViewRow row in dtgDSHVDangKy.SelectedRows)
                    if (!row.IsNewRow) dtgDSHVDangKy.Rows.Remove(row);
            }
            else
            {
                MessageBox.Show("Bạn phải chọn một dòng để xóa");
                return;
            }
        }
        private void dtgDSHocVienDK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgDSHVDangKy.Rows[e.RowIndex];
                txtTenHocVien.Text = row.Cells[2].Value.ToString();
                cbbKhoaHoc.Text = row.Cells[3].Value.ToString();
                cbbChuongTrinhHoc.Text = row.Cells[4].Value.ToString();
                cbbLopHoc.Text = row.Cells[5].Value.ToString();
                lblHocPhi.Text = row.Cells[6].Value.ToString();
            }
            catch (Exception)
            {

            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dtgDSHVDangKy.Rows.Count > 0)
            {
                for (int i = 0; i < dtgDSHVDangKy.Rows.Count; i++)
                {
                    if (_objthongtindangkybus.Edit_TrangThai_ThongTinDangKy(dtgDSHVDangKy.Rows[i].Cells[1].Value.ToString(), "Đang học") &&
                        _objhocvienbus.Edit_MaLop_HocVien(dtgDSHVDangKy.Rows[i].Cells[1].Value.ToString(), _objlopbus.GetMa_TheoTen_LopHoc(dtgDSHVDangKy.Rows[i].Cells[5].Value.ToString())))
                    {
                        dtgDSHVDangKy.Rows.Remove(dtgDSHVDangKy.Rows[i]);
                        i--;
                        LoadData();
                    }
                    else
                    {
                        string a = dtgDSHVDangKy.Rows[i].Cells[0].Value.ToString();
                        MessageBox.Show("Lưu dòng " + a + " thất bại");
                    }

                }
                if (dtgDSHVDangKy.Rows.Count == 0)
                {
                    MessageBox.Show("Lưu thành công");
                    resettextbox();
                }

            }
            else
            {
                MessageBox.Show("Không có dữ liệu để lưu ! ", "Thống báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cbbChonLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDSHVTheoLop(_objlopbus.GetMa_TheoTen_LopHoc(cbbChonLop.Text));
            lblLop.Text = cbbChonLop.Text;
        }

    }
}