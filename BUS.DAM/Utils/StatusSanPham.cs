using BUS.DAM.Utils.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.DAM.Utils
{
    public static class StatusSanPham
    {
        public static string GetStatusName(this StatusEnum trangThai)
        {
            return trangThai switch
            {
                StatusEnum.DangBan => "1 - Đang Bán",
                StatusEnum.DungBan => "2- Dừng Bán",
                _ => "Ko xác định"
            };
        }
    }
    
}
