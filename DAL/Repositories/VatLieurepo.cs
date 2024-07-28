using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class VatLieurepo
    {
        QuanLyBanHangContext quanLyBanHangContext;
        public VatLieurepo()
        {
            quanLyBanHangContext = new QuanLyBanHangContext();
        }
        public List<VatLieu> GetAll()
        {
            return quanLyBanHangContext.VatLieus.ToList(); // Lấy ra danh sách toàn bộ sản phẩm
        }
        public VatLieu GetById(string id)
        {
            return quanLyBanHangContext.VatLieus.Find(id); // Phương thức Find(id) chỉ áp dụng khi id là khóa chính
        }
        public bool CreateVl(VatLieu vatLieu)
        {
            try
            {
                quanLyBanHangContext.VatLieus.Add(vatLieu); quanLyBanHangContext.SaveChanges(); return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        // Sửa sản phẩm
        public bool UpdateVl(VatLieu vatLieu, string id)
        {
            try
            {
                // Lấy ra đối tượng cần sửa
                var updateItem = quanLyBanHangContext.VatLieus.Find(id); // chỉ dùng với khóa chính
                updateItem.MaVl = vatLieu.MaVl;
                updateItem.TenVl = vatLieu.TenVl;
                quanLyBanHangContext.VatLieus.Update(updateItem);
                quanLyBanHangContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        public bool DeleteVl(string id)
        {
            try {
                var deleteitem = quanLyBanHangContext.VatLieus.Find(id);
                quanLyBanHangContext.VatLieus.Remove(deleteitem);
                quanLyBanHangContext.SaveChanges() ;
                return true;
            }
            catch(Exception) {
                return false;
            }
            
        }
    }
}
