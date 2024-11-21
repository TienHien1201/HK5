namespace Buoi5.DBBT8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThamSo")]
    public partial class ThamSo
    {
        [Key]
        [StringLength(40)]
        public string TenThamSo { get; set; }

        public int? GiaTri { get; set; }
    }
}
