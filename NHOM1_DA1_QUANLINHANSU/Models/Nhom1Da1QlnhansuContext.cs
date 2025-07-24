using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NHOM1_DA1_QUANLINHANSU.Models;

public partial class Nhom1Da1QlnhansuContext : DbContext
{
    public Nhom1Da1QlnhansuContext()
    {
    }

    public Nhom1Da1QlnhansuContext(DbContextOptions<Nhom1Da1QlnhansuContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Baohiem> Baohiems { get; set; }

    public virtual DbSet<Chamcong> Chamcongs { get; set; }

    public virtual DbSet<Congviec> Congviecs { get; set; }

    public virtual DbSet<Hopdong> Hopdongs { get; set; }

    public virtual DbSet<KhenthuongKiluat> KhenthuongKiluats { get; set; }

    public virtual DbSet<Loaicong> Loaicongs { get; set; }

    public virtual DbSet<Loaihopdong> Loaihopdongs { get; set; }

    public virtual DbSet<Luong> Luongs { get; set; }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    public virtual DbSet<Phongban> Phongbans { get; set; }

    public virtual DbSet<Taikhoan> Taikhoans { get; set; }

    public virtual DbSet<Trinhdo> Trinhdos { get; set; }

    public virtual DbSet<Vaitro> Vaitros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-6GBA1KF\\SQLEXPRESS;Database=NHOM1_DA1_QLNHANSU;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Baohiem>(entity =>
        {
            entity.HasKey(e => e.IdbaoHiem).HasName("PK__BAOHIEM__6C8381777E220C94");

            entity.ToTable("BAOHIEM");

            entity.Property(e => e.IdbaoHiem).HasColumnName("IDBaoHiem");
            entity.Property(e => e.Idnv).HasColumnName("IDNV");
            entity.Property(e => e.LoaiBaoHiem).HasMaxLength(50);
            entity.Property(e => e.NoiCap).HasMaxLength(200);
            entity.Property(e => e.NoiDangKi).HasMaxLength(200);
            entity.Property(e => e.TrangThai).HasMaxLength(50);

            entity.HasOne(d => d.IdnvNavigation).WithMany(p => p.Baohiems)
                .HasForeignKey(d => d.Idnv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BAOHIEM__IDNV__37A5467C");
        });

        modelBuilder.Entity<Chamcong>(entity =>
        {
            entity.HasKey(e => e.IdchamCong).HasName("PK__CHAMCONG__AC232BEE6F1A2ED4");

            entity.ToTable("CHAMCONG");

            entity.Property(e => e.IdchamCong).HasColumnName("IDChamCong");
            entity.Property(e => e.CaLam).HasMaxLength(10);
            entity.Property(e => e.IdloaiCong).HasColumnName("IDLoaiCong");
            entity.Property(e => e.Idnv).HasColumnName("IDNV");
            entity.Property(e => e.Nam).HasColumnName("NAM");
            entity.Property(e => e.Ngay).HasColumnName("NGAY");
            entity.Property(e => e.Thang).HasColumnName("THANG");
            entity.Property(e => e.TrangThaiCa).HasMaxLength(10);

            entity.HasOne(d => d.IdloaiCongNavigation).WithMany(p => p.Chamcongs)
                .HasForeignKey(d => d.IdloaiCong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CHAMCONG__IDLoai__5441852A");

            entity.HasOne(d => d.IdnvNavigation).WithMany(p => p.Chamcongs)
                .HasForeignKey(d => d.Idnv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CHAMCONG__IDNV__534D60F1");
        });

        modelBuilder.Entity<Congviec>(entity =>
        {
            entity.HasKey(e => e.IdcongViec).HasName("PK__CONGVIEC__6D97AEE4658C5000");

            entity.ToTable("CONGVIEC");

            entity.Property(e => e.IdcongViec)
                .ValueGeneratedNever()
                .HasColumnName("IDCongViec");
            entity.Property(e => e.TenCongViec).HasMaxLength(255);
        });

        modelBuilder.Entity<Hopdong>(entity =>
        {
            entity.HasKey(e => e.SoHopDong).HasName("PK__HOPDONG__71C5D5BAA55FB86D");

            entity.ToTable("HOPDONG");

            entity.Property(e => e.IdloaiHd).HasColumnName("IDLoaiHD");
            entity.Property(e => e.Idnv).HasColumnName("IDNV");
            entity.Property(e => e.NgayBd).HasColumnName("NgayBD");
            entity.Property(e => e.NgayKt).HasColumnName("NgayKT");
            entity.Property(e => e.ThoiHan).HasMaxLength(100);
            entity.Property(e => e.TrangThai).HasMaxLength(50);

            entity.HasOne(d => d.IdloaiHdNavigation).WithMany(p => p.Hopdongs)
                .HasForeignKey(d => d.IdloaiHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOPDONG__IDLoaiH__403A8C7D");

            entity.HasOne(d => d.IdnvNavigation).WithMany(p => p.Hopdongs)
                .HasForeignKey(d => d.Idnv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOPDONG__IDNV__3F466844");
        });

        modelBuilder.Entity<KhenthuongKiluat>(entity =>
        {
            entity.HasKey(e => e.IdktKl).HasName("PK__KHENTHUO__326968ECB77E71D0");

            entity.ToTable("KHENTHUONG_KILUAT");

            entity.Property(e => e.IdktKl).HasColumnName("IDKT_KL");
            entity.Property(e => e.Idnv).HasColumnName("IDNV");
            entity.Property(e => e.Loai).HasMaxLength(100);
            entity.Property(e => e.SoKtKl).HasColumnName("SoKT_KL");

            entity.HasOne(d => d.IdnvNavigation).WithMany(p => p.KhenthuongKiluats)
                .HasForeignKey(d => d.Idnv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KHENTHUONG__IDNV__34C8D9D1");
        });

        modelBuilder.Entity<Loaicong>(entity =>
        {
            entity.HasKey(e => e.IdloaiCong).HasName("PK__LOAICONG__8E9A196C7BBF62C9");

            entity.ToTable("LOAICONG");

            entity.Property(e => e.IdloaiCong)
                .ValueGeneratedNever()
                .HasColumnName("IDLoaiCong");
            entity.Property(e => e.TenLoaiCong).HasMaxLength(100);
        });

        modelBuilder.Entity<Loaihopdong>(entity =>
        {
            entity.HasKey(e => e.IdloaiHopDong).HasName("PK__LOAIHOPD__6C2A0CFFC31EBE92");

            entity.ToTable("LOAIHOPDONG");

            entity.Property(e => e.IdloaiHopDong)
                .ValueGeneratedNever()
                .HasColumnName("IDLoaiHopDong");
            entity.Property(e => e.TenHopDong).HasMaxLength(50);
        });

        modelBuilder.Entity<Luong>(entity =>
        {
            entity.HasKey(e => e.Idluong).HasName("PK__LUONG__AFAF1A6F1DC69017");

            entity.ToTable("LUONG");

            entity.Property(e => e.Idluong).HasColumnName("IDLuong");
            entity.Property(e => e.Idnv).HasColumnName("IDNV");
            entity.Property(e => e.Nam).HasColumnName("NAM");
            entity.Property(e => e.Ngay).HasColumnName("NGAY");
            entity.Property(e => e.Thang).HasColumnName("THANG");
            entity.Property(e => e.TrangThai).HasMaxLength(50);

            entity.HasOne(d => d.IdnvNavigation).WithMany(p => p.Luongs)
                .HasForeignKey(d => d.Idnv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LUONG__IDNV__3A81B327");
        });

        modelBuilder.Entity<Nhanvien>(entity =>
        {
            entity.HasKey(e => e.Idnv).HasName("PK__NHANVIEN__B87DC9B2AD9765A3");

            entity.ToTable("NHANVIEN");

            entity.Property(e => e.Idnv).HasColumnName("IDNV");
            entity.Property(e => e.Cccd)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CCCD");
            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.GioiTinh).HasMaxLength(50);
            entity.Property(e => e.IdcongViec).HasColumnName("IDCongViec");
            entity.Property(e => e.IdphongBan).HasColumnName("IDPhongBan");
            entity.Property(e => e.IdtrinhDo).HasColumnName("IDTrinhDo");
            entity.Property(e => e.IdvaiTro).HasColumnName("IDVaiTro");
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SDT");
            entity.Property(e => e.TenNv)
                .HasMaxLength(255)
                .HasColumnName("TenNV");
            entity.Property(e => e.TrangThai).HasMaxLength(50);

            entity.HasOne(d => d.IdcongViecNavigation).WithMany(p => p.Nhanviens)
                .HasForeignKey(d => d.IdcongViec)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NHANVIEN__IDCong__2E1BDC42");

            entity.HasOne(d => d.IdphongBanNavigation).WithMany(p => p.Nhanviens)
                .HasForeignKey(d => d.IdphongBan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NHANVIEN__IDPhon__2D27B809");

            entity.HasOne(d => d.IdtrinhDoNavigation).WithMany(p => p.Nhanviens)
                .HasForeignKey(d => d.IdtrinhDo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NHANVIEN__IDTrin__2F10007B");

            entity.HasOne(d => d.IdvaiTroNavigation).WithMany(p => p.Nhanviens)
                .HasForeignKey(d => d.IdvaiTro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NHANVIEN__IDVaiT__300424B4");
        });

        modelBuilder.Entity<Phongban>(entity =>
        {
            entity.HasKey(e => e.IdphongBan).HasName("PK__PHONGBAN__1F6C42EFB3827294");

            entity.ToTable("PHONGBAN");

            entity.Property(e => e.IdphongBan)
                .ValueGeneratedNever()
                .HasColumnName("IDPhongBan");
            entity.Property(e => e.TenPhongBan).HasMaxLength(255);
        });

        modelBuilder.Entity<Taikhoan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TAIKHOAN");

            entity.Property(e => e.Idnv).HasColumnName("IDNV");
            entity.Property(e => e.IdtaiKhoan)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDTaiKhoan");
            entity.Property(e => e.MatKhau)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TenHienThi).HasMaxLength(255);
            entity.Property(e => e.TenTaiKhoan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TrangThai).HasMaxLength(50);

            entity.HasOne(d => d.IdnvNavigation).WithMany()
                .HasForeignKey(d => d.Idnv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TAIKHOAN__IDNV__31EC6D26");
        });

        modelBuilder.Entity<Trinhdo>(entity =>
        {
            entity.HasKey(e => e.IdtrinhDo).HasName("PK__TRINHDO__2BBB82348EC743C1");

            entity.ToTable("TRINHDO");

            entity.Property(e => e.IdtrinhDo)
                .ValueGeneratedNever()
                .HasColumnName("IDTrinhDo");
            entity.Property(e => e.TenTrinhDo).HasMaxLength(255);
        });

        modelBuilder.Entity<Vaitro>(entity =>
        {
            entity.HasKey(e => e.IdvaiTro).HasName("PK__VAITRO__45D3FF493649328C");

            entity.ToTable("VAITRO");

            entity.Property(e => e.IdvaiTro)
                .ValueGeneratedNever()
                .HasColumnName("IDVaiTro");
            entity.Property(e => e.TenVaiTro).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
