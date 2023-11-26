using System;
using System.Collections.Generic;

namespace QuanLiDuAn_Agile.Models
{
    public partial class Khachhang
    {
        public Khachhang()
        {
            Phieumuas = new HashSet<Phieumua>();
        }

        public string Idkh { get; set; } = null!;
        public string Hoten { get; set; } = null!;
        public int Sdt { get; set; }
        public string Diachi { get; set; } = null!;

        public virtual ICollection<Phieumua> Phieumuas { get; set; }
    }
}
