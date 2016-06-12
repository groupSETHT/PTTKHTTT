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
    public partial class fSuaKhoaHoc : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        KhoaHocBUS _objkhoahocbus = new KhoaHocBUS();
        KhoaHoc _objkhoahoc;
        DataTable _dtkhoahoc;

        public fSuaKhoaHoc()
        {
            InitializeComponent();
        }
        public Form RefToMainForm { set; get; }
        public void LoadData()
        {
            _dtkhoahoc = _objkhoahocbus.GetAllKhoaHoc();
            dataGridViewX1.DataSource = _dtkhoahoc;
            dataGridViewX1.RowHeadersVisible = true;
            _dtkhoahoc.Columns.Add("STT");
            for (int i = 0; i < _dtkhoahoc.Rows.Count; i++)
                _dtkhoahoc.Rows[i]["STT"] = i + 1;
            dataGridViewX1.Columns["STT"].DisplayIndex = 0;
            dataGridViewX1.Columns["MaKhoaHoc"].HeaderText = "Mã Khóa Học";
            dataGridViewX1.Columns["MaKhoaHoc"].Width = 130;
            dataGridViewX1.Columns["TenKhoaHoc"].HeaderText = "Tên Khóa Học";
            dataGridViewX1.Columns["TenKhoaHoc"].Width = 130;
            dataGridViewX1.Columns["HocPhi"].HeaderText = "Học Phí";
            dataGridViewX1.Columns["HocPhi"].Width = 130;
            dataGridViewX1.ClearSelection();
        }

        private void fSuaKhoaHoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridViewX1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridViewX1.Rows[e.RowIndex];
                txttenkhoahoc.Text = row.Cells[1].Value.ToString();
                txthocphi.Text = row.Cells[2].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.RowCount > 0)
            {
                if (txthocphi.Text == "" || txttenkhoahoc.Text == "")
                {
                    MessageBox.Show("Bạn còn thiếu thông tin nhập vào ! ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                double _temp_hocphi = double.Parse(txthocphi.Text);
                if (_temp_hocphi <= 0)
                    MessageBox.Show("Học phí của một khóa học phải lớn hơn 0 ! ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _objkhoahoc = new KhoaHoc(dataGridViewX1.CurrentRow.Cells[0].Value.ToString(), txttenkhoahoc.Text, double.Parse(txthocphi.Text));
                if (_objkhoahocbus.EditKhoaHoc(_objkhoahoc))
                {
                    LoadData();
                    MessageBox.Show("Sửa Thành Công Khóa Học " + dataGridViewX1.CurrentRow.Cells[0].Value.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Sửa Thất Bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không có Khóa học để sữa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count = dataGridViewX1.SelectedRows.Count;

            if (count != 0)
            {

                if (_objkhoahocbus.DeleteKhoaHoc(dataGridViewX1.CurrentRow.Cells[0].Value.ToString()))
                {
                    LoadData();
                    MessageBox.Show("Xóa thành công");

                }
                else
                    MessageBox.Show("Khóa học  này đã được tổ chức bạn phải xóa tất cả các chương trình học,lớp học  liên quan nến khóa học này trước ! ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Bạn chưa chon dòng cần xóa","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}