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
    public partial class fSuaLoaiKyThi : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        LoaiKyThi _objloaikythi;
        LoaiKyThiBUS _objloaikythibus = new LoaiKyThiBUS();
        DataTable _dtloaikythi;
        public fSuaLoaiKyThi()
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
            //set witdth dgv's cells
            dgvDSLoaiKyThi.Columns["STT"].Width = 40;
            dgvDSLoaiKyThi.Columns["MaLoaiKyThi"].Width = 80;
            dgvDSLoaiKyThi.Columns["TenLoaiKyThi"].Width = 250;
            dgvDSLoaiKyThi.ClearSelection();
        }

        private void fSuaLoaiKyThi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvDSLoaiKyThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenLoaiKyThi.Text = dgvDSLoaiKyThi.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvDSLoaiKyThi.RowCount>0)
            {
                if(txtTenLoaiKyThi.Text=="")
                {
                    MessageBox.Show("Bạn còn số liệu chưa nhập ");
                    return;
                }
                _objloaikythi = new LoaiKyThi(dgvDSLoaiKyThi.CurrentRow.Cells[0].Value.ToString(),
                    txtTenLoaiKyThi.Text);
                if(_objloaikythibus.EditLoaiKyThi(_objloaikythi))
                {
                    MessageBox.Show("Sửa Thành Công!!!");
                    LoadData();
                    txtTenLoaiKyThi.Text = "";
                }
                else
                {
                    MessageBox.Show("Sửa Thất Bại!!!");
                }
            }
            else
            {
                MessageBox.Show("Không Có Thông Tin Để Sửa");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count = dgvDSLoaiKyThi.SelectedRows.Count;
            if(count!=0)
            {
                if(_objloaikythibus.DeleteLoaiKyThi(dgvDSLoaiKyThi.CurrentRow.Cells[0].Value.ToString()))
                {
                    LoadData();
                    txtTenLoaiKyThi.Text = "";
                    MessageBox.Show("Xóa Thành Công!!!");
                }
               
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dòng cần xóa");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}