using System;
using System.Collections.Generic;

namespace NHOM1_DA1_QUANLINHANSU.Models;

public partial class Nhanvien
{
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

    public int IdtaiKhoan { get; set; }

    public int IdphongBan { get; set; }

    public int IdcongViec { get; set; }

    public int IdtrinhDo { get; set; }

    public virtual ICollection<Baohiem> Baohiems { get; set; } = new List<Baohiem>();

    public virtual ICollection<Chamcong> Chamcongs { get; set; } = new List<Chamcong>();

    public virtual ICollection<Hopdong> Hopdongs { get; set; } = new List<Hopdong>();

    public virtual Congviec IdcongViecNavigation { get; set; } = null!;

    public virtual Phongban IdphongBanNavigation { get; set; } = null!;

    public virtual Taikhoan IdtaiKhoanNavigation { get; set; } = null!;

    public virtual Trinhdo IdtrinhDoNavigation { get; set; } = null!;

    public virtual ICollection<KhenthuongKiluat> KhenthuongKiluats { get; set; } = new List<KhenthuongKiluat>();
}
