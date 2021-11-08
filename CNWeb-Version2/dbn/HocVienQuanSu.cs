namespace dbn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HocVienQuanSu")]
    public partial class HocVienQuanSu
    {
        [Key]
        [StringLength(10)]
        public string ma_docgia { get; set; }

        [StringLength(50)]
        public string donvi_hocvien { get; set; }

        [StringLength(50)]
        public string khoa_hocvien { get; set; }

        [StringLength(20)]
        public string khoahoc_hocvien { get; set; }

        public virtual DocGia DocGia { get; set; }
    }
}
