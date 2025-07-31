using System;
using System.Collections.Generic;

namespace NHOM1_DA1_QUANLINHANSU.Models;

public partial class Chamcong
{
    public int IdchamCong { get; set; }

    public int Nam { get; set; }

    public int Thang { get; set; }

    public int Ngay { get; set; }

    public int GioVao { get; set; }

    public int PhutVao { get; set; }

    public int GioRa { get; set; }

    public int PhutRa { get; set; }

    public string CaLam { get; set; } = null!;

    public int Idnv { get; set; }

    public int IdloaiCong { get; set; }

    public virtual Loaicong IdloaiCongNavigation { get; set; } = null!;

    public virtual Nhanvien IdnvNavigation { get; set; } = null!;
}
