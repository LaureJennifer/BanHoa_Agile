using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuanLiDuAn_Agile.DomainClass
{
    [Table("KHACHHANG")]
    public partial class Khachhang
    {
        public Khachhang()
        {
            Phieumuas = new HashSet<Phieumua>();
        }

        [Key]
        [Column("IDKH")]
        [StringLength(10)]
        [Unicode(false)]
        public string Idkh { get; set; } = null!;
        [Column("HOTEN")]
        [StringLength(30)]
        public string Hoten { get; set; } = null!;
        [Column("SDT")]
        public int Sdt { get; set; }
        [Column("DIACHI")]
        [StringLength(50)]
        public string Diachi { get; set; } = null!;

        [InverseProperty("IdkhNavigation")]
        public virtual ICollection<Phieumua> Phieumuas { get; set; }
    }
}
