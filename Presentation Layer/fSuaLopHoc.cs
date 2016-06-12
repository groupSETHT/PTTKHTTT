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
    public partial class fSuaLopHoc : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        Lop _objlop;
        LopBUS _objlopbus = new LopBUS();
        DataTable _dtlophoc;
        public fSuaLopHoc()
        {
            InitializeComponent();
        }
        public void LoadSelect()
        {
            GiangVienBUS _objgvbus = new GiangVienBUS();
            DataTable _dtgv = _objgvbus.GetMaTen();
            cbGiangVien.DataSource = _dtgv;
            cbGiangVien.ValueMember = "MaGV";
            cbGiangVien.DisplayMember = "TenGV";
            cbGiangVien.SelectedIndex = -1;

            KhoaHocBUS _objkhoahocbus = new KhoaHocBUS();
            DataTable _dtkh = _objkhoahocbus.GetMaTenKhoaHoc();
            cbKhoaHoc.DataSource = _dtkh;
            cbKhoaHoc.ValueMember = "MaKhoaHoc";
            cbKhoaHoc.DisplayMember = "TenKhoaHoc";
            PhongHocBUS _objphonghocbus = new PhongHocBUS();
            DataTable _dtph = _objphonghocbus.GetMaTen();
            cbPhongHoc.DataSource = _dtph;
            cbPhongHoc.ValueMember = "MaPhong";
            cbPhongHoc.DisplayMember = "TenPhong";
            cbPhongHoc.SelectedIndex = -1;

            CaHocBUS _objcahocbus = new CaHocBUS();
            DataTable _dtch = _objcahocbus.GetMaTen();
            cbCaHoc.DataSource = _dtch;
            cbCaHoc.ValueMember = "MaCa";
            cbCaHoc.DisplayMember = "TenCa";
            cbCaHoc.Text = "";

            NgayHocBUS _objngayhocbus = new NgayHocBUS();
            DataTable _dtngay = _objngayhocbus.GetAllNgayHoc();
            cbNgayHoc.DataSource = _dtngay;
            cbNgayHoc.ValueMember = "MaNgay";
            cbNgayHoc.DisplayMember = "DanhSachNgay";
            cbNgayHoc.SelectedIndex = -1;

            cbChuongTrinhHoc.SelectedIndex = -1;
            txtGioBatDau.Text = "";
            txtGioKetThuc.Text = "";
        }
        public void LoadData()
        {
            LoadSelect();
            _dtlophoc = _objlopbus.GetAll_CT();
            dataGridViewX1.DataSource = _dtlophoc;
            dataGridViewX1.RowHeadersVisible = true;
            _dtlophoc.Columns.Add("STT");
            for (int i = 0; i < _dtlophoc.Rows.Count; i++)
                _dtlophoc.Rows[i]["STT"] = i + 1;
            dataGridViewX1.Columns["STT"].DisplayIndex = 0;
            dataGridViewX1.Columns["STT"].Width = 30;
            dataGridViewX1.Columns["MaLop"].HeaderText = "Mã Lớp";
            dataGridViewX1.Columns["MaLop"].Width = 50;
            dataGridViewX1.Columns["TenLop"].HeaderText = "Tên Lớp";
            dataGridViewX1.Columns["TenKhoaHoc"].HeaderText = "Tên Khóa Học";
            dataGridViewX1.Columns["TenChuongTrinhHoc"].HeaderText = "Chương Trình Học";
            dataGridViewX1.Columns["NgayBatDau"].HeaderText = "Ngày Bắt Đầu";
            dataGridViewX1.Columns["NgayKetThuc"].HeaderText = "Ngày Kết Thúc";
            dataGridViewX1.Columns["TenCa"].HeaderText = "Ca học";
            dataGridViewX1.Columns["GioBatDau"].HeaderText = "Giờ Bắt Đầu";
            dataGridViewX1.Columns["GioKetThuc"].HeaderText = "Giờ Kết Thúc";
            dataGridViewX1.Columns["DanhSachNgay"].HeaderText = "Ngày Học";
            dataGridViewX1.Columns["TenGV"].HeaderText = "Tên Giảng Viên";
            dataGridViewX1.Columns["TenPhong"].HeaderText = "Phòng Học";
            dataGridViewX1.ClearSelection();
        }
        private void fSuaLopHoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }  
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTenLopFind.Text != "")
            {
                DataTable _dtlophocfind;
                _dtlophocfind = _objlopbus.FindCT_TheoTenLop(txtTenLopFind.Text);
                if (_dtlophocfind != null)
                {
                    dataGridViewX1.DataSource = _dtlophocfind;
                    dataGridViewX1.RowHeadersVisible = true;
                    _dtlophocfind.Columns.Add("STT");
                    for (int i = 0; i < _dtlophoc.Rows.Count; i++)
                        _dtlophoc.Rows[i]["STT"] = i + 1;
                    dataGridViewX1.Columns["STT"].DisplayIndex = 0;
                    dataGridViewX1.Columns["STT"].Width = 30;
                    dataGridViewX1.Columns["MaLop"].HeaderText = "Mã Lớp";
                    dataGridViewX1.Columns["MaLop"].Width = 40;
                    dataGridViewX1.Columns["TenLop"].HeaderText = "Tên Lớp";
                    dataGridViewX1.Columns["TenKhoaHoc"].HeaderText = "Tên Khóa Học";
                    dataGridViewX1.Columns["TenChuongTrinhHoc"].HeaderText = "Chương Trình Học";
                    dataGridViewX1.Columns["NgayBatDau"].HeaderText = "Ngày Bắt Đầu";
                    dataGridViewX1.Columns["NgayKetThuc"].HeaderText = "Ngày Kết Thúc";
                    dataGridViewX1.Columns["TenCa"].HeaderText = "Ca Học ";
                    dataGridViewX1.Columns["GioBatDau"].HeaderText = "Giờ Bắt Đầu";
                    dataGridViewX1.Columns["GioKetThuc"].HeaderText = "Giờ Kết Thúc";
                    dataGridViewX1.Columns["DanhSachNgay"].HeaderText = "Ngày Học";
                    dataGridViewX1.Columns["TenGV"].HeaderText = "Tên Giảng Viên";
                    dataGridViewX1.Columns["TenPhong"].HeaderText = "Phòng Học";
                    dataGridViewX1.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy lớp " + txtTenLopFind.Text, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập lớp cần tìm . ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridViewX1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridViewX1.Rows[e.RowIndex];
            txtTenLop.Text = row.Cells[1].Value.ToString();
            cbKhoaHoc.Text = row.Cells[2].Value.ToString();
            cbChuongTrinhHoc.Text = row.Cells[3].Value.ToString();
            dtipNgayBatDau.Text = row.Cells[4].Value.ToString();
            dtipNgayKetThuc.Text = row.Cells[5].Value.ToString();
            cbCaHoc.Text = row.Cells[6].Value.ToString();
            txtGioBatDau.Text = row.Cells[7].Value.ToString();
            txtGioKetThuc.Text = row.Cells[8].Value.ToString();
            cbNgayHoc.Text = row.Cells[9].Value.ToString();
            cbGiangVien.Text = row.Cells[10].Value.ToString();
            cbPhongHoc.Text = row.Cells[11].Value.ToString();
        }

        private void cbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChuongTrinhHocBUS _objchuongtrinhhocbus = new ChuongTrinhHocBUS();
            DataTable _dtcth = _objchuongtrinhhocbus.GetMaTen_TheoKhoa(cbKhoaHoc.SelectedValue.ToString());
            if (_dtcth.Rows.Count != 0)
            {
                cbChuongTrinhHoc.DataSource = _dtcth;
                cbChuongTrinhHoc.ValueMember = "MaChuongTrinhHoc";
                cbChuongTrinhHoc.DisplayMember = "TenChuongTrinhHoc";
            }
            else
            {
                cbChuongTrinhHoc.DataSource = null;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string makhoa, machuongtrinhhoc, magv, maphonghoc, mangayhoc, maca;
            makhoa = new KhoaHocBUS().GetMa_TheoTen(cbKhoaHoc.Text);
            machuongtrinhhoc = new ChuongTrinhHocBUS().GetMa_TheoTen(cbChuongTrinhHoc.Text);
            magv = new GiangVienBUS().GetMa_TheoTen(cbGiangVien.Text);
            maphonghoc = new PhongHocBUS().GetMa_TheoTen_PhongHoc(cbPhongHoc.Text);
            mangayhoc = new NgayHocBUS().GetMa_TheoTen(cbNgayHoc.Text);
            maca = new CaHocBUS().GetMa_TheoTen(cbCaHoc.Text);
            _objlop = new Lop(
                dataGridViewX1.CurrentRow.Cells[0].Value.ToString(),
                txtTenLop.Text,
                makhoa,
                machuongtrinhhoc,
                DateTime.Parse(dtipNgayBatDau.Value.ToShortDateString()),
                DateTime.Parse(dtipNgayBatDau.Value.ToShortDateString()),
                maca,
                mangayhoc,
                magv,
                maphonghoc);
            //MessageBox.Show(dataGridViewX1.CurrentRow.Cells[0].Value.ToString() +
            //    txtTenLop.Text+
            //    makhoa+
            //    machuongtrinhhoc+
            //    DateTime.Parse(dtipNgayBatDau.Value.ToShortDateString())+
            //    DateTime.Parse(dtipNgayBatDau.Value.ToShortDateString())+
            //    maca+
            //    mangayhoc+
            //    magv+
            //    maphonghoc);

            if (_objlopbus.EditLop(_objlop))
            {
                MessageBox.Show("Cập nhật thành công ","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadData();
                resettextbox();
            }
            else
            {
                MessageBox.Show("Cập Nhật thất bại", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void resettextbox()
        {

            dtipNgayBatDau.Text = "";
            dtipNgayKetThuc.Text = "";
            cbCaHoc.Text = "";
            cbChuongTrinhHoc.SelectedIndex = -1;
            cbGiangVien.SelectedIndex = -1;
            cbNgayHoc.SelectedIndex = -1;
            cbPhongHoc.SelectedIndex = -1;
            txtGioBatDau.Text = "";
            txtGioKetThuc.Text = "";
            txtTenLop.Text = "";
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count = dataGridViewX1.SelectedRows.Count;

            if (count != 0)
            {
                string _malop = dataGridViewX1.CurrentRow.Cells[0].Value.ToString();
                if (_objlopbus.DeleteLop(_malop))
                {
                    resettextbox();
                    LoadData();
                    MessageBox.Show("Xóa thành công");

                }
                else
                    MessageBox.Show("Mùa giải này đã được tổ chức bạn phải xóa tất cả đội bóng,cầu thủ, bàn thắng, trận đấu liên quan trước khi xóa mùa giải");
            }
            else
                MessageBox.Show("Bạn chưa chon dòng cần xóa");
        }

        private void cbCaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            CaHocBUS _objcahocbus = new CaHocBUS();
            DataTable _dtch = _objcahocbus.Get_CT(cbCaHoc.SelectedValue.ToString());
            for (int i = 0; i < _dtch.Rows.Count; i++)
            {
                txtGioBatDau.Text = _dtch.Rows[i]["GioBatDau"].ToString();
                txtGioKetThuc.Text = _dtch.Rows[i]["GioKetThuc"].ToString();
            }
        }
    }
}