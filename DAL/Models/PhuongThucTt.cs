using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class PhuongThucTt
{
    public string MaPttt { get; set; } = null!;

    public string? TenPttt { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
