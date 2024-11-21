namespace DoAnMau.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_DoanhThu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoHD { get; set; }

        public DateTime? NgayLap { get; set; }

        [StringLength(10)]
        public string MaHang { get; set; }

        [StringLength(50)]
        public string TenHang { get; set; }

        [StringLength(10)]
        public string DVTinh { get; set; }

        public int? GiaBan { get; set; }

        public int? SoLuong { get; set; }

        public int? ThanhTien { get; set; }

        [StringLength(30)]
        public string TenNguoiDung { get; set; }
    }
}
