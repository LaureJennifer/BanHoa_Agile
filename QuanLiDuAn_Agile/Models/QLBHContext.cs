using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace QuanLiDuAn_Agile.Models
{
    public partial class QLBHContext : DbContext
    {
        public QLBHContext()
        {
        }

        public QLBHContext(DbContextOptions<QLBHContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ctphieumua> Ctphieumuas { get; set; } = null!;
        public virtual DbSet<Khachhang> Khachhangs { get; set; } = null!;
        public virtual DbSet<Phieumua> Phieumuas { get; set; } = null!;
        public virtual DbSet<Sanpham> Sanphams { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LEVANHUNG;Initial Catalog=QLBH;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ctphieumua>(entity =>
            {
                entity.HasKey(e => new { e.Idphieumua, e.IdsanPham });

                entity.ToTable("CTPHIEUMUA");

                entity.Property(e => e.Idphieumua)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDPHIEUMUA");

                entity.Property(e => e.IdsanPham)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDSanPham");

                entity.Property(e => e.Dongia)
                    .HasColumnType("money")
                    .HasColumnName("DONGIA");

                entity.Property(e => e.Slmua).HasColumnName("SLMUA");

                entity.HasOne(d => d.IdphieumuaNavigation)
                    .WithMany(p => p.Ctphieumuas)
                    .HasForeignKey(d => d.Idphieumua)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTPHIEUMUA_PHIEUMUA");

                entity.HasOne(d => d.IdsanPhamNavigation)
                    .WithMany(p => p.Ctphieumuas)
                    .HasForeignKey(d => d.IdsanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTPHIEUMUA_SANPHAM");
            });

            modelBuilder.Entity<Khachhang>(entity =>
            {
                entity.HasKey(e => e.Idkh)
                    .HasName("PK__KHACHHAN__B87DC1A7EBD3A019");

                entity.ToTable("KHACHHANG");

                entity.Property(e => e.Idkh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDKH");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(50)
                    .HasColumnName("DIACHI");

                entity.Property(e => e.Hoten)
                    .HasMaxLength(30)
                    .HasColumnName("HOTEN");

                entity.Property(e => e.Sdt).HasColumnName("SDT");
            });

            modelBuilder.Entity<Phieumua>(entity =>
            {
                entity.HasKey(e => e.Idphieumua)
                    .HasName("PK__PHIEUMUA__F3A4493665C3C458");

                entity.ToTable("PHIEUMUA");

                entity.Property(e => e.Idphieumua)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDPHIEUMUA");

                entity.Property(e => e.Idkh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDKH");

                entity.Property(e => e.IdsanPham)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDSanPham");

                entity.Property(e => e.Ngaymua)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYMUA");

                entity.Property(e => e.Trangthai)
                    .HasMaxLength(1)
                    .HasColumnName("TRANGTHAI");

                entity.HasOne(d => d.IdkhNavigation)
                    .WithMany(p => p.Phieumuas)
                    .HasForeignKey(d => d.Idkh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHIEUMUA_KHACHHANG");

                entity.HasOne(d => d.IdsanPhamNavigation)
                    .WithMany(p => p.Phieumuas)
                    .HasForeignKey(d => d.IdsanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHIEUMUA_SANPHAM");
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.HasKey(e => e.IdsanPham)
                    .HasName("PK__SANPHAM__9D45E58AFFE2F41B");

                entity.ToTable("SANPHAM");

                entity.Property(e => e.IdsanPham)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDSanPham");

                entity.Property(e => e.Gianhap)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("GIANHAP");

                entity.Property(e => e.Slnhap).HasColumnName("SLNHAP");

                entity.Property(e => e.Ten)
                    .HasMaxLength(30)
                    .HasColumnName("TEN");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
