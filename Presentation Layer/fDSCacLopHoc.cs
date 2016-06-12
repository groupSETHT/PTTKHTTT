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

    public partial class fDSCacLopHoc : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        LopBUS _objlopbus = new LopBUS();
        DataTable _dtlop;
        KhoaHocBUS _objkhoahocbus = new KhoaHocBUS();
        ChuongTrinhHocBUS _objchuongtrinhhoc = new ChuongTrinhHocBUS();
        public fDSCacLopHoc()
        {
            InitializeComponent();
        }
        public void LoadData(string makhoa, string machuongtrinhhoc,DataGridView dgv)
        {
            try
            {
                DataTable _dtlop = _objlopbus.GetAll_TheoCTH_KH(makhoa,machuongtrinhhoc);
                dgv.DataSource = _dtlop;
                dgv.RowHeadersVisible = true;
                _dtlop.Columns.Add("STT");
                _dtlop.Columns.Add("SoLuong");
                for (int i = 0; i < _dtlop.Rows.Count; i++)
                {
                    _dtlop.Rows[i]["STT"] = i + 1;

                }
                dgv.Columns["STT"].DisplayIndex = 0;
                dgv.Columns["STT"].Width = 30;
                dgv.Columns["MaLop"].HeaderText = "Mã Lớp";
                dgv.Columns["MaLop"].Width = 50;
                dgv.Columns["TenLop"].HeaderText = "Tên Lớp";
                for (int i = 0; i < _dtlop.Rows.Count; i++)
                {
                    _dtlop.Rows[i]["SoLuong"] = _objlopbus.GetSoLuongHocVien(dgv.Rows[i].Cells[0].Value.ToString());

                }
                dgv.Columns["SoLuong"].DisplayIndex = 3;
                dgv.Columns["SoLuong"].HeaderText = "Số Lượng Học Viên";
                dgv.Columns["TenKhoaHoc"].HeaderText = "Tên Khóa Học";
                dgv.Columns["TenChuongTrinhHoc"].HeaderText = "Chương Trình Học";
                dgv.Columns["NgayBatDau"].HeaderText = "Ngày Bắt Đầu";
                dgv.Columns["NgayKetThuc"].HeaderText = "Ngày Kết Thúc";
                dgv.Columns["TenCa"].HeaderText = "Ca học";
                dgv.Columns["GioBatDau"].HeaderText = "Giờ Bắt Đầu";
                dgv.Columns["GioKetThuc"].HeaderText = "Giờ Kết Thúc";
                dgv.Columns["DanhSachNgay"].HeaderText = "Ngày Học";
                dgv.Columns["TenGV"].HeaderText = "Tên Giảng Viên";
                dgv.Columns["TenPhong"].HeaderText = "Phòng Học";
                dgv.ClearSelection();
            }
            catch (Exception ex)
            {
                return;
            }

        }
        private void fDSLopHoc_Load(object sender, EventArgs e)
        {
            //LoadData();

            DataTable _dtkhoahoc = _objkhoahocbus.GetAllKhoaHoc();
            cbbKhoaHoc.DataSource = _dtkhoahoc;
            cbbKhoaHoc.ValueMember = "MaKhoaHoc";
            cbbKhoaHoc.DisplayMember = "TenKhoaHoc";
            cbbKhoaHoc.Text = "";
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenLop.Text != "")
                {
                    DataTable _dtlopkq = _objlopbus.FindCT_TheoTen_KhoaHoc_ChuongTrinhHoc(txtTenLop.Text, cbbKhoaHoc.SelectedValue.ToString(), cbbChuongTrinhHoc.SelectedValue.ToString());
                    if (_dtlopkq.Rows.Count > 0)
                    {
                        dgvDSLop.DataSource = _dtlopkq;
                        dgvDSLop.RowHeadersVisible = true;
                        _dtlopkq.Columns.Add("STT");
                        _dtlopkq.Columns.Add("SoLuong");
                        for (int i = 0; i < _dtlopkq.Rows.Count; i++)
                        {
                            _dtlopkq.Rows[i]["STT"] = i + 1;

                        }
                        dgvDSLop.Columns["STT"].DisplayIndex = 0;
                        dgvDSLop.Columns["STT"].Width = 30;
                        dgvDSLop.Columns["MaLop"].HeaderText = "Mã Lớp";
                        dgvDSLop.Columns["MaLop"].Width = 50;
                        dgvDSLop.Columns["TenLop"].HeaderText = "Tên Lớp";
                        for (int i = 0; i < _dtlopkq.Rows.Count; i++)
                        {
                            _dtlopkq.Rows[i]["SoLuong"] = _objlopbus.GetSoLuongHocVien(dgvDSLop.Rows[i].Cells[0].Value.ToString());

                        }
                        dgvDSLop.Columns["SoLuong"].DisplayIndex = 3;
                        dgvDSLop.Columns["SoLuong"].HeaderText = "Số Lượng Học Viên";
                        dgvDSLop.Columns["NgayBatDau"].HeaderText = "Ngày Bắt Đầu";
                        dgvDSLop.Columns["NgayKetThuc"].HeaderText = "Ngày Kết Thúc";
                        dgvDSLop.Columns["TenCa"].HeaderText = "Ca học";
                        dgvDSLop.Columns["GioBatDau"].HeaderText = "Giờ Bắt Đầu";
                        dgvDSLop.Columns["GioKetThuc"].HeaderText = "Giờ Kết Thúc";
                        dgvDSLop.Columns["DanhSachNgay"].HeaderText = "Ngày Học";
                        dgvDSLop.Columns["TenGV"].HeaderText = "Tên Giảng Viên";
                        dgvDSLop.Columns["TenPhong"].HeaderText = "Phòng Học";
                        dgvDSLop.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("Không có lớp cần tìm  ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("Bạn Chưa Nhập tên lớp  ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chọn đủ thông tin khóa học, chương trình học  ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbChuongTrinhHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData(cbbKhoaHoc.SelectedValue.ToString(), cbbChuongTrinhHoc.SelectedValue.ToString(), dgvDSLop);
           
        }

        private void cbbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbKhoaHoc.SelectedValue != null)
                {
                    DataTable _dtchuongtrinhhoc = _objchuongtrinhhoc.GetChuongTrinhHoc_TheoKhoaHoc(cbbKhoaHoc.SelectedValue.ToString());
                    cbbChuongTrinhHoc.DataSource = _dtchuongtrinhhoc;
                    cbbChuongTrinhHoc.ValueMember = "MaChuongTrinhHoc";
                    cbbChuongTrinhHoc.DisplayMember = "TenChuongTrinhHoc";
                    cbbChuongTrinhHoc.Text = "";
                }
                else
                {
                    cbbChuongTrinhHoc.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show("chưa có chương trình hoc ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            LoadData(cbbKhoaHoc.SelectedValue.ToString(), cbbChuongTrinhHoc.SelectedValue.ToString(),dgvDSLop);
        }





    }
}