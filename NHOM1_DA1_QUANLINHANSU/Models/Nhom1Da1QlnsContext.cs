using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NHOM1_DA1_QUANLINHANSU.Models;

public partial class Nhom1Da1QlnsContext : DbContext
{
    public Nhom1Da1QlnsContext()
    {
    }

    public Nhom1Da1QlnsContext(DbContextOptions<Nhom1Da1QlnsContext> options)
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

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    public virtual DbSet<Phongban> Phongbans { get; set; }

    public virtual DbSet<Taikhoan> Taikhoans { get; set; }

    public virtual DbSet<Trinhdo> Trinhdos { get; set; }

    public virtual DbSet<Vaitro> Vaitros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-6GBA1KF\\SQLEXPRESS;Database=NHOM1_DA1_QLNS;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Baohiem>(entity =>
        {
            entity.HasKey(e => e.IdbaoHiem).HasName("PK__BAOHIEM__6C8381770BAD77DB");

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
                .HasConstraintName("FK__BAOHIEM__IDNV__38996AB5");
        });

        modelBuilder.Entity<Chamcong>(entity =>
        {
            entity.HasKey(e => e.IdchamCong).HasName("PK__CHAMCONG__AC232BEEC33F8451");

            entity.ToTable("CHAMCONG");

            entity.Property(e => e.IdchamCong).HasColumnName("IDChamCong");
            entity.Property(e => e.CaLam).HasMaxLength(10);
            entity.Property(e => e.IdloaiCong).HasColumnName("IDLoaiCong");
            entity.Property(e => e.Idnv).HasColumnName("IDNV");
            entity.Property(e => e.Nam).HasColumnName("NAM");
            entity.Property(e => e.Ngay).HasColumnName("NGAY");
            entity.Property(e => e.Thang).HasColumnName("THANG");

            entity.HasOne(d => d.IdloaiCongNavigation).WithMany(p => p.Chamcongs)
                .HasForeignKey(d => d.IdloaiCong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CHAMCONG__IDLoai__440B1D61");

            entity.HasOne(d => d.IdnvNavigation).WithMany(p => p.Chamcongs)
                .HasForeignKey(d => d.Idnv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CHAMCONG__IDNV__4316F928");
        });

        modelBuilder.Entity<Congviec>(entity =>
        {
            entity.HasKey(e => e.IdcongViec).HasName("PK__CONGVIEC__6D97AEE41E8CE033");

            entity.ToTable("CONGVIEC");

            entity.Property(e => e.IdcongViec)
                .ValueGeneratedNever()
                .HasColumnName("IDCongViec");
            entity.Property(e => e.TenCongViec).HasMaxLength(255);
        });

        modelBuilder.Entity<Hopdong>(entity =>
        {
            entity.HasKey(e => e.SoHopDong).HasName("PK__HOPDONG__71C5D5BA424279C2");

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
                .HasConstraintName("FK__HOPDONG__IDLoaiH__3E52440B");

            entity.HasOne(d => d.IdnvNavigation).WithMany(p => p.Hopdongs)
                .HasForeignKey(d => d.Idnv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOPDONG__IDNV__3D5E1FD2");
        });

        modelBuilder.Entity<KhenthuongKiluat>(entity =>
        {
            entity.HasKey(e => e.IdktKl).HasName("PK__KHENTHUO__326968EC95438CF5");

            entity.ToTable("KHENTHUONG_KILUAT");

            entity.Property(e => e.IdktKl).HasColumnName("IDKT_KL");
            entity.Property(e => e.Idnv).HasColumnName("IDNV");
            entity.Property(e => e.Loai).HasMaxLength(100);
            entity.Property(e => e.SoKtKl).HasColumnName("SoKT_KL");

            entity.HasOne(d => d.IdnvNavigation).WithMany(p => p.KhenthuongKiluats)
                .HasForeignKey(d => d.Idnv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KHENTHUONG__IDNV__35BCFE0A");
        });

        modelBuilder.Entity<Loaicong>(entity =>
        {
            entity.HasKey(e => e.IdloaiCong).HasName("PK__LOAICONG__8E9A196C5502FB0F");

            entity.ToTable("LOAICONG");

            entity.Property(e => e.IdloaiCong)
                .ValueGeneratedNever()
                .HasColumnName("IDLoaiCong");
            entity.Property(e => e.TenLoaiCong).HasMaxLength(100);
        });

        modelBuilder.Entity<Loaihopdong>(entity =>
        {
            entity.HasKey(e => e.IdloaiHopDong).HasName("PK__LOAIHOPD__6C2A0CFF66EDF997");

            entity.ToTable("LOAIHOPDONG");

            entity.Property(e => e.IdloaiHopDong)
                .ValueGeneratedNever()
                .HasColumnName("IDLoaiHopDong");
            entity.Property(e => e.TenHopDong).HasMaxLength(50);
        });

        modelBuilder.Entity<Nhanvien>(entity =>
        {
            entity.HasKey(e => e.Idnv).HasName("PK__NHANVIEN__B87DC9B21FE7823E");

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
            entity.Property(e => e.IdtaiKhoan).HasColumnName("IDTaiKhoan");
            entity.Property(e => e.IdtrinhDo).HasColumnName("IDTrinhDo");
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
                .HasConstraintName("FK__NHANVIEN__IDCong__31EC6D26");

            entity.HasOne(d => d.IdphongBanNavigation).WithMany(p => p.Nhanviens)
                .HasForeignKey(d => d.IdphongBan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NHANVIEN__IDPhon__30F848ED");

            entity.HasOne(d => d.IdtaiKhoanNavigation).WithMany(p => p.Nhanviens)
                .HasForeignKey(d => d.IdtaiKhoan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NHANVIEN__IDTaiK__300424B4");

            entity.HasOne(d => d.IdtrinhDoNavigation).WithMany(p => p.Nhanviens)
                .HasForeignKey(d => d.IdtrinhDo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NHANVIEN__IDTrin__32E0915F");
        });

        modelBuilder.Entity<Phongban>(entity =>
        {
            entity.HasKey(e => e.IdphongBan).HasName("PK__PHONGBAN__1F6C42EF7FEB95EC");

            entity.ToTable("PHONGBAN");

            entity.Property(e => e.IdphongBan)
                .ValueGeneratedNever()
                .HasColumnName("IDPhongBan");
            entity.Property(e => e.TenPhongBan).HasMaxLength(255);
        });

        modelBuilder.Entity<Taikhoan>(entity =>
        {
            entity.HasKey(e => e.IdtaiKhoan).HasName("PK__TAIKHOAN__BC5F907C310B72C4");

            entity.ToTable("TAIKHOAN");

            entity.Property(e => e.IdtaiKhoan).HasColumnName("IDTaiKhoan");
            entity.Property(e => e.IdvaiTro).HasColumnName("IDVaiTro");
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

            entity.HasOne(d => d.IdvaiTroNavigation).WithMany(p => p.Taikhoans)
                .HasForeignKey(d => d.IdvaiTro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TAIKHOAN__IDVaiT__2C3393D0");
        });

        modelBuilder.Entity<Trinhdo>(entity =>
        {
            entity.HasKey(e => e.IdtrinhDo).HasName("PK__TRINHDO__2BBB82346F45A196");

            entity.ToTable("TRINHDO");

            entity.Property(e => e.IdtrinhDo)
                .ValueGeneratedNever()
                .HasColumnName("IDTrinhDo");
            entity.Property(e => e.TenTrinhDo).HasMaxLength(255);
        });

        modelBuilder.Entity<Vaitro>(entity =>
        {
            entity.HasKey(e => e.IdvaiTro).HasName("PK__VAITRO__45D3FF491FEC2268");

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
