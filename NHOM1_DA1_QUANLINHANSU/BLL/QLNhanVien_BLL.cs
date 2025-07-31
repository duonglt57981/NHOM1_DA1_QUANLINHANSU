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
    internal class QLNhanVien_BLL
    {
        private QLNhanVien_DAL QLNV_DAL = new QLNhanVien_DAL();

        public List<QLNhanVien_DTO> GetAllNhanVien()
        {
            return QLNV_DAL.GetAllNhanVien();
        }

        public List<Phongban> GetPhongban()
        {
            return QLNV_DAL.GetPhongban();
        }

        public List<Congviec> GetCongViec()
        {
            return QLNV_DAL.GetCongViec();
        }

        public List<Trinhdo> GetTrinhDo()
        {
            return QLNV_DAL.GetTrinhDo();
        }

        public List<Vaitro> GetVaiTro()
        {
            return QLNV_DAL.GetVaiTro();
        }

        public void AddNhanVien(Nhanvien nhanVien)
        {
            QLNV_DAL.AddNhanVien(nhanVien);
        }


    }
}
