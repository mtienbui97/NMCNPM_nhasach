using System;
using System.Collections.Generic;
using System.Linq;
using System.Text
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class PhieuThuTienBUS
    {
       
        public static bool InsertPhieuThuTien(PhieuThuTienDTO phieuthu)
        {
            var baocaocongno_moi = new BaoCaoCongNoDTO();
            var baocaocongno_truoc = BaoCaoCongNoBUS.SelectBaoCaoCongNoByMaKhachHangvaThangTruoc(phieuthu.MaKhachHang, phieuthu.NgayThu);
            var khachhang = KhachHangDAO.SelectKhachHangByMaKhachHang(phieuthu.MaKhachHang);
            baocaocongno_moi.MaKhachHang = khachhang.MaKhachHang;
            baocaocongno_moi.Thang = phieuthu.NgayThu;
            if (ThamSoBUS.CheckApDungQuiDinh4())
            {
                phieuthu.SoTienThu = khachhang.SoTienNo;
                if (phieuthu.NgayThu.Date.ToString() == "1")
                {
                    baocaocongno_moi.NoDau = baocaocongno_truoc.NoCuoi;
                }
                if(baocaocongno_moi.NoDau == khachhang.SoTienNo)
                {
                    baocaocongno_moi.NoPhatSinh = 0;
                    baocaocongno_moi.NoCuoi = khachhang.SoTienNo;
                }
                baocaocongno_moi.NoCuoi = baocaocongno_moi.NoCuoi = phieuthu.SoTienThu;
                baocaocongno_moi.NoPhatSinh = baocaocongno_moi.NoPhatSinh - phieuthu.SoTienThu;
                khachhang.SoTienNo = khachhang.SoTienNo - phieuthu.SoTienThu;
                if (BaoCaoCongNoBUS.CheckBaoCaoCongNoByMaKhachHangvaThang(phieuthu.MaKhachHang, phieuthu.NgayThu))
                {
                    BaoCaoCongNoBUS.UpdateBaoCaoCongNo(baocaocongno_moi);
                }
                else
                {
                    BaoCaoCongNoBUS.InsertBaoCaoCongNo(baocaocongno_moi);
                }
            }
            else
            {

            }
        }
        public static string GenerateNewMaPhieuThu()
        {
            return PhieuThuTienDAO.GenerateNewMaPhieuThu();
        }


    }
}
