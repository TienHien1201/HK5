using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Buoi5.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=DBBT7")
        {
        }

        public virtual DbSet<KetQua> KetQua { get; set; }
        public virtual DbSet<Khoa> Khoa { get; set; }
        public virtual DbSet<MonHoc> MonHoc { get; set; }
        public virtual DbSet<SinhVien> SinhVien { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KetQua>()
                .Property(e => e.MaMH)
                .IsFixedLength();

            modelBuilder.Entity<Khoa>()
                .Property(e => e.MaKhoa)
                .IsFixedLength();

            modelBuilder.Entity<Khoa>()
                .Property(e => e.TenKhoa)
                .IsFixedLength();

            modelBuilder.Entity<MonHoc>()
                .Property(e => e.MaMH)
                .IsFixedLength();

            modelBuilder.Entity<MonHoc>()
                .Property(e => e.TenMH)
                .IsFixedLength();

            modelBuilder.Entity<MonHoc>()
                .HasMany(e => e.KetQua)
                .WithRequired(e => e.MonHoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.MaKhoa)
                .IsFixedLength();

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.HinhThe)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.KetQua)
                .WithRequired(e => e.SinhVien)
                .WillCascadeOnDelete(false);
        }
    }
}
