using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class NuocSx
{
    public string MaQg { get; set; } = null!;

    public string? TenQg { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
