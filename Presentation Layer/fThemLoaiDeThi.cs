using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms;
using DTO;
using BUS;
namespace Presentation_Layer
{
    public partial class fThemLoaiDeThi : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        LoaiDeThiBUS _objloaidethibus = new LoaiDeThiBUS();
        LoaiDeThi _objloaidethi;
        DataTable _dtldt;
        public fThemLoaiDeThi()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            _dtldt = _objloaidethibus.GetAllLoaiDeThi();
            dgvDSLoaiDeThiDaCo.DataSource = _dtldt;
            dgvDSLoaiDeThiDaCo.RowHeadersVisible = true;
            _dtldt.Columns.Add("STT");
            for (int i = 0; i < _dtldt.Rows.Count; i++)
                _dtldt.Rows[i]["STT"] = i + 1;
            dgvDSLoaiDeThiDaCo.Columns["STT"].DisplayIndex = 0;
            dgvDSLoaiDeThiDaCo.Columns["MaLoaiDeThi"].HeaderText = "Mã Loại Đề Thi";
            dgvDSLoaiDeThiDaCo.Columns["TenLoaiDeThi"].HeaderText = "Tên Loại Đề Thi";
            dgvDSLoaiDeThiDaCo.Columns["ThoiLuongThi"].HeaderText = "Thời Lượng Thi ";
            dgvDSLoaiDeThiDaCo.ClearSelection();

        }
        public void resetbox()
        {
            txtThoiLuong.Text = "";
            txtTenLoaiDeThi.Text = "";
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenLoaiDeThi.Text == "" || txtThoiLuong.Text == "")
                {
                    MessageBox.Show("Bạn còn số liệu chưa nhập ");
                    return;
                }
                dgvDSLoaiDeThi.Rows.Add(dgvDSLoaiDeThi.Rows.Count + 1,txtTenLoaiDeThi.Text,txtThoiLuong.Text);
                dgvDSLoaiDeThi.ClearSelection();
                resetbox();
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai thông tin khóa học  , vui lòng nhập lại  !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDSLoaiDeThi_CellMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenLoaiDeThi.Text == "" || txtThoiLuong.Text == "")
                {
                    MessageBox.Show("Bạn còn số liệu chưa nhập ");
                    return;
                }
                dgvDSLoaiDeThi.CurrentRow.Cells[1].Value = txtTenLoaiDeThi.Text;
                dgvDSLoaiDeThi.CurrentRow.Cells[2].Value = txtThoiLuong.Text;


                dgvDSLoaiDeThi.ClearSelection();
                resetbox();
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai thông tin khóa học  , vui lòng nhập lại  !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            int icountSelectedRow = dgvDSLoaiDeThi.SelectedRows.Count;
            if (icountSelectedRow > 0)
            {
                foreach (DataGridViewRow row in dgvDSLoaiDeThi.SelectedRows)
                    if (!row.IsNewRow)
                    {
                        dgvDSLoaiDeThi.Rows.Remove(row);
                    }
                resetbox();
            }
            else
            {
                MessageBox.Show("Bạn phải chọn một dòng để xóa");
                return;
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (dgvDSLoaiDeThi.Rows.Count > 0)
            {
                for (int i = 0; i < dgvDSLoaiDeThi.Rows.Count; i++)
                {
                    _objloaidethi = new LoaiDeThi(_objloaidethibus.Next_ID_LoaiKyThi(),
                        dgvDSLoaiDeThi.Rows[i].Cells[1].Value.ToString(),
                       int.Parse(dgvDSLoaiDeThi.Rows[i].Cells[2].Value.ToString()));
                    
                    if (_objloaidethibus.AddLoaiDeThi(_objloaidethi))
                    {
                        dgvDSLoaiDeThi.Rows.Remove(dgvDSLoaiDeThi.Rows[i]);
                        i--;
                        LoadData();
                    }
                    else
                    {
                        string a = dgvDSLoaiDeThi.Rows[i].Cells[0].Value.ToString();
                        MessageBox.Show("Lưu dòng " + a + " thất bại");
                    }
                    if (dgvDSLoaiDeThi.Rows.Count == 0)
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

        private void dgvDSLoaiDeThi_CellMouseClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
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

        private void fThemLoaiDeThi_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}