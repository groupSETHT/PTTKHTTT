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
    public partial class fSuaDeThi : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        LoaiDeThiBUS _objloaidethibus = new LoaiDeThiBUS();
        DataTable _dtloaidethi;
        DeThi _objdethi;
        DeThiBUS _objdethibus = new DeThiBUS();
        DataTable _dtdethi;
        public fSuaDeThi()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            _dtdethi = _objdethibus.GetAllDeThi_TheoMaLoaiDeThi(_objloaidethibus.GetMa_TheoTen_LoaiDeThi(cbbLoaiDeThi.Text));
            dgvDSDeThi.DataSource = _dtdethi;
            dgvDSDeThi.RowHeadersVisible = false;
            _dtdethi.Columns.Add("STT");
            for (int i = 0; i < _dtdethi.Rows.Count; i++)
            {
                _dtdethi.Rows[i]["STT"] = i + 1;
            }
            dgvDSDeThi.Columns["STT"].DisplayIndex = 0;
            dgvDSDeThi.Columns["MaDeThi"].HeaderText = "Mã Đề Thi";
            dgvDSDeThi.Columns["TenDeThi"].HeaderText = "Tên Đề Thi";
            dgvDSDeThi.Columns["MaLoaiDeThi"].HeaderText = "Mã Loại Đề Thi";
            dgvDSDeThi.Columns["NgayLap"].HeaderText = "Ngày Lập";
            dgvDSDeThi.ClearSelection();
            lbLoaiDeThi.Text = cbbLoaiDeThi.Text;
            lbLoaiDeThi.Visible = true;

        }
        private void fSuaDeThi_Load(object sender, EventArgs e)
        {
            //combo box Loai De Thi
            _dtloaidethi = _objloaidethibus.GetAllLoaiDeThi();
            cbbLoaiDeThi.DataSource = _dtloaidethi;
            cbbLoaiDeThi.ValueMember = "MaLoaiDeThi";
            cbbLoaiDeThi.DisplayMember = "TenLoaiDeThi";
            cbbLoaiDeThi.SelectedIndex = -1;
            LoadData();
        }
        public void resetbox()
        {
            txtTenDeThi.Text = "";
            dtNgayLap.Text = "";
        }
        private void cbbLoaiDeThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
            resetbox();
        }

        private void dgvDSDeThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenDeThi.Text = dgvDSDeThi.CurrentRow.Cells[1].Value.ToString();
            dtNgayLap.Text = dgvDSDeThi.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDSDeThi.RowCount > 0)
            {
                if (dgvDSDeThi.SelectedRows.Count > 0)
                {
                    if (cbbLoaiDeThi.SelectedIndex == -1 || txtTenDeThi.Text == "" || dtNgayLap.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!!!");
                        return;
                    }
                    _objdethi = new DeThi(dgvDSDeThi.CurrentRow.Cells[0].Value.ToString(),
                        txtTenDeThi.Text,
                        dgvDSDeThi.CurrentRow.Cells[2].Value.ToString(),
                        dtNgayLap.Text);
                    if (_objdethibus.EditDeThi(_objdethi))
                    {
                        MessageBox.Show("Sửa thành công!!!");
                        LoadData();
                        resetbox();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn dòng cần sửa!!!");
                    return;
                }

            }
            else
            {
                MessageBox.Show("Không có dữ liệu để sửa!!!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (dgvDSDeThi.SelectedRows.Count != 0)
            {
                   if( _objdethibus.DeleteDeThi(dgvDSDeThi.CurrentRow.Cells[0].Value.ToString()))
                   {
                       MessageBox.Show("Xóa thành công!!!");
                       LoadData();
                       resetbox();
                   }
                   else
                   {
                       MessageBox.Show("Đề thi đang được sử dụng ở kỳ thi nên không xóa được!!!");
                   }
            }

            else
            {
                MessageBox.Show("Chưa chọn dòng cần xóa!!!");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}