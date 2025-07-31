using System;
using System.Collections.Generic;

namespace NHOM1_DA1_QUANLINHANSU.Models;

public partial class Hopdong
{
    public int SoHopDong { get; set; }

    public DateOnly NgayBd { get; set; }

    public DateOnly NgayKt { get; set; }

    public DateOnly NgayKiHopDong { get; set; }

    public int LanKi { get; set; }

    public string? NoiDung { get; set; }

    public string ThoiHan { get; set; } = null!;

    public double HeSoLuong { get; set; }

    public double LuongCoBan { get; set; }

    public string TrangThai { get; set; } = null!;

    public int Idnv { get; set; }

    public int IdloaiHd { get; set; }

    public virtual Loaihopdong IdloaiHdNavigation { get; set; } = null!;

    public virtual Nhanvien IdnvNavigation { get; set; } = null!;
}
