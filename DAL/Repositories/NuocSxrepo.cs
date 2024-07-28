using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class NuocSxrepo
    {
       QuanLyBanHangContext quanLyBanHangContext;
        public NuocSxrepo()
        {
            
            quanLyBanHangContext = new QuanLyBanHangContext();
        }
        public List<NuocSx> GetAll()
        {
            return quanLyBanHangContext.NuocSxes.ToList(); // Lấy ra danh sách toàn bộ sản phẩm
        }
        public NuocSx GetById(string id)
        {
            return quanLyBanHangContext.NuocSxes.Find(id); // Phương thức Find(id) chỉ áp dụng khi id là khóa chính
        }
        public bool CreateQg(NuocSx nuocSx)
        {
            try
            {
                quanLyBanHangContext.NuocSxes.Add(nuocSx); quanLyBanHangContext.SaveChanges(); return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        // Sửa sản phẩm
        public bool UpdateQG(NuocSx nuocSx, string id)
        {
            try
            {
                // Lấy ra đối tượng cần sửa
                var updateItem = quanLyBanHangContext.NuocSxes.Find(id); // chỉ dùng với khóa chính
                if (updateItem == null)
                {
                    return false;
                }

                updateItem.MaQg = nuocSx.MaQg;
                updateItem.TenQg = nuocSx.TenQg;

                quanLyBanHangContext.SaveChanges(); // Chỉ cần SaveChanges mà không cần Update()
                return true;
            }
            catch (Exception ex)
            {
                // Log hoặc xử lý lỗi ở đây nếu cần
                return false;
            }
        }
        public bool DeleteQG(string id)
        {
            try
            {
                var deleteitem = quanLyBanHangContext.NuocSxes.Find(id);
                quanLyBanHangContext.NuocSxes.Remove(deleteitem);
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
