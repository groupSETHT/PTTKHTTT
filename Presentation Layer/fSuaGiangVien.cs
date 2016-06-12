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
    public partial class fSuaGiangVien : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        GiangVien _objgiangvien;
        GiangVienBUS _objgiangvienbus = new GiangVienBUS();
        DataTable _dtgiangvien;
        public fSuaGiangVien()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            _dtgiangvien = _objgiangvienbus.GetAllGiangVien();
            dataGridViewX1.DataSource = _dtgiangvien;
            dataGridViewX1.RowHeadersVisible = false;
            _dtgiangvien.Columns.Add("STT");
            for (int i = 0; i < _dtgiangvien.Rows.Count; i++)
            {
                _dtgiangvien.Rows[i]["STT"] = i + 1;
            }
            dataGridViewX1.Columns["STT"].DisplayIndex = 0;          
            dataGridViewX1.Columns["MaGV"].HeaderText = "Mã Giảng Viên";           
            dataGridViewX1.Columns["TenGV"].HeaderText = "Tên Giảng Viên";
            dataGridViewX1.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dataGridViewX1.Columns["GioiTinh"].HeaderText = "Giới Tính";
           dataGridViewX1.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            //set width for DataGridView's cells
           dataGridViewX1.Columns["STT"].Width = 30;
           dataGridViewX1.Columns["MaGV"].Width = 60;
           dataGridViewX1.Columns["GioiTinh"].Width = 40;
            dataGridViewX1.ClearSelection();
        }

        private void fSuaGV_Load(object sender, EventArgs e)
        {
            LoadData();
            dataGridViewX1.RowHeadersVisible = false;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable _dtTimGV = _objgiangvienbus.TimTen_GiangVien(txtTimGV.Text);
            dataGridViewX1.DataSource = _dtTimGV;
            dataGridViewX1.RowHeadersVisible = false;
            _dtTimGV.Columns.Add("STT");
            for (int i = 0; i < _dtTimGV.Rows.Count; i++)
            {
                _dtTimGV.Rows[i]["STT"] = i + 1;
            }
            dataGridViewX1.Columns["STT"].DisplayIndex = 0;
            dataGridViewX1.Columns["MaGV"].HeaderText = "Mã Giảng Viên";
            dataGridViewX1.Columns["TenGV"].HeaderText = "Tên Giảng Viên";
            dataGridViewX1.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dataGridViewX1.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dataGridViewX1.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            //set width for DataGridView's cells
            dataGridViewX1.Columns["STT"].Width = 30;
            dataGridViewX1.Columns["MaGV"].Width = 60;
            dataGridViewX1.Columns["GioiTinh"].Width = 40;
            dataGridViewX1.ClearSelection();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenGV.Text = dataGridViewX1.CurrentRow.Cells[1].Value.ToString();
            dtNgaySinh.Text = dataGridViewX1.CurrentRow.Cells[2].Value.ToString();
            cbGioiTinh.Text = dataGridViewX1.CurrentRow.Cells[3].Value.ToString();
            txtSDT.Text = dataGridViewX1.CurrentRow.Cells[4].Value.ToString();
            txtDiaChi.Text = dataGridViewX1.CurrentRow.Cells[5].Value.ToString();
        }
        void resetbox()
        {
            txtTenGV.Text = "";
            dtNgaySinh.Text = "";
            cbGioiTinh.SelectedIndex = -1;
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtTimGV.Text = "";
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.RowCount > 0)
            {
                if (txtTenGV.Text == "" || dtNgaySinh.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "" || cbGioiTinh.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn còn số liệu chưa nhập ");
                    return;
                }
                _objgiangvien = new GiangVien(dataGridViewX1.CurrentRow.Cells[0].Value.ToString(),
                    txtTenGV.Text,
                    dtNgaySinh.Text,
                    cbGioiTinh.Text,
                    txtSDT.Text,
                    txtDiaChi.Text);
                if (_objgiangvienbus.EditGiangVien(_objgiangvien))
                {
                    MessageBox.Show("Sửa Thành Công Giảng Viên " + dataGridViewX1.CurrentRow.Cells[1].Value.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Không có Thông tin Giảng Viên để sữa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count = dataGridViewX1.SelectedRows.Count;
            if (count != 0)
            {
                if (_objgiangvienbus.DeleteGiangVien(dataGridViewX1.CurrentRow.Cells[0].Value.ToString()))
                {
                    LoadData();
                    resetbox();
                    MessageBox.Show("Xóa thành công!!!");
                }
                else
                {
                    MessageBox.Show("Giảng Viên đang dạy trong lớp khác bạn không thể xóa!!!");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chon dòng cần xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}