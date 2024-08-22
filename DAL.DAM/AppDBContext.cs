using System;
using System.Collections.Generic;
using DAL.DAM.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.DAM;

public partial class ThreeLayerDb2Context : DbContext
{
    public ThreeLayerDb2Context()
    {
    }

    public ThreeLayerDb2Context(DbContextOptions<ThreeLayerDb2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=POWWA\\MSSQLSERVER01;Database=ThreeLayerDB_2;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LoaiSanPham>(entity =>
        {
            entity.HasKey(e => e.MaLoai).HasName("PK__LoaiSanP__730A575994C96E39");

            entity.ToTable("LoaiSanPham");

            entity.Property(e => e.MaLoai).ValueGeneratedNever();
            entity.Property(e => e.MoTa).HasMaxLength(500);
            entity.Property(e => e.TenLoai).HasMaxLength(100);
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.MaSanPham).HasName("PK__SanPham__FAC7442D287D2C49");

            entity.ToTable("SanPham");

            entity.Property(e => e.MaSanPham).ValueGeneratedNever();
            entity.Property(e => e.MoTa).HasMaxLength(1000);
            entity.Property(e => e.NhaSanXuat).HasMaxLength(100);
            entity.Property(e => e.TenSanPham).HasMaxLength(150);
            entity.Property(e => e.XuatXu).HasMaxLength(100);

            entity.HasOne(d => d.MaLoaiNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.MaLoai)
                .HasConstraintName("FK__SanPham__MaLoai__3B75D760");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
