using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace Presentation_Layer
{
    public partial class fKetQuaThi : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        LoaiKyThiBUS _objloaikythibus = new LoaiKyThiBUS();
        KyThiBUS _objkythibus = new KyThiBUS();
        DanhSachThiBUS _objdanhsachthibus = new DanhSachThiBUS();
        LopBUS _objlopbus = new LopBUS();
        DataTable _dtketquathi;
        public fKetQuaThi()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            if (cbbKyThi.Text != "")
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
                clmTenHocVien.Visible = false;
                clmMaHocVien.Visible = false;
                clmKetQuaThi.Visible = false;
                dgvKetQuaThi.ClearSelection();
            }
            else
            {
                lblTenLop.Text = "";
                dgvKetQuaThi.DataSource = null;
                clmSTT.Visible = true;
                clmTenHocVien.Visible = true;
                clmMaHocVien.Visible = true;
                clmKetQuaThi.Visible = true;
            }
        }
        private void fKetQuaThi_Load(object sender, EventArgs e)
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
                    DataTable _dtkythi = _objkythibus.GetMaTenKyThi_TheoLoaiKyThi(cbbLoaiKyThi.SelectedValue.ToString());
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

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
