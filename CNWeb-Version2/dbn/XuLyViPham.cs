namespace dbn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XuLyViPham")]
    public partial class XuLyViPham
    {
        [Key]
        [StringLength(10)]
        public string maxuly { get; set; }

        public DateTime? ngayxuly { get; set; }

        [StringLength(100)]
        public string lydo { get; set; }

        public decimal? tienphat { get; set; }

        [Required]
        [StringLength(10)]
        public string ma_muonTra { get; set; }

        public virtual TT_MuonTra TT_MuonTra { get; set; }
    }
}
