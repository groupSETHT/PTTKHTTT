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
    public partial class fSuaCaHoc : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        CaHocBUS _objcahocbus = new CaHocBUS();
        CaHoc _objcahoc;
        DataTable _dtcahoc;
        public fSuaCaHoc()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            _dtcahoc = _objcahocbus.GetAllCaHoc();
            dtgSuaCaHoc.DataSource = _dtcahoc;
            dtgSuaCaHoc.RowHeadersVisible = true;
            _dtcahoc.Columns.Add("STT");
            for (int i = 0; i < _dtcahoc.Rows.Count; i++)
                _dtcahoc.Rows[i]["STT"] = i + 1;
            dtgSuaCaHoc.Columns["STT"].DisplayIndex = 0;
            dtgSuaCaHoc.Columns["MaCa"].HeaderText = "Mã Ca";
            dtgSuaCaHoc.Columns["TenCa"].HeaderText = "Tên Ca Học";
            dtgSuaCaHoc.Columns["GioBatDau"].HeaderText = "Giờ Bắt Đầu ";
            dtgSuaCaHoc.Columns["GioKetThuc"].HeaderText = "Giờ Kết Thúc";
            dtgSuaCaHoc.ClearSelection();

        }
        private void fSuaCaHoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void reset()
        {
            txtTenCa.Text = "";
            dtpGioBatDau.ResetText();
            dtpGioKetThuc.ResetText();
        }
        private void dtgSuaCaHoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgSuaCaHoc.Rows[e.RowIndex];

                txtTenCa.Text = row.Cells[1].Value.ToString();
                dtpGioBatDau.Text = row.Cells[2].Value.ToString();
                dtpGioKetThuc.Text = row.Cells[3].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            int count = dtgSuaCaHoc.SelectedRows.Count;

            if (count != 0)
            {
                string _maca = dtgSuaCaHoc.CurrentRow.Cells[0].Value.ToString();
                if (_objcahocbus.DeleteCaHoc(_maca))
                {
                    
                    LoadData();
                    MessageBox.Show("Xóa thành công", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();

                }
                else
                    MessageBox.Show("Ca Học đã có trong một số lớp học , bạn phải thay đổi ca học hoặc xóa lớp đó","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Bạn chưa chon dòng cần xóa", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgSuaCaHoc.RowCount > 0)
            {
                if (txtTenCa.Text == "" || dtpGioBatDau.Text == "" || dtpGioKetThuc.Text == "")
                {
                    MessageBox.Show("Bạn còn thiếu thông tin nhập vào ! ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime a = DateTime.Parse(dtpGioBatDau.Value.ToShortTimeString());
                DateTime b = DateTime.Parse(dtpGioKetThuc.Value.ToShortTimeString());
                if (a > b)
                {
                    MessageBox.Show("Giờ bắt đầu học phải nhỏ hơn Giờ kết thúc ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;                 
                }
                _objcahoc = new CaHoc(dtgSuaCaHoc.CurrentRow.Cells[0].Value.ToString(), txtTenCa.Text,dtpGioBatDau.Text,dtpGioKetThuc.Text);
                if (_objcahocbus.EditCaHoc(_objcahoc))
                {
                    LoadData();
                    MessageBox.Show("Sửa Thành Công Ca Học ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                }
                else
                    MessageBox.Show("Sửa Thất Bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không có Ca học để sữa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}