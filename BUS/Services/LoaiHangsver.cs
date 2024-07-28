using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class LoaiHangsver
    {
        LoaiHangrepo LoaiHangrepo;
        public LoaiHangsver()
        {
            LoaiHangrepo = new LoaiHangrepo();
        }
        public List<LoaiHang> GetAll()
        {
            return LoaiHangrepo.GetAll();
        }
        public LoaiHang GetByid(string id)
        {
            return LoaiHangrepo.GetById(id);
        }
        public string Create(LoaiHang loaiHang)
        {
            if (LoaiHangrepo.CreateLH(loaiHang))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";
        }
        public string Update(LoaiHang loaiHang, string id)
        {
            if (LoaiHangrepo.UpdateLH(loaiHang, id))
            {
                return "Sửa thành công";
            }
            else return "Sửa thất bại";
        }
        public string Delete(string id)
        {
            if (LoaiHangrepo.DeleteLH(id))
            {
                return "Xóa thành công";
            }
            else return "Xóa thất bại";
        }
    }
}
