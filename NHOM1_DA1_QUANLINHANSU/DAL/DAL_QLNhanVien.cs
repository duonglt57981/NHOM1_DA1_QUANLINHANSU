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
                .Include(nv => nv.IdtrinhDoNavigation)
                .Include(nv => nv.IdtaiKhoanNavigation).ToList()
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
                    TenTaiKhoan = x.IdtaiKhoanNavigation.TenTaiKhoan,
                    TenPhongBan = x.IdphongBanNavigation?.TenPhongBan,
                    TenCongViec = x.IdcongViecNavigation?.TenCongViec,
                    MoTaCV = x.IdcongViecNavigation?.MoTa,
                    TenTrinhDo = x.IdtrinhDoNavigation?.TenTrinhDo
                }).ToList();
        }

        public bool KiemTraTaiKhoan( int IDTK)
        {
            return _db.Nhanviens.Any(nv => nv.IdtaiKhoan == IDTK);
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

        public List<Taikhoan> GetTaiKhoan()
        {
            return _db.Taikhoans.ToList();
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

        public void SuaNhanVien(Nhanvien NewNV)
        {
            try
            {
                var OldNV = _db.Nhanviens.FirstOrDefault(nv => nv.Idnv == NewNV.Idnv);
                if (OldNV != null)
                {
                    OldNV.TenNv = NewNV.TenNv  == null? OldNV.TenNv : NewNV.TenNv;
                    OldNV.GioiTinh = NewNV.GioiTinh == null? OldNV.GioiTinh : NewNV.GioiTinh;
                    OldNV.NgaySinh = NewNV.NgaySinh == null? OldNV.NgaySinh : NewNV.NgaySinh;
                    OldNV.Sdt = NewNV.Sdt == null? OldNV.Sdt : NewNV.Sdt;
                    OldNV.Cccd = NewNV.Cccd == null? OldNV.Cccd : NewNV.Cccd;
                    OldNV.DiaChi = NewNV.DiaChi == null? OldNV.DiaChi : NewNV.DiaChi;
                    OldNV.HinhAnh = NewNV.HinhAnh == null ? OldNV.HinhAnh : NewNV.HinhAnh;
                    OldNV.SoTienPhuCap = NewNV.SoTienPhuCap == null ? OldNV.SoTienPhuCap : NewNV.SoTienPhuCap ;
                    OldNV.TrangThai = NewNV.TrangThai == null ? OldNV.TrangThai : NewNV.TrangThai;
                    if(NewNV.IdphongBanNavigation != null 
                        && NewNV.IdcongViecNavigation != null
                        && NewNV.IdtrinhDoNavigation != null
                        && NewNV.IdtaiKhoanNavigation != null)
                    {
                        OldNV.IdphongBanNavigation.TenPhongBan = NewNV.IdphongBanNavigation.TenPhongBan == null
                            ? OldNV.IdphongBanNavigation.TenPhongBan: NewNV.IdphongBanNavigation.TenPhongBan;
                        OldNV.IdcongViecNavigation.TenCongViec = NewNV.IdcongViecNavigation.TenCongViec == null
                            ? OldNV.IdcongViecNavigation.TenCongViec : NewNV.IdcongViecNavigation.TenCongViec;
                        OldNV.IdtrinhDoNavigation.TenTrinhDo = NewNV.IdtrinhDoNavigation.TenTrinhDo == null
                            ? OldNV.IdtrinhDoNavigation.TenTrinhDo : NewNV.IdtrinhDoNavigation.TenTrinhDo;
                        OldNV.IdtaiKhoanNavigation.TenTaiKhoan = NewNV.IdtaiKhoanNavigation.TenTaiKhoan == null ?
                            OldNV.IdtaiKhoanNavigation.TenTaiKhoan : NewNV.IdtaiKhoanNavigation.TenTaiKhoan;
                    }
                    _db.SaveChanges();
                    MessageBox.Show("Sửa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nhân viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi sửa nhân viên: " + ex.Message);
            }
        }

        public List<DTO_QLNhanVien> TimKiemNV(string tuKhoa)
        {
            return _db.Nhanviens
        .Include(nv => nv.IdphongBanNavigation)
        .Include(nv => nv.IdcongViecNavigation)
        .Include(nv => nv.IdtrinhDoNavigation)
        .Include(nv => nv.IdtaiKhoanNavigation)
        .Where(x => x.Idnv.ToString().Equals(tuKhoa) || x.TenNv.Contains(tuKhoa)
            || x.DiaChi.Contains(tuKhoa)
            || x.IdphongBanNavigation.TenPhongBan.Contains(tuKhoa)
            || x.IdcongViecNavigation.TenCongViec.Contains(tuKhoa)
            || x.IdtrinhDoNavigation.TenTrinhDo.Contains(tuKhoa)
            || x.IdtaiKhoanNavigation.TenTaiKhoan.Contains(tuKhoa))
        .ToList()
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
            SoTienPhuCap = x.SoTienPhuCap,
            TrangThai = x.TrangThai,
            TenTaiKhoan = x.IdtaiKhoanNavigation.TenTaiKhoan,
            TenPhongBan = x.IdphongBanNavigation?.TenPhongBan,
            TenCongViec = x.IdcongViecNavigation?.TenCongViec,
            MoTaCV = x.IdcongViecNavigation?.MoTa,
            TenTrinhDo = x.IdtrinhDoNavigation?.TenTrinhDo
        }).ToList();
        }
    }
}
