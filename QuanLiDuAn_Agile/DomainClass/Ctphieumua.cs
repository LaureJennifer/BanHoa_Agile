using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuanLiDuAn_Agile.DomainClass
{
    [Table("CTPHIEUMUA")]
    public partial class Ctphieumua
    {
        [Key]
        [Column("IDPHIEUMUA")]
        [StringLength(10)]
        [Unicode(false)]
        public string Idphieumua { get; set; } = null!;
        [Key]
        [Column("IDSanPham")]
        [StringLength(10)]
        [Unicode(false)]
        public string IdsanPham { get; set; } = null!;
        [Column("SLMUA")]
        public int Slmua { get; set; }
        [Column("DONGIA", TypeName = "money")]
        public decimal Dongia { get; set; }

        [ForeignKey("Idphieumua")]
        [InverseProperty("Ctphieumuas")]
        public virtual Phieumua IdphieumuaNavigation { get; set; } = null!;
        [ForeignKey("IdsanPham")]
        [InverseProperty("Ctphieumuas")]
        public virtual Sanpham IdsanPhamNavigation { get; set; } = null!;
    }
}
