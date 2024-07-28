using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class VatLieu
{
    public string MaVl { get; set; } = null!;

    public string? TenVl { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
