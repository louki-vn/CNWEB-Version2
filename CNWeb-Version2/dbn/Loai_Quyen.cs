namespace dbn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Loai_Quyen
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string ma_chucvu { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string ma_quyen { get; set; }

        [StringLength(100)]
        public string ghichu { get; set; }

        public virtual ChucVu ChucVu { get; set; }

        public virtual Quyen_NhanVien Quyen_NhanVien { get; set; }
    }
}
