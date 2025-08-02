using NHOM1_DA1_QUANLINHANSU.DAL;
using NHOM1_DA1_QUANLINHANSU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHOM1_DA1_QUANLINHANSU.BLL
{
    internal class BLL_QLHopDong
    {
        private DAL_QLHopDong QLHD_DAL = new DAL_QLHopDong();

        public List<DTO.DTO_QLHopDong> GetAllHopDong()
        {
            return QLHD_DAL.GetAllHopDong();
        }
        public List<Loaihopdong> GetAllLoaiHopDong()
        {
            return QLHD_DAL.GetAllLoaiHopDong();
        }

        public List<Nhanvien> GetAllNhanVien()
        {
            return QLHD_DAL.GetAllNhanVien();
        }

        public void ThemHopDong(Hopdong hopdong)
        {
            QLHD_DAL.ThemHopDong(hopdong);
        }
    }
}
