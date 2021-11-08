namespace dbn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TT_MuonTra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TT_MuonTra()
        {
            XuLyViPhams = new HashSet<XuLyViPham>();
        }

        [Key]
        [StringLength(10)]
        public string ma_muontra { get; set; }

        [Required]
        [StringLength(10)]
        public string masach { get; set; }

        [Required]
        [StringLength(10)]
        public string ma_docgia { get; set; }

        [StringLength(10)]
        public string ma_nvchomuon { get; set; }

        [StringLength(10)]
        public string ma_nvtra { get; set; }

        public DateTime? ngaymuon { get; set; }

        public DateTime? hantra { get; set; }

        public DateTime? ngaytra { get; set; }

        public bool? tinhtrang { get; set; }

        public virtual CuonSach CuonSach { get; set; }

        public virtual DocGia DocGia { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual NhanVien NhanVien1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XuLyViPham> XuLyViPhams { get; set; }
    }
}
