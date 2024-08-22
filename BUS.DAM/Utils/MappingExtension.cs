using BUS.DAM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAM.Entities;

namespace BUS.DAM.Utils
{
    public class MappingExtension
    {
        public static SanPhamVM MapEntityToVM(SanPham entity)
        {
            return new()
            {
                MaSanPham = entity.MaSanPham,
                TenSanPham = entity.TenSanPham,
                GiaBan = entity.GiaBan,
                SoLuongTon = entity.SoLuongTon,
                NhaSanXuat = entity.NhaSanXuat,
                XuatXu =entity.XuatXu,
                TrangThai = entity.TrangThai,
                MaLoai = entity.MaLoai,
                MoTa = entity.MoTa
            };
        }

        public static SanPham MapCreateVMToEntity(SanPhamCreateVM createVM)
        {
            return new()
            {
                MaSanPham = createVM.MaSanPham,
                TenSanPham = createVM.TenSanPham,
                GiaBan = createVM.GiaBan,
                SoLuongTon = createVM.SoLuongTon,
                NhaSanXuat = createVM.NhaSanXuat,
                XuatXu = createVM.XuatXu,
                TrangThai = createVM.TrangThai,
                MaLoai = createVM.MaLoai,
                MoTa = createVM.MoTa
            };
        }

        public static SanPham MapUpdateVMToEntity(SanPhamUpdateVM updateVM)
        {
            return new()
            {
                MaSanPham = updateVM.MaSanPham,
                TenSanPham = updateVM.TenSanPham,
                GiaBan = updateVM.GiaBan,
                SoLuongTon = updateVM.SoLuongTon,
                NhaSanXuat = updateVM.NhaSanXuat,
                XuatXu = updateVM.XuatXu,
                TrangThai = updateVM.TrangThai,
                MaLoai = updateVM.MaLoai,
                MoTa = updateVM.MoTa
            };
        }
    }
}
