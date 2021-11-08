using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace dbn
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<CuonSach> CuonSaches { get; set; }
        public virtual DbSet<DauSach> DauSaches { get; set; }
        public virtual DbSet<DocGia> DocGias { get; set; }
        public virtual DbSet<GiaoVien_QuanSu> GiaoVien_QuanSu { get; set; }
        public virtual DbSet<HocVienQuanSu> HocVienQuanSus { get; set; }
        public virtual DbSet<KieuSach> KieuSaches { get; set; }
        public virtual DbSet<Loai_Quyen> Loai_Quyen { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NhomDocGia> NhomDocGias { get; set; }
        public virtual DbSet<Quyen_NhanVien> Quyen_NhanVien { get; set; }
        public virtual DbSet<SangTac> SangTacs { get; set; }
        public virtual DbSet<SinhVien_DanSu> SinhVien_DanSu { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TacGia> TacGias { get; set; }
        public virtual DbSet<TaiKhoan_NV> TaiKhoan_NV { get; set; }
        public virtual DbSet<TheLoai> TheLoais { get; set; }
        public virtual DbSet<TT_MuonTra> TT_MuonTra { get; set; }
        public virtual DbSet<XuLyViPham> XuLyViPhams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChucVu>()
                .Property(e => e.ma_chucvu)
                .IsUnicode(false);

            modelBuilder.Entity<ChucVu>()
                .HasMany(e => e.Loai_Quyen)
                .WithRequired(e => e.ChucVu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CuonSach>()
                .Property(e => e.ma_cuonsach)
                .IsUnicode(false);

            modelBuilder.Entity<CuonSach>()
                .Property(e => e.ma_dausach)
                .IsUnicode(false);

            modelBuilder.Entity<CuonSach>()
                .HasMany(e => e.TT_MuonTra)
                .WithRequired(e => e.CuonSach)
                .HasForeignKey(e => e.masach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DauSach>()
                .Property(e => e.ma_dausach)
                .IsUnicode(false);

            modelBuilder.Entity<DauSach>()
                .Property(e => e.anh_dausach)
                .IsUnicode(false);

            modelBuilder.Entity<DauSach>()
                .Property(e => e.giatien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DauSach>()
                .Property(e => e.ma_kieusach)
                .IsUnicode(false);

            modelBuilder.Entity<DauSach>()
                .HasMany(e => e.CuonSaches)
                .WithRequired(e => e.DauSach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DauSach>()
                .HasMany(e => e.SangTacs)
                .WithRequired(e => e.DauSach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DauSach>()
                .HasMany(e => e.TheLoais)
                .WithMany(e => e.DauSaches)
                .Map(m => m.ToTable("TheLoaiDauSach").MapLeftKey("ma_dausach").MapRightKey("ma_theloai"));

            modelBuilder.Entity<DocGia>()
                .Property(e => e.ma_docgia)
                .IsUnicode(false);

            modelBuilder.Entity<DocGia>()
                .Property(e => e.anh_docgia)
                .IsUnicode(false);

            modelBuilder.Entity<DocGia>()
                .Property(e => e.sdt_docgia)
                .IsUnicode(false);

            modelBuilder.Entity<DocGia>()
                .Property(e => e.ma_nhom)
                .IsUnicode(false);

            modelBuilder.Entity<DocGia>()
                .HasOptional(e => e.GiaoVien_QuanSu)
                .WithRequired(e => e.DocGia);

            modelBuilder.Entity<DocGia>()
                .HasOptional(e => e.HocVienQuanSu)
                .WithRequired(e => e.DocGia);

            modelBuilder.Entity<DocGia>()
                .HasOptional(e => e.SinhVien_DanSu)
                .WithRequired(e => e.DocGia);

            modelBuilder.Entity<DocGia>()
                .HasMany(e => e.TT_MuonTra)
                .WithRequired(e => e.DocGia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GiaoVien_QuanSu>()
                .Property(e => e.ma_docgia)
                .IsUnicode(false);

            modelBuilder.Entity<HocVienQuanSu>()
                .Property(e => e.ma_docgia)
                .IsUnicode(false);

            modelBuilder.Entity<HocVienQuanSu>()
                .Property(e => e.khoahoc_hocvien)
                .IsUnicode(false);

            modelBuilder.Entity<KieuSach>()
                .Property(e => e.ma_kieusach)
                .IsUnicode(false);

            modelBuilder.Entity<KieuSach>()
                .HasMany(e => e.NhomDocGias)
                .WithMany(e => e.KieuSaches)
                .Map(m => m.ToTable("NhomMuonSach").MapLeftKey("ma_kieusach").MapRightKey("ma_nhom"));

            modelBuilder.Entity<Loai_Quyen>()
                .Property(e => e.ma_chucvu)
                .IsUnicode(false);

            modelBuilder.Entity<Loai_Quyen>()
                .Property(e => e.ma_quyen)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.ma_nhanvien)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.anh_nhanvien)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.sdt_nhanvien)
                .HasPrecision(12, 0);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.ma_chucvu)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasOptional(e => e.TaiKhoan_NV)
                .WithRequired(e => e.NhanVien);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.TT_MuonTra)
                .WithOptional(e => e.NhanVien)
                .HasForeignKey(e => e.ma_nvchomuon);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.TT_MuonTra1)
                .WithOptional(e => e.NhanVien1)
                .HasForeignKey(e => e.ma_nvtra);

            modelBuilder.Entity<NhomDocGia>()
                .Property(e => e.ma_nhom)
                .IsUnicode(false);

            modelBuilder.Entity<NhomDocGia>()
                .HasMany(e => e.DocGias)
                .WithRequired(e => e.NhomDocGia1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Quyen_NhanVien>()
                .Property(e => e.ma_quyen)
                .IsUnicode(false);

            modelBuilder.Entity<Quyen_NhanVien>()
                .Property(e => e.ten_quyen)
                .IsUnicode(false);

            modelBuilder.Entity<Quyen_NhanVien>()
                .HasMany(e => e.Loai_Quyen)
                .WithRequired(e => e.Quyen_NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SangTac>()
                .Property(e => e.ma_dausach)
                .IsUnicode(false);

            modelBuilder.Entity<SangTac>()
                .Property(e => e.ma_tacgia)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien_DanSu>()
                .Property(e => e.ma_docgia)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien_DanSu>()
                .Property(e => e.khoahoc_sinhvien)
                .IsUnicode(false);

            modelBuilder.Entity<TacGia>()
                .Property(e => e.ma_tacgia)
                .IsUnicode(false);

            modelBuilder.Entity<TacGia>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<TacGia>()
                .HasMany(e => e.SangTacs)
                .WithRequired(e => e.TacGia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan_NV>()
                .Property(e => e.ma_nhanvien)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan_NV>()
                .Property(e => e.tentaikhoan)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan_NV>()
                .Property(e => e.matkhau)
                .IsUnicode(false);

            modelBuilder.Entity<TheLoai>()
                .Property(e => e.ma_theloai)
                .IsUnicode(false);

            modelBuilder.Entity<TT_MuonTra>()
                .Property(e => e.ma_muontra)
                .IsUnicode(false);

            modelBuilder.Entity<TT_MuonTra>()
                .Property(e => e.masach)
                .IsUnicode(false);

            modelBuilder.Entity<TT_MuonTra>()
                .Property(e => e.ma_docgia)
                .IsUnicode(false);

            modelBuilder.Entity<TT_MuonTra>()
                .Property(e => e.ma_nvchomuon)
                .IsUnicode(false);

            modelBuilder.Entity<TT_MuonTra>()
                .Property(e => e.ma_nvtra)
                .IsUnicode(false);

            modelBuilder.Entity<TT_MuonTra>()
                .HasMany(e => e.XuLyViPhams)
                .WithRequired(e => e.TT_MuonTra)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<XuLyViPham>()
                .Property(e => e.maxuly)
                .IsUnicode(false);

            modelBuilder.Entity<XuLyViPham>()
                .Property(e => e.tienphat)
                .HasPrecision(18, 0);

            modelBuilder.Entity<XuLyViPham>()
                .Property(e => e.ma_muonTra)
                .IsUnicode(false);
        }
    }
}
