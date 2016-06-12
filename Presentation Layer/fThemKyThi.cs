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
    public partial class fThemKyThi : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        LoaiKyThiBUS _objloaikythibus = new LoaiKyThiBUS();
        DataTable _dtloaikythi;
        LoaiDeThiBUS _objloaidethibus = new LoaiDeThiBUS();
        DataTable _dtloaidethi;
        DeThiBUS _objdethibus = new DeThiBUS();
        DataTable _dtdethi;
        PhongHocBUS _objphonghocbus = new PhongHocBUS();
        DataTable _dtphonghoc;
        LopBUS _objlopbus = new LopBUS();
        DataTable _dtlop;
        KyThi _objkythi;
        KyThiBUS _objkythibus = new KyThiBUS();
        DataTable _dtkythi;

        public fThemKyThi()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            _dtkythi = _objkythibus.GetAllKyThi_TheoMa_LoaiKyThi(_objloaikythibus.GetMa_TheoTen_LoaiKyThi(cbbLoaiKyThi.Text));
            dgvDSKyThi.DataSource = _dtkythi;
            dgvDSKyThi.RowHeadersVisible = false;
            _dtkythi.Columns.Add("STT");
            for (int i = 0; i < _dtkythi.Rows.Count; i++)
            {
                _dtkythi.Rows[i]["STT"] = i + 1;
            }
            dgvDSKyThi.Columns["STT"].DisplayIndex = 0;
            dgvDSKyThi.Columns["MaKyThi"].HeaderText = "Mã Kỳ Thi";
            dgvDSKyThi.Columns["TenKyThi"].HeaderText = "Tên Kỳ Thi";
            dgvDSKyThi.Columns["NgayThi"].HeaderText = "Ngày Thi";
            dgvDSKyThi.Columns["GioThi"].HeaderText = "Giờ Thi";
            dgvDSKyThi.Columns["MaPhongThi"].HeaderText = "Mã Phòng Thi";
            dgvDSKyThi.Columns["MaDeThi"].HeaderText = "Mã Đề Thi";
            dgvDSKyThi.Columns["MaLoaiKyThi"].HeaderText = "Mã Loại Kỳ Thi";
            dgvDSKyThi.Columns["MaLop"].HeaderText = "Mã Lớp";
            dgvDSKyThi.ClearSelection();



            //combobox DeThi
            _dtdethi = _objdethibus.GetAllTen_DeThi_TheoMa_LoaiDeThi(_objloaidethibus.GetMa_TheoTen_LoaiDeThi(cbbLoaiDeThi.Text));
            cbbDeThi.DataSource = _dtdethi;
            cbbDeThi.DisplayMember = "TenDeThi";
            lblLoaiKyThi.Text = cbbLoaiKyThi.Text;
            lblLoaiKyThi.Visible = true;
        }
        private void fThemKyThi_Load(object sender, EventArgs e)
        {
            //combo box LoaiKyThi
            _dtloaikythi = _objloaikythibus.GetAllLoaiKyThi();
            cbbLoaiKyThi.DataSource = _dtloaikythi;
            cbbLoaiKyThi.ValueMember = "MaLoaiKyThi";
            cbbLoaiKyThi.DisplayMember = "TenLoaiKyThi";
            cbbLoaiKyThi.SelectedIndex = -1;

            //combobox LoaiDeThi
            _dtloaidethi = _objloaidethibus.GetAllLoaiDeThi();
            cbbLoaiDeThi.DataSource = _dtloaidethi;
            cbbLoaiDeThi.ValueMember = "MaLoaiDeThi";
            cbbLoaiDeThi.DisplayMember = "TenLoaiDeThi";
            cbbLoaiDeThi.SelectedIndex = -1;

            //combobox PhongHoc
            _dtphonghoc = _objphonghocbus.GetAllPhongHoc();
            cbbPhongThi.DataSource = _dtphonghoc;
            cbbPhongThi.ValueMember = "MaPhong";
            cbbPhongThi.DisplayMember = "TenPhong";
            cbbPhongThi.SelectedIndex = -1;

            //combobox LopHoc
            _dtlop = _objlopbus.GetAllLop();
            cbbLop.DataSource = _dtlop;
            cbbLop.ValueMember = "MaLop";
            cbbLop.DisplayMember = "TenLop";
            cbbLop.SelectedIndex = -1;


            LoadData();
        }

        private void cbbLoaiDeThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();


        }

        private void cbbLoaiKyThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        public void resetbox()
        {
            txtTenKyThi.Text = "";
            cbbLoaiDeThi.SelectedIndex = -1;
            cbbLop.SelectedIndex = -1;
            dtGioThi.Text = "";
            dtNgayThi.Text = "";
            cbbPhongThi.SelectedIndex = -1;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbLoaiKyThi.SelectedIndex == -1 || txtTenKyThi.Text == "" || cbbDeThi.SelectedIndex == -1 || cbbLoaiDeThi.SelectedIndex == -1 || cbbLop.SelectedIndex == -1 || dtGioThi.Text == "" || dtNgayThi.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin!!!");
                    return;
                }
                dgvKyThi.Rows.Add(dgvKyThi.Rows.Count + 1, txtTenKyThi.Text, cbbLoaiDeThi.Text, cbbDeThi.Text, cbbLop.Text, dtNgayThi.Text, dtGioThi.Text, cbbPhongThi.Text);
                dgvKyThi.ClearSelection();
                resetbox();
            }
            catch
            {

            }
        }

        private void dgvKyThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenKyThi.Text = dgvKyThi.CurrentRow.Cells[1].Value.ToString();
            cbbLoaiDeThi.Text = dgvKyThi.CurrentRow.Cells[2].Value.ToString();
            cbbDeThi.Text = dgvKyThi.CurrentRow.Cells[3].Value.ToString();
            cbbLop.Text = dgvKyThi.CurrentRow.Cells[4].Value.ToString();
            dtNgayThi.Text = dgvKyThi.CurrentRow.Cells[5].Value.ToString();
            dtGioThi.Text = dgvKyThi.CurrentRow.Cells[6].Value.ToString();
            cbbPhongThi.Text = dgvKyThi.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbLoaiKyThi.SelectedIndex == -1 || txtTenKyThi.Text == "" || cbbDeThi.SelectedIndex == -1 || cbbLoaiDeThi.SelectedIndex == -1 || cbbLop.SelectedIndex == -1 || dtGioThi.Text == "" || dtNgayThi.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin!!!");
                    return;
                }
                dgvKyThi.CurrentRow.Cells[1].Value = txtTenKyThi.Text;
                dgvKyThi.CurrentRow.Cells[2].Value = cbbLoaiDeThi.Text;
                dgvKyThi.CurrentRow.Cells[3].Value = cbbDeThi.Text;
                dgvKyThi.CurrentRow.Cells[4].Value = cbbLop.Text;
                dgvKyThi.CurrentRow.Cells[5].Value = dtNgayThi.Text;
                dgvKyThi.CurrentRow.Cells[6].Value = dtGioThi.Text;
                dgvKyThi.CurrentRow.Cells[7].Value = cbbPhongThi.Text;
                dgvKyThi.ClearSelection();
                resetbox();

            }
            catch
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKyThi.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvKyThi.SelectedRows)
                    if (!row.IsNewRow) dgvKyThi.Rows.Remove(row);
                resetbox();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dòng cần xóa");
                return;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dgvKyThi.Rows.Count > 0)
            {
                for (int i = 0; i < dgvKyThi.Rows.Count; i++)
                {
                    _objkythi = new KyThi(_objkythibus.KyThi_NextID(),
                        dgvKyThi.Rows[i].Cells[1].Value.ToString(),
                        _objloaidethibus.GetMa_TheoTen_LoaiDeThi(dgvKyThi.Rows[i].Cells[2].Value.ToString()),
                        _objdethibus.GetMa_TheoTen_DeThi(dgvKyThi.Rows[i].Cells[3].Value.ToString()),
                        _objlopbus.GetMa_TheoTen_LopHoc(dgvKyThi.Rows[i].Cells[4].Value.ToString()),
                        dgvKyThi.Rows[i].Cells[5].Value.ToString(),
                        dgvKyThi.Rows[i].Cells[6].Value.ToString(),
                        _objphonghocbus.GetMa_TheoTen_PhongHoc(dgvKyThi.Rows[i].Cells[7].Value.ToString()),
                        _objloaikythibus.GetMa_TheoTen_LoaiKyThi(cbbLoaiKyThi.Text));
                    if (_objkythibus.AddKyThi(_objkythi))
                    {
                        dgvKyThi.Rows.Remove(dgvKyThi.Rows[i]);
                        i--;
                        LoadData();
                        resetbox();
                    }
                    else
                    {
                        string a = dgvKyThi.Rows[i].Cells[0].Value.ToString();
                        MessageBox.Show("Lưu dòng " + a + "thất bại!!!");
                    }

                    if (dgvKyThi.Rows.Count == 0)
                    {
                        MessageBox.Show("Lưu thành công!!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để lưu!!!");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
