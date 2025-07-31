using System;
using System.Collections.Generic;

namespace NHOM1_DA1_QUANLINHANSU.Models;

public partial class Congviec
{
    public int IdcongViec { get; set; }

    public string TenCongViec { get; set; } = null!;

    public string? MoTa { get; set; }

    public virtual ICollection<Nhanvien> Nhanviens { get; set; } = new List<Nhanvien>();
}
