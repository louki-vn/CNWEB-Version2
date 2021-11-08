namespace dbn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            TT_MuonTra = new HashSet<TT_MuonTra>();
            TT_MuonTra1 = new HashSet<TT_MuonTra>();
        }

        [Key]
        [StringLength(10)]
        public string ma_nhanvien { get; set; }

        [StringLength(50)]
        public string ten_nhanvien { get; set; }

        [StringLength(20)]
        public string anh_nhanvien { get; set; }

        public DateTime? ngaysinh_nhanvien { get; set; }

        public decimal? sdt_nhanvien { get; set; }

        [StringLength(10)]
        public string ma_chucvu { get; set; }

        public virtual ChucVu ChucVu { get; set; }

        public virtual TaiKhoan_NV TaiKhoan_NV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TT_MuonTra> TT_MuonTra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TT_MuonTra> TT_MuonTra1 { get; set; }
    }
}
