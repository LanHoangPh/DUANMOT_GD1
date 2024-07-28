using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HoaDonNhap
{
    public string MaHdn { get; set; } = null!;

    public string? MaNhaCc { get; set; }

    public DateOnly? NgayDatHang { get; set; }

    public decimal? TongSoTien { get; set; }

    public string? MaNv { get; set; }

    public virtual ICollection<ChiTietHoaDonNhap> ChiTietHoaDonNhaps { get; set; } = new List<ChiTietHoaDonNhap>();

    public virtual NhaCungCap? MaNhaCcNavigation { get; set; }

    public virtual NhanVien? MaNvNavigation { get; set; }
}
