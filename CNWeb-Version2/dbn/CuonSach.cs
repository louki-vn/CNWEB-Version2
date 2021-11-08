namespace dbn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CuonSach")]
    public partial class CuonSach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CuonSach()
        {
            TT_MuonTra = new HashSet<TT_MuonTra>();
        }

        [Key]
        [StringLength(10)]
        public string ma_cuonsach { get; set; }

        [Required]
        [StringLength(10)]
        public string ma_dausach { get; set; }

        public bool? tinhtrang { get; set; }

        public DateTime? ngaynhap { get; set; }

        public virtual DauSach DauSach { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TT_MuonTra> TT_MuonTra { get; set; }
    }
}
