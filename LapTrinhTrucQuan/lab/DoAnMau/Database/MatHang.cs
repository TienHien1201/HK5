namespace DoAnMau.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MatHang")]
    public partial class MatHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MatHang()
        {
            CTHoaDon = new HashSet<CTHoaDon>();
        }

        [Key]
        [StringLength(10)]
        public string MaHang { get; set; }

        [StringLength(50)]
        public string TenHang { get; set; }

        [StringLength(20)]
        public string AnhDaiDien { get; set; }

        [StringLength(10)]
        public string DVTinh { get; set; }

        public int? GiaBan { get; set; }

        public int? SLTon { get; set; }

        public int? ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHoaDon> CTHoaDon { get; set; }

        public virtual ThuongHieu ThuongHieu { get; set; }
    }
}
