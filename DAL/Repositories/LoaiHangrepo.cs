using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class LoaiHangrepo
    {
        QuanLyBanHangContext quanLyBanHangContext;
        public LoaiHangrepo()
        {
            quanLyBanHangContext = new QuanLyBanHangContext();
        }
        public List<LoaiHang> GetAll()
        {
            return quanLyBanHangContext.LoaiHangs.ToList(); // Lấy ra danh sách toàn bộ sản phẩm
        }
        public LoaiHang GetById(string id)
        {
            return quanLyBanHangContext.LoaiHangs.Find(id); // Phương thức Find(id) chỉ áp dụng khi id là khóa chính
        }
        public bool CreateLH(LoaiHang loaiHang)
        {
            try
            {
                quanLyBanHangContext.LoaiHangs.Add(loaiHang); quanLyBanHangContext.SaveChanges(); return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        // Sửa sản phẩm
        public bool UpdateLH(LoaiHang loaiHang, string id)
        {
            try
            {
                // Lấy ra đối tượng cần sửa
                var updateItem = quanLyBanHangContext.LoaiHangs.Find(id); // chỉ dùng với khóa chính
                if (updateItem == null)
                {
                    return false;
                }

                updateItem.MaLoaiLh = loaiHang.MaLoaiLh;
                updateItem.TenLh = loaiHang.TenLh;

                quanLyBanHangContext.SaveChanges(); // Chỉ cần SaveChanges mà không cần Update()
                return true;
            }
            catch (Exception ex)
            {
                // Log hoặc xử lý lỗi ở đây nếu cần
                return false;
            }
        }
        public bool DeleteLH(string id)
        {
            try
            {
                var deleteitem = quanLyBanHangContext.LoaiHangs.Find(id);
                quanLyBanHangContext.LoaiHangs.Remove(deleteitem);
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
