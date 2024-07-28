using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class KhachHang
{
    public string MaKh { get; set; } = null!;

    public string? MaTk { get; set; }

    public string? TenKh { get; set; }

    public string? Phone { get; set; }

    public string? DiaChi { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

    public virtual TaiKhoan? MaTkNavigation { get; set; }
}
