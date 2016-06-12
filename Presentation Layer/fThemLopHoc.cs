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
    public partial class fThemLopHoc : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        LopBUS _objlopbus = new LopBUS();
        Lop _objlop;
        DataTable _dtlophoc;
       
        public fThemLopHoc()
        {
            InitializeComponent();
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
        protected void LoadData()
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
            _dtlophoc = _objlopbus.GetAll_CT();
            dataGridViewX2.DataSource = _dtlophoc;
            dataGridViewX2.RowHeadersVisible = true;
            _dtlophoc.Columns.Add("STT");
            for (int i = 0; i < _dtlophoc.Rows.Count; i++)
                _dtlophoc.Rows[i]["STT"] = i + 1;
            dataGridViewX2.Columns["STT"].DisplayIndex = 0;
            dataGridViewX2.Columns["MaLop"].HeaderText = "Mã Lớp";
            dataGridViewX2.Columns["TenLop"].HeaderText = "Tên Lớp";
            dataGridViewX2.Columns["TenKhoaHoc"].HeaderText = "Tên Khóa Học";
            dataGridViewX2.Columns["TenChuongTrinhHoc"].HeaderText = "Chương Trình Học";
            dataGridViewX2.Columns["NgayBatDau"].HeaderText = "Ngày Bắt Đầu";
            dataGridViewX2.Columns["NgayKetThuc"].HeaderText = "Ngày Kết Thúc";
            dataGridViewX2.Columns["GioBatDau"].HeaderText = "Giờ Bắt Đầu";
            dataGridViewX2.Columns["GioKetThuc"].HeaderText = "Giờ Kết Thúc";
            dataGridViewX2.Columns["DanhSachNgay"].HeaderText = "Ngày Học";
            dataGridViewX2.Columns["TenGV"].HeaderText = "Tên Giảng Viên";
            dataGridViewX2.Columns["TenPhong"].HeaderText = "Phòng Học";
            dataGridViewX2.ClearSelection();
        }
        private void fThemLopHoc_Load(object sender, EventArgs e)
        {
            resettextbox();
            LoadData();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if ((dtipNgayBatDau.Text == "") || (dtipNgayKetThuc.Text == "") || cbChuongTrinhHoc.Text == "" || cbGiangVien.Text == "" || cbKhoaHoc.Text == "" || cbNgayHoc.Text == "" || cbPhongHoc.Text == "")
            {
                MessageBox.Show("Bạn còn số liệu chưa nhập ", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime a = DateTime.Parse(dtipNgayBatDau.Text);
            DateTime b = DateTime.Parse(dtipNgayKetThuc.Text);
            int tam = DateTime.Compare(a, b);
            if (tam >= 0)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataGridViewX1.Rows.Add(dataGridViewX1.Rows.Count + 1,txtTenLop.Text, cbKhoaHoc.Text, cbChuongTrinhHoc.Text, dtipNgayBatDau.Value.ToShortDateString(), dtipNgayKetThuc.Value.ToShortDateString(), cbNgayHoc.Text,cbCaHoc.Text, txtGioBatDau.Text,txtGioKetThuc.Text, cbGiangVien.Text, cbPhongHoc.Text);
            dataGridViewX1.ClearSelection();
            resettextbox();
        }
        
        private void cbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ChuongTrinhHocBUS _objchuongtrinhhocbus = new ChuongTrinhHocBUS();
            DataTable _dtcth = _objchuongtrinhhocbus.GetMaTen_TheoKhoa(cbKhoaHoc.SelectedValue.ToString());
            if (_dtcth.Rows.Count !=0)
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
            try
            {
                if ((dtipNgayBatDau.Text == "") || (dtipNgayKetThuc.Text == "") || cbChuongTrinhHoc.Text == "" || cbGiangVien.Text == "" || cbKhoaHoc.Text == "" || cbNgayHoc.Text == "" || cbPhongHoc.Text == "")
                {
                    MessageBox.Show("Bạn còn số liệu chưa nhập ", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime a = DateTime.Parse(dtipNgayBatDau.Text);
                DateTime b = DateTime.Parse(dtipNgayKetThuc.Text);
                int tam = DateTime.Compare(a, b);
                if (tam >= 0)
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dataGridViewX1.CurrentRow.Cells[1].Value = txtTenLop.Text;
                dataGridViewX1.CurrentRow.Cells[2].Value = cbKhoaHoc.Text;
                dataGridViewX1.CurrentRow.Cells[3].Value = cbChuongTrinhHoc.Text;
                dataGridViewX1.CurrentRow.Cells[4].Value = dtipNgayBatDau.Value.ToShortDateString();
                dataGridViewX1.CurrentRow.Cells[5].Value = dtipNgayBatDau.Value.ToShortDateString();
                dataGridViewX1.CurrentRow.Cells[6].Value = cbNgayHoc.Text;
                dataGridViewX1.CurrentRow.Cells[7].Value = cbCaHoc.Text;
                dataGridViewX1.CurrentRow.Cells[8].Value = txtGioBatDau.Text;
                dataGridViewX1.CurrentRow.Cells[9].Value = txtGioKetThuc.Text;
                dataGridViewX1.CurrentRow.Cells[10].Value = cbGiangVien.Text;
                dataGridViewX1.CurrentRow.Cells[11].Value = cbPhongHoc.Text;
                resettextbox();
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai thông tin khóa học  , vui lòng nhập lại  !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void dataGridViewX1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridViewRow row = new DataGridViewRow();
            row = dataGridViewX1.Rows[e.RowIndex];
            txtTenLop.Text = row.Cells[1].Value.ToString();
            cbKhoaHoc.Text = row.Cells[2].Value.ToString();
            cbChuongTrinhHoc.Text = row.Cells[3].Value.ToString();
            dtipNgayBatDau.Text = row.Cells[4].Value.ToString();
            dtipNgayKetThuc.Text = row.Cells[5].Value.ToString();
            cbNgayHoc.Text = row.Cells[6].Value.ToString();
            cbCaHoc.Text = row.Cells[7].Value.ToString();
            txtGioBatDau.Text = row.Cells[8].Value.ToString();
            txtGioKetThuc.Text = row.Cells[9].Value.ToString();
            cbGiangVien.Text = row.Cells[10].Value.ToString();
            cbPhongHoc.Text = row.Cells[11].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int icountSelectedRow = dataGridViewX1.SelectedRows.Count;
            if (icountSelectedRow > 0)
            {
                foreach (DataGridViewRow row in dataGridViewX1.SelectedRows)
                    if (!row.IsNewRow) dataGridViewX1.Rows.Remove(row);
                txtTenLop.Text = "";
                dtipNgayBatDau.Text = "";
                dtipNgayKetThuc.Text = "";
                
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
                    string makhoa, machuongtrinhhoc, magv, maphonghoc, mangayhoc,maca;
                    makhoa = new KhoaHocBUS().GetMa_TheoTen(dataGridViewX1.Rows[i].Cells[2].Value.ToString());
                    machuongtrinhhoc = new ChuongTrinhHocBUS().GetMa_TheoTen(dataGridViewX1.Rows[i].Cells[3].Value.ToString());
                    magv = new GiangVienBUS().GetMa_TheoTen(dataGridViewX1.Rows[i].Cells[10].Value.ToString());
                    maphonghoc = new PhongHocBUS().GetMa_TheoTen_PhongHoc(dataGridViewX1.Rows[i].Cells[11].Value.ToString());
                    mangayhoc = new NgayHocBUS().GetMa_TheoTen(dataGridViewX1.Rows[i].Cells[6].Value.ToString());
                    maca = new CaHocBUS().GetMa_TheoTen(dataGridViewX1.Rows[i].Cells[7].Value.ToString());
                    _objlop = new Lop(
                        _objlopbus.Lop_NextID(),
                        dataGridViewX1.Rows[i].Cells[1].Value.ToString(),
                        makhoa,
                        machuongtrinhhoc,
                        DateTime.Parse(dataGridViewX1.Rows[i].Cells[4].Value.ToString()),
                        DateTime.Parse(dataGridViewX1.Rows[i].Cells[5].Value.ToString()),
                        maca,
                        mangayhoc,
                        magv,
                        maphonghoc);
                    
                    if (_objlopbus.AddLop(_objlop))
                    {
                        dataGridViewX1.Rows.Remove(dataGridViewX1.Rows[i]);
                        i--;
                        LoadData();
                    }
                    else
                    {
                        string a = dataGridViewX1.Rows[i].Cells[0].Value.ToString();
                        MessageBox.Show("Lưu dòng " + a + " thất bại");
                    }

                }


                if (dataGridViewX1.Rows.Count == 0)
                    MessageBox.Show("Lưu thành công");
              
                dtipNgayBatDau.Text = "";
                dtipNgayKetThuc.Text = "";
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để lưu ! ", "Thống báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}