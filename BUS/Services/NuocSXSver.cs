using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class NuocSXSver
    {
        NuocSxrepo repo;
        public NuocSXSver()
        {
            repo = new NuocSxrepo();
        }
        public List<NuocSx> GetAll()
        {
            return repo.GetAll();
        }
        public NuocSx GetByid(string id)
        {
            return repo.GetById(id);
        }
        public string Create(NuocSx NuocSx)
        {
            if (repo.CreateQg(NuocSx))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";
        }
        public string Update(NuocSx NuocSx, string id)
        {
            if (repo.UpdateQG(NuocSx, id))
            {
                return "Sửa thành công";
            }
            else return "Sửa thất bại";
        }
        public string Delete(string id)
        {
            if (repo.DeleteQG(id))
            {
                return "Xóa thành công";
            }
            else return "Xóa thất bại";
        }
    }
}
