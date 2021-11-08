namespace db
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
        public int MaXuLy { get; set; }

        [StringLength(10)]
        public string MaDocGia { get; set; }

        [StringLength(30)]
        public string LyDo { get; set; }

        public decimal? TienPhat { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayXuLy { get; set; }

        [StringLength(10)]
        public string MaSach { get; set; }

        public virtual DocGia DocGia { get; set; }
    }
}
