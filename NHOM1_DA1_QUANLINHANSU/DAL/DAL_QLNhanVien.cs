using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NHOM1_DA1_QUANLINHANSU.DTO;
using NHOM1_DA1_QUANLINHANSU.Models;

namespace NHOM1_DA1_QUANLINHANSU.DAL
{
    internal class DAL_QLNhanVien
    {
        private Nhom1Da1QlnsContext _db = new Nhom1Da1QlnsContext();

        public List<DTO_QLNhanVien> GetAllNhanVien()
        {
            return   _db.Nhanviens.Include(nv => nv.IdphongBanNavigation)
                .Include(nv => nv.IdcongViecNavigation)
                .Include(nv => nv.IdtrinhDoNavigation).ToList()
                .Select((x, index) => new DTO_QLNhanVien
                {
                    STT = index + 1,
                    Idnv = x.Idnv,
                    TenNv = x.TenNv,
                    GioiTinh = x.GioiTinh,
                    NgaySinh = x.NgaySinh,
                    Sdt = x.Sdt,
                    Cccd = x.Cccd,
                    DiaChi = x.DiaChi,
                    HinhAnh = x.HinhAnh,
                    SoTienPhuCap = x.SoTienPhuCap,
                    TrangThai = x.TrangThai,
                    IdtaiKhoan = x.IdtaiKhoan,
                    TenPhongBan = x.IdphongBanNavigation.TenPhongBan,
                    TenCongViec = x.IdcongViecNavigation.TenCongViec,
                    TenTrinhDo = x.IdtrinhDoNavigation.TenTrinhDo
                }).ToList();
        }

        public List<Phongban> GetPhongBAN()
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

        public void ThemNhanVien(Nhanvien nv)
        {
            try
            {
                _db.Nhanviens.Add(nv);
                _db.SaveChanges();
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm nhân viên: " + ex.Message);
            }
        }
    }
}
