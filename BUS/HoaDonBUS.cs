using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class HoaDonBUS
    {
        public static string GenerateNewMaHoaDon()
        {
            return HoaDonDAO.GenerateNewMaHoaDon();
        }
    }
}
