using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;
namespace Presentation_Layer
{
    public partial class fSuaHocVienTiemNang : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        HocVienBUS _objHVBUS = new HocVienBUS();
        HocVien _objHV;
        DataTable _dtHocVien;
        ThongTinDangKyBUS _objThongTinDangKyBUS = new ThongTinDangKyBUS();
        ThongTinDangKy _objThongTinDangKy;
        

        TrinhDoBUS _objTrinhDoBUS = new TrinhDoBUS();
        DataTable _dtTrinhDo;
        NgayHocBUS _objNgayHocBUS = new NgayHocBUS();
        DataTable _dtNgayHoc;
        CaHocBUS _objCaHocBUS = new CaHocBUS();
        DataTable _dtCaHoc;

        public fSuaHocVienTiemNang()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                //Load DS hoc vien tim nang
                _dtHocVien = _objHVBUS.GetAllHocVienTiemNang_ChiTiet();
                dgvDSHVTiemNang.DataSource = _dtHocVien;
                dgvDSHVTiemNang.RowHeadersVisible = false;
                dgvDSHVTiemNang.Columns["STT"].DisplayIndex = 0;
                dgvDSHVTiemNang.Columns["STT"].Width = 40;
                dgvDSHVTiemNang.Columns["MaHV"].HeaderText = "Mã Học Viên";
                dgvDSHVTiemNang.Columns["MaHV"].Width = 70;
                dgvDSHVTiemNang.Columns["HoTen"].HeaderText = "Tên Học Viên";
                dgvDSHVTiemNang.Columns["HoTen"].Width = 150;
                dgvDSHVTiemNang.Columns["SDT"].HeaderText = "SĐT";
                dgvDSHVTiemNang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dgvDSHVTiemNang.Columns["Phai"].HeaderText = "Giới tính";
                dgvDSHVTiemNang.Columns["NoHP"].Visible = false;
                dgvDSHVTiemNang.Columns["MaLop"].Visible = false;
                dgvDSHVTiemNang.Columns["NgayDangKy"].Visible = false;
                dgvDSHVTiemNang.Columns["TrangThai"].Visible = false;
                dgvDSHVTiemNang.Columns["SoLuongCuocHen"].Visible = false;
                dgvDSHVTiemNang.Columns["DanhSachNgay"].HeaderText = "Ngày Rảnh";
                dgvDSHVTiemNang.Columns["TenCa"].HeaderText = "Ca Rảnh";
                dgvDSHVTiemNang.Columns["MaTrinhDoHienTai"].HeaderText = "Trình Độ Hiện Tại";
                dgvDSHVTiemNang.Columns["MaTrinhDoMuonHoc"].HeaderText = "Trình Độ Muốn Học";
                dgvDSHVTiemNang.Columns["MaTrinhDoDuocHoc"].HeaderText = "Trình Độ Được Học";
                dgvDSHVTiemNang.Columns["MaKiThiXepLop"].Visible = false;
                dgvDSHVTiemNang.ClearSelection();

                //Load data cbbox Trinh do
                _dtTrinhDo = _objTrinhDoBUS.GetAllTrinhDo();
                cbTrinhDoHienTai.DataSource = _dtTrinhDo;
                cbTrinhDoHienTai.ValueMember = "MaTrinhDo";
                cbTrinhDoHienTai.DisplayMember = "TenTrinhDo";
                cbTrinhDoHienTai.SelectedIndex = -1;

                //Load data cbbox Trinh do muon hoc
                _dtTrinhDo = _objTrinhDoBUS.GetAllTrinhDo();
                cbTrinhDoMuonHoc.DataSource = _dtTrinhDo;
                cbTrinhDoMuonHoc.ValueMember = "MaTrinhDo";
                cbTrinhDoMuonHoc.DisplayMember = "TenTrinhDo";
                cbTrinhDoMuonHoc.SelectedIndex = -1;

                //Load data cbbox Ngay hoc
                _dtNgayHoc = _objNgayHocBUS.GetAllNgayHoc();
                cbNgayRanh.DataSource = _dtNgayHoc;
                cbNgayRanh.ValueMember = "MaNgay";
                cbNgayRanh.DisplayMember = "DanhSachNgay";
                cbNgayRanh.SelectedIndex = -1;
                //Set ngay mac dinh
                dtNgayLapTTHV.Value = DateTime.Now;

