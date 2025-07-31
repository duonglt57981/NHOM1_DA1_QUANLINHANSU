using NHOM1_DA1_QUANLINHANSU.DAL;
using NHOM1_DA1_QUANLINHANSU.DTO;
using NHOM1_DA1_QUANLINHANSU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHOM1_DA1_QUANLINHANSU.BLL
{
    internal class BLL_QLNhanVien
    {
        private DAL_QLNhanVien QLNV_DAL = new DAL_QLNhanVien();

        public List<DTO_QLNhanVien> GetAllNhanVien()
        {
            return QLNV_DAL.GetAllNhanVien();
        }

        public List<Phongban> GetPhongBAN()
        {
            return QLNV_DAL.GetPhongBAN();
        }

        public List<Congviec> GetCongViec()
        {
            return QLNV_DAL.GetCongViec();
        }
        public List<Trinhdo> GetTrinhDo()
        {
            return QLNV_DAL.GetTrinhDo();
        }

        public void ThemNhanVien(Nhanvien nv)
        {
            QLNV_DAL.ThemNhanVien(nv);
        }
    }
}
