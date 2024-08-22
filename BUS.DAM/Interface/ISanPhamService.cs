using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS.DAM.ViewModel;

namespace BUS.DAM.Interface
{
    public interface ISanPhamService
    {
        List<SanPhamVM> GetList();
        string Create(SanPhamCreateVM createVM);
        bool Delete(int code);
        bool Update(SanPhamUpdateVM updateVM);
        List<SanPhamVM> GetListOrderByName();
        List<LoaiSanPhamVM> GetLoaiSanPhams();
    }
}
