using System;
using System.Collections.Generic;

namespace NHOM1_DA1_QUANLINHANSU.Models;

public partial class Taikhoan
{
    public int IdtaiKhoan { get; set; }

    public string TenHienThi { get; set; } = null!;

    public string TenTaiKhoan { get; set; } = null!;

    public string MatKhau { get; set; } = null!;

    public string TrangThai { get; set; } = null!;

    public int Idnv { get; set; }

    public virtual Nhanvien IdnvNavigation { get; set; } = null!;
}
