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
    
    public partial class fSuaPhongHoc : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        PhongHoc _objphonghoc ;
        PhongHocBUS _objphonghocbus = new PhongHocBUS();
        DataTable _dtph;
        public void LoadData()
        {
            _dtph = _objphonghocbus.GetAllPhongHoc();
            dgvDSPhongHoc.DataSource = _dtph;
            dgvDSPhongHoc.RowHeadersVisible = true;
            _dtph.Columns.Add("STT");
            for (int i = 0; i < _dtph.Rows.Count; i++)
                _dtph.Rows[i]["STT"] = i + 1;
            dgvDSPhongHoc.Columns["STT"].DisplayIndex = 0;
            dgvDSPhongHoc.Columns["MaPhong"].HeaderText = "Mã Phòng";
            dgvDSPhongHoc.Columns["TenPhong"].HeaderText = "Tên Phòng";
            dgvDSPhongHoc.Columns["DiaDiem"].HeaderText = "Địa điểm ";
            dgvDSPhongHoc.ClearSelection();

        }

        public fSuaPhongHoc()
        {
            InitializeComponent();
        }

        private void fSuaPhongHoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if(txtPhongFind.Text != "")
            {
                  DataTable _dtphonghocfind;
                _dtphonghocfind = _objphonghocbus.Find_PhongHoc(txtPhongFind.Text);
                if (_dtphonghocfind.Rows.Count >0)
                {
                    dgvDSPhongHoc.DataSource = _dtphonghocfind;
                    dgvDSPhongHoc.RowHeadersVisible = true;
                    _dtphonghocfind.Columns.Add("STT");
                    for (int i = 0; i < _dtphonghocfind.Rows.Count; i++)
                        _dtphonghocfind.Rows[i]["STT"] = i + 1;
                    dgvDSPhongHoc.Columns["STT"].DisplayIndex = 0;
                    dgvDSPhongHoc.Columns["STT"].Width = 20;
                    dgvDSPhongHoc.Columns["MaPhong"].HeaderText = "Mã Lớp";
                    dgvDSPhongHoc.Columns["TenPhong"].HeaderText = "Tên Lớp";
                    dgvDSPhongHoc.Columns["DiaDiem"].HeaderText = "Tên Khóa Học";
                    dgvDSPhongHoc.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy lớp " + txtPhongFind.Text, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập tên phòng cần tìm . ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvDSPhongHoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvDSPhongHoc.Rows[e.RowIndex];
                txtPhong.Text = row.Cells[1].Value.ToString();
                txtDiaDiem.Text = row.Cells[2].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            _objphonghoc = new PhongHoc(dgvDSPhongHoc.CurrentRow.Cells[0].Value.ToString(), txtPhong.Text, txtDiaDiem.Text);
           
            if (_objphonghocbus.EditPhongHoc(_objphonghoc))
            {
                MessageBox.Show("Cập nhật thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                txtDiaDiem.Text = "";
                txtPhong.Text = "";
            }
            else
            {
                MessageBox.Show("Cập Nhật thất bại", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count = dgvDSPhongHoc.SelectedRows.Count;

            if (count != 0)
            {
                string _maphong = dgvDSPhongHoc.CurrentRow.Cells[0].Value.ToString();
                if (_objphonghocbus.DeletePhongHoc(_maphong))
                {
                    txtDiaDiem.Text = "";
                    txtPhong.Text = "";
                    LoadData();
                    MessageBox.Show("Xóa thành công", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Lớp học này  đã được tổ chức bạn phải xóa kì thi hoặc hoặc viên liên quan trước khi xóa lớp này", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Bạn chưa chon dòng cần xóa", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}