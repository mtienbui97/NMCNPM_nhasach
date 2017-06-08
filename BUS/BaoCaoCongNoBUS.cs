using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BaoCaoCongNoBUS
    {
        #region 1. Inserting
        public static void InsertBaoCaoCongNo()
        {
          
        }

        public static void UpdateBaoCaoCongNo(BaoCaoCongNoDTO baocaocongno)
        {
            if (BaoCaoCongNoDAO.CheckBaoCaoCongNoByMaKhachHangvaThang(baocaocongno.MaKhachHang, baocaocongno.Thang))
            {

                BaoCaoCongNoDAO.UpdateBaoCaoCongNo(baocaocongno);
            }
            else
            {
                BaoCaoCongNoDAO.InsertBaoCaoCongNo(baocaocongno);
            }
        }

        public static BaoCaoCongNoDTO SelectBaoCaoCongNoByMaKhachHangvaThang(string maKhachHang, DateTime thang)
        {
            return BaoCaoCongNoDAO.SelectBaoCaoCongNoByMaKhachHangvaThang(maKhachHang, thang);
        }

        public static BaoCaoCongNoDTO SelectBaoCaoCongNoByMaKhachHangvaThangTruoc(string maKhachHang, DateTime thang)
        {
           
           return BaoCaoCongNoDAO.SelectBaoCaoCongNoByMaKhachHangvaThang(maKhachHang, thang);
        }


        public static bool CheckBaoCaoCongNoByMaKhachHangvaThang(string maKhachHang, DateTime thang)
        {
            return BaoCaoCongNoDAO.CheckBaoCaoCongNoByMaKhachHangvaThang(maKhachHang, thang);
        }

        #endregion
    }
}
