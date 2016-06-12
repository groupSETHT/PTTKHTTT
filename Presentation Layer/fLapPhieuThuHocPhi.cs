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
    public partial class fLapPhieuThuHocPhi : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        PhieuThuHocPhiBUS _objphieuthuhocphibus = new PhieuThuHocPhiBUS();
        PhieuThuHocPhi _objphieuthuhocphi = new PhieuThuHocPhi();
        HocVienBUS _objhocvienbus = new HocVienBUS();
        DataTable _dthocvien;
        ThongTinDangKyBUS _objthongtindangkybus = new ThongTinDangKyBUS();
        KhoaHocBUS _objkhoahocbus = new KhoaHocBUS();
        DataTable _dtkhoahoc;
        ChuongTrinhHocBUS _objchuongtrinhhocbus = new ChuongTrinhHocBUS();
        DataTable _dtchuongtrinhhoc;
        LopBUS _objlopbus = new LopBUS();
        DataTable _dtlop;
        private void LoadData()
        {
            try
            {
                //Load DS hoc vien chinh thuc
                _dthocvien = _objhocvienbus.GetAllHocVienConNoHP_ChiTiet();
                dtgDSHVNoHP.DataSource = _dthocvien;
                dtgDSHVNoHP.RowHeadersVisible = true;
                dtgDSHVNoHP.Columns["STT"].DisplayIndex = 0;
                dtgDSHVNoHP.Columns["STT"].Width = 40;
                dtgDSHVNoHP.Columns["MaHV"].HeaderText = "Mã Học Viên";
                dtgDSHVNoHP.Columns["MaHV"].Width = 70;
                dtgDSHVNoHP.Columns["HoTen"].HeaderText = "Tên Học Viên";
                dtgDSHVNoHP.Columns["HoTen"].Width = 150;
                dtgDSHVNoHP.Columns["SDT"].HeaderText = "SĐT";
                dtgDSHVNoHP.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dtgDSHVNoHP.Columns["Phai"].Visible = false;
                dtgDSHVNoHP.Columns["NoHP"].HeaderText = "Nợ học phí";
                dtgDSHVNoHP.Columns["TenLop"].HeaderText = "Lớp";
                dtgDSHVNoHP.Columns["TenChuongTrinhHoc"].HeaderText = "Chương trình học";
                dtgDSHVNoHP.Columns["TenKhoaHoc"].HeaderText = "Khóa học";
                dtgDSHVNoHP.ClearSelection();
                //Load ccbKhoaHoc
                _dtkhoahoc = _objkhoahocbus.GetMaTenKhoaHoc();
                cbbKhoaHoc.DataSource = _dtkhoahoc;
                cbbKhoaHoc.ValueMember = "MaKhoaHoc";
                cbbKhoaHoc.DisplayMember = "TenKhoaHoc";
                cbbKhoaHoc.Text = "";

                //Load cbbChuong Trinh Hoc
                _dtchuongtrinhhoc = _objchuongtrinhhocbus.GetMaTen_TheoKhoa(cbbKhoaHoc.SelectedValue.ToString());
                cbbChuongTrinhHoc.DataSource = _dtchuongtrinhhoc;
                cbbChuongTrinhHoc.ValueMember = "MaChuongTrinhHoc";
                cbbChuongTrinhHoc.DisplayMember = "TenChuongTrinhHoc";

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
                dtNgayLapPTHP.Value  = DateTime.Now;
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
            lblHocPhi.Text = "0";
            lblSoTienNo.Text = "0";
            lblConNoLai.Text = "0";
            txtSoTienDong.Text = "0";

        }
        public fLapPhieuThuHocPhi()
        {
            InitializeComponent();
        }

        private void fLapPhieuThuHocPhi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgDSHVNoHP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgDSHVNoHP.Rows[e.RowIndex];
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

        private void txtSoTienDong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSoTienDong.Text.Length > 9)
            {
                e.Handled = true; //Không cho thể hiện lên TextBox
                MessageBox.Show("Số tiền đóng quá lớn , vui lòng kiểm tra lại.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (char.IsLetter(e.KeyChar) || //Ký tự Alphabe
               char.IsSymbol(e.KeyChar) || //Ký tự đặc biệt
               char.IsWhiteSpace(e.KeyChar) || //Khoảng cách
               char.IsPunctuation(e.KeyChar)) //Dấu chấm                
            {
                e.Handled = true; //Không cho thể hiện lên TextBox
                MessageBox.Show("Vui lòng nhập số.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSoTienDong_TextChanged(object sender, EventArgs e)
        {
            double sotiendong = 0;
            if (txtSoTienDong.Text == "")
                sotiendong = 0;
            else
                sotiendong = double.Parse(txtSoTienDong.Text);
            if (txtSoTienDong.Text.Length > 3)
            {
                txtSoTienDong.Text = String.Format("{0:0,0}", (double.Parse(txtSoTienDong.Text)));
                txtSoTienDong.SelectionStart = txtSoTienDong.Text.Length;
            }

            lblConNoLai.Text = String.Format("{0:0,0}", (double.Parse(lblSoTienNo.Text) - sotiendong));
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            DataTable _dttimhocvien = _objhocvienbus.FindTenHV_ConNoHP(txtTimTenHocVien.Text);
            dtgDSHVNoHP.DataSource = _dttimhocvien;
            dtgDSHVNoHP.RowHeadersVisible = false;

            //Load DS hoc vien con no hoc phi
            dtgDSHVNoHP.RowHeadersVisible = true;
            dtgDSHVNoHP.Columns["STT"].DisplayIndex = 0;
            dtgDSHVNoHP.Columns["STT"].Width = 40;
            dtgDSHVNoHP.Columns["MaHV"].HeaderText = "Mã Học Viên";
            dtgDSHVNoHP.Columns["MaHV"].Width = 70;
            dtgDSHVNoHP.Columns["HoTen"].HeaderText = "Tên Học Viên";
            dtgDSHVNoHP.Columns["HoTen"].Width = 150;
            dtgDSHVNoHP.Columns["SDT"].HeaderText = "SĐT";
            dtgDSHVNoHP.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dtgDSHVNoHP.Columns["Phai"].Visible = false;
            dtgDSHVNoHP.Columns["NoHP"].HeaderText = "Nợ học phí";
            dtgDSHVNoHP.Columns["TenLop"].HeaderText = "Lớp";
            dtgDSHVNoHP.Columns["TenChuongTrinhHoc"].HeaderText = "Chương trình học";
            dtgDSHVNoHP.Columns["TenKhoaHoc"].HeaderText = "Khóa học";
            dtgDSHVNoHP.ClearSelection();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtSoTienDong.Text == ""))
                {
                    MessageBox.Show("Bạn chưa nhập sốd tiền đóng.");
                    return;
                }
                string _maPhieuThuHocPhi= _objphieuthuhocphibus.NextIDPhieuThuHocPhi();
                string _maHV = dtgDSHVNoHP.CurrentRow.Cells[0].Value.ToString();//cbbMaHocVien.Text;
                
                //Them hoc vien
                _objphieuthuhocphi = new PhieuThuHocPhi(
                    _maPhieuThuHocPhi,
                    _maHV,
                     Double.Parse(lblHocPhi.Text),
                    Double.Parse(txtSoTienDong.Text),
                    Double.Parse(lblConNoLai.Text),
                    dtNgayLapPTHP.Text);

                if (_objphieuthuhocphibus.AddPhieuThuHocPhi(_objphieuthuhocphi) && _objhocvienbus.Edit_NoHP_HocVien(_maHV, Double.Parse(lblConNoLai.Text)))
                {
                    LoadData();
                    MessageBox.Show("Thanh Toán Thành Công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resettextbox();
                }
                else
                    MessageBox.Show("Thanh Toán Thất Bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai thông tin, vui lòng nhập lại  !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}