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
    public partial class fThemDeThi : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        DeThi _objdethi;
        DeThiBUS _objdethibus = new DeThiBUS();
        LoaiDeThiBUS _objloaidethibus = new LoaiDeThiBUS();

        DataTable _dtloaidethi;
        DataTable _dtdethi;
        public fThemDeThi()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            _dtdethi = _objdethibus.GetAllDeThi_TheoMaLoaiDeThi(_objloaidethibus.GetMa_TheoTen_LoaiDeThi(cbbLoaiDeThi.Text));
            dgvDSDeThi.DataSource = _dtdethi;
            dgvDSDeThi.RowHeadersVisible = false;
            _dtdethi.Columns.Add("STT");
            for (int i = 0; i < _dtdethi.Rows.Count; i++)
            {
                _dtdethi.Rows[i]["STT"] = i + 1;
            }
            dgvDSDeThi.Columns["STT"].DisplayIndex = 0;
            dgvDSDeThi.Columns["MaDeThi"].HeaderText = "Mã Đề Thi";
            dgvDSDeThi.Columns["TenDeThi"].HeaderText = "Tên Đề Thi";
            dgvDSDeThi.Columns["MaLoaiDeThi"].HeaderText = "Mã Loại Đề Thi";
            dgvDSDeThi.Columns["NgayLap"].HeaderText = "Ngày Lập";
            dgvDSDeThi.ClearSelection();
            lbLoaiDeThi.Text = cbbLoaiDeThi.Text;
            lbLoaiDeThi.Visible = true;
        }

        private void fThemDeThi_Load(object sender, EventArgs e)
        {
            //combobox Loai De Thi
            _dtloaidethi = _objloaidethibus.GetAllLoaiDeThi();
            cbbLoaiDeThi.DataSource = _dtloaidethi;
            cbbLoaiDeThi.ValueMember = "MaLoaiDeThi";
            cbbLoaiDeThi.DisplayMember = "TenLoaiDeThi";
            cbbLoaiDeThi.SelectedIndex = -1;
            LoadData();
        }

        private void cbbLoaiDeThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        public void resetbox()
        {
            //cbbLoaiDeThi.SelectedIndex = -1;
            txtTenDeThi.Text = "";
            dtNgayLap.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try { 
                if(cbbLoaiDeThi.SelectedIndex==-1 || txtTenDeThi.Text=="" || dtNgayLap.Text=="")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!!!");
                    return;
                }
                dgvDeThi.Rows.Add(dgvDeThi.Rows.Count + 1, cbbLoaiDeThi.Text, txtTenDeThi.Text, dtNgayLap.Text);
                dgvDeThi.ClearSelection();
                resetbox();
            }
            catch
            {
            }
        }

        private void dgvDeThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbLoaiDeThi.Text = dgvDeThi.CurrentRow.Cells[1].Value.ToString();
            txtTenDeThi.Text = dgvDeThi.CurrentRow.Cells[2].Value.ToString();
            dtNgayLap.Text = dgvDeThi.CurrentRow.Cells[3].Value.ToString();
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                    if (cbbLoaiDeThi.SelectedIndex == -1 || txtTenDeThi.Text == "" || dtNgayLap.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!!!");
                        return;
                    }
                    dgvDeThi.CurrentRow.Cells[1].Value = cbbLoaiDeThi.Text;
                    dgvDeThi.CurrentRow.Cells[2].Value = txtTenDeThi.Text;
                    dgvDeThi.CurrentRow.Cells[3].Value = dtNgayLap.Text;
                    dgvDeThi.ClearSelection();
                    resetbox();
            }
            catch
            {

            }

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvDeThi.SelectedRows.Count>0)
            {
                foreach(DataGridViewRow row in dgvDeThi.SelectedRows)
                    if (!row.IsNewRow) dgvDeThi.Rows.Remove(row);
                resetbox();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dòng cần xóa");
                return;
            }
        }




        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(dgvDeThi.Rows.Count>0)
            {
                for(int i=0; i<dgvDeThi.Rows.Count; i++)
                {
                    _objdethi = new DeThi(_objdethibus.NextID_DeThi(),
                        dgvDeThi.Rows[i].Cells[2].Value.ToString(),
                        _objloaidethibus.GetMa_TheoTen_LoaiDeThi(dgvDeThi.Rows[i].Cells[1].Value.ToString()),
                        dgvDeThi.Rows[i].Cells[3].Value.ToString());
                    if(_objdethibus.AddDeThi(_objdethi))
                    {
                        dgvDeThi.Rows.Remove(dgvDeThi.Rows[i]);
                        i--;
                        LoadData();
                    }
                    else
                    {
                        string a = dgvDeThi.Rows[i].Cells[0].Value.ToString();
                        MessageBox.Show("Lưu dòng " + a + "thất bại!!!");
                    }
                }
                if(dgvDeThi.Rows.Count==0)
                {
                    MessageBox.Show("Lưu thành công!!!");
                }
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}