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
    public partial class fThemHocVienTiemNang : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        //  HocVienBUS objTHV = new HocVienBUS();
        HocVienBUS _objhocvienbus = new HocVienBUS();
        HocVien _objhocvien;
        DataTable _dthocvien = new DataTable();

        TrinhDoBUS _objtrinhdobus = new TrinhDoBUS();
        DataTable _dttrinhdo;
        NgayHocBUS _objngayhocbus = new NgayHocBUS();
        DataTable _dtngayhoc;
        CaHocBUS _objcahocbus = new CaHocBUS();
        DataTable _dtcahoc;
        ThongTinDangKyBUS _objthongtindangkybus = new ThongTinDangKyBUS();
        ThongTinDangKy _objthongtindangky;

        public fThemHocVienTiemNang()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                //Load DS Hoc Vien Tiem Nang
                _dthocvien = _objhocvienbus.GetAllHocVienTiemNang();
                dataGridViewX2.DataSource = _dthocvien;
                dataGridViewX2.RowHeadersVisible = true;
                dataGridViewX2.Columns["MaHV"].HeaderText = "Mã Học Viên";
                dataGridViewX2.Columns["HoTen"].HeaderText = "Tên Học Viên";
                dataGridViewX2.Columns["SDT"].HeaderText = "SĐT";
                dataGridViewX2.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dataGridViewX2.Columns["Phai"].HeaderText = "Giới tính";
                dataGridViewX2.Columns["STT"].DisplayIndex = 0;
                // dataGridViewX2.Columns["NoHP"].Visible =false ;
                dataGridViewX2.ClearSelection();

                //Load data cbbox Trinh do
                _dttrinhdo = _objtrinhdobus.GetAllTrinhDo();
                cbTrinhDoHienTai.DataSource = _dttrinhdo;
                cbTrinhDoHienTai.ValueMember = "MaTrinhDo";
                cbTrinhDoHienTai.DisplayMember = "TenTrinhDo";
                cbTrinhDoHienTai.SelectedIndex = -1;

                //Load data cbbox Trinh do muon hoc
                _dttrinhdo = _objtrinhdobus.GetAllTrinhDo();
                cbTrinhDoMuonHoc.DataSource = _dttrinhdo;
                cbTrinhDoMuonHoc.ValueMember = "MaTrinhDo";
                cbTrinhDoMuonHoc.DisplayMember = "TenTrinhDo";
                cbTrinhDoMuonHoc.SelectedIndex = -1;

                //Load data cbbox Ngay hoc
                _dtngayhoc = _objngayhocbus.GetAllNgayHoc();
                cbNgayRanh.DataSource = _dtngayhoc;
                cbNgayRanh.ValueMember = "MaNgay";
                cbNgayRanh.DisplayMember = "DanhSachNgay";
                cbNgayRanh.SelectedIndex = -1;
                //Set ngay mac dinh
                dtNgayLapTTHV.Value = DateTime.Now;

                //Load data cbbox Ca hoc
                _dtcahoc = _objcahocbus.GetAllCaHoc();
                cbCaRanh.DataSource = _dtcahoc;
                cbCaRanh.ValueMember = "MaCa";
                cbCaRanh.DisplayMember = "TenCa";
                cbCaRanh.SelectedIndex = -1;
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
            cbNgayRanh.Text = "";
            cbGioiTinh.SelectedIndex = -1;
            cbTrinhDoHienTai.SelectedIndex = -1;
            cbTrinhDoMuonHoc.SelectedIndex = -1;
            cbNgayRanh.SelectedIndex = -1;
            cbCaRanh.SelectedIndex = -1;

        }
        private void fThemHVTiemNang_Load(object sender, EventArgs e)
        {

            dataGridViewX1.RowHeadersVisible = false;

            LoadData();
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtTenHocVien.Text == "") || (txtSDT.Text == "") || (txtDiaChi.Text == "") || (cbGioiTinh.Text == "") || (cbNgayRanh.Text == "") || (cbCaRanh.Text == "") || (cbTrinhDoHienTai.Text == "") || (cbTrinhDoMuonHoc.Text == ""))
                {
                    MessageBox.Show("Bạn còn số liệu chưa nhập ");
                    return;
                }
                dataGridViewX1.Rows.Add(
                    dataGridViewX1.Rows.Count + 1,
                    txtTenHocVien.Text,
                    txtSDT.Text,
                    txtDiaChi.Text,
                    cbGioiTinh.Text,
                    cbNgayRanh.Text,
                    cbCaRanh.Text,
                    cbTrinhDoHienTai.Text,
                    cbTrinhDoMuonHoc.Text);
                dataGridViewX1.ClearSelection();
                resettextbox();
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
                if ((txtTenHocVien.Text == "") || (txtSDT.Text == "") || (txtDiaChi.Text == "") || (cbGioiTinh.Text == "") || (cbNgayRanh.Text == "") || (cbCaRanh.Text == "") || (cbTrinhDoHienTai.Text == "") || (cbTrinhDoMuonHoc.Text == ""))
                {
                    MessageBox.Show("Bạn còn số liệu chưa nhập ");
                    return;
                }
                dataGridViewX1.CurrentRow.Cells[1].Value = txtTenHocVien.Text;
                dataGridViewX1.CurrentRow.Cells[2].Value = txtSDT.Text;
                dataGridViewX1.CurrentRow.Cells[3].Value = txtDiaChi.Text;
                dataGridViewX1.CurrentRow.Cells[4].Value = cbGioiTinh.Text;
                dataGridViewX1.CurrentRow.Cells[5].Value = cbNgayRanh.Text;
                dataGridViewX1.CurrentRow.Cells[6].Value = cbCaRanh.Text;
                dataGridViewX1.CurrentRow.Cells[7].Value = cbTrinhDoHienTai.Text;
                dataGridViewX1.CurrentRow.Cells[8].Value = cbTrinhDoMuonHoc.Text;

                resettextbox();
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai thông tin, vui lòng nhập lại  !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int icountSelectedRow = dataGridViewX1.SelectedRows.Count;
            if (icountSelectedRow > 0)
            {
                foreach (DataGridViewRow row in dataGridViewX1.SelectedRows)
                    if (!row.IsNewRow) dataGridViewX1.Rows.Remove(row);
            }
            else
            {
                MessageBox.Show("Bạn phải chọn một dòng để xóa");
                return;
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridViewX1.Rows.Count; i++)
                {
                    string _maHV = _objhocvienbus.NextIDHocVien();
                    //Them hoc vien
                    _objhocvien = new HocVien(
                        _maHV,
                        dataGridViewX1.Rows[i].Cells[1].Value.ToString(),//hoten
                        dataGridViewX1.Rows[i].Cells[4].Value.ToString(),//gioitinh
                        dataGridViewX1.Rows[i].Cells[3].Value.ToString(),//diachi
                        dataGridViewX1.Rows[i].Cells[2].Value.ToString(),//sdt
                        null,
                        Double.Parse("0"));
                    //Them thong tin dang ky cua hoc vien
                    _objthongtindangky = new ThongTinDangKy(
                        _maHV,
                        dtNgayLapTTHV.Text,
                        "Chưa học",
                         Int32.Parse("0"),
                        _objngayhocbus.GetMa_TheoTen(dataGridViewX1.Rows[0].Cells[5].Value.ToString()),//mangayranh
                        _objcahocbus.GetMa_TheoTen(dataGridViewX1.Rows[0].Cells[6].Value.ToString()),//macaranh
                        _objtrinhdobus.GetMa_TheoTen(dataGridViewX1.Rows[0].Cells[7].Value.ToString()),//matrinhdohientai
                        _objtrinhdobus.GetMa_TheoTen(dataGridViewX1.Rows[0].Cells[8].Value.ToString()),//matrinhdomuonhoc
                        _objtrinhdobus.GetMa_TheoTen(dataGridViewX1.Rows[0].Cells[8].Value.ToString()),//matrinhdoduochoc
                         null);
                    if (_objthongtindangkybus.AddThongTinDangKy(_objthongtindangky))
                    {
                        if (_objhocvienbus.AddHocVien(_objhocvien))
                        {
                            dataGridViewX1.Rows.Remove(dataGridViewX1.Rows[i]);
                            i--;
                            LoadData();
                        }
                        else
                        {
                            _objthongtindangkybus.DeleteThongTinDangKy(_maHV);
                        }
                    }
                    else
                    {
                        string a = dataGridViewX1.Rows[i].Cells[0].Value.ToString();
                        MessageBox.Show("Lưu dòng " + a + " thất bại");
                    }

                }
                if (dataGridViewX1.Rows.Count == 0)
                    MessageBox.Show("Lưu thành công");
                resettextbox();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để lưu ! ", "Thống báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridViewX1.Rows[e.RowIndex];
                txtTenHocVien.Text = row.Cells[1].Value.ToString();
                txtSDT.Text = row.Cells[2].Value.ToString();
                txtDiaChi.Text = row.Cells[3].Value.ToString();
                cbGioiTinh.Text = row.Cells[4].Value.ToString();
                cbNgayRanh.Text = row.Cells[5].Value.ToString();
                cbCaRanh.Text = row.Cells[6].Value.ToString();
                cbTrinhDoHienTai.Text = row.Cells[7].Value.ToString();
                cbTrinhDoMuonHoc.Text = row.Cells[8].Value.ToString();

            }
            catch (Exception)
            {

            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}