using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class NhaCungCap
{
    public string MaNhaCc { get; set; } = null!;

    public string? TenNhaCungCap { get; set; }

    public string? TenLienLac { get; set; }

    public string? DiaChi { get; set; }

    public string? Phone { get; set; }

    public virtual ICollection<HoaDonNhap> HoaDonNhaps { get; set; } = new List<HoaDonNhap>();

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
