using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAO;

using DTO;

namespace BUS
{
    public class PhieuNhapBUS
    {
        #region 1. Inserting

        public static bool InsertPhieuNhap(PhieuNhapDTO phieuNhap, List <ChiTietPhieuNhapDTO> listChiTietPhieuNhap)
        {
            if (PhieuNhapDAO.CheckPhieuNhapByMaPhieuNhap(phieuNhap.MaPhieuNhap))
            {
                throw new Exception("Mã phiếu nhập đã tồn tại");
            }

            foreach ( var chiTietPhieuNhap in listChiTietPhieuNhap )
            {
                if ( ChiTietPhieuNhapDAO.CheckChiTietPhieuNhapByMaChiTietPhieuNhap (
                    chiTietPhieuNhap.MaChiTietPhieuNhap ) )
                {
                    throw new Exception ( "Mã chi tiết phiếu nhập đã tồn tại" );
                }

                if ( chiTietPhieuNhap.SoLuongNhap < ThamSoDAO.SelectThamSoAll().SoLuongNhapItNhat)
                {
                    throw new Exception (
                        $"Sách có mã {chiTietPhieuNhap.MaSach} có số lượng nhập ít hơn {ThamSoDAO.SelectThamSoAll( ).SoLuongNhapItNhat}" );
                }

                if ( SachDAO.SelectSachByMaSach ( chiTietPhieuNhap.MaSach ).SoLuongTon >
                     ThamSoDAO.SelectSoLuongTonToiDaTruocNhap ( ) )
                {
                    throw new Exception (
                        $"Sách có mã {chiTietPhieuNhap.MaSach} có số lượng tồn nhiều hơn {ThamSoDAO.SelectSoLuongTonToiDaTruocNhap ( )}" );
                }
            }

            PhieuNhapDAO.InsertPhieuNhap(phieuNhap);
            foreach ( var chiTietPhieuNhap in listChiTietPhieuNhap )
            {
                chiTietPhieuNhap.MaChiTietPhieuNhap = ChiTietPhieuNhapDAO.GenerateNewMaChiTietPhieuNhap ( );
                
                ChiTietPhieuNhapDAO.InsertChiTietPhieuNhap ( chiTietPhieuNhap );

                SachDTO sach = SachDAO.SelectSachByMaSach(chiTietPhieuNhap.MaSach);
                sach.SoLuongTon += chiTietPhieuNhap.SoLuongNhap;
                SachDAO.UpdateSach(sach);
            }

            return true;
        }

        #endregion
        #region 2. Update
        
        #endregion
        #region 4. Retrieving

        public static string GenerateNewMaPhieuNhap ( )
        {
            return PhieuNhapDAO.GenerateNewMaPhieuNhap ( );
        }

        #endregion
    }
}
