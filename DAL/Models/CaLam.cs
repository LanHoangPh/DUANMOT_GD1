using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class CaLam
{
    public string MaCl { get; set; } = null!;

    public string? TenCl { get; set; }

    public string? ThoiGianLam { get; set; }

    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}
