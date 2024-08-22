using BUS.DAM.Implement;
using BUS.DAM.Interface;
using BUS.DAM.ViewModel;
using BUS.DAM.Utils.Status;
using BUS.DAM.Utils;
using PL.DAM.Extension;

namespace PL.DAM
{
    public partial class Form1 : Form
    {
        List<SanPhamVM> _sanPhams;
        ISanPhamService _sanPhamService;
        int _maSanPhamChon;

        public Form1()
        {
            _sanPhamService = new SanPhamService();
            InitializeComponent();
            LoadFormData();
            LoadGridData();
            LoadLoaiSanPhamComboBox();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void LoadFormData()
        {
            dgv_sanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_sanpham.Columns.Clear();
            dgv_sanpham.Columns.Add("clm1", "STT");
            dgv_sanpham.Columns.Add("clm1", "Tên");
            dgv_sanpham.Columns.Add("clm1", "Giá Bán");
            dgv_sanpham.Columns.Add("clm1", "Số Lượng Tồn");
            dgv_sanpham.Columns.Add("clm1", "Nhà Sản Xuất");
            dgv_sanpham.Columns.Add("clm1", "Xuất Xứ");
            dgv_sanpham.Columns.Add("clm1", "Trạng Thái");
            dgv_sanpham.Columns.Add("clm1", "Mô tả");
            dgv_sanpham.Columns.Add("clm1", "Loại Sản Phẩm");

            txt_timkiem.PlaceholderText = HienThi("tên sản phẩm cần tìm");
            txt_ten.PlaceholderText = HienThi("tên sản phẩm");
            txt_nhasanxuat.PlaceholderText = HienThi("nhà sản xuất");
            txt_xuatxu.PlaceholderText = HienThi("xuất xứ");
            txt_mota.PlaceholderText = HienThi("mô tả");

            cb_gia.Items.Clear();
            cb_gia.Items.Add("10000");
            cb_gia.Items.Add("20000");
            cb_gia.Items.Add("30000");
            cb_gia.Items.Add("40000");

            for (int i = 1; i <= 1000; i++)
            {
                cb_soluongton.Items.Add(i);
            }
            cb_soluongton.SelectedIndex = 0;

            cb_trangthai.Items.Clear();
            cb_trangthai.Items.Add(StatusEnum.DangBan.GetStatusName());
            cb_trangthai.Items.Add(StatusEnum.DungBan.GetStatusName());

        }
        private string HienThi(string text)
        {
            return $"Nhập {text}";
        }

        private string GetStatusName(int trangThai)
        {
            switch (trangThai)
            {
                case 1:
                    return "đang bán";
                case 2:
                    return "Dừng bán";
                default:
                    return "Không xác định";
            }

        }

        private void LoadLoaiSanPhamComboBox()
        {
            var loaiSanPhams = _sanPhamService.GetLoaiSanPhams();

            cb_loaisanpham.Items.Clear();
            foreach (var loai in loaiSanPhams)
            {
                cb_loaisanpham.Items.Add($"{loai.MaLoai} - {loai.TenLoai}");
            }

            if (cb_loaisanpham.Items.Count > 0)
            {
                cb_loaisanpham.SelectedIndex = 0;
            }
        }

        private void LoadGridData()
        {
            dgv_sanpham.Rows.Clear();
            _sanPhams = _sanPhamService.GetList();

            foreach (var sp in _sanPhams)
            {
                string tenLoaiSanPham = sp.MaLoai.HasValue ? GetTenLoaiSanPham(sp.MaLoai.Value) : "Không xác định";
                dgv_sanpham.Rows.Add(
                    (_sanPhams.IndexOf(sp) + 1),
                    sp.TenSanPham,
                    sp.GiaBan,
                    sp.SoLuongTon,
                    sp.NhaSanXuat,
                    sp.XuatXu,
                    GetStatusName(sp.TrangThai),
                    sp.MoTa,
                    tenLoaiSanPham
                );
            }
        }

        private int TaoMaSanPham()
        {
            var sanPhams = _sanPhamService.GetList();
            var lastMaSanPham = sanPhams
                .Select(sp => sp.MaSanPham)
                .OrderByDescending(ma => ma)
                .FirstOrDefault();
            return lastMaSanPham + 1;
        }

        private string GetTenLoaiSanPham(int maLoai)
        {
            var loaiSanPham = _sanPhamService.GetLoaiSanPhams().FirstOrDefault(lsp => lsp.MaLoai == maLoai);
            return loaiSanPham != null ? loaiSanPham.TenLoai : "Không xác định";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            bool isGiaBanValid = int.TryParse(cb_gia.Text, out int giaBan);
            bool isSoLuongTonValid = int.TryParse(cb_soluongton.Text, out int soLuongTon);
            bool isTrangThaiValid = cb_trangthai.SelectedIndex > -1 &&
                                    (cb_trangthai.SelectedItem.ToString() == StatusEnum.DangBan.GetStatusName() ||
                                     cb_trangthai.SelectedItem.ToString() == StatusEnum.DungBan.GetStatusName());

            if (!isGiaBanValid || giaBan <= 0 || !isSoLuongTonValid || soLuongTon <= 0)
            {
                MessageBoxExtension.Notification("THÊM", "Các trường số phải là số nguyên dương.");
                return;
            }

            int trangThai = cb_trangthai.SelectedItem.ToString() == StatusEnum.DangBan.GetStatusName() ? 1 : 2;

            if (MessageBoxExtension.Confirm("thêm"))
            {
                var newMaSanPham = TaoMaSanPham();

                var sanPhamCreate = new SanPhamCreateVM
                {
                    MaSanPham = newMaSanPham,
                    TenSanPham = txt_ten.Text,
                    GiaBan = giaBan,
                    SoLuongTon = soLuongTon,
                    NhaSanXuat = txt_nhasanxuat.Text,
                    XuatXu = txt_xuatxu.Text,
                    TrangThai = trangThai,
                    MoTa = txt_mota.Text
                };

                var result = _sanPhamService.Create(sanPhamCreate);
                MessageBoxExtension.Notification("THÊM", result);
                LoadGridData();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (_maSanPhamChon == 0)
            {
                MessageBoxExtension.Notification("CHỈNH SỬA", "Vui lòng chọn sản phẩm cần chỉnh sửa.");
                return;
            }

            bool isGiaBanValid = int.TryParse(cb_gia.Text, out int giaBan);
            bool isSoLuongTonValid = int.TryParse(cb_soluongton.Text, out int soLuongTon);
            bool isTrangThaiValid = int.TryParse(cb_trangthai.Text, out int trangThai);

            if (!isGiaBanValid || giaBan <= 0 ||
                !isSoLuongTonValid || soLuongTon <= 0 ||
                !isTrangThaiValid || trangThai <= 0)
            {
                MessageBoxExtension.Notification("CHỈNH SỬA", "Các trường số phải là số nguyên dương.");
                return;
            }

            var spUpdate = new SanPhamUpdateVM
            {
                MaSanPham = _maSanPhamChon,
                TenSanPham = txt_ten.Text,
                GiaBan = giaBan,
                SoLuongTon = soLuongTon,
                NhaSanXuat = txt_nhasanxuat.Text,
                XuatXu = txt_xuatxu.Text,
                TrangThai = trangThai,
                MoTa = txt_mota.Text
            };

            var result = _sanPhamService.Update(spUpdate);

            string msg = result ? "Chỉnh sửa thành công" : "Chỉnh sửa thất bại";
            MessageBoxExtension.Notification("CHỈNH SỬA", msg);

            LoadGridData();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (_maSanPhamChon == 0)
            {
                MessageBoxExtension.Notification("XÓA", "Vui lòng chọn sản phẩm cần xóa.");
                return;
            }

            if (MessageBoxExtension.Confirm("xóa"))
            {
                var result = _sanPhamService.Delete(_maSanPhamChon);

                string msg = result ? "Xóa thành công" : "Xóa thất bại";
                MessageBoxExtension.Notification("XÓA", msg);

                LoadGridData();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            LoadFormData();
            LoadGridData();
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            _sanPhams = _sanPhamService.GetList().Where(sp => sp.TenSanPham.Contains(txt_timkiem.Text)).ToList();

            dgv_sanpham.Rows.Clear();

            foreach (var sp in _sanPhams)
            {
                dgv_sanpham.Rows.Add(
                    (_sanPhams.IndexOf(sp) + 1),
                    sp.TenSanPham,
                    sp.GiaBan,
                    sp.SoLuongTon,
                    sp.NhaSanXuat,
                    sp.TrangThai,
                    sp.MoTa
                );
            }
        }

        private void dgv_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;

            if (index < 0 || index >= _sanPhams.Count)
            {
                _maSanPhamChon = 0;
                return;
            }

            var sanPhamChon = _sanPhams.ElementAt(index);

            _maSanPhamChon = sanPhamChon.MaSanPham;
            txt_ten.Text = sanPhamChon.TenSanPham;
            cb_gia.Text = sanPhamChon.GiaBan.ToString();
            cb_soluongton.Text = sanPhamChon.SoLuongTon.ToString();
            txt_nhasanxuat.Text = sanPhamChon.NhaSanXuat;
            cb_trangthai.Text = sanPhamChon.TrangThai.ToString();
            txt_xuatxu.Text = sanPhamChon.XuatXu;
            txt_mota.Text = sanPhamChon.MoTa;
        }
    }
}
