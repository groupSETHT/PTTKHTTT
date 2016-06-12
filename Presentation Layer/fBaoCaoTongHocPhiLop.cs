using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
using Report;
namespace Presentation_Layer
{
    public partial class fBaoCaoTongHocPhiLop : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        LopBUS _objlopbus = new LopBUS();

        public fBaoCaoTongHocPhiLop()
        {
            InitializeComponent();
        }
        public void LoadData(string thang, string nam)
        {
            try
            {
                DataTable _dtdanhsachlop = _objlopbus.BaoCaoTongHocPhi(thang, nam);
                if (_dtdanhsachlop.Rows.Count > 0)
                {
                    dgvDSLop.DataSource = _dtdanhsachlop;
                    dgvDSLop.RowHeadersVisible = false;
                    _dtdanhsachlop.Columns.Add("STT");
                    for (int i = 0; i < _dtdanhsachlop.Rows.Count; i++)
                    {
                        _dtdanhsachlop.Rows[i]["STT"] = i + 1;
                    }
                    dgvDSLop.Columns["STT"].DisplayIndex = 0;
                    dgvDSLop.Columns["STT"].Width = 50;
                    dgvDSLop.Columns["MaLop"].Width = 50;
                    dgvDSLop.Columns["MaLop"].HeaderText = "Mã Lớp";
                    dgvDSLop.Columns["TenLop"].HeaderText = "Tên Lớp";
                    dgvDSLop.Columns["TenLop"].Width = 70;
                    dgvDSLop.Columns["TenKhoaHoc"].HeaderText = "Khoá Học";
                    dgvDSLop.Columns["TenKhoaHoc"].Width = 120;
                    dgvDSLop.Columns["TenChuongTrinhHoc"].Width = 120;
                    dgvDSLop.Columns["TenChuongTrinhHoc"].HeaderText = "Chương Trình Học";
                    dgvDSLop.Columns["NgayBatDau"].HeaderText = "Ngày Bắt Đầu";
                    dgvDSLop.Columns["NgayKetThuc"].HeaderText = "Ngày Kết Thúc";
                    dgvDSLop.Columns["NgayBatDau"].Width = 70;
                    dgvDSLop.Columns["NgayKetThuc"].Width = 70;
                    dgvDSLop.Columns["HocPhi"].HeaderText = "Học phí lớp ";
                    _dtdanhsachlop.Columns.Add("SoLuong");
                    for (int i = 0; i < _dtdanhsachlop.Rows.Count; i++)
                    {
                        _dtdanhsachlop.Rows[i]["SoLuong"] = _objlopbus.GetSoLuongHocVien(dgvDSLop.Rows[i].Cells[0].Value.ToString());
                    }
                    dgvDSLop.Columns["SoLuong"].DisplayIndex = 8;
                    dgvDSLop.Columns["SoLuong"].HeaderText = "Số lượng học viên";
                    dgvDSLop.Columns["SoLuong"].Width = 50;
                    _dtdanhsachlop.Columns.Add("TongTien");
                    for (int i = 0; i < _dtdanhsachlop.Rows.Count; i++)
                    {
                        _dtdanhsachlop.Rows[i]["TongTien"] = _objlopbus.TongTien_LopHoc(dgvDSLop.Rows[i].Cells[0].Value.ToString());
                    }
                    dgvDSLop.Columns["TongTien"].DisplayIndex = 9;
                    dgvDSLop.Columns["TongTien"].HeaderText = "Tổng học phí";
                    dgvDSLop.Columns["TongTien"].Width = 100;

                }
                else
                {
                    MessageBox.Show("Không có học viên ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Load dữ liệu thất bại. Kiểm Tra Kết Nối . \nThực Hiện Lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbThang.Text == "" || dtipNam.Text == "" || dtipNgayLap.Text == "")
                {
                    MessageBox.Show("Chưa nhập đủ thông tin . nhập lại !", "LỖI ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LoadData(cbbThang.Text, dtipNam.Text);
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            dgvDSLop.DataSource = null;
            cbbThang.Text = "";
            dtipNam.Text = "";
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbThang.Text == "" || dtipNam.Text == "" || dtipNgayLap.Text == "")
                {
                    MessageBox.Show("Chưa nhập đủ thông tin . nhập lại !", "LỖI ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DataTable _dtdanhsach = _objlopbus.BaoCaoTongHocPhi(cbbThang.Text, dtipNam.Text);
                if (_dtdanhsach.Rows.Count > 0)
                {
                    string ngaythang = "Tháng " + cbbThang.Text + " năm " + dtipNam.Text;
                    string ngaylap = dtipNgayLap.Value.ToLongDateString();
                    DataColumn colstt = new DataColumn("STT", typeof(int));
                    _dtdanhsach.Columns.Add(colstt);
                    colstt.SetOrdinal(0);
                    DataColumn colsoluong = new DataColumn("SoLuong", typeof(int));
                    _dtdanhsach.Columns.Add(colsoluong);
                    colsoluong.SetOrdinal(8);
                    DataColumn coltongtien = new DataColumn("TongTien", typeof(int));
                    _dtdanhsach.Columns.Add(coltongtien);
                    coltongtien.SetOrdinal(9);
                    
                    int len = _dtdanhsach.Rows.Count;
                    for (int i = 0; i < len; ++i)
                    {
                        _dtdanhsach.Rows[i]["STT"] = i + 1;
                        _dtdanhsach.Rows[i]["SoLuong"] = _objlopbus.GetSoLuongHocVien(_dtdanhsach.Rows[i]["MaLop"].ToString());
                        _dtdanhsach.Rows[i]["TongTien"] =_objlopbus.TongTien_LopHoc(_dtdanhsach.Rows[i]["MaLop"].ToString());

                    } Dictionary<string, string> dic = new Dictionary<string, string>();
                    dic.Add("ThangNam", ngaythang);
                    dic.Add("NgayLap", ngaylap);
                    WordUltil wd = new WordUltil(Application.StartupPath + "/BaoCaoHocPhi.dotx", true);
                    wd.WriteFields(dic);
                    wd.WriteTable(_dtdanhsach, 1);
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để xuất file .", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("In thất bại! \nThực hiện lại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}