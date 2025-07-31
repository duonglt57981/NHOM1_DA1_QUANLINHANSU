using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHOM1_DA1_QUANLINHANSU.DTO
{
    public class DTO_QLNhanVien
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

        public string TenPhongBan { get; set; } = null!;

        public string TenCongViec { get; set; } = null!;

        public string TenTrinhDo { get; set; } = null!;

        public int IdtaiKhoan { get; set; }
    }
}
