using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAM.Entities;

namespace DAL.DAM.Repositories.Interface
{
    public interface ISanPhamRepo
    {
        List<SanPham> GetList();
        List<SanPham> GetListOrderByName();
        string Create(SanPham pham);
        bool Update(SanPham pham);  
        bool Delete(int code);
        List<LoaiSanPham> GetLoaiSanPhams();
    }
}
