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
    public partial class fThemGiangVien : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        GiangVienBUS _objgiangvienbus = new GiangVienBUS();
        GiangVien _objgiangvien;
        DataTable _dtgiangvien;
        public fThemGiangVien()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            _dtgiangvien = _objgiangvienbus.GetAllGiangVien();
            dataGridViewX2.DataSource = _dtgiangvien;
            dataGridViewX2.RowHeadersVisible = false;
            _dtgiangvien.Columns.Add("STT");
            for(int i=0; i<_dtgiangvien.Rows.Count; i++)
            {
                _dtgiangvien.Rows[i]["STT"] = i + 1;
            }
            dataGridViewX2.Columns["STT"].DisplayIndex = 0;
            dataGridViewX2.Columns["MaGV"].HeaderText="Mã Giảng Viên";
            dataGridViewX2.Columns["TenGV"].HeaderText="Tên Giảng Viên";
            dataGridViewX2.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dataGridViewX2.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dataGridViewX2.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dataGridViewX2.ClearSelection();
            //set width for DataGridView's cells
            dataGridViewX2.Columns["STT"].Width = 30;
            dataGridViewX2.Columns["MaGV"].Width = 60;
            dataGridViewX2.Columns["GioiTinh"].Width = 40;

        }

        private void fThemGV_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtTenGV.Text=="" || dtNgaySinh.Text=="" || txtSDT.Text=="" || txtDiaChi.Text=="" || cbGioiTinh.SelectedIndex==-1)
                {
                    MessageBox.Show("Bạn còn số liệu chưa nhập ");
                    return;
                }
                dataGridViewX1.Rows.Add(dataGridViewX1.Rows.Count + 1, txtTenGV.Text, dtNgaySinh.Text, cbGioiTinh.Text, txtSDT.Text, txtDiaChi.Text);
                dataGridViewX1.ClearSelection();
                resetbox();
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai thông tin khóa học  , vui lòng nhập lại  !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void resetbox()
        {
            txtTenGV.Text = "";
            dtNgaySinh.Text = "";
            cbGioiTinh.SelectedIndex = -1;
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenGV.Text = dataGridViewX1.CurrentRow.Cells[1].Value.ToString();
            dtNgaySinh.Text = dataGridViewX1.CurrentRow.Cells[2].Value.ToString();
            cbGioiTinh.Text = dataGridViewX1.CurrentRow.Cells[3].Value.ToString();
            txtSDT.Text = dataGridViewX1.CurrentRow.Cells[4].Value.ToString();
            txtDiaChi.Text = dataGridViewX1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenGV.Text == "" || dtNgaySinh.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "" || cbGioiTinh.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn còn số liệu chưa nhập ");
                    return;
                }
                dataGridViewX1.CurrentRow.Cells[1].Value = txtTenGV.Text;
                dataGridViewX1.CurrentRow.Cells[2].Value = dtNgaySinh.Text;
                dataGridViewX1.CurrentRow.Cells[3].Value = cbGioiTinh.Text;
                dataGridViewX1.CurrentRow.Cells[4].Value = txtSDT.Text;
                dataGridViewX1.CurrentRow.Cells[5].Value = txtDiaChi.Text;

                dataGridViewX1.ClearSelection();
                resetbox();
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai thông tin khóa học  , vui lòng nhập lại  !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int icountSelectedRow = dataGridViewX1.SelectedRows.Count;
            if (icountSelectedRow > 0)
            {
                foreach (DataGridViewRow row in dataGridViewX1.SelectedRows)
                    if (!row.IsNewRow)
                    {
                        dataGridViewX1.Rows.Remove(row);
                    }
                resetbox();
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
                    _objgiangvien = new GiangVien(_objgiangvienbus.NextID(),
                        dataGridViewX1.Rows[i].Cells[1].Value.ToString(),
                        dataGridViewX1.Rows[i].Cells[2].Value.ToString(),
                        dataGridViewX1.Rows[i].Cells[3].Value.ToString(),
                        dataGridViewX1.Rows[i].Cells[4].Value.ToString(),
                        dataGridViewX1.Rows[i].Cells[5].Value.ToString());
                    if (_objgiangvienbus.AddGiangVien(_objgiangvien))
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
                    if (dataGridViewX1.Rows.Count == 0)
                    {
                        MessageBox.Show("Lưu thành công");
                    }
                }
            }

            else
            {
                MessageBox.Show("Không có dữ liệu để lưu ! ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}