using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class NhanVien
{
    public string MaNv { get; set; } = null!;

    public string? MaTk { get; set; }

    public string? TenNv { get; set; }

    public string? HinhAnh { get; set; }

    public string? MaCv { get; set; }

    public string? MaCl { get; set; }

    public virtual ICollection<HoaDonNhap> HoaDonNhaps { get; set; } = new List<HoaDonNhap>();

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

    public virtual CaLam? MaClNavigation { get; set; }

    public virtual CongViec? MaCvNavigation { get; set; }

    public virtual TaiKhoan? MaTkNavigation { get; set; }
}
