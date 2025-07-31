using System;
using System.Collections.Generic;

namespace NHOM1_DA1_QUANLINHANSU.Models;

public partial class Loaihopdong
{
    public int IdloaiHopDong { get; set; }

    public string TenHopDong { get; set; } = null!;

    public virtual ICollection<Hopdong> Hopdongs { get; set; } = new List<Hopdong>();
}
