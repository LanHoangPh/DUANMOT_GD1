using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class LoaiHang
{
    public string MaLoaiLh { get; set; } = null!;

    public string? TenLh { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
