using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class fMain : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public fMain()
        {
            InitializeComponent();
        }

        //SHOW FORM ON MAINFORM
        public static fThemKhoaHoc _fTKH = null;
        public static void ShowFormTKH(fMain MF)
        {
            if (_fTKH == null || _fTKH.IsDisposed)
            {
                _fTKH = new fThemKhoaHoc();
               // _fTKH.RefToMainForm = MF;
                _fTKH.MdiParent = MF;
                _fTKH.Show();
            }
            else
                _fTKH.Activate();
        }

        public static fSuaKhoaHoc _fSKH = null;
        public static void ShowFormSKH(fMain MF)
        {
            if (_fSKH == null || _fSKH.IsDisposed)
            {
                _fSKH = new fSuaKhoaHoc();
                _fSKH.RefToMainForm = MF;
                _fSKH.MdiParent = MF;
                _fSKH.Show();
            }
            else
                _fSKH.Activate();
        }

        public static fThemLopHoc _fTLH = null;
        public static void ShowFormTLH(fMain MF)
        {
            if (_fTLH == null || _fTLH.IsDisposed)
            {
                _fTLH = new fThemLopHoc();
                // _fTLH.RefToMainForm = MF;
                _fTLH.MdiParent = MF;
                _fTLH.Show();
            }
            else
                _fTLH.Activate();
        }

        public static fSuaLopHoc _fSLH = null;
        public static void ShowFormSLH(fMain MF)
        {
            if (_fSLH == null || _fSLH.IsDisposed)
            {
                _fSLH = new fSuaLopHoc();
                // _fTKH.RefToMainForm = MF;
                _fSLH.MdiParent = MF;
                _fSLH.Show();
            }
            else
                _fSLH.Activate();
        }

        public static fThemHocVienTiemNang _fTHVTN = null;
        public static void ShowFormTHVTN(fMain MF)
        {
            if (_fTHVTN == null || _fTHVTN.IsDisposed)
            {
                _fTHVTN = new fThemHocVienTiemNang();
                //_fTHVTN.RefToMainForm = MF;
                _fTHVTN.MdiParent = MF;
                _fTHVTN.Show();
            }
            else
                _fTHVTN.Activate();
        }

       public static fSuaHocVienTiemNang _fSHVTN = null;
        public static void ShowFormSHVTN(fMain MF)
        {
            if (_fSHVTN == null || _fSHVTN.IsDisposed)
            {
                _fSHVTN = new fSuaHocVienTiemNang();
                //_fSHVTN.RefToMainForm = MF;
                _fSHVTN.MdiParent = MF;
                _fSHVTN.Show();
            }
            else
                _fSHVTN.Activate();
        }

        public static fThemHocVienChinhThuc _fTHVCT = null;
        public static void ShowFormTHVCT(fMain MF)
        {
            if (_fTHVCT == null || _fTHVCT.IsDisposed)
            {
                _fTHVCT = new fThemHocVienChinhThuc();
                //_fTHVCT.RefToMainForm = MF;
                _fTHVCT.MdiParent = MF;
                _fTHVCT.Show();
            }
            else
                _fTHVCT.Activate();
        }

        public static fSuaHocVienChinhThuc _fSHVCT = null;
        public static void ShowFormSHVCT(fMain MF)
        {
            if (_fSHVCT == null || _fSHVCT.IsDisposed)
            {
                _fSHVCT = new fSuaHocVienChinhThuc();
                //_fSHVCT.RefToMainForm = MF;
                _fSHVCT.MdiParent = MF;
                _fSHVCT.Show();
            }
            else
                _fSHVCT.Activate();
        }
        public static fThemLoaiDeThi _fTLDT = null;
        public static void ShowFormTLDT(fMain MF)
        {
            if (_fTLDT == null || _fTLDT.IsDisposed)
            {
                _fTLDT = new fThemLoaiDeThi();
                //_fSHVCT.RefToMainForm = MF;
                _fTLDT.MdiParent = MF;
                _fTLDT.Show();
            }
            else
                _fTLDT.Activate();
        }
        public static fSuaLoaiDeThi _fSLDT = null;
        public static void ShowFormSLDT(fMain MF)
        {
            if (_fSLDT == null || _fSLDT.IsDisposed)
            {
                _fSLDT = new fSuaLoaiDeThi();
                //_fSHVCT.RefToMainForm = MF;
                _fSLDT.MdiParent = MF;
                _fSLDT.Show();
            }
            else
                _fSLDT.Activate();
        }
        public static fThemChuongTrinhHoc _fTCTH = null;
        public static void ShowFormTCTH(fMain MF)
        {
            if (_fTCTH == null || _fTCTH.IsDisposed)
            {
                _fTCTH = new fThemChuongTrinhHoc();
                // _fTKH.RefToMainForm = MF;
                _fTCTH.MdiParent = MF;
                _fTCTH.Show();
            }
            else
                _fTCTH.Activate();
        }

        public static fSuaChuongTrinhHoc _fSCTH = null;
        public static void ShowFormSCTH(fMain MF)
        {
            if (_fSCTH == null || _fSCTH.IsDisposed)
            {
                _fSCTH = new fSuaChuongTrinhHoc();
                // _fTKH.RefToMainForm = MF;
                _fSCTH.MdiParent = MF;
                _fSCTH.Show();
            }
            else
                _fSCTH.Activate();
        }
        
        public static fThemCaHoc _fTLiH = null;
        public static void ShowFormTLiH(fMain MF)
        {
            if (_fTLiH == null || _fTLiH.IsDisposed)
            {
                _fTLiH = new fThemCaHoc();
                // _fTKH.RefToMainForm = MF;
                _fTLiH.MdiParent = MF;
                _fTLiH.Show();
            }
            else
                _fTLiH.Activate();
        }

        public static fSuaCaHoc _fSLiH = null;
        public static void ShowFormSLiH(fMain MF)
        {
            if (_fSLiH == null || _fSLiH.IsDisposed)
            {
                _fSLiH = new fSuaCaHoc();
                // _fTKH.RefToMainForm = MF;
                _fSLiH.MdiParent = MF;
                _fSLiH.Show();
            }
            else
                _fSLiH.Activate();
        }
        

        public static fThemGiangVien _fTGV = null;
        public static void ShowFormTGV(fMain MF)
        {
            if (_fTGV == null || _fTGV.IsDisposed)
            {
                _fTGV = new fThemGiangVien();
                // _fTGV.RefToMainForm = MF;
                _fTGV.MdiParent = MF;
                _fTGV.Show();
            }
            else
                _fTGV.Activate();
        }

        public static fSuaGiangVien _fSGV = null;
        public static void ShowFormSGV(fMain MF)
        {
            if (_fSGV == null || _fSGV.IsDisposed)
            {
                _fSGV = new fSuaGiangVien();
                // _fSGV.RefToMainForm = MF;
                _fSGV.MdiParent = MF;
                _fSGV.Show();
            }
            else
                _fSGV.Activate();
        }

        public static fThemPhongHoc _fTPH = null;
        public static void ShowFormTPH(fMain MF)
        {
            if (_fTPH == null || _fTPH.IsDisposed)
            {
                _fTPH = new fThemPhongHoc();
                // _fTPH.RefToMainForm = MF;
                _fTPH.MdiParent = MF;
                _fTPH.Show();
            }
            else
                _fTPH.Activate();
        }

        public static fSuaPhongHoc _fSPH = null;
        public static void ShowFormSPH(fMain MF)
        {
            if (_fSPH == null || _fSPH.IsDisposed)
            {
                _fSPH = new fSuaPhongHoc();
                // _fSPH.RefToMainForm = MF;
                _fSPH.MdiParent = MF;
                _fSPH.Show();
            }
            else
                _fSPH.Activate();
        }
        public static fThemLoaiKyThi _fTLKT = null;
        public static void ShowFormTLKT(fMain MF)
        {
            if (_fTLKT == null || _fTLKT.IsDisposed)
            {
                _fTLKT = new fThemLoaiKyThi();
                //  _fTKQTXL.RefToMainForm = MF;
                _fTLKT.MdiParent = MF;
                _fTLKT.Show();
            }
            else
                _fTLKT.Activate();
        }
        public static fBaoCaoHocVienDangKyMoi _fBCHVDK = null;
        public static void ShowFormBCHVDK(fMain MF)
        {
            if (_fBCHVDK == null || _fBCHVDK.IsDisposed)
            {
                _fBCHVDK = new fBaoCaoHocVienDangKyMoi();
                //  _fBCHVDK.RefToMainForm = MF;
                _fBCHVDK.MdiParent = MF;
                _fBCHVDK.Show();
            }
            else
                _fBCHVDK.Activate();
        }
        public static fSuaLoaiKyThi _fSLKT = null;
        public static void ShowFormSLKT(fMain MF)
        {
            if (_fSLKT == null || _fSLKT.IsDisposed)
            {
                _fSLKT = new fSuaLoaiKyThi();
                // _fTKQTXL.RefToMainForm = MF;
                _fSLKT.MdiParent = MF;
                _fSLKT.Show();
            }
            else
                _fSLKT.Activate();
        }
        public static fThemKyThi _fTKT = null;
        public static void ShowFormTKT(fMain MF)
        {
            if(_fTKT==null || _fTKT.IsDisposed)
            {
                _fTKT = new fThemKyThi();
                _fTKT.MdiParent = MF;
                _fTKT.Show();
            }
            else
            {
                _fTKT.Activate();
            }
        }

        public static fSuaKyThi _fSKT = null;
        public static void ShowFormSKT(fMain MF)
        {
            if (_fSKT == null || _fSKT.IsDisposed)
            {
                _fSKT = new fSuaKyThi();
                _fSKT.MdiParent = MF;
                _fSKT.Show();
            }
            else
            {
                _fSKT.Activate();
            }
        }
        public static fNhapKetQuaThi _fNKQT = null;
        public static void ShowFormNKQT(fMain MF)
        {
            if (_fNKQT == null || _fNKQT.IsDisposed)
            {
                _fNKQT = new fNhapKetQuaThi();
                //  _fTKQTXL.RefToMainForm = MF;
                _fNKQT.MdiParent = MF;
                _fNKQT.Show();
            }
            else
                _fNKQT.Activate();
        }

        public static fSuaKetQuaThi _fSKQT = null;
        public static void ShowFormSKQT(fMain MF)
        {
            if (_fSKQT == null || _fSKQT.IsDisposed)
            {
                _fSKQT = new fSuaKetQuaThi();
                //  _fSKQTXL.RefToMainForm = MF;
                _fSKQT.MdiParent = MF;
                _fSKQT.Show();
            }
            else
                _fSKQT.Activate();
        }
        public static fThemDeThi _fTDT = null;
        public static void ShowFormTDT(fMain MF)
        {
            if(_fTDT==null || _fTDT.IsDisposed)
            {
                _fTDT = new fThemDeThi();
                _fTDT.MdiParent = MF;
                _fTDT.Show();
            }
        }

        public static fSuaDeThi _fSDT = null;
        public static void ShowFormSDT(fMain MF)
        {
            if (_fSDT == null || _fSDT.IsDisposed)
            {
                _fSDT = new fSuaDeThi();
                _fSDT.MdiParent = MF;
                _fSDT.Show();
            }
        }
        public static fKetQuaThi _fKQT = null;
        public static void ShowFormKQT(fMain MF)
        {
            if (_fKQT == null || _fKQT.IsDisposed)
            {
                _fKQT = new fKetQuaThi();
                //  _fKQTXL.RefToMainForm = MF;
                _fKQT.MdiParent = MF;
                _fKQT.Show();
            }
            else
                _fKQT.Activate();
        }

        public static fThemKetQuaThiCuoiKhoa _fTKQTCK = null;
        public static void ShowFormTKQTCK(fMain MF)
        {
            if (_fTKQTCK == null || _fTKQTCK.IsDisposed)
            {
                _fTKQTCK = new fThemKetQuaThiCuoiKhoa();
                //  _fTKQTCK.RefToMainForm = MF;
                _fTKQTCK.MdiParent = MF;
                _fTKQTCK.Show();
            }
            else
                _fTKQTCK.Activate();
        }

        public static fSuaKetQuaThiCuoiKhoa _fSKQTCK = null;
        public static void ShowFormSKQTCK(fMain MF)
        {
            if (_fSKQTCK== null || _fSKQTCK.IsDisposed)
            {
                _fSKQTCK = new fSuaKetQuaThiCuoiKhoa();
                //  _fSKQTCK.RefToMainForm = MF;
                _fSKQTCK.MdiParent = MF;
                _fSKQTCK.Show();
            }
            else
                _fSKQTCK.Activate();
        }

        public static fKetQuaThiCuoiKhoa _fKQTCK = null;
        public static void ShowFormKQTCK(fMain MF)
        {
            if (_fKQTCK == null || _fKQTCK.IsDisposed)
            {
                _fKQTCK = new fKetQuaThiCuoiKhoa();
                //  _fKQTCK.RefToMainForm = MF;
                _fKQTCK.MdiParent = MF;
                _fKQTCK.Show();
            }
            else
                _fKQTCK.Activate();
        }

        

        public static fPhanQuyen _fPQ = null;
        public static void ShowFormPQ(fMain MF)
        {
            if (_fPQ == null || _fPQ.IsDisposed)
            {
                _fPQ = new fPhanQuyen();
                // _fPQ.RefToMainForm = MF;
                _fPQ.MdiParent = MF;
                _fPQ.Show();
            }
            else
                _fPQ.Activate();
        }

        public static fThemQuanLy _fTQL = null;
        public static void ShowFormTQL(fMain MF)
        {
            if (_fTQL == null || _fTQL.IsDisposed)
            {
                _fTQL = new fThemQuanLy();
                // _fTQL.RefToMainForm = MF;
                _fTQL.MdiParent = MF;
                _fTQL.Show();
            }
            else
                _fTQL.Activate();
        }

        public static fSuaQuanLy _fSQL = null;
        public static void ShowFormSQL(fMain MF)
        {
            if (_fSQL == null || _fSQL.IsDisposed)
            {
                _fSQL = new fSuaQuanLy();
                // _fSQL.RefToMainForm = MF;
                _fSQL.MdiParent = MF;
                _fSQL.Show();
            }
            else
                _fSQL.Activate();
        }

        public static fDanhSachHocVien _fDSHV = null;
        public static void ShowFormDSHV(fMain MF)
        {
            if (_fDSHV == null || _fDSHV.IsDisposed)
            {
                _fDSHV = new fDanhSachHocVien();

                _fDSHV.MdiParent = MF;
                _fDSHV.Show();
            }
            else
                _fDSHV.Activate();
        }
        public static fDanhSachLop _fDSL = null;
        public static void ShowFormDSL(fMain MF)
        {
            if (_fDSL == null || _fDSL.IsDisposed)
            {
                _fDSL = new fDanhSachLop();

                _fDSL.MdiParent = MF;
                _fDSL.Show();
            }
            else
                _fDSL.Activate();
        }

        public static fBaoCaoTongHocPhiLop _fBCHP = null;
        public static void ShowFormBCHP(fMain MF)
        {
            if (_fBCHP == null || _fBCHP.IsDisposed)
            {
                _fBCHP = new fBaoCaoTongHocPhiLop();

                _fBCHP.MdiParent = MF;
                _fBCHP.Show();
            }
            else
                _fBCHP.Activate();
        }
        public static fDSCacLopHoc _fDSCL = null;
        public static void ShowFormDSCL(fMain MF)
        {
            if (_fDSCL == null || _fDSCL.IsDisposed)
            {
                _fDSCL = new fDSCacLopHoc();

                _fDSCL.MdiParent = MF;
                _fDSCL.Show();
            }
            else
                _fDSCL.Activate();
        }
        public static fLapPhieuThuHocPhi _fLPTHP = null;
        public static void ShowFormLPTHP(fMain MF)
        {
            if (_fLPTHP == null || _fLPTHP.IsDisposed)
            {
                _fLPTHP = new fLapPhieuThuHocPhi();

                _fLPTHP.MdiParent = MF;
                _fLPTHP.Show();
            }
            else
                _fLPTHP.Activate();
        }

        //CLOSE FORM CHILD
        public bool CloseForm(Form F)
        {
            if (_fTKH != F)
            {
                if ((_fTKH != null) && (!_fTKH.IsDisposed))
                {
                    _fTKH.Close();
                }
            }
            if (_fSKH != F)
            {
                if ((_fSKH != null) && (!_fSKH.IsDisposed))
                {
                    _fSKH.Close();
                }
            }
            if (_fTLH != F)
            {
                if ((_fTLH != null) && (!_fTLH.IsDisposed))
                {
                    _fTLH.Close();
                }
            }
            if (_fSLH != F)
            {
                if ((_fSLH != null) && (!_fSLH.IsDisposed))
                {
                    _fSLH.Close();
                }
            }
            if (_fTHVTN != F)
            {
                if ((_fTHVTN != null) && (!_fTHVTN.IsDisposed))
                {
                    _fTHVTN.Close();
                }
            }
            if (_fSHVTN != F)
            {
                if ((_fSHVTN != null) && (!_fSHVTN.IsDisposed))
                {
                    _fSHVTN.Close();
                }
            }
            if (_fBCHVDK != F)
            {
                if ((_fBCHVDK != null) && (!_fBCHVDK.IsDisposed))
                {
                    _fBCHVDK.Close();
                }
            }
            if (_fTHVCT != F)
            {
                if ((_fTHVCT != null) && (!_fTHVCT.IsDisposed))
                {
                    _fTHVCT.Close();
                }
            }
            if (_fSHVCT != F)
            {
                if ((_fSHVCT != null) && (!_fSHVCT.IsDisposed))
                {
                    _fSHVCT.Close();
                }
            }
            if (_fTLDT!= F)
            {
                if ((_fTLDT != null) && (!_fTLDT.IsDisposed))
                {
                    _fTLDT.Close();
                }
            }
            if (_fSLDT != F)
            {
                if ((_fSLDT != null) && (!_fSLDT.IsDisposed))
                {
                    _fSLDT.Close();
                }
            }
            if (_fTCTH != F)
            {
                if ((_fTCTH != null) && (!_fTCTH.IsDisposed))
                {
                    _fTCTH.Close();
                }
            }
            if (_fSCTH != F)
            {
                if ((_fSCTH != null) && (!_fSCTH.IsDisposed))
                {
                    _fSCTH.Close();
                }
            }
            if (_fSCTH != F)
            {
                if ((_fSCTH != null) && (!_fSCTH.IsDisposed))
                {
                    _fSCTH.Close();
                }
            }
            if (_fTLiH != F)
            {
                if ((_fTLiH != null) && (!_fTLiH.IsDisposed))
                {
                    _fTLiH.Close();
                }
            }
            if (_fSLiH != F)
            {
                if ((_fSLiH != null) && (!_fSLiH.IsDisposed))
                {
                    _fSLiH.Close();
                }
            }
             
            if (_fTGV != F)
            {
                if ((_fTGV!= null) && (!_fTGV.IsDisposed))
                {
                    _fTGV.Close();
                }
            }
            if (_fSGV != F)
            {
                if ((_fSGV != null) && (!_fSGV.IsDisposed))
                {
                    _fSGV.Close();
                }
            }
            if (_fTPH != F)
            {
                if ((_fTPH != null) && (!_fTPH.IsDisposed))
                {
                    _fTPH.Close();
                }
            }
            if (_fSPH != F)
            {
                if ((_fSPH != null) && (!_fSPH.IsDisposed))
                {
                    _fSPH.Close();
                }
            }

            if (_fTLKT != F)
            {
                if ((_fTLKT != null) && (!_fTLKT.IsDisposed))
                {
                    _fTLKT.Close();
                }
            }
            if (_fSLKT != F)
            {
                if ((_fSLKT != null) && (!_fSLKT.IsDisposed))
                {
                    _fSLKT.Close();
                }
            }
            if (_fTKT != F)
            {
                if ((_fTKT != null) && (!_fTKT.IsDisposed))
                {
                    _fTKT.Close();
                }
            }
            if (_fSKT != F)
            {
                if ((_fSKT != null) && (!_fSKT.IsDisposed))
                {
                    _fSKT.Close();
                }
            }
            if (_fTDT != F)
            {
                if ((_fTDT != null) && (!_fTDT.IsDisposed))
                {
                    _fTDT.Close();
                }
            }
            if (_fSDT != F)
            {
                if ((_fSDT != null) && (!_fSDT.IsDisposed))
                {
                    _fSDT.Close();
                }
            }
            if (_fNKQT != F)
            {
                if ((_fNKQT != null) && (!_fNKQT.IsDisposed))
                {
                    _fNKQT.Close();
                }
            }
            if (_fSKQT!= F)
            {
                if ((_fSKQT != null) && (!_fSKQT.IsDisposed))
                {
                    _fSKQT.Close();
                }
            }
            if (_fKQT != F)
            {
                if ((_fKQT != null) && (!_fKQT.IsDisposed))
                {
                    _fKQT.Close();
                }
            }
            if (_fTKQTCK!= F)
            {
                if ((_fTKQTCK != null) && (!_fTKQTCK.IsDisposed))
                {
                    _fTKQTCK.Close();
                }
            }
            if (_fSKQTCK != F)
            {
                if ((_fSKQTCK != null) && (!_fSKQTCK.IsDisposed))
                {
                    _fSKQTCK.Close();
                }
            }
            if (_fKQTCK != F)
            {
                if ((_fKQTCK != null) && (!_fKQTCK.IsDisposed))
                {
                    _fKQTCK.Close();
                }
            }
            if (_fPQ != F)
            {
                if ((_fPQ != null) && (!_fPQ.IsDisposed))
                {
                    _fPQ.Close();
                }
            }
            if (_fTQL != F)
            {
                if ((_fTQL != null) && (!_fTQL.IsDisposed))
                {
                    _fTQL.Close();
                }
            }
            if (_fSQL != F)
            {
                if ((_fSQL != null) && (!_fSQL.IsDisposed))
                {
                    _fSQL.Close();
                }
            }
            if (_fDSHV != F)
            {
                if ((_fDSHV != null) && (!_fDSHV.IsDisposed))
                {
                    _fDSHV.Close();
                }
            }

            if (_fDSL != F)
            {
                if ((_fDSL != null) && (!_fDSL.IsDisposed))
                {
                    _fDSL.Close();
                }
            }

            if (_fDSCL != F)
            {
                if ((_fDSCL != null) && (!_fDSCL.IsDisposed))
                {
                    _fDSCL.Close();
                }
            }
            if (_fBCHP != F)
            {
                if ((_fBCHP != null) && (!_fBCHP.IsDisposed))
                {
                    _fBCHP.Close();
                }
            }
            return true;
        }

        //EVENT CALL FORM CHILD
        private void btnThemKhoaHoc_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fTKH))
                ShowFormTKH(this);
        }

        private void btnSuaKhoaHoc_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fSKH))
                ShowFormSKH(this);
        }

        private void btnThemLopHoc_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fTLH))
                ShowFormTLH(this);
        }

        private void btnSuaLopHoc_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fSLH))
                ShowFormSLH(this);
        }

        private void btnThemHVTN_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fTHVTN))
                ShowFormTHVTN(this);
        }

        private void btnSuaHVTN_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fSHVTN))
               ShowFormSHVTN(this);
       }

        private void btnThemHVCT_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fTHVCT))
                ShowFormTHVCT(this);
        }

        private void btnSuaHVCT_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fSHVCT))
                ShowFormSHVCT(this);
        }
        
        private void btnThemCTHoc_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fTCTH))
                ShowFormTCTH(this);
        }

        private void btnSuaCTHoc_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fSCTH))
                ShowFormSCTH(this);
        }

        private void btnThemLichHoc_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fTLiH))
                ShowFormTLiH(this);
        }

        private void btnSuaLichHoc_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fSLiH))
                ShowFormSLiH(this);
        }
        
        private void btnThemGV_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fTGV))
                ShowFormTGV(this);
        }

        private void btnSuaGV_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fSGV))
                ShowFormSGV(this);
        }

        private void btnThemPhongHoc_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fTPH))
                ShowFormTPH(this);
        }

        private void btnSuaPhongHoc_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fSPH))
                ShowFormSPH(this);
        }

        private void btnKetQuaThi_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fKQT))
                ShowFormKQT(this);
        }
        private void btnSuaKQThiXL_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fSKQT))
                ShowFormSKQT(this);
        }
        private void btnXemKQThiXL_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fKQT))
                ShowFormKQT(this);
        }
        private void btnThemKQThiCuoiKhoa_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fTKQTCK))
                ShowFormTKQTCK(this);
        }

        private void btnSuaKQThiCuoiKhoa_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fSKQTCK))
                ShowFormSKQTCK(this);
        }
        private void btnXemKQThiCuoiKhoa_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fKQTCK))
                ShowFormKQTCK(this);
        }
        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fPQ))
                ShowFormPQ(this);
        }
        private void btnThemQuanLy_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fTQL))
                ShowFormTQL(this);
        }

        private void btnSuaQuanLy_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fSQL))
                ShowFormSQL(this);
        }

        private void applicationButton1_Click(object sender, EventArgs e)
        {

        }

        private void ribbonBar9_ItemClick(object sender, EventArgs e)
        {

        }

        private void btnSuaLoaiKyThi_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fSLKT))
                ShowFormSLKT(this);
        }

        private void btnThemLoaiKyThi_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fTLKT))
                ShowFormTLKT(this);
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void btnThemLoaiDeThi_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fTLDT))
                ShowFormTLDT(this);
        }
        private void btnSuaLoaiDeThi_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fSLDT))
                ShowFormSLDT(this);
        }
        private void btnThemDeThi_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fTDT))
                ShowFormTDT(this);
        }

        private void btnSuaDeThi_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fSDT))
                ShowFormSDT(this);
        }

        private void btnThemKyThi_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fTKT))
                ShowFormTKT(this);
        }

        private void btnSuaKyThi_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fSKT))
                ShowFormSKT(this);
        }

        private void btnNhapKetQuaThi_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fNKQT))
                ShowFormNKQT(this);
        }

        private void ribbonBar10_ItemClick(object sender, EventArgs e)
        {

        }

        private void btnDanhSachHocVien_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fDSHV))
                ShowFormDSHV(this);
        }

        private void btnDanhSachLop_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fDSL))
                ShowFormDSL(this);
        }

        private void btnDanhSachCacLop_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fDSCL))
                ShowFormDSCL(this);
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fBCHVDK))
                ShowFormBCHVDK(this);
        }

        private void btnTongHocPhi_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fBCHP))
                ShowFormBCHP(this);
        }

        private void btnLapPhieuThuHocPhi_Click(object sender, EventArgs e)
        {
            if (CloseForm(_fLPTHP))
                ShowFormLPTHP(this);
        }
       
    }
}