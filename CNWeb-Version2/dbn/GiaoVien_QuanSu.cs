namespace dbn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GiaoVien_QuanSu
    {
        [Key]
        [StringLength(10)]
        public string ma_docgia { get; set; }

        [StringLength(50)]
        public string khoa_giaovien { get; set; }

        [StringLength(50)]
        public string bomon_giaovien { get; set; }

        public virtual DocGia DocGia { get; set; }
    }
}
