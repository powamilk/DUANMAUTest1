using System;
using System.Collections.Generic;

namespace DAL.DAM.Entities;

public partial class LoaiSanPham
{
    public int MaLoai { get; set; }

    public string TenLoai { get; set; } = null!;

    public string? MoTa { get; set; }

    public int TrangThai { get; set; }

    public DateOnly NgayTao { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
