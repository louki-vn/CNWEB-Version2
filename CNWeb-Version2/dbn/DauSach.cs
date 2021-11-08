namespace dbn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DauSach")]
    public partial class DauSach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DauSach()
        {
            CuonSaches = new HashSet<CuonSach>();
            SangTacs = new HashSet<SangTac>();
            TheLoais = new HashSet<TheLoai>();
        }

        [Key]
        [StringLength(10)]
        public string ma_dausach { get; set; }

        [StringLength(50)]
        public string ten_dausach { get; set; }

        [StringLength(20)]
        public string anh_dausach { get; set; }

        [StringLength(50)]
        public string ten_nxb { get; set; }

        public DateTime? namxuatban { get; set; }

        public decimal? giatien { get; set; }

        public int? soluong { get; set; }

        [StringLength(10)]
        public string ma_kieusach { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuonSach> CuonSaches { get; set; }

        public virtual KieuSach KieuSach { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SangTac> SangTacs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TheLoai> TheLoais { get; set; }
    }
}
