using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class CongViec
{
    public string MaCv { get; set; } = null!;

    public string? ChucVu { get; set; }

    public decimal? Luong { get; set; }

    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}
