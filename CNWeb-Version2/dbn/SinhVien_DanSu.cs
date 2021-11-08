namespace dbn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SinhVien_DanSu
    {
        [Key]
        [StringLength(10)]
        public string ma_docgia { get; set; }

        [StringLength(50)]
        public string lop_sinhvien { get; set; }

        [StringLength(50)]
        public string khoa_sinhvien { get; set; }

        [StringLength(20)]
        public string khoahoc_sinhvien { get; set; }

        public virtual DocGia DocGia { get; set; }
    }
}
