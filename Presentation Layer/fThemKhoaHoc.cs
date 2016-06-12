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
    public partial class fThemKhoaHoc : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        KhoaHocBUS _objkhoahocbus = new KhoaHocBUS();
        KhoaHoc _objkhoahoc;
        DataTable _dtkhoahoc = new DataTable();
        public fThemKhoaHoc()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            _dtkhoahoc = _objkhoahocbus.GetAllKhoaHoc();
            dataGridViewX2.DataSource = _dtkhoahoc;
            dataGridViewX2.RowHeadersVisible = true;
            _dtkhoahoc.Columns.Add("STT");
            for (int i = 0; i < _dtkhoahoc.Rows.Count; i++)
                _dtkhoahoc.Rows[i]["STT"] = i + 1;
            dataGridViewX2.Columns["STT"].DisplayIndex = 0;
            dataGridViewX2.Columns["MaKhoaHoc"].HeaderText = "Mã Khóa Học";
            dataGridViewX2.Columns["TenKhoaHoc"].HeaderText = "Tên Khóa Học";
            dataGridViewX2.Columns["HocPhi"].HeaderText = "Học Phí";
            dataGridViewX2.ClearSelection();

        }

        private void fThemKhoaHoc_Load(object sender, EventArgs e)
        {
           
            LoadData();
            dataGridViewX1.RowHeadersVisible = false;

        }
        public void resettextbox(string id_dgv)
        {
           
            txtTenKhoaHoc.Text = "";
            txthocphi.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                
                if ((txtTenKhoaHoc.Text == "") || (txthocphi.Text == ""))
                {
                    MessageBox.Show("Bạn còn số liệu chưa nhập ");
                    return;
                }
                double _hocphi = double.Parse(txthocphi.Text);
                if (_hocphi <= 0)
                {
                    MessageBox.Show("Học phí của khóa học phải >0 ");
                    return;
                }
                dataGridViewX1.Rows.Add(dataGridViewX1.Rows.Count + 1, txtTenKhoaHoc.Text, txthocphi.Text);
                dataGridViewX1.ClearSelection();
               
                
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai thông tin khóa học  , vui lòng nhập lại  !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    double _hocphi = double.Parse(txthocphi.Text);
                    if ((txtTenKhoaHoc.Text == "") || (txthocphi.Text == ""))
                    {
                        MessageBox.Show("Bạn còn số liệu chưa nhập ");
                        return;
                    }
                    if (_hocphi <= 0)
                    {
                        MessageBox.Show("Học phí của khóa học phải >0 ");
                        return;
                    }
                    dataGridViewX1.CurrentRow.Cells[1].Value = txtTenKhoaHoc.Text;
                    dataGridViewX1.CurrentRow.Cells[2].Value = txthocphi.Text;
                    MessageBox.Show("Cập nhật thành công ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Cập nhật không thành công ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
        
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai thông tin khóa học  , vui lòng nhập lại  !","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void dataGridViewX1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridViewX1.Rows[e.RowIndex];
               
                txtTenKhoaHoc.Text = row.Cells[1].Value.ToString();
                txthocphi.Text = row.Cells[2].Value.ToString();
            }
            catch(Exception )
            {
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

                    _objkhoahoc = new KhoaHoc(_objkhoahocbus.NextID(), dataGridViewX1.Rows[i].Cells[1].Value.ToString(), double.Parse(dataGridViewX1.Rows[i].Cells[2].Value.ToString()));

                    if (_objkhoahocbus.AddKhoaHoc(_objkhoahoc))
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
              
                txtTenKhoaHoc.Text = "";
                txthocphi.Text = "";
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

        private void fThemKhoaHoc_FormClosing(object sender, FormClosingEventArgs e)
        {
             if (dataGridViewX1.Rows.Count > 0)
            {

                DialogResult dialogResult = MessageBox.Show("Có một số khóa học chưa được lưu\n Bạn có muốn thoát !(YES OR NO)", "CẢNH BÁO !!! ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}