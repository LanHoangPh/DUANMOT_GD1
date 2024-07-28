using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class TaiKhoan
{
    public string MaTk { get; set; } = null!;

    public string? Username { get; set; }

    public string? Passwordd { get; set; }

    public string? ChucVu { get; set; }

    public virtual ICollection<KhachHang> KhachHangs { get; set; } = new List<KhachHang>();

    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}
