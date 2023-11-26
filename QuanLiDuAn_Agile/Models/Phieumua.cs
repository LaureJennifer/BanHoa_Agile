using System;
using System.Collections.Generic;

namespace QuanLiDuAn_Agile.Models
{
    public partial class Phieumua
    {
        public Phieumua()
        {
            Ctphieumuas = new HashSet<Ctphieumua>();
        }

        public string Idphieumua { get; set; } = null!;
        public string Idkh { get; set; } = null!;
        public string IdsanPham { get; set; } = null!;
        public DateTime Ngaymua { get; set; }
        public string Trangthai { get; set; } = null!;

        public virtual Khachhang IdkhNavigation { get; set; } = null!;
        public virtual Sanpham IdsanPhamNavigation { get; set; } = null!;
        public virtual ICollection<Ctphieumua> Ctphieumuas { get; set; }
    }
}
