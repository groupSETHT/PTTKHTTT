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
    public partial class fThemPhongHoc : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        PhongHoc _objphonghoc;
        PhongHocBUS _objphonghocbus = new PhongHocBUS();
        DataTable _dtphonghoc;
        public fThemPhongHoc()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            _dtphonghoc = _objphonghocbus.GetAllPhongHoc();
            dgvDSPhongHocDaCo.DataSource = _dtphonghoc;
            dgvDSPhongHocDaCo.RowHeadersVisible = true;
            _dtphonghoc.Columns.Add("STT");
            for (int i = 0; i < _dtphonghoc.Rows.Count; i++)
                _dtphonghoc.Rows[i]["STT"] = i + 1;
            dgvDSPhongHocDaCo.Columns["STT"].DisplayIndex = 0;
            dgvDSPhongHocDaCo.Columns["MaPhong"].HeaderText = "Mã Phòng";
            dgvDSPhongHocDaCo.Columns["TenPhong"].HeaderText = "Tên Phòng";
            dgvDSPhongHocDaCo.Columns["DiaDiem"].HeaderText = "Địa Điểm ";
            dgvDSPhongHocDaCo.ClearSelection();
        }
        public void reset()
        {
            txtDiaDiem.Text = "";
            txtPhongHoc.Text = "";
        }
        private void fThemPhongHoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {


                if ((txtDiaDiem.Text == "") || (txtPhongHoc.Text == ""))
                {
                    MessageBox.Show("Bạn còn số liệu chưa nhập ");
                    return;
                }
                dgvDSPhongHoc.Rows.Add(dgvDSPhongHoc.Rows.Count + 1, txtPhongHoc.Text, txtDiaDiem.Text);
                dgvDSPhongHoc.ClearSelection();
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
                if (txtPhongHoc.Text == "" || txtDiaDiem.Text == "")
                {
                    MessageBox.Show("Bạn còn số liệu chưa nhập ", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dgvDSPhongHoc.CurrentRow.Cells[1].Value = txtPhongHoc.Text;
                dgvDSPhongHoc.CurrentRow.Cells[2].Value = txtDiaDiem.Text;


                reset();
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai thông tin Phòng học , vui lòng nhập lại  !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDSPhongHoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvDSPhongHoc.Rows[e.RowIndex];
                txtPhongHoc.Text = row.Cells[1].Value.ToString();
                txtDiaDiem.Text = row.Cells[2].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int icountSelectedRow = dgvDSPhongHoc.SelectedRows.Count;
            if (icountSelectedRow > 0)
            {
                foreach (DataGridViewRow row in dgvDSPhongHoc.SelectedRows)
                    if (!row.IsNewRow) dgvDSPhongHoc.Rows.Remove(row);
                reset();
            }
            else
            {
                MessageBox.Show("Bạn phải chọn một dòng để xóa");
                return;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dgvDSPhongHoc.Rows.Count > 0)
            {
                for (int i = 0; i < dgvDSPhongHoc.Rows.Count; i++)
                {
                    string maphong, tenphong, diadiem;
                    maphong = _objphonghocbus.NextID();
                    tenphong = dgvDSPhongHoc.Rows[i].Cells[1].Value.ToString();
                    diadiem = dgvDSPhongHoc.Rows[i].Cells[2].Value.ToString();

                    _objphonghoc = new PhongHoc(maphong, tenphong, diadiem);

                    if (_objphonghocbus.AddPhongHoc(_objphonghoc))
                    {
                        dgvDSPhongHoc.Rows.Remove(dgvDSPhongHoc.Rows[i]);
                        i--;
                        LoadData();
                    }
                    else
                    {
                        string a = dgvDSPhongHoc.Rows[i].Cells[0].Value.ToString();
                        MessageBox.Show("Lưu dòng " + a + " thất bại");
                    }

                }


                if (dgvDSPhongHoc.Rows.Count == 0)
                    MessageBox.Show("Lưu thành công");

                reset();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để lưu ! ", "Thống báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }




    }
}