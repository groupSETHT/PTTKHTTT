using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;
using Report;
namespace Presentation_Layer
{
    public partial class fBaoCaoHocVienDangKyMoi : DevComponents.DotNetBar.Metro.MetroAppForm
    {
         HocVienBUS _objhocvienbus = new HocVienBUS();

        public fBaoCaoHocVienDangKyMoi()
        {
            InitializeComponent();
        }

   
        public void LoadData(string thang, string nam)
        {
          
            DataTable _dtdanhsachhocvien = _objhocvienbus.GetAll_HocVienBaoCao(thang, nam);
            if (_dtdanhsachhocvien.Rows.Count > 0)
            {
                dgvDSLop.DataSource = _dtdanhsachhocvien;
                dgvDSLop.RowHeadersVisible = false;
                _dtdanhsachhocvien.Columns.Add("STT");
                for (int i = 0; i < _dtdanhsachhocvien.Rows.Count; i++)
                {
                    _dtdanhsachhocvien.Rows[i]["STT"] = i + 1;
                }
                dgvDSLop.Columns["STT"].DisplayIndex = 0;
                dgvDSLop.Columns["MaHV"].HeaderText = "Mã Học Viên";
                dgvDSLop.Columns["HoTen"].HeaderText = "Tên Học Viên";
                dgvDSLop.Columns["SDT"].HeaderText = "SĐT";
                dgvDSLop.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dgvDSLop.Columns["Phai"].HeaderText = "Giới tính";
            }else
            {
                MessageBox.Show("Không có học viên ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void fBaoCaoHocVienDangKyMoi_Load_1(object sender, EventArgs e)
        {
            //LoadData(cbbThang.Text, dtipNam.Text);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                int soluong = _objhocvienbus.GetSoLuong_HocVien_BaoCao(cbbThang.Text, dtipNam.Text);
                if (soluong > 0)
                {
                    txtSoLuong.Text = soluong.ToString();
                }
                if (cbbThang.Text == "" || dtipNam.Text == "" || dtipNgayLap.Text == "")
                {
                    MessageBox.Show("Chưa nhập đủ thông tin . nhập lại !", "LỖI ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LoadData(cbbThang.Text, dtipNam.Text);
            }
            catch (Exception ex)
            {

            }
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
                DataTable _dtdanhsach = _objhocvienbus.GetAll_HocVienBaoCao(cbbThang.Text, dtipNam.Text);
                if (_dtdanhsach.Rows.Count > 0)
                {
                    string ngaythang = "Tháng " + cbbThang.Text + " năm " + dtipNam.Text;
                    DataColumn col = new DataColumn("STT", typeof(int));
                    _dtdanhsach.Columns.Add(col);
                    col.SetOrdinal(0);
                    int len = _dtdanhsach.Rows.Count;
                    for (int i = 0; i < len; ++i)
                    {
                        _dtdanhsach.Rows[i]["STT"] = i + 1;
                    } Dictionary<string, string> dic = new Dictionary<string, string>();
                    dic.Add("ThangNam", ngaythang);
                    WordUltil wd = new WordUltil(Application.StartupPath + "/Baocaodanhsach.dotx", true);
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

        private void buttonX1_Click(object sender, EventArgs e)
        {
            dgvDSLop.DataSource = null;
            cbbThang.Text = "";
            dtipNam.Text = "";
        }
      
    }
}