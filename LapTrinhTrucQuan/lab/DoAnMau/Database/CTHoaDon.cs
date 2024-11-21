namespace DoAnMau.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTHoaDon")]
    public partial class CTHoaDon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STT { get; set; }

        public int? SoHD { get; set; }

        [StringLength(10)]
        public string MaHang { get; set; }

        public int? SoLuong { get; set; }

        public int? GiaBan { get; set; }

        public virtual MatHang MatHang { get; set; }

        public virtual HoaDon HoaDon { get; set; }
    }
}
