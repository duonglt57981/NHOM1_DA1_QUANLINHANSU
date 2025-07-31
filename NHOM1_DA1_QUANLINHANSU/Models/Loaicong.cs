using System;
using System.Collections.Generic;

namespace NHOM1_DA1_QUANLINHANSU.Models;

public partial class Loaicong
{
    public int IdloaiCong { get; set; }

    public string TenLoaiCong { get; set; } = null!;

    public double HeSo { get; set; }

    public virtual ICollection<Chamcong> Chamcongs { get; set; } = new List<Chamcong>();
}
