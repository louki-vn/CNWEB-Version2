namespace db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinNopPhat")]
    public partial class ThongTinNopPhat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaXuLy { get; set; }

        [StringLength(50)]
        public string TenDocGia { get; set; }

        [StringLength(20)]
        public string DonVi { get; set; }

        [StringLength(30)]
        public string LyDo { get; set; }

        public decimal? TienPhat { get; set; }
    }
}
