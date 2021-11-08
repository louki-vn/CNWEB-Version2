namespace dbn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TaiKhoan_NV
    {
        [Key]
        [StringLength(10)]
        public string ma_nhanvien { get; set; }

        [Required]
        [StringLength(50)]
        public string tentaikhoan { get; set; }

        [Required]
        [StringLength(50)]
        public string matkhau { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
