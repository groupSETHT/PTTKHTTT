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
    public partial class fNhapKetQuaThi : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        LoaiKyThiBUS _objloaikythibus = new LoaiKyThiBUS();
        KyThiBUS _objkythibus = new KyThiBUS();
        DanhSachThiBUS _objdanhsachthibus = new DanhSachThiBUS();
        DanhSachThi _objdanhsachthi;
        LopBUS _objlopbus = new LopBUS();
        DataTable _dtketquathi;
        public fNhapKetQuaThi()
        {
            InitializeComponent();
        }

        public void resetbox()
        {
            lblTenHV.Text = "";
            txtDiem.Text = "";
        }
        public void LoadData()
        {

            if (cbbKyThi.Text != "")
            {
                lblTenLop.Text = "Lớp : " + _objlopbus.GetTen_TheoMa_LopHoc(_objkythibus.GetLop_TheoMaKyThi(cbbKyThi.SelectedValue.ToString()));
                _dtketquathi = _objdanhsachthibus.GetAllDanhSachThi_TheoKyThi(cbbKyThi.SelectedValue.ToString());
                dgvKetQuaThi.RowHeadersVisible = true;
                dgvKetQuaThi.DataSource = _dtketquathi;
                if (dgvDSHocVienThamGia.DataSource != null)
                {

                    _dtketquathi.Columns.Add("STT");
                    for (int i = 0; i < _dtketquathi.Rows.Count; i++)
                        _dtketquathi.Rows[i]["STT"] = i + 1;
                    dgvKetQuaThi.Columns["STT"].DisplayIndex = 0;
                    dgvKetQuaThi.Columns["MaHV"].HeaderText = "Mã Học Viên";
                    //dgvKetQuaThi.Columns["MaHV"].Width = 140;
                    dgvKetQuaThi.Columns["HoTen"].HeaderText = "Tên Học Viên";
                    //dgvKetQuaThi.Columns["HoTen"].Width = 140;
                    dgvKetQuaThi.Columns["KetQuaThi"].HeaderText = "Kết quả thi";
                    dgvKetQuaThi.ClearSelection();
                }
            }
            else
            {
                lblTenLop.Text = "";
            }



        }
        private void fNhapKetQuaThi_Load(object sender, EventArgs e)
        {
            DataTable _dtloaikythi = _objloaikythibus.GetAllLoaiKyThi();
            cbbLoaiKyThi.DataSource = _dtloaikythi;
            cbbLoaiKyThi.ValueMember = "MaLoaiKyThi";
            cbbLoaiKyThi.DisplayMember = "TenLoaiKyThi";
            lblTenLop.Text = "";
            LoadData();
        }

        private void cbbLoaiKyThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbLoaiKyThi.Text != "")
                {
                    DataTable _dtkythi = _objkythibus.GetMaTenKyThi_TheoLoaiKyThi(_objloaikythibus.GetMa_TheoTen_LoaiKyThi(cbbLoaiKyThi.Text));
                    cbbKyThi.DataSource = _dtkythi;
                    cbbKyThi.ValueMember = "MaKyThi";
                    cbbKyThi.DisplayMember = "TenKyThi";
                    if (cbbKyThi.Text == "")
                    {
                        lblTenLop.Text = "";
                    }
                }
                else
                {
                    cbbKyThi.DataSource = null;
                }
                LoadData();
            }
            catch
            {
                MessageBox.Show("Không tìm thấy có kỳ thi nào .", "Thông  Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbbKyThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                DataTable _dtdanhsachthi = _objkythibus.GetDanhSachThi_TheoKyThi(cbbKyThi.SelectedValue.ToString());
                dgvDSHocVienThamGia.RowHeadersVisible = true;
                if (_dtdanhsachthi != null)
                {
                    dgvDSHocVienThamGia.DataSource = _dtdanhsachthi;
                    _dtdanhsachthi.Columns.Add("STT");
                    for (int i = 0; i < _dtdanhsachthi.Rows.Count; i++)
                        _dtdanhsachthi.Rows[i]["STT"] = i + 1;
                    dgvDSHocVienThamGia.Columns["STT"].DisplayIndex = 0;
                    dgvDSHocVienThamGia.Columns["MaHV"].HeaderText = "Mã Học Viên";
                    dgvDSHocVienThamGia.Columns["MaHV"].Width = 140;
                    dgvDSHocVienThamGia.Columns["HoTen"].HeaderText = "Tên Học Viên";
                    dgvDSHocVienThamGia.Columns["HoTen"].Width = 140;
                    dgvDSHocVienThamGia.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu học viên tham gia thi ");
                }


                LoadData();



            }
            catch
            {

            }

        }

        private void dgvDSHocVienThamGia_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvDSHocVienThamGia.Rows[e.RowIndex];
                if (_objdanhsachthibus.CheckHV_DaCoDiem_DanhSachThi(dgvDSHocVienThamGia.CurrentRow.Cells[0].Value.ToString()))
                {
                    MessageBox.Show("Học Viên này đã được nhập điểm!!!");
                    resetbox();
                    return;
                }
                lblTenHV.Text = row.Cells[1].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                float diem = float.Parse(txtDiem.Text);
                if (txtDiem.Text == "")
                {
                    MessageBox.Show("Bạn còn số liệu chưa nhập ");
                    return;
                }
                if (diem < 0 || diem > 10)
                {
                    MessageBox.Show("Điểm của học viên phải >=0 và nhỏ hơn hoặc bằng 10  ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string _mahv = dgvDSHocVienThamGia.CurrentRow.Cells[0].Value.ToString();
                dgvDSDiemHocVien.Rows.Add(dgvDSDiemHocVien.Rows.Count + 1, _mahv, lblTenHV.Text, txtDiem.Text);
                dgvDSHocVienThamGia.Rows.Remove(dgvDSHocVienThamGia.CurrentRow);
                resetbox();
                dgvDSDiemHocVien.ClearSelection();


            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai thông tin khóa học  , vui lòng nhập lại  !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void dgvDSDiemHocVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvDSDiemHocVien.Rows[e.RowIndex];
                lblTenHV.Text = row.Cells[2].Value.ToString();
                txtDiem.Text = row.Cells[3].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDiem.Text == "")
                {
                    MessageBox.Show("Bạn còn số liệu chưa nhập ", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dgvDSDiemHocVien.CurrentRow.Cells[3].Value = txtDiem.Text;
                resetbox();
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai thông tin Phòng học , vui lòng nhập lại  !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dgvDSDiemHocVien.Rows.Count > 0)
            {
                for (int i = 0; i < dgvDSDiemHocVien.Rows.Count; i++)
                {
                    string makt, mahv;
                    float diem;
                    makt = cbbKyThi.SelectedValue.ToString();
                    mahv = dgvDSDiemHocVien.Rows[i].Cells[1].Value.ToString();
                    diem = float.Parse(dgvDSDiemHocVien.Rows[i].Cells[3].Value.ToString());

                    _objdanhsachthi = new DanhSachThi(makt, mahv, diem);

                    if (_objdanhsachthibus.AddDanhSachThi(_objdanhsachthi))
                    {
                        dgvDSDiemHocVien.Rows.Remove(dgvDSDiemHocVien.Rows[i]);
                        i--;
                        LoadData();
                    }
                    else
                    {
                        string a = dgvDSDiemHocVien.Rows[i].Cells[0].Value.ToString();
                        MessageBox.Show("Lưu dòng " + a + " thất bại");
                    }

                }


                if (dgvDSDiemHocVien.Rows.Count == 0)
                    MessageBox.Show("Lưu thành công");

                resetbox();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để lưu ! ", "Thống báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int icountSelectedRow = dgvDSDiemHocVien.SelectedRows.Count;
            if (icountSelectedRow > 0)
            {
                foreach (DataGridViewRow row in dgvDSDiemHocVien.SelectedRows)
                    if (!row.IsNewRow) dgvDSDiemHocVien.Rows.Remove(row);
                resetbox();
            }
            else
            {
                MessageBox.Show("Bạn phải chọn một dòng để xóa");
                return;
            }
        }


    }
}