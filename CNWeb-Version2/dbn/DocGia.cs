namespace dbn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocGia")]
    public partial class DocGia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocGia()
        {
            TT_MuonTra = new HashSet<TT_MuonTra>();
        }

        [Key]
        [StringLength(10)]
        public string ma_docgia { get; set; }

        [StringLength(50)]
        public string hoten_docgia { get; set; }

        [StringLength(50)]
        public string anh_docgia { get; set; }

        public DateTime? ngaysinh_docgia { get; set; }

        public bool? gioitinh_docgia { get; set; }

        [StringLength(12)]
        public string sdt_docgia { get; set; }

        public DateTime? ngaycapthe { get; set; }

        public DateTime? ngayhenhan { get; set; }

        [StringLength(100)]
        public string nhomdocgia { get; set; }

        [Required]
        [StringLength(10)]
        public string ma_nhom { get; set; }

        public virtual NhomDocGia NhomDocGia1 { get; set; }

        public virtual GiaoVien_QuanSu GiaoVien_QuanSu { get; set; }

        public virtual HocVienQuanSu HocVienQuanSu { get; set; }

        public virtual SinhVien_DanSu SinhVien_DanSu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TT_MuonTra> TT_MuonTra { get; set; }
    }
}
