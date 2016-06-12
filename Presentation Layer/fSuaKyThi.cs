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
    public partial class fSuaKyThi : DevComponents.DotNetBar.Metro.MetroAppForm
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
        public fSuaKyThi()
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




            lblLoaiKyThi.Text = cbbLoaiKyThi.Text;
        }

        private void fSuaKyThi_Load(object sender, EventArgs e)
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
            dgvDSKyThi.RowHeadersVisible = false;
        }

        private void cbbLoaiDeThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combobox DeThi
            _dtdethi = _objdethibus.GetAllTen_DeThi_TheoMa_LoaiDeThi(_objloaidethibus.GetMa_TheoTen_LoaiDeThi(cbbLoaiDeThi.Text));
            cbbDeThi.DataSource = _dtdethi;
            cbbDeThi.DisplayMember = "TenDeThi";


        }

        private void cbbLoaiKyThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
            resetbox();
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

        private void dgvDSKyThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenKyThi.Text = dgvDSKyThi.CurrentRow.Cells[1].Value.ToString();
            cbbLoaiDeThi.Text=_objloaidethibus.GetTen_TheoMa_LoaiDeThi(dgvDSKyThi.CurrentRow.Cells[2].Value.ToString());
            cbbDeThi.Text = _objdethibus.GetTen_TheoMa_DeThi(dgvDSKyThi.CurrentRow.Cells[3].Value.ToString());
            cbbLop.Text = _objlopbus.GetTen_TheoMa_LopHoc(dgvDSKyThi.CurrentRow.Cells[4].Value.ToString());
            dtNgayThi.Text = dgvDSKyThi.CurrentRow.Cells[5].Value.ToString();
            dtGioThi.Text = dgvDSKyThi.CurrentRow.Cells[6].Value.ToString();
            cbbPhongThi.Text = _objphonghocbus.GetTen_TheoMa_PhongHoc(dgvDSKyThi.CurrentRow.Cells[7].Value.ToString());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvDSKyThi.RowCount>0)
            {
                if (cbbLoaiKyThi.SelectedIndex == -1 || txtTenKyThi.Text == "" || cbbDeThi.SelectedIndex == -1 || cbbLoaiDeThi.SelectedIndex == -1 || cbbLop.SelectedIndex == -1 || dtGioThi.Text == "" || dtNgayThi.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin!!!");
                    return;
                }
                _objkythi = new KyThi(dgvDSKyThi.CurrentRow.Cells[0].Value.ToString(),
                    txtTenKyThi.Text,
                    _objloaidethibus.GetMa_TheoTen_LoaiDeThi(cbbLoaiDeThi.Text),
                    _objdethibus.GetMa_TheoTen_DeThi(cbbDeThi.Text),
                    _objlopbus.GetMa_TheoTen_LopHoc(cbbLop.Text),
                    dtNgayThi.Text,
                    dtGioThi.Text,
                    _objphonghocbus.GetMa_TheoTen_PhongHoc(cbbPhongThi.Text),
                    _objloaikythibus.GetMa_TheoTen_LoaiKyThi(cbbLoaiKyThi.Text));
                if(_objkythibus.EditKyThi(_objkythi))
                {
                    MessageBox.Show("Sửa Thành Công!!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    resetbox();
                }
                else
                {
                    MessageBox.Show("Sửa Thất Bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Không có dữ liệu để sửa!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvDSKyThi.SelectedRows.Count!=0)
            {
                if(_objkythibus.DeleteKyThi(dgvDSKyThi.CurrentRow.Cells[0].Value.ToString()))
                {
                    MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    resetbox();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dòng cần xóa!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}