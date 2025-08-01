using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHOM1_DA1_QUANLINHANSU.DTO
{
    public class DTO_QLNhanVien
    {
        public int STT { get; set; }

        [DisplayName("ID Nhân Viên")]
        public int Idnv { get; set; }

        [DisplayName("Tên Nhân Viên")]
        public string TenNv { get; set; } = null!;

        [DisplayName("Giới Tính")]
        public string GioiTinh { get; set; } = null!;

        [DisplayName("Ngày Sinh")]
        public DateOnly NgaySinh { get; set; }

        [DisplayName("Số Điện Thoại")]
        public string Sdt { get; set; } = null!;

        [DisplayName("CCCD")]
        public string Cccd { get; set; } = null!;

        [DisplayName("Địa Chỉ")]
        public string DiaChi { get; set; } = null!;

        public byte[] HinhAnh { get; set; } = null!;

        [DisplayName("Số Tiền Phụ Cấp")]
        public double SoTienPhuCap { get; set; }

        [DisplayName("Trạng Thái")]
        public string TrangThai { get; set; } = null!;

        [DisplayName("Tên Phòng Ban")]
        public string TenPhongBan { get; set; } = null!;

        [DisplayName("Tên Công Việc")]
        public string TenCongViec { get; set; } = null!;

        [DisplayName("Mô Tả Công Việc")]
        public string MoTaCV { get; set; } = null!;

        [DisplayName("Trình Độ")]
        public string TenTrinhDo { get; set; } = null!;

        public string TenTaiKhoan { get; set; }
    }
}
