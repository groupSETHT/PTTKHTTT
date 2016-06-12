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
    public partial class fThemChuongTrinhHoc : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        KhoaHocBUS _objkhoahocbus = new KhoaHocBUS();
        ChuongTrinhHocBUS _objchuongtrinhhocbus = new ChuongTrinhHocBUS();
        TrinhDoBUS _objtrinhdobus = new TrinhDoBUS();
        ChuongTrinhHoc _objchuongtrinhhoc;
        DataTable _dtchuongtrinhhoc = new DataTable();
        DataTable _dtkhoahoc;
        DataTable _dttrinhdo;
        public fThemChuongTrinhHoc()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            string makh = new KhoaHocBUS().GetMa_TheoTen(cbKhoaHoc.Text.ToString());
            _dtchuongtrinhhoc = _objchuongtrinhhocbus.GetChuongTrinhHoc_TheoKhoaHoc(makh);
            dataGridViewX2.DataSource = _dtchuongtrinhhoc;
            dataGridViewX2.RowHeadersVisible = false;
            _dtchuongtrinhhoc.Columns.Add("STT");
            for (int i = 0; i < _dtchuongtrinhhoc.Rows.Count; i++)
            {
                _dtchuongtrinhhoc.Rows[i]["STT"] = i + 1;
            }
            dataGridViewX2.Columns["STT"].DisplayIndex = 0;

            dataGridViewX2.Columns["MaChuongTrinhHoc"].HeaderText = "Mã Chương Trình Học";
            dataGridViewX2.Columns["TenChuongTrinhHoc"].HeaderText = "Chương Trình Học";
            dataGridViewX2.Columns["MaTrinhDo"].HeaderText = "Mã Trình Độ";
            dataGridViewX2.Columns["MaKhoaHoc"].HeaderText = "Mã Khóa Học";
            dataGridViewX2.Columns["HocPhi"].HeaderText = "Học Phí";
            //set width for DataGridView's cells
            dataGridViewX2.Columns["STT"].Width = 30;
            dataGridViewX2.Columns["MaChuongTrinhHoc"].Width = 100;
            dataGridViewX2.Columns["TenChuongTrinhHoc"].Width = 190;
            dataGridViewX2.Columns["MaTrinhDo"].Width = 60;
            dataGridViewX2.Columns["MaKhoaHoc"].Width = 60;
            dataGridViewX2.ClearSelection();
            lbKhoaHoc.Text = cbKhoaHoc.Text;
        }

        private void fThemChuongTrinhHoc_Load(object sender, EventArgs e)
        {

            //combo box Khoa Hoc
            _dtkhoahoc = _objkhoahocbus.GetAllKhoaHoc();
            cbKhoaHoc.DataSource = _dtkhoahoc;
            cbKhoaHoc.ValueMember = "MaKhoaHoc";
            cbKhoaHoc.DisplayMember = "TenKhoaHoc";
            cbKhoaHoc.SelectedIndex = -1;

            //combobox Trinh Do
            _dttrinhdo = _objtrinhdobus.GetAllTrinhDo();
            cbtrinhdo.DataSource = _dttrinhdo;
            cbtrinhdo.ValueMember = "MaTrinhDo";
            cbtrinhdo.DisplayMember = "TenTrinhDo";
            cbtrinhdo.SelectedIndex = -1;

            LoadData();
            dataGridViewX1.RowHeadersVisible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
            try
             {
                   

                    if ((txtchuongtrinhhoc.Text == "") || (txtHocPhi.Text == "") || (cbtrinhdo.SelectedIndex == -1))
                    {
                        MessageBox.Show("Thông tin cần nhập còn thiếu!!!");
                        return;
                    }
                    double _hocphi = double.Parse(txtHocPhi.Text);
                    if (_hocphi <= 0)
                    {
                        MessageBox.Show("Học phí của khóa học phải >0 ");
                        return;
                    }
                    dataGridViewX1.Rows.Add(dataGridViewX1.Rows.Count + 1, txtchuongtrinhhoc.Text, cbtrinhdo.Text, txtHocPhi.Text);
                    dataGridViewX1.ClearSelection();
                    resettextbox();

             }
            catch
            {
                MessageBox.Show("Khóa học chưa được chọn, vui lòng nhập lại  !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void resettextbox()
        {
            txtchuongtrinhhoc.Text = "";
            txtHocPhi.Text = "";
            cbtrinhdo.SelectedIndex = -1;
            //cbKhoaHoc.SelectedIndex = -1;
        }
        private void cbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
            resettextbox();
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtchuongtrinhhoc.Text = dataGridViewX1.CurrentRow.Cells[1].Value.ToString();
            cbtrinhdo.Text = dataGridViewX1.CurrentRow.Cells[2].Value.ToString();
            txtHocPhi.Text = dataGridViewX1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                double _hocphi = double.Parse(txtHocPhi.Text);
                if ((txtchuongtrinhhoc.Text == "") || (txtHocPhi.Text == ""))
                {
                    MessageBox.Show("Bạn còn số liệu chưa nhập ");
                    return;
                }
                if (_hocphi <= 0)
                {
                    MessageBox.Show("Học phí của khóa học phải >0 ");
                    return;
                }
                dataGridViewX1.CurrentRow.Cells[1].Value = txtchuongtrinhhoc.Text;
                dataGridViewX1.CurrentRow.Cells[2].Value = cbtrinhdo.Text;
                dataGridViewX1.CurrentRow.Cells[3].Value = txtHocPhi.Text;
                resettextbox();

            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai thông tin khóa học  , vui lòng nhập lại  !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int icountSelectedRow = dataGridViewX1.SelectedRows.Count;
            if (icountSelectedRow > 0)
            {
                foreach (DataGridViewRow row in dataGridViewX1.SelectedRows)
                    if (!row.IsNewRow) dataGridViewX1.Rows.Remove(row);
            }
            else
            {
                MessageBox.Show("Bạn phải chọn một dòng để xóa");
                return;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridViewX1.Rows.Count; i++)
                {
                    string makh = new KhoaHocBUS().GetMa_TheoTen(cbKhoaHoc.Text.ToString());
                    string matd = new TrinhDoBUS().GetMa_TheoTen(dataGridViewX1.Rows[i].Cells[2].Value.ToString());

                    _objchuongtrinhhoc = new ChuongTrinhHoc(_objchuongtrinhhocbus.NextID(), 
                        dataGridViewX1.Rows[i].Cells[1].Value.ToString(), 
                        matd, 
                        makh, 
                        double.Parse(dataGridViewX1.Rows[i].Cells[3].Value.ToString()));

                    if (_objchuongtrinhhocbus.AddChuongTrinhHoc(_objchuongtrinhhoc))
                    {
                        dataGridViewX1.Rows.Remove(dataGridViewX1.Rows[i]);
                        i--;
                        LoadData();
                    }
                    else
                    {
                        string a = dataGridViewX1.Rows[i].Cells[0].Value.ToString();
                        MessageBox.Show("Lưu dòng " + a + " thất bại");
                    }
                }
                 if (dataGridViewX1.Rows.Count == 0)
                    MessageBox.Show("Lưu thành công");
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để lưu ! ","Thống báo ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbtrinhdo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        }
    }