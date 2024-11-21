using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Buoi5.DBBT8
{
    public partial class DBBT8 : DbContext
    {
        public DBBT8()
            : base("name=DBBT8")
        {
        }

        public virtual DbSet<BANGCAP> BANGCAP { get; set; }
        public virtual DbSet<DOCGIA> DOCGIA { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIEN { get; set; }
        public virtual DbSet<PHIEUMUONSACH> PHIEUMUONSACH { get; set; }
        public virtual DbSet<PHIEUTHUTIEN> PHIEUTHUTIEN { get; set; }
        public virtual DbSet<SACH> SACH { get; set; }
        public virtual DbSet<ThamSo> ThamSo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BANGCAP>()
                .HasMany(e => e.NHANVIEN)
                .WithOptional(e => e.BANGCAP)
                .WillCascadeOnDelete();

            modelBuilder.Entity<DOCGIA>()
                .HasMany(e => e.PHIEUMUONSACH)
                .WithOptional(e => e.DOCGIA)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUTHUTIEN)
                .WithOptional(e => e.NHANVIEN)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PHIEUMUONSACH>()
                .HasMany(e => e.SACH)
                .WithMany(e => e.PHIEUMUONSACH)
                .Map(m => m.ToTable("CHITIETPHIEUMUON").MapLeftKey("MaPhieuMuon").MapRightKey("MaSach"));
        }
    }
}
