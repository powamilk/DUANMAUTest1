using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.DAM.ViewModel
{
    public class SanPhamCreateVM
    {
        public int MaSanPham { get; set; }

        public string TenSanPham { get; set; } = null!;

        public int GiaBan { get; set; }

        public int SoLuongTon { get; set; }

        public string? NhaSanXuat { get; set; }

        public string? XuatXu { get; set; }

        public int TrangThai { get; set; }

        public string? MoTa { get; set; }

        public int? MaLoai { get; set; }
    }
}
