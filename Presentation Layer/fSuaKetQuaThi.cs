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
    public partial class fSuaKetQuaThi : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        LoaiKyThiBUS _objloaikythibus = new LoaiKyThiBUS();
        KyThiBUS _objkythibus = new KyThiBUS();
        DanhSachThiBUS _objdanhsachthibus = new DanhSachThiBUS();
        LopBUS _objlopbus = new LopBUS();
        DataTable _dtketquathi;
        public fSuaKetQuaThi()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            if(cbbKyThi.Text!="")
            {
                lblTenLop.Text = "Lớp : " + _objlopbus.GetTen_TheoMa_LopHoc(_objkythibus.GetLop_TheoMaKyThi(cbbKyThi.SelectedValue.ToString()));
                _dtketquathi = _objdanhsachthibus.GetAllDanhSachThi_TheoKyThi(cbbKyThi.SelectedValue.ToString());
                dgvKetQuaThi.DataSource = _dtketquathi;

                    _dtketquathi.Columns.Add("STT");
                    for (int i = 0; i < _dtketquathi.Rows.Count; i++)
                        _dtketquathi.Rows[i]["STT"] = i + 1;
                    dgvKetQuaThi.Columns["STT"].DisplayIndex = 0;
                    dgvKetQuaThi.Columns["MaHV"].HeaderText = "Mã Học Viên";
                    dgvKetQuaThi.Columns["MaHV"].Width = 140;
                    dgvKetQuaThi.Columns["HoTen"].HeaderText = "Tên Học Viên";
                    dgvKetQuaThi.Columns["HoTen"].Width = 140;
                    dgvKetQuaThi.Columns["KetQuaThi"].HeaderText = "Kết quả thi";
                    dgvKetQuaThi.Columns["KetQuaThi"].Width = 140;
                    clmSTT.Visible = false;
                    clmTenHV.Visible = false;
                    clmMaHV.Visible = false;
                    clmKetQua.Visible = false;
                    dgvKetQuaThi.ClearSelection();
                }
                else
                {
                    lblTenLop.Text = "";
                    dgvKetQuaThi.DataSource = null;
                    clmSTT.Visible = true;
                    clmTenHV.Visible = true;
                    clmMaHV.Visible = true;
                    clmKetQua.Visible = true;
                }
            }
            
        private void fSuaKetQuaThi_Load(object sender, EventArgs e)
        {
            DataTable _dtloaikythi = _objloaikythibus.GetAllLoaiKyThi();
            cbbLoaiKyThi.DataSource = _dtloaikythi;
            cbbLoaiKyThi.ValueMember = "MaLoaiKyThi";
            cbbLoaiKyThi.DisplayMember = "TenLoaiKyThi";
            lblTenLop.Text = "";
            LoadData();
        }
        private void cbbLoaiKyThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load cbb kỳ thi
            DataTable _dtkythi = _objkythibus.GetAllKyThi_TheoMa_LoaiKyThi(cbbLoaiKyThi.SelectedValue.ToString());
            cbbKyThi.DataSource = _dtkythi;
            cbbKyThi.ValueMember = "MaKyThi";
            cbbKyThi.DisplayMember = "TenKyThi";
            cbbKyThi.Text = "";
            LoadData();
        }

        private void cbbKyThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        private void cbMaKyThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch
            {
                MessageBox.Show("Load dữ liệu thất bại ! , Thực hiện lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvKetQuaThi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvKetQuaThi.Rows[e.RowIndex];
                lblHocVien.Text = row.Cells[5].Value.ToString();
                txtDiem.Text = row.Cells[6].Value.ToString();
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
                string makt, mahv;
                float diem = float.Parse(txtDiem.Text) ;
                if (diem < 0 || diem > 10)
                {
                    MessageBox.Show("Nhập điểm sai .nhập lại ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DanhSachThi _objdanhsachthi = new DanhSachThi(cbbKyThi.SelectedValue.ToString(), dgvKetQuaThi.CurrentRow.Cells[4].Value.ToString(), float.Parse(txtDiem.Text));

                if (_objdanhsachthibus.EditDanhSachThi(_objdanhsachthi))
                {
                    MessageBox.Show("Cập nhật điểm thành công ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    lblHocVien.Text = "";
                    txtDiem.Text = "";
                }
                else
                {

                    MessageBox.Show("Cập nhật điểm thất bại ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            {
                MessageBox.Show("Cập nhật điểm thất bại ", "Thống báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}