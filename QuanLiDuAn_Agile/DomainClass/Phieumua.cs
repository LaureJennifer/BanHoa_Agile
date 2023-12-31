﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuanLiDuAn_Agile.DomainClass
{
    [Table("PHIEUMUA")]
    public partial class Phieumua
    {
        public Phieumua()
        {
            Ctphieumuas = new HashSet<Ctphieumua>();
        }

        [Key]
        [Column("IDPHIEUMUA")]
        [StringLength(10)]
        [Unicode(false)]
        public string Idphieumua { get; set; } = null!;
        [Column("IDKH")]
        [StringLength(10)]
        [Unicode(false)]
        public string Idkh { get; set; } = null!;
        [Column("NGAYMUA", TypeName = "datetime")]
        public DateTime Ngaymua { get; set; }
        [Column("TRANGTHAI")]
        [StringLength(1)]
        public string Trangthai { get; set; } = null!;

        [ForeignKey("Idkh")]
        [InverseProperty("Phieumuas")]
        public virtual Khachhang IdkhNavigation { get; set; } = null!;
        [InverseProperty("IdphieumuaNavigation")]
        public virtual ICollection<Ctphieumua> Ctphieumuas { get; set; }
    }
}
