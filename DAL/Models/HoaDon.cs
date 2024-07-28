using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HoaDon
{
    public string MaHd { get; set; } = null!;

    public string? MaKh { get; set; }

    public DateOnly? NgayDh { get; set; }

    public decimal? TongSoTien { get; set; }

    public string? MaPttt { get; set; }

    public string? MaNv { get; set; }

    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    public virtual KhachHang? MaKhNavigation { get; set; }

    public virtual NhanVien? MaNvNavigation { get; set; }

    public virtual PhuongThucTt? MaPtttNavigation { get; set; }
}
