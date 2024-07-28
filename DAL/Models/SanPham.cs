using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SanPham
{
    public string MaSp { get; set; } = null!;

    public string? TenSp { get; set; }

    public string? HinhAnh { get; set; }

    public string? MaLoaiLh { get; set; }

    public string? MaVl { get; set; }

    public string? MaNhaCc { get; set; }

    public string? MaQg { get; set; }

    public decimal? Gia { get; set; }

    public virtual ICollection<ChiTietHoaDonNhap> ChiTietHoaDonNhaps { get; set; } = new List<ChiTietHoaDonNhap>();

    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    public virtual LoaiHang? MaLoaiLhNavigation { get; set; }

    public virtual NhaCungCap? MaNhaCcNavigation { get; set; }

    public virtual NuocSx? MaQgNavigation { get; set; }

    public virtual VatLieu? MaVlNavigation { get; set; }
}
