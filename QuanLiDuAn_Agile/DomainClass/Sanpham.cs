using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuanLiDuAn_Agile.DomainClass
{
    [Table("SANPHAM")]
    public partial class Sanpham
    {
        public Sanpham()
        {
            Ctphieumuas = new HashSet<Ctphieumua>();
        }

        [Key]
        [Column("IDSanPham")]
        [StringLength(10)]
        [Unicode(false)]
        public string IdsanPham { get; set; } = null!;
        [Column("TEN")]
        [StringLength(30)]
        public string Ten { get; set; } = null!;
        [Column("GIANHAP", TypeName = "money")]
        public decimal Gianhap { get; set; }
        [Column("SLNHAP")]
        public int Slnhap { get; set; }

        [InverseProperty("IdsanPhamNavigation")]
        public virtual ICollection<Ctphieumua> Ctphieumuas { get; set; }
    }
}
