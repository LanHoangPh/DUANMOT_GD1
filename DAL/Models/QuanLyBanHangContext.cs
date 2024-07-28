using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class QuanLyBanHangContext : DbContext
{
    public QuanLyBanHangContext()
    {
    }

    public QuanLyBanHangContext(DbContextOptions<QuanLyBanHangContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CaLam> CaLams { get; set; }

    public virtual DbSet<ChiTietHoaDonNhap> ChiTietHoaDonNhaps { get; set; }

    public virtual DbSet<CongViec> CongViecs { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }

    public virtual DbSet<HoaDonNhap> HoaDonNhaps { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<LoaiHang> LoaiHangs { get; set; }

    public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<NuocSx> NuocSxes { get; set; }

    public virtual DbSet<PhuongThucTt> PhuongThucTts { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

    public virtual DbSet<VatLieu> VatLieus { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-G1OA6S5\\HOANGLAN;Initial Catalog=QuanLyBanHang;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CaLam>(entity =>
        {
            entity.HasKey(e => e.MaCl).HasName("PK__CaLam__27258E0C091D9263");

            entity.ToTable("CaLam");

            entity.Property(e => e.MaCl)
                .HasMaxLength(50)
                .HasColumnName("MaCL");
            entity.Property(e => e.TenCl)
                .HasMaxLength(50)
                .HasColumnName("TenCL");
            entity.Property(e => e.ThoiGianLam).HasMaxLength(50);
        });

        modelBuilder.Entity<ChiTietHoaDonNhap>(entity =>
        {
            entity.HasKey(e => new { e.MaHdn, e.MaSp }).HasName("PK__ChiTietH__EEE2B8471E9646C4");

            entity.ToTable("ChiTietHoaDonNhap");

            entity.Property(e => e.MaHdn)
                .HasMaxLength(50)
                .HasColumnName("MaHDN");
            entity.Property(e => e.MaSp)
                .HasMaxLength(50)
                .HasColumnName("MaSP");
            entity.Property(e => e.DonGia).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.MaHdnNavigation).WithMany(p => p.ChiTietHoaDonNhaps)
                .HasForeignKey(d => d.MaHdn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietHo__MaHDN__4BAC3F29");

            entity.HasOne(d => d.MaSpNavigation).WithMany(p => p.ChiTietHoaDonNhaps)
                .HasForeignKey(d => d.MaSp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietHoa__MaSP__4CA06362");
        });

        modelBuilder.Entity<CongViec>(entity =>
        {
            entity.HasKey(e => e.MaCv).HasName("PK__CongViec__27258E76355875F6");

            entity.ToTable("CongViec");

            entity.Property(e => e.MaCv)
                .HasMaxLength(50)
                .HasColumnName("MaCV");
            entity.Property(e => e.ChucVu).HasMaxLength(50);
            entity.Property(e => e.Luong).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.MaHd).HasName("PK__HoaDon__2725A6E0A5CFDEF7");

            entity.ToTable("HoaDon");

            entity.Property(e => e.MaHd)
                .HasMaxLength(50)
                .HasColumnName("MaHD");
            entity.Property(e => e.MaKh)
                .HasMaxLength(50)
                .HasColumnName("MaKH");
            entity.Property(e => e.MaNv)
                .HasMaxLength(50)
                .HasColumnName("MaNV");
            entity.Property(e => e.MaPttt)
                .HasMaxLength(50)
                .HasColumnName("MaPTTT");
            entity.Property(e => e.NgayDh).HasColumnName("NgayDH");
            entity.Property(e => e.TongSoTien).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaKh)
                .HasConstraintName("FK__HoaDon__MaKH__3F466844");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaNv)
                .HasConstraintName("FK__HoaDon__MaNV__412EB0B6");

            entity.HasOne(d => d.MaPtttNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaPttt)
                .HasConstraintName("FK__HoaDon__MaPTTT__403A8C7D");
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
            entity.HasKey(e => new { e.MaHd, e.MaSp }).HasName("PK__HoaDonCh__F557F66163672EF7");

            entity.ToTable("HoaDonChiTiet");

            entity.Property(e => e.MaHd)
                .HasMaxLength(50)
                .HasColumnName("MaHD");
            entity.Property(e => e.MaSp)
                .HasMaxLength(50)
                .HasColumnName("MaSP");
            entity.Property(e => e.DonGia).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.MaHdNavigation).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.MaHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoaDonChiT__MaHD__440B1D61");

            entity.HasOne(d => d.MaSpNavigation).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.MaSp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoaDonChiT__MaSP__44FF419A");
        });

        modelBuilder.Entity<HoaDonNhap>(entity =>
        {
            entity.HasKey(e => e.MaHdn).HasName("PK__HoaDonNh__3C90E8C6B4E17273");

            entity.ToTable("HoaDonNhap");

            entity.Property(e => e.MaHdn)
                .HasMaxLength(50)
                .HasColumnName("MaHDN");
            entity.Property(e => e.MaNhaCc)
                .HasMaxLength(50)
                .HasColumnName("MaNhaCC");
            entity.Property(e => e.MaNv)
                .HasMaxLength(50)
                .HasColumnName("MaNV");
            entity.Property(e => e.TongSoTien).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.MaNhaCcNavigation).WithMany(p => p.HoaDonNhaps)
                .HasForeignKey(d => d.MaNhaCc)
                .HasConstraintName("FK__HoaDonNha__MaNha__47DBAE45");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.HoaDonNhaps)
                .HasForeignKey(d => d.MaNv)
                .HasConstraintName("FK__HoaDonNhap__MaNV__48CFD27E");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKh).HasName("PK__KhachHan__2725CF1EA82489F9");

            entity.ToTable("KhachHang");

            entity.Property(e => e.MaKh)
                .HasMaxLength(50)
                .HasColumnName("MaKH");
            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.MaTk)
                .HasMaxLength(50)
                .HasColumnName("MaTK");
            entity.Property(e => e.Phone).HasMaxLength(15);
            entity.Property(e => e.TenKh)
                .HasMaxLength(100)
                .HasColumnName("TenKH");

            entity.HasOne(d => d.MaTkNavigation).WithMany(p => p.KhachHangs)
                .HasForeignKey(d => d.MaTk)
                .HasConstraintName("FK__KhachHang__MaTK__267ABA7A");
        });

        modelBuilder.Entity<LoaiHang>(entity =>
        {
            entity.HasKey(e => e.MaLoaiLh).HasName("PK__LoaiHang__1225335D367C7B27");

            entity.ToTable("LoaiHang");

            entity.Property(e => e.MaLoaiLh)
                .HasMaxLength(50)
                .HasColumnName("MaLoaiLH");
            entity.Property(e => e.TenLh)
                .HasMaxLength(50)
                .HasColumnName("TenLH");
        });

        modelBuilder.Entity<NhaCungCap>(entity =>
        {
            entity.HasKey(e => e.MaNhaCc).HasName("PK__NhaCungC__C87CD371BC3F1756");

            entity.ToTable("NhaCungCap");

            entity.Property(e => e.MaNhaCc)
                .HasMaxLength(50)
                .HasColumnName("MaNhaCC");
            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(15);
            entity.Property(e => e.TenLienLac).HasMaxLength(100);
            entity.Property(e => e.TenNhaCungCap).HasMaxLength(100);
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNv).HasName("PK__NhanVien__2725D70AE655709A");

            entity.ToTable("NhanVien");

            entity.Property(e => e.MaNv)
                .HasMaxLength(50)
                .HasColumnName("MaNV");
            entity.Property(e => e.HinhAnh).HasMaxLength(1000);
            entity.Property(e => e.MaCl)
                .HasMaxLength(50)
                .HasColumnName("MaCL");
            entity.Property(e => e.MaCv)
                .HasMaxLength(50)
                .HasColumnName("MaCV");
            entity.Property(e => e.MaTk)
                .HasMaxLength(50)
                .HasColumnName("MaTK");
            entity.Property(e => e.TenNv)
                .HasMaxLength(100)
                .HasColumnName("TenNV");

            entity.HasOne(d => d.MaClNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.MaCl)
                .HasConstraintName("FK__NhanVien__MaCL__4E88ABD4");

            entity.HasOne(d => d.MaCvNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.MaCv)
                .HasConstraintName("FK__NhanVien__MaCV__4D94879B");

            entity.HasOne(d => d.MaTkNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.MaTk)
                .HasConstraintName("FK__NhanVien__MaTK__29572725");
        });

        modelBuilder.Entity<NuocSx>(entity =>
        {
            entity.HasKey(e => e.MaQg).HasName("PK__NuocSx__2725F85795721DD1");

            entity.ToTable("NuocSx");

            entity.Property(e => e.MaQg)
                .HasMaxLength(50)
                .HasColumnName("MaQG");
            entity.Property(e => e.TenQg)
                .HasMaxLength(50)
                .HasColumnName("TenQG");
        });

        modelBuilder.Entity<PhuongThucTt>(entity =>
        {
            entity.HasKey(e => e.MaPttt).HasName("PK__PhuongTh__B30A28029E01ED5B");

            entity.ToTable("PhuongThucTT");

            entity.Property(e => e.MaPttt)
                .HasMaxLength(50)
                .HasColumnName("MaPTTT");
            entity.Property(e => e.TenPttt)
                .HasMaxLength(50)
                .HasColumnName("TenPTTT");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.MaSp).HasName("PK__SanPham__2725081C3D99A0B6");

            entity.ToTable("SanPham");

            entity.Property(e => e.MaSp)
                .HasMaxLength(50)
                .HasColumnName("MaSP");
            entity.Property(e => e.Gia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HinhAnh).HasMaxLength(1000);
            entity.Property(e => e.MaLoaiLh)
                .HasMaxLength(50)
                .HasColumnName("MaLoaiLH");
            entity.Property(e => e.MaNhaCc)
                .HasMaxLength(50)
                .HasColumnName("MaNhaCC");
            entity.Property(e => e.MaQg)
                .HasMaxLength(50)
                .HasColumnName("MaQG");
            entity.Property(e => e.MaVl)
                .HasMaxLength(50)
                .HasColumnName("MaVL");
            entity.Property(e => e.TenSp)
                .HasMaxLength(100)
                .HasColumnName("TenSP");

            entity.HasOne(d => d.MaLoaiLhNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.MaLoaiLh)
                .HasConstraintName("FK__SanPham__MaLoaiL__398D8EEE");

            entity.HasOne(d => d.MaNhaCcNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.MaNhaCc)
                .HasConstraintName("FK__SanPham__MaNhaCC__3B75D760");

            entity.HasOne(d => d.MaQgNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.MaQg)
                .HasConstraintName("FK__SanPham__MaQG__3C69FB99");

            entity.HasOne(d => d.MaVlNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.MaVl)
                .HasConstraintName("FK__SanPham__MaVL__3A81B327");
        });

        modelBuilder.Entity<TaiKhoan>(entity =>
        {
            entity.HasKey(e => e.MaTk).HasName("PK__TaiKhoan__2725007079F005BE");

            entity.ToTable("TaiKhoan");

            entity.Property(e => e.MaTk)
                .HasMaxLength(50)
                .HasColumnName("MaTK");
            entity.Property(e => e.ChucVu).HasMaxLength(20);
            entity.Property(e => e.Passwordd).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<VatLieu>(entity =>
        {
            entity.HasKey(e => e.MaVl).HasName("PK__VatLieu__2725103647844C26");

            entity.ToTable("VatLieu");

            entity.Property(e => e.MaVl)
                .HasMaxLength(50)
                .HasColumnName("MaVL");
            entity.Property(e => e.TenVl)
                .HasMaxLength(50)
                .HasColumnName("TenVL");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
