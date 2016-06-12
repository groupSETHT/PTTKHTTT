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
    public partial class fThemLoaiKyThi : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        LoaiKyThi _objloaikythi;
        LoaiKyThiBUS _objloaikythibus = new LoaiKyThiBUS();
        DataTable _dtloaikythi;
        public fThemLoaiKyThi()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            _dtloaikythi = _objloaikythibus.GetAllLoaiKyThi();
            dgvDSLoaiKyThi.DataSource = _dtloaikythi;
            dgvDSLoaiKyThi.RowHeadersVisible = false;
            _dtloaikythi.Columns.Add("STT");
            for(int i=0; i<_dtloaikythi.Rows.Count; i++)
            {
                _dtloaikythi.Rows[i]["STT"] = i + 1;
            }
            dgvDSLoaiKyThi.Columns["STT"].DisplayIndex = 0;
            dgvDSLoaiKyThi.Columns["MaLoaiKyThi"].HeaderText = "Mã Loại Kỳ Thi";
            dgvDSLoaiKyThi.Columns["TenLoaiKyThi"].HeaderText = "Loại Kỳ Thi";
            dgvDSLoaiKyThi.ClearSelection();
            //set witdth dgv's cells
            dgvDSLoaiKyThi.Columns["STT"].Width = 40;
            dgvDSLoaiKyThi.Columns["MaLoaiKyThi"].Width = 80;
            dgvDSLoaiKyThi.Columns["TenLoaiKyThi"].Width = 250;
        }

        private void fThemLoaiKyThi_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void resetbox()
        {
            txtTenLoaiKyThi.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTenLoaiKyThi.Text=="")
            {
                MessageBox.Show("Bạn còn dữ liệu chưa nhập!!!");
            }
            else
            {
                dgvThemLoaiKyThi.Rows.Add(dgvThemLoaiKyThi.Rows.Count + 1, txtTenLoaiKyThi.Text);
                dgvThemLoaiKyThi.ClearSelection();
                resetbox();
            }
        }
        private void dgvThemLoaiKyThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenLoaiKyThi.Text = dgvThemLoaiKyThi.CurrentRow.Cells[1].Value.ToString();
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenLoaiKyThi.Text == "")
                {
                    MessageBox.Show("Bạn còn dữ liệu chưa nhập!!!");
                }
                else
                {
                    dgvThemLoaiKyThi.CurrentRow.Cells[1].Value = txtTenLoaiKyThi.Text;
                    dgvThemLoaiKyThi.ClearSelection();
                    resetbox();
                }
            }
            catch
            {

            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int icountSelectedRow = dgvThemLoaiKyThi.SelectedRows.Count;
            if (icountSelectedRow > 0)
            {
                foreach (DataGridViewRow row in dgvThemLoaiKyThi.SelectedRows)
                    if (!row.IsNewRow) dgvThemLoaiKyThi.Rows.Remove(row);
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
            if(dgvThemLoaiKyThi.Rows.Count>0)
            {
                for(int i=0; i<dgvThemLoaiKyThi.Rows.Count; i++)
                {
                    _objloaikythi = new LoaiKyThi(_objloaikythibus.NextID(), 
                        dgvThemLoaiKyThi.Rows[i].Cells[1].Value.ToString());
                    if(_objloaikythibus.AddLoaiKyThi(_objloaikythi))
                    {
                        dgvThemLoaiKyThi.Rows.Remove(dgvThemLoaiKyThi.Rows[i]);
                        i--;
                        LoadData();
                        resetbox();
                    }
                    else
                    {
                        string a = dgvThemLoaiKyThi.Rows[i].Cells[0].Value.ToString();
                        MessageBox.Show("Lưu dòng " + a + " thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để lưu ! ", "Thống báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }





    }
}