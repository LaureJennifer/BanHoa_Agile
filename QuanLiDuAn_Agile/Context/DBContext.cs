using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using QuanLiDuAn_Agile.DomainClass;

namespace QuanLiDuAn_Agile.Context
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
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
                optionsBuilder.UseSqlServer("Data Source=trang;Initial Catalog=QLBH_agile;Integrated Security=True;Trust Server Certificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ctphieumua>(entity =>
            {
                entity.HasKey(e => new { e.Idphieumua, e.IdsanPham });

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
                    .HasName("PK__KHACHHAN__B87DC1A7EB1A7701");
            });

            modelBuilder.Entity<Phieumua>(entity =>
            {
                entity.HasKey(e => e.Idphieumua)
                    .HasName("PK__PHIEUMUA__F3A44936BE5AE355");

                entity.HasOne(d => d.IdkhNavigation)
                    .WithMany(p => p.Phieumuas)
                    .HasForeignKey(d => d.Idkh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHIEUMUA_KHACHHANG");
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.HasKey(e => e.IdsanPham)
                    .HasName("PK__SANPHAM__9D45E58A7108E21C");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
