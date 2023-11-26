using System;
using System.Collections.Generic;

namespace QuanLiDuAn_Agile.Models
{
    public partial class Ctphieumua
    {
        public string Idphieumua { get; set; } = null!;
        public string IdsanPham { get; set; } = null!;
        public int Slmua { get; set; }
        public decimal Dongia { get; set; }

        public virtual Phieumua IdphieumuaNavigation { get; set; } = null!;
        public virtual Sanpham IdsanPhamNavigation { get; set; } = null!;
    }
}
