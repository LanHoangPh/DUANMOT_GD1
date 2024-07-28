using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class VatLieuSver
    {
        VatLieurepo VatLieurepo;
        public VatLieuSver()
        {
            VatLieurepo = new VatLieurepo();
        }
        public List<VatLieu> GetAll() {
            return VatLieurepo.GetAll();
        }
        public VatLieu GetByid(string id)
        {
            return VatLieurepo.GetById(id);
        }
        public string Create(VatLieu vatLieu)
        {
            if (VatLieurepo.CreateVl(vatLieu))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";
        }
        public string Update(VatLieu vatLieu, string id)
        {
            if (VatLieurepo.UpdateVl(vatLieu, id))
            {
                return "Sửa thành công";
            }
            else return "Sửa thất bại";
        }
        public string Delete(string id)
        {
            if (VatLieurepo.DeleteVl(id))
            {
                return "Xóa thành công";
            }
            else return "Xóa thất bại";
        }
    }
}
