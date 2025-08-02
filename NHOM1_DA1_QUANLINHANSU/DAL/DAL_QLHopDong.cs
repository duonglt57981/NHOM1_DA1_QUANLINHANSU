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
    internal class DAL_QLHopDong
    {
        private Nhom1Da1QlnsContext _db = new Nhom1Da1QlnsContext();

        public List<DTO_QLHopDong> GetAllHopDong()
        {
            return _db.Hopdongs.Include(nv => nv.IdnvNavigation)
                .Include(nv => nv.IdloaiHdNavigation).ToList()
                .Select((x, index) => new DTO_QLHopDong
                {
                    STT = index + 1,
                    SoHopDong = x.SoHopDong,
                    TenHopDong = x.IdloaiHdNavigation.TenHopDong,
                    NgayBd = x.NgayBd,
                    NgayKt = x.NgayKt,
                    NgayKiHopDong = x.NgayKiHopDong,
                    LanKi = x.LanKi,
                    NoiDung = x.NoiDung,
                    ThoiHan = x.ThoiHan,
                    HeSoLuong = x.HeSoLuong,
                    LuongCoBan = x.LuongCoBan,
                    TrangThai = x.TrangThai,
                    TenNv = x.IdnvNavigation.TenNv,
                    Sdt = x.IdnvNavigation.Sdt,
                    Cccd = x.IdnvNavigation.Cccd,
                    DiaChi = x.IdnvNavigation.DiaChi
                }).ToList();
        }

        public List<Loaihopdong> GetAllLoaiHopDong()
        {
            return _db.Loaihopdongs.ToList();
        }

        public List<Nhanvien> GetAllNhanVien()
        {
            return _db.Nhanviens.ToList()
                .Select(nv => new Nhanvien
                {
                    Idnv = nv.Idnv,
                    TenNv = nv.TenNv,
                    Sdt = nv.Sdt,
                    Cccd = nv.Cccd,
                    DiaChi = nv.DiaChi
                }).ToList();
        }

        public void ThemHopDong(Hopdong hopdong)
        {
            try
            {
                _db.Hopdongs.Add(hopdong);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm hợp đồng: " + ex.Message);
            }
        }
    }
}
