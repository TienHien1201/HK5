namespace Buoi5.DBBT8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOCGIA")]
    public partial class DOCGIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOCGIA()
        {
            PHIEUMUONSACH = new HashSet<PHIEUMUONSACH>();
            PHIEUTHUTIEN = new HashSet<PHIEUTHUTIEN>();
        }

        [Key]
        public int MaDocGia { get; set; }

        [StringLength(40)]
        public string HoTenDocGia { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(30)]
        public string Email { get; set; }

        public DateTime? NgayLapThe { get; set; }

        public DateTime? NgayHetHan { get; set; }

        public double? TienNo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUMUONSACH> PHIEUMUONSACH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTHUTIEN> PHIEUTHUTIEN { get; set; }
    }
}
