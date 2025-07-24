using System;
using System.Collections.Generic;

namespace NHOM1_DA1_QUANLINHANSU.Models;

public partial class Luong
{
    public int Idluong { get; set; }

    public int Nam { get; set; }

    public int Thang { get; set; }

    public int Ngay { get; set; }

    public double SoTien { get; set; }

    public string TrangThai { get; set; } = null!;

    public int Idnv { get; set; }

    public virtual Nhanvien IdnvNavigation { get; set; } = null!;
}
