using DAL.DAM.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAM.Entities;
using DAL.DAM;

namespace DAL.DAM.Repositories.Implement
{
    public class SanPhamRepo : ISanPhamRepo
    {
        ThreeLayerDb2Context _appDbContext;

        public SanPhamRepo()
        {
            _appDbContext = new ThreeLayerDb2Context();
        }
        public string Create(SanPham pham)
        {
            try
            {
                _appDbContext.Add(pham);
                _appDbContext.SaveChanges();

                return "them thanh cong";
            }
            catch (Exception ex)
            {
                return "Them That Bai" +
                    $"loi: {ex}";
            };
        }

        public bool Delete(int code)
        {
            try
            {
                var queryable = _appDbContext.SanPhams.AsQueryable();
                SanPham sanPham = queryable.FirstOrDefault(e => e.MaSanPham == code);

                _appDbContext.Remove(sanPham);
                _appDbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<SanPham> GetList()
        {
           var queryable = _appDbContext.SanPhams.AsQueryable();
            List<SanPham> sanPhams = queryable.ToList();
            return sanPhams;
        }

        public List<SanPham> GetListOrderByName()
        {
            return _appDbContext.SanPhams.OrderBy(pham => pham.TenSanPham).ToList();
        }

        public bool Update(SanPham pham)
        {
            try
            {
                var queryable = _appDbContext.SanPhams.AsQueryable();
                SanPham sanPham = queryable.FirstOrDefault(e => e.MaSanPham == pham.MaSanPham);
                sanPham.TenSanPham = pham.TenSanPham;
                sanPham.MoTa = pham.MoTa;
                sanPham.NhaSanXuat = pham.NhaSanXuat;
                sanPham.GiaBan = pham.GiaBan;
                sanPham.SoLuongTon = pham.SoLuongTon;
                sanPham.XuatXu = pham.XuatXu;
                sanPham.TrangThai = pham.TrangThai;
                sanPham.MaLoai = pham.MaLoai;

                _appDbContext.Update(sanPham);
                _appDbContext.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<LoaiSanPham> GetLoaiSanPhams()
        {
            var queryable = _appDbContext.LoaiSanPhams.AsQueryable();
            List<LoaiSanPham> loaiSanPhams = queryable.ToList();
            return loaiSanPhams;
        }

    }
}
