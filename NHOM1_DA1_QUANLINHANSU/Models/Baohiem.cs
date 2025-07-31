using System;
using System.Collections.Generic;

namespace NHOM1_DA1_QUANLINHANSU.Models;

public partial class Baohiem
{
    public int IdbaoHiem { get; set; }

    public string LoaiBaoHiem { get; set; } = null!;

    public int SoBaoHiem { get; set; }

    public DateOnly NgayCap { get; set; }

    public string NoiCap { get; set; } = null!;

    public string NoiDangKi { get; set; } = null!;

    public DateOnly NgayBatDau { get; set; }

    public DateOnly NgayHetHan { get; set; }

    public string? TrangThai { get; set; }

    public int Idnv { get; set; }

    public virtual Nhanvien IdnvNavigation { get; set; } = null!;
}
