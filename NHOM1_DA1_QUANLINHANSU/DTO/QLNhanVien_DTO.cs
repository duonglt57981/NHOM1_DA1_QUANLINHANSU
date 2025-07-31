using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHOM1_DA1_QUANLINHANSU.Models;

namespace NHOM1_DA1_QUANLINHANSU.DTO
{
    public class QLNhanVien_DTO
    {
        public int STT { get; set; }

        public int Idnv { get; set; }

        public string TenNv { get; set; } = null!;

        public string GioiTinh { get; set; } = null!;

        public DateOnly NgaySinh { get; set; }

        public string Sdt { get; set; } = null!;

        public string Cccd { get; set; } = null!;

        public string DiaChi { get; set; } = null!;

        public byte[] HinhAnh { get; set; } = null!;

        public double SoTienPhuCap { get; set; }

        public string TrangThai { get; set; } = null!;

        public string TenCongViec { get; set; } = null!;

        public string? MoTaCV { get; set; }

        public string TenVaiTro { get; set; } = null!;

        public string? MoTaVT { get; set; }

        public string TenTrinhDo { get; set; } = null!;

        public string? MoTaTD { get; set; }

        public string TenPhongBan { get; set; } = null!;

        public string? MoTaPB { get; set; }

    }
}
