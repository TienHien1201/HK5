using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DoAnMau.Database
{
    public partial class DoAnMauDB : DbContext
    {
        public DoAnMauDB()
            : base("name=DoAnMauDB12")
        {
        }

        public virtual DbSet<CTHoaDon> CTHoaDons { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<MatHang> MatHangs { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<Quyen> Quyens { get; set; }
        public virtual DbSet<ThuongHieu> ThuongHieus { get; set; }
        public virtual DbSet<vw_DoanhThu> DoanhThus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CTHoaDon>()
                .Property(e => e.MaHang)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.TenNguoiDung)
                .IsUnicode(false);

            modelBuilder.Entity<MatHang>()
                .Property(e => e.MaHang)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.TenNguoiDung)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);
        }
        SqlConnection connection;
        public void KetNoi()
        {
            if (connection == null)
            {
                connection = new SqlConnection();
                connection.ConnectionString = "data source=HIEN\\SQLEXPRESS;initial catalog=DoAnMau;persist security info=True;user id=sa;password=123456789;MultipleActiveResultSets=True;";
            }
            if (connection.State == System.Data.ConnectionState.Closed || connection.State == System.Data.ConnectionState.Broken)
            {
                connection.Open();
                Console.WriteLine("Kết nối thành công!");
            }
        }
        public void NgatKetNoi()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                Console.WriteLine("Đã ngắt kết nối");
            }
        }
        public DataTable LayDuLieu(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                KetNoi();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi lấy dữ liệu: " + ex.Message);
            }
            finally
            {
                NgatKetNoi();
            }
            return dt;
        }
        public int CapNhatDuLieu(string sql)
        {
            int kq = -1;
            try
            {
                KetNoi();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = sql;
                kq = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi Thêm/Sửa/Xóa dữ liệu: " + ex.Message);
            }
            finally
            {
                NgatKetNoi();
            }
            return kq;
        }
    }
}
