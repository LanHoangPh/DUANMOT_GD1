using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class PhuongTHucttrepo
    {
        QuanLyBanHangContext quanLyBanHangContext;
        public PhuongTHucttrepo()
        {
            quanLyBanHangContext = new QuanLyBanHangContext();
        }
        public List<PhuongThucTt> GetALL()
        {
            return quanLyBanHangContext.PhuongThucTts.ToList();
        }
        public PhuongThucTt GetId(string id) 
        {
            return quanLyBanHangContext.PhuongThucTts.Find(id);
        }
        public bool CreatePTTT(PhuongThucTt phuongThucTt)
        {
            try
            {
                quanLyBanHangContext.PhuongThucTts.Add(phuongThucTt);
                quanLyBanHangContext.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpadtePTTT(PhuongThucTt phuongThucTt, string id)
        {
            try {
                var UpadteItem = quanLyBanHangContext.PhuongThucTts.Find(id);
                UpadteItem.MaPttt = phuongThucTt.MaPttt;
                UpadteItem.TenPttt = phuongThucTt.TenPttt;
                quanLyBanHangContext.PhuongThucTts.Update(UpadteItem);
                quanLyBanHangContext.SaveChanges();
                return true;
                    
            }
            catch(Exception) 
            {
            return false;
            }
        }
        public bool DeletePTTT(string id)
        {
            try { 
            var delteitems = quanLyBanHangContext.PhuongThucTts.Find(id);
                quanLyBanHangContext.PhuongThucTts.Remove(delteitems);
                quanLyBanHangContext.SaveChanges();
                return true;
            }
            catch(Exception) {
                return false;
            }
        }
        

        }
    }

