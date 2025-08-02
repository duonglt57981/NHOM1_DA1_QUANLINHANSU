using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHOM1_DA1_QUANLINHANSU.DTO
{
    internal class DTO_QLHopDong
    {
        public int STT { get; set; }
        public int SoHopDong { get; set; }

        public string TenHopDong { get; set; } = null!;

        public DateOnly NgayBd { get; set; }

        public DateOnly NgayKt { get; set; }

        public DateOnly NgayKiHopDong { get; set; }

        public int LanKi { get; set; }

        public string? NoiDung { get; set; }

        public string ThoiHan { get; set; } = null!;

        public double HeSoLuong { get; set; }

        public double LuongCoBan { get; set; }

        public string TrangThai { get; set; } = null!;

        public string TenNv { get; set; } = null!;

        public string Sdt { get; set; } = null!;

        public string Cccd { get; set; } = null!;

        public string DiaChi { get; set; } = null!;
    }
}
