using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class SanPhamSver
    {
        SanPamRepo sanPamRepo;
        public SanPhamSver()
        {
            sanPamRepo = new SanPamRepo();
        }
        public List<SanPham> GetAll()
        {
            return sanPamRepo.GetAll();
        }
        public SanPham GetByid(string id) 
        {
            return sanPamRepo.GetId(id);
        }
        public string Create(SanPham sanPham)
        {
            if (sanPamRepo.CreateSp(sanPham))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";
        }
        public string Update(SanPham sanPham, string id)
        {
            if (sanPamRepo.UpdateSp(sanPham, id))
            {
                return "Sửa thành công";
            }
            else return "Sửa thất bại";
        }
        public string Delete( string id)
        {
            if (sanPamRepo.DeleteSp( id))
            {
                return "Xóa thành công";
            }
            else return "Xóa thất bại";
        }
    }
}
