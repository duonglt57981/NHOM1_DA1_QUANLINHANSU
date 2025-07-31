using System;
using System.Collections.Generic;

namespace NHOM1_DA1_QUANLINHANSU.Models;

public partial class Trinhdo
{
    public int IdtrinhDo { get; set; }

    public string TenTrinhDo { get; set; } = null!;

    public string? MoTa { get; set; }

    public virtual ICollection<Nhanvien> Nhanviens { get; set; } = new List<Nhanvien>();
}
