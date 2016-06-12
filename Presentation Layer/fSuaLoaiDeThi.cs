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
    public partial class fSuaLoaiDeThi : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        LoaiDeThiBUS _objloaidethibus = new LoaiDeThiBUS();
        LoaiDeThi _objloaidethi;
        DataTable _dtldt;
        public fSuaLoaiDeThi()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            _dtldt = _objloaidethibus.GetAllLoaiDeThi();
            dgvDSLoaiDeThi.DataSource = _dtldt;
            dgvDSLoaiDeThi.RowHeadersVisible = true;
            _dtldt.Columns.Add("STT");
            for (int i = 0; i < _dtldt.Rows.Count; i++)
                _dtldt.Rows[i]["STT"] = i + 1;
            dgvDSLoaiDeThi.Columns["STT"].DisplayIndex = 0;
            dgvDSLoaiDeThi.Columns["MaLoaiDeThi"].HeaderText = "Mã Loại Đề Thi";
            dgvDSLoaiDeThi.Columns["TenLoaiDeThi"].HeaderText = "Tên Loại Đề Thi";
            dgvDSLoaiDeThi.Columns["ThoiLuongThi"].HeaderText = "Thời Lượng Thi ";
            dgvDSLoaiDeThi.ClearSelection();

        }
        public void reset()
        {
            txtTenLoaiDeThi.Text = "";
            txtThoiLuong.Text = "";
        }
        private void fSuaLoaiDeThi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvDSLoaiDeThi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvDSLoaiDeThi.Rows[e.RowIndex];
                txtTenLoaiDeThi.Text = row.Cells[1].Value.ToString();
                txtThoiLuong.Text = row.Cells[2].Value.ToString();
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
                if (txtTenLoaiDeThi.Text == "" || txtThoiLuong.Text == "")
                {
                    MessageBox.Show("Bạn còn số liệu chưa nhập ","Thông Báo ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                _objloaidethi = new LoaiDeThi(dgvDSLoaiDeThi.CurrentRow.Cells[0].Value.ToString(), txtTenLoaiDeThi.Text, int.Parse(txtThoiLuong.Text));
                if (_objloaidethibus.EditLoaiDeThi(_objloaidethi))
                {
                    LoadData();
                    MessageBox.Show("Sửa Thành Công Loaị Đề Thi ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                }
                else
                {
                    MessageBox.Show("Sửa Thất Bại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                             
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai thông tin của Loại đề thi  , vui lòng nhập lại  !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count = dgvDSLoaiDeThi.SelectedRows.Count;

            if (count != 0)
            {
                if (_objloaidethibus.DeleteLoaiDeThi(dgvDSLoaiDeThi.CurrentRow.Cells[0].Value.ToString()))
                {

                    LoadData();
                    MessageBox.Show("Xóa thành công", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();

                }
                else
                    MessageBox.Show("Loại đề thi  đã có trong một số đề thi  , bạn phải thay đổi hoặc xóa đề thi đó trước ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Bạn chưa chọn loại đề thi  cần xóa", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}