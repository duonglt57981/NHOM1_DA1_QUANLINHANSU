using System;
using System.Collections.Generic;

namespace NHOM1_DA1_QUANLINHANSU.Models;

public partial class Vaitro
{
    public int IdvaiTro { get; set; }

    public string TenVaiTro { get; set; } = null!;

    public virtual ICollection<Taikhoan> Taikhoans { get; set; } = new List<Taikhoan>();
}
