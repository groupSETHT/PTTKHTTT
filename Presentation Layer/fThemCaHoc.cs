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
    public partial class fThemCaHoc : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        CaHocBUS _objcahocbus = new CaHocBUS();
        CaHoc _objcahoc;
        DataTable _dtcahoc;
        public fThemCaHoc()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void reset()
        {
            txtTenCa.Text = "";
            dtpGioBatDau.ResetText();
            dtpGioKetThuc.ResetText();
        }
        public void LoadData()
        {
            _dtcahoc = _objcahocbus.GetAllCaHoc();
            dgvDSCaHocDaCo.DataSource = _dtcahoc;
            dgvDSCaHocDaCo.RowHeadersVisible = true;
            _dtcahoc.Columns.Add("STT");
            for (int i = 0; i < _dtcahoc.Rows.Count; i++)
                _dtcahoc.Rows[i]["STT"] = i + 1;
            dgvDSCaHocDaCo.Columns["STT"].DisplayIndex = 0;
            dgvDSCaHocDaCo.Columns["MaCa"].HeaderText = "Mã Ca";
            dgvDSCaHocDaCo.Columns["TenCa"].HeaderText = "Tên Ca Học";
            dgvDSCaHocDaCo.Columns["GioBatDau"].HeaderText = "Giờ Bắt Đầu ";
            dgvDSCaHocDaCo.Columns["GioKetThuc"].HeaderText = "Giờ Kết Thúc";
            dgvDSCaHocDaCo.ClearSelection();

        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                DateTime a = DateTime.Parse(dtpGioBatDau.Value.ToShortTimeString());
                DateTime b = DateTime.Parse(dtpGioKetThuc.Value.ToShortTimeString());

                if ((txtTenCa.Text == "") || (dtpGioBatDau.Text == "") || (dtpGioKetThuc.Text == ""))
                {
                    MessageBox.Show("Bạn còn số liệu chưa nhập ");
                    return;
                }
                if (a > b)
                {
                    MessageBox.Show("Giờ bắt đầu học phải nhỏ hơn giờ kết thúc học  ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgvDSCaHoc.Rows.Add(dgvDSCaHoc.Rows.Count + 1, txtTenCa.Text, dtpGioBatDau.Text, dtpGioKetThuc.Text);
                dgvDSCaHoc.ClearSelection();
                reset();

            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai thông tin khóa học  , vui lòng nhập lại  !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    DateTime a = DateTime.Parse(dtpGioBatDau.Value.ToShortTimeString());
                    DateTime b = DateTime.Parse(dtpGioKetThuc.Value.ToShortTimeString());

                    if ((txtTenCa.Text == "") || (dtpGioBatDau.Text == "") || (dtpGioKetThuc.Text == ""))
                    {
                        MessageBox.Show("Bạn còn số liệu chưa nhập ");
                        return;
                    }
                    if (a > b)
                    {
                        MessageBox.Show("Giờ bắt đầu học phải nhỏ hơn giờ kết thúc học  ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    dgvDSCaHoc.CurrentRow.Cells[1].Value = txtTenCa.Text;
                    dgvDSCaHoc.CurrentRow.Cells[2].Value = dtpGioBatDau.Text;
                    dgvDSCaHoc.CurrentRow.Cells[3].Value = dtpGioKetThuc.Text;
                    reset();
                    MessageBox.Show("Cập nhật thành công ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Cập nhật không thành công ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai thông tin khóa học  , vui lòng nhập lại  !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewX1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvDSCaHoc.Rows[e.RowIndex];

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
            int icountSelectedRow = dgvDSCaHoc.SelectedRows.Count;
            if (icountSelectedRow > 0)
            {
                foreach (DataGridViewRow row in dgvDSCaHoc.SelectedRows)
                    if (!row.IsNewRow) dgvDSCaHoc.Rows.Remove(row);
                reset();
            }
            else
            {
                MessageBox.Show("Bạn phải chọn một dòng để xóa");
                return;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
     
            if (dgvDSCaHoc.Rows.Count > 0)
            {
                for (int i = 0; i < dgvDSCaHoc.Rows.Count; i++)
                {
                   string maca, tenca, giobatdau, gioketthuc;
                   maca = _objcahocbus.NextIDCaHoc();
                   tenca = dgvDSCaHoc.Rows[i].Cells[1].Value.ToString();
                   giobatdau = dgvDSCaHoc.Rows[i].Cells[2].Value.ToString();
                   gioketthuc = dgvDSCaHoc.Rows[i].Cells[3].Value.ToString();
                    _objcahoc = new CaHoc(maca,tenca,giobatdau,gioketthuc);

                    if (_objcahocbus.AddCaHoc(_objcahoc))
                    {
                        dgvDSCaHoc.Rows.Remove(dgvDSCaHoc.Rows[i]);
                        i--;
                        LoadData();
                    }
                    else
                    {
                        string a = dgvDSCaHoc.Rows[i].Cells[0].Value.ToString();
                        MessageBox.Show("Lưu dòng " + a + " thất bại");
                    }

                }


                if (dgvDSCaHoc.Rows.Count == 0)
                    MessageBox.Show("Lưu thành công");

                txtTenCa.Text = "";
                dtpGioBatDau.Text = "";
                dtpGioKetThuc.Text = "";
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để lưu ! ", "Thống báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void fThemCaHoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}