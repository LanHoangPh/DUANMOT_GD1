using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class SanPamRepo
    {
        QuanLyBanHangContext quanLyBanHangContext;
        public SanPamRepo()
        {
            quanLyBanHangContext = new QuanLyBanHangContext();

        }
        public List<SanPham> GetAll()
        {
            return quanLyBanHangContext.SanPhams.ToList();
        }
        public SanPham GetId(string id)
        {
            return quanLyBanHangContext.SanPhams.Find(id);
        }
        public bool CreateSp(SanPham sanPham)
        {
            try
            {
                quanLyBanHangContext.SanPhams.Add(sanPham);
                quanLyBanHangContext.SaveChanges();
                return true;

            }
            catch (Exception )
            {
                return false;
            }
        }
        public bool UpdateSp(SanPham sanPham, string id)
        {
            try
            {
                var updateItems = quanLyBanHangContext.SanPhams.Find(id);
                updateItems.MaSp = sanPham.MaSp;
                updateItems.TenSp = sanPham.TenSp;
                updateItems.HinhAnh = sanPham.HinhAnh;
                updateItems.MaLoaiLh = sanPham.MaLoaiLh;
                updateItems.MaVl = sanPham.MaVl;
                updateItems.MaNhaCc = sanPham.MaNhaCc;
                updateItems.MaQg = sanPham.MaQg;
                updateItems.Gia = sanPham.Gia;
                quanLyBanHangContext.SanPhams.Update(sanPham);
                quanLyBanHangContext.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteSp(string id)
        {
            try
            {
                var deltetItem = quanLyBanHangContext.SanPhams.Find(id);
                quanLyBanHangContext.SanPhams.Remove(deltetItem);
                quanLyBanHangContext.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
