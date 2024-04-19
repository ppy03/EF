using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DB_First.Models;

public partial class QlsvContext : DbContext
{
    public QlsvContext()
    {
    }

    public QlsvContext(DbContextOptions<QlsvContext> options)
        : base(options)
    {
    }



    public virtual DbSet<Khoa> Khoas { get; set; }

    public virtual DbSet<Lop> Lops { get; set; }

    public virtual DbSet<SinhVien> SinhViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=SNOOPY\\SQLEXPRESS;Initial Catalog=QLSV;User ID=sa;Password=13122003;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Khoa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Khoa__3214EC0766AF864D");

            entity.ToTable("Khoa");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Ten).HasMaxLength(50);
        });

        modelBuilder.Entity<Lop>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Lop__3214EC07A8D78EC1");

            entity.ToTable("Lop");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Ten).HasMaxLength(50);

            entity.HasOne(d => d.Khoa).WithMany(p => p.Lops)
                .HasForeignKey(d => d.KhoaId)
                .HasConstraintName("FK__Lop__KhoaId__4E88ABD4");
        });

        modelBuilder.Entity<SinhVien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SinhVien__3214EC07B127E3E5");

            entity.ToTable("SinhVien");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Ten).HasMaxLength(100);

            entity.HasOne(d => d.Lop).WithMany(p => p.SinhViens)
                .HasForeignKey(d => d.LopId)
                .HasConstraintName("FK__SinhVien__LopId__5165187F");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