                //Load data cbbox Ca hoc
                _dtCaHoc = _objCaHocBUS.GetAllCaHoc();
                cbCaRanh.DataSource = _dtCaHoc;
                cbCaRanh.ValueMember = "MaCa";
                cbCaRanh.DisplayMember = "TenCa";
                cbCaRanh.SelectedIndex = -1;
            }
            catch
            {
                MessageBox.Show("Load dữ liệu gặp sự cố.Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void fSuaHVTiemNang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtTenHocVien.Text == "") || (txtSDT.Text == "") || (txtDiaChi.Text == "") || (cbGioiTinh.Text == "") || (cbNgayRanh.Text == "") || (cbCaRanh.Text == "") || (cbTrinhDoHienTai.Text == "") || (cbTrinhDoMuonHoc.Text == ""))
                {
                    MessageBox.Show("Bạn còn số liệu chưa nhập ");
                    return;
                }
                string _maHV = dgvDSHVTiemNang.CurrentRow.Cells[0].Value.ToString();//cbbMaHocVien.Text;
                //Them hoc vien
                _objHV = new HocVien(
                    _maHV,
                    txtTenHocVien.Text,//hoten
                    cbGioiTinh.Text,//gioitinh
                    txtDiaChi.Text,//diachi
                    txtSDT.Text,//sdt
                    null,
                    Double.Parse("0"));
                //Them thong tin dang ky cua hoc vien
                _objThongTinDangKy = new ThongTinDangKy(
                    _maHV,
                    dtNgayLapTTHV.Text,
                    "Chưa học",
                     Int32.Parse("0"),
                    _objNgayHocBUS.GetMa_TheoTen(cbNgayRanh.Text),//mangayranh
                    _objCaHocBUS.GetMa_TheoTen(cbCaRanh.Text),//macaranh
                    _objTrinhDoBUS.GetMa_TheoTen(cbTrinhDoHienTai.Text),//matrinhdohientai
                    _objTrinhDoBUS.GetMa_TheoTen(cbTrinhDoMuonHoc.Text),//matrinhdomuonhoc
                    _objTrinhDoBUS.GetMa_TheoTen(cbTrinhDoMuonHoc.Text),//matrinhdoduochoc
                     null);
                if (_objHVBUS.EditHocVien(_objHV) && _objThongTinDangKyBUS.EditThongTinDangKy(_objThongTinDangKy))
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
            if (dgvDSHVTiemNang.CurrentRow.Cells[0].Value.ToString() != "")
            {
                if (_objHVBUS.DeleteHocVien(dgvDSHVTiemNang.CurrentRow.Cells[0].Value.ToString()) && _objThongTinDangKyBUS.DeleteThongTinDangKy(dgvDSHVTiemNang.CurrentRow.Cells[0].Value.ToString()))
                {
                    MessageBox.Show("Xóa thành công");
                    fSuaHVTiemNang_Load(sender, e);
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

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || //Ký tự Alphabe
               char.IsSymbol(e.KeyChar) || //Ký tự đặc biệt
               char.IsWhiteSpace(e.KeyChar) || //Khoảng cách
               char.IsPunctuation(e.KeyChar)) //Dấu chấm                
            {
                e.Handled = true; //Không cho thể hiện lên TextBox
                MessageBox.Show("Vui lòng nhập số.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void resettextbox()
        {
            txtTenHocVien.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            cbNgayRanh.Text = "";
            cbGioiTinh.SelectedIndex = -1;
            cbTrinhDoHienTai.SelectedIndex = -1;
            cbTrinhDoMuonHoc.SelectedIndex = -1;
            cbNgayRanh.SelectedIndex = -1;
            cbCaRanh.SelectedIndex = -1;

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable _dtTimHV = _objHVBUS.FindTenHV_TiemNang(txtTimTenHocVien.Text);
            dgvDSHVTiemNang.DataSource = _dtTimHV;
            dgvDSHVTiemNang.RowHeadersVisible = false;
           
            //Load DS hoc vien tim nang
            dgvDSHVTiemNang.Columns["STT"].DisplayIndex = 0;
            dgvDSHVTiemNang.Columns["MaHV"].HeaderText = "Mã Học Viên";
            dgvDSHVTiemNang.Columns["HoTen"].HeaderText = "Tên Học Viên";
            dgvDSHVTiemNang.Columns["SDT"].HeaderText = "SĐT";
            dgvDSHVTiemNang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgvDSHVTiemNang.Columns["Phai"].HeaderText = "Giới tính";
            dgvDSHVTiemNang.Columns["NoHP"].Visible = false;
            dgvDSHVTiemNang.Columns["MaLop"].Visible = false;
            dgvDSHVTiemNang.Columns["NgayDangKy"].Visible = false;
            dgvDSHVTiemNang.Columns["TrangThai"].Visible = false;
            dgvDSHVTiemNang.Columns["SoLuongCuocHen"].Visible = false;
            dgvDSHVTiemNang.Columns["DanhSachNgay"].HeaderText = "Ngày Rảnh";
            dgvDSHVTiemNang.Columns["TenCa"].HeaderText = "Ca Rảnh";
            dgvDSHVTiemNang.Columns["MaTrinhDoHienTai"].HeaderText = "Trình Độ Hiện Tại";
            dgvDSHVTiemNang.Columns["MaTrinhDoMuonHoc"].HeaderText = "Trình Độ Muốn Học";
            dgvDSHVTiemNang.Columns["MaTrinhDoDuocHoc"].HeaderText = "Trình Độ Được Học";
            dgvDSHVTiemNang.Columns["MaKiThiXepLop"].Visible = false;
            dgvDSHVTiemNang.ClearSelection();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            fSuaHVTiemNang_Load(sender, e);
            txtTimTenHocVien.Text = "";
            resettextbox();
        }

        private void dgvDSHVTiemNang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvDSHVTiemNang.Rows[e.RowIndex];
                txtTenHocVien.Text = row.Cells[1].Value.ToString();
                cbGioiTinh.Text = row.Cells[2].Value.ToString();
                txtDiaChi.Text = row.Cells[3].Value.ToString();
                txtSDT.Text = row.Cells[4].Value.ToString();
                cbNgayRanh.Text = row.Cells[10].Value.ToString();
                cbCaRanh.Text = row.Cells[11].Value.ToString();
                cbTrinhDoHienTai.Text = _objTrinhDoBUS.GetTen_TheoMa(row.Cells[12].Value.ToString());
                cbTrinhDoMuonHoc.Text = _objTrinhDoBUS.GetTen_TheoMa(row.Cells[13].Value.ToString());
            }
            catch (Exception)
            {

            }
        }

       


    }
}