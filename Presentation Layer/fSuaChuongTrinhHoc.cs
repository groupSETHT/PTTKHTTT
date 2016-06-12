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
    public partial class fSuaChuongTrinhHoc : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        KhoaHocBUS _objkhoahocbus = new KhoaHocBUS();
        ChuongTrinhHocBUS _objchuongtrinhhocbus = new ChuongTrinhHocBUS();
        TrinhDoBUS _objtrinhdobus = new TrinhDoBUS();
        ChuongTrinhHoc _objchuongtrinhhoc;
        DataTable _dtchuongtrinhhoc = new DataTable();
        DataTable _dtkhoahoc;
        DataTable _dttrinhdo;
        public fSuaChuongTrinhHoc()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            string makh = new KhoaHocBUS().GetMa_TheoTen(cbKhoaHoc.Text.ToString());
            _dtchuongtrinhhoc = _objchuongtrinhhocbus.GetChuongTrinhHoc_TheoKhoaHoc(makh);
            dataGridViewX1.DataSource = _dtchuongtrinhhoc;
            dataGridViewX1.RowHeadersVisible = false;
            _dtchuongtrinhhoc.Columns.Add("STT");
            for (int i = 0; i < _dtchuongtrinhhoc.Rows.Count; i++)
            {
                _dtchuongtrinhhoc.Rows[i]["STT"] = i + 1;
            }
            dataGridViewX1.Columns["STT"].DisplayIndex = 0;

            dataGridViewX1.Columns["MaChuongTrinhHoc"].HeaderText = "Mã Chương Trình Học";
            dataGridViewX1.Columns["TenChuongTrinhHoc"].HeaderText = "Chương Trình Học";
            dataGridViewX1.Columns["MaTrinhDo"].HeaderText = "Mã Trình Độ";
            dataGridViewX1.Columns["MaKhoaHoc"].HeaderText = "Mã Khóa Học";
            dataGridViewX1.Columns["HocPhi"].HeaderText = "Học Phí";

            //set width for DataGridView's cells
            dataGridViewX1.Columns["STT"].Width = 30;
            dataGridViewX1.Columns["MaChuongTrinhHoc"].Width = 100;
            dataGridViewX1.Columns["TenChuongTrinhHoc"].Width = 190;
            dataGridViewX1.Columns["MaTrinhDo"].Width = 60;
            dataGridViewX1.Columns["MaKhoaHoc"].Width = 60;
            dataGridViewX1.ClearSelection();
            lbKhoaHoc.Text = cbKhoaHoc.Text;
        }

        private void fSuaChuongTrinhHoc_Load(object sender, EventArgs e)
        {
            //combobox Khoa Hoc
            _dtkhoahoc = _objkhoahocbus.GetAllKhoaHoc();
            cbKhoaHoc.DataSource = _dtkhoahoc;
            cbKhoaHoc.ValueMember = "MaKhoaHoc";
            cbKhoaHoc.DisplayMember = "TenKhoaHoc";
            cbKhoaHoc.SelectedIndex = -1;

            //combobox Trinh Do
            _dttrinhdo = _objtrinhdobus.GetAllTrinhDo();
            cbTrinhDo.DataSource = _dttrinhdo;
            cbTrinhDo.ValueMember = "MaTrinhDo";
            cbTrinhDo.DisplayMember = "TenTrinhDo";
            cbTrinhDo.SelectedIndex = -1;

            LoadData();
            dataGridViewX1.RowHeadersVisible = false;
        }

        private void cbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }


        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtChuongTrinhHoc.Text = dataGridViewX1.CurrentRow.Cells[1].Value.ToString();
            string tentd = new TrinhDoBUS().GetTen_TheoMa(dataGridViewX1.CurrentRow.Cells[2].Value.ToString());
            cbTrinhDo.Text = tentd;
            txtHocPhi.Text = dataGridViewX1.CurrentRow.Cells[4].Value.ToString();
        }
        void resetbox()
        {
            txtChuongTrinhHoc.Text = "";
            cbTrinhDo.SelectedIndex = -1;
            txtHocPhi.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.RowCount > 0)
            {
                if (txtChuongTrinhHoc.Text == "" || txtHocPhi.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin");
                    return;
                }
                double _temp_hocphi = double.Parse(txtHocPhi.Text);
                if (_temp_hocphi <= 0)
                {
                    MessageBox.Show("Học phí của một khóa học phải lớn hơn 0 ! ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                string ma_kh = dataGridViewX1.CurrentRow.Cells[3].Value.ToString();
                string ma_cth = dataGridViewX1.CurrentRow.Cells[0].Value.ToString();
                
                string ma_td = _objtrinhdobus.GetMa_TheoTen(cbTrinhDo.Text);
                _objchuongtrinhhoc = new ChuongTrinhHoc(ma_cth, 
                    txtChuongTrinhHoc.Text, 
                    ma_td, 
                    ma_kh, 
                    double.Parse(txtHocPhi.Text));

                if (_objchuongtrinhhocbus.EditChuongTrinhHoc(_objchuongtrinhhoc))
                {
                    LoadData();
                    resetbox();
                    MessageBox.Show("Sửa Thành Công Chương Trình Học " + dataGridViewX1.CurrentRow.Cells[0].Value.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa Thất Bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không có Khóa học để sữa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count = dataGridViewX1.SelectedRows.Count;
            if(count!=0)
            {
                if (_objchuongtrinhhocbus.DeleteChuongTrinhHoc(dataGridViewX1.CurrentRow.Cells[0].Value.ToString()))
                {
                    LoadData();
                    resetbox();
                    MessageBox.Show("Xóa thành công!!!");
                }
                }
            else
            {
                MessageBox.Show("Bạn chưa chon dòng cần xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}