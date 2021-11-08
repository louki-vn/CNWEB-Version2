namespace dbn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Quyen_NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Quyen_NhanVien()
        {
            Loai_Quyen = new HashSet<Loai_Quyen>();
        }

        [Key]
        [StringLength(10)]
        public string ma_quyen { get; set; }

        [StringLength(50)]
        public string ten_quyen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Loai_Quyen> Loai_Quyen { get; set; }
    }
}
