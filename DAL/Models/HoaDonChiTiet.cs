using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HoaDonChiTiet
{
    public string MaHd { get; set; } = null!;

    public string MaSp { get; set; } = null!;

    public int? SoLuong { get; set; }

    public decimal? DonGia { get; set; }

    public virtual HoaDon MaHdNavigation { get; set; } = null!;

    public virtual SanPham MaSpNavigation { get; set; } = null!;
}
