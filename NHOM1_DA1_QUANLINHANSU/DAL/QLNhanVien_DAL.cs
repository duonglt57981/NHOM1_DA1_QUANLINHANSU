using Microsoft.EntityFrameworkCore;
using NHOM1_DA1_QUANLINHANSU.DTO;
using NHOM1_DA1_QUANLINHANSU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHOM1_DA1_QUANLINHANSU.DAL
{
    internal class QLNhanVien_DAL
    {
        Nhom1Da1QlnhansuContext _db = new Nhom1Da1QlnhansuContext();

        public List<QLNhanVien_DTO> GetAllNhanVien()
        {
            return _db.Nhanviens.Include(nv => nv.IdcongViecNavigation)
               .Include(nv => nv.IdphongBanNavigation)
               .Include(nv => nv.IdtrinhDoNavigation)
               .Include(nv => nv.IdvaiTroNavigation).ToList()
               .Select((x, index) => new QLNhanVien_DTO
               {
                   STT = index + 1,
                   Idnv = x.Idnv,
                   TenNv = x.TenNv,
                   GioiTinh = x.GioiTinh,
                   NgaySinh = x.NgaySinh,
                   DiaChi = x.DiaChi,
                   Sdt = x.Sdt,
                   Cccd = x.Cccd,
                   SoTienPhuCap = x.SoTienPhuCap,
                   TrangThai = x.TrangThai,
                   TenPhongBan = x.IdphongBanNavigation.TenPhongBan,
                   MoTaPB = x.IdphongBanNavigation.MoTa,
                   TenCongViec = x.IdcongViecNavigation.TenCongViec,
                   MoTaCV = x.IdcongViecNavigation.MoTa,
                   TenTrinhDo = x.IdtrinhDoNavigation.TenTrinhDo,
                   MoTaTD = x.IdtrinhDoNavigation.MoTa,
                   TenVaiTro = x.IdvaiTroNavigation.TenVaiTro,
                   MoTaVT = x.IdvaiTroNavigation.MoTa,

               }).ToList();
            
        }

        public List<Phongban> GetPhongban()
        {
            return _db.Phongbans.ToList();
        }

        public List<Congviec> GetCongViec()
        {
            return _db.Congviecs.ToList();
        }

        public List<Trinhdo> GetTrinhDo()
        {
            return _db.Trinhdos.ToList();
        }

        public List<Vaitro> GetVaiTro()
        {
            return _db.Vaitros.ToList();
        }

        public void AddNhanVien(Nhanvien nhanVien)
        {
            try
            {
                _db.Nhanviens.Add(nhanVien);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm nhân viên: " + ex.Message);
            }
        }
    }
}
