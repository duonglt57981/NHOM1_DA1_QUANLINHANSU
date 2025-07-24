using System;
using System.Collections.Generic;

namespace NHOM1_DA1_QUANLINHANSU.Models;

public partial class KhenthuongKiluat
{
    public int IdktKl { get; set; }

    public int SoKtKl { get; set; }

    public string Loai { get; set; } = null!;

    public string? NoiDung { get; set; }

    public DateOnly NgayRaQuyetDinh { get; set; }

    public int Idnv { get; set; }

    public virtual Nhanvien IdnvNavigation { get; set; } = null!;
}
