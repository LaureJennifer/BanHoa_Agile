using System;
using System.Collections.Generic;

namespace QuanLiDuAn_Agile.Models
{
    public partial class Sanpham
    {
        public Sanpham()
        {
            Ctphieumuas = new HashSet<Ctphieumua>();
            Phieumuas = new HashSet<Phieumua>();
        }

        public string IdsanPham { get; set; } = null!;
        public string Ten { get; set; } = null!;
        public decimal Gianhap { get; set; }
        public int Slnhap { get; set; }

        public virtual ICollection<Ctphieumua> Ctphieumuas { get; set; }
        public virtual ICollection<Phieumua> Phieumuas { get; set; }
    }
}
