using DAL.DAM.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS.DAM.Interface;
using BUS.DAM.ViewModel;
using DAL.DAM;
using DAL.DAM.Repositories.Implement;
using BUS.DAM.Utils;
using DAL.DAM.Entities;

namespace BUS.DAM.Implement
{
    public class SanPhamService : ISanPhamService
    {
        private readonly ISanPhamRepo _repo;
        private readonly ThreeLayerDb2Context _appDbContext;

        public SanPhamService()
        {
            _repo = new SanPhamRepo();
            _appDbContext = new ThreeLayerDb2Context();
        }

        public string Create(SanPhamCreateVM createVM)
        {
            SanPham entity = MappingExtension.MapCreateVMToEntity(createVM);
            var result = _repo.Create(entity);
            return result;
        }

        public bool Delete(int code)
        {
            var result = _repo.Delete(code);
            return result;
        }

        public List<SanPhamVM> GetList()
        {
            List<SanPham> entities  = _repo.GetList();
            var sp = entities.Select(e => MappingExtension.MapEntityToVM(e)).ToList();
            return sp;
        }

        public List<SanPhamVM> GetListOrderByName()
        {
            return _repo.GetListOrderByName().Select(MappingExtension.MapEntityToVM).ToList();
        }

        public bool Update(SanPhamUpdateVM updateVM)
        {
            SanPham entity = MappingExtension.MapUpdateVMToEntity(updateVM);
            var result = _repo.Update(entity);
            return result;
        }

        public List<LoaiSanPhamVM> GetLoaiSanPhams()
        {
            List<LoaiSanPham> entities = _repo.GetLoaiSanPhams();
            var loaiSanPhams = entities.Select(e => new LoaiSanPhamVM
            {
                MaLoai = e.MaLoai,
                TenLoai = e.TenLoai
            }).ToList();

            return loaiSanPhams;
        }

    }
}
