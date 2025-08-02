using NHOM1_DA1_QUANLINHANSU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHOM1_DA1_QUANLINHANSU.DAL
{
    public class DAL_QLBaoHiem
    {
        private readonly Nhom1Da1QlnsContext _dal;

        public DAL_QLBaoHiem()
        {
            _dal = new Nhom1Da1QlnsContext();
        }

        public List<Baohiem> GetAll()
        {
            return _dal.Baohiems.ToList();
        }

        public void Add(Baohiem bh)
        {
           _dal.Baohiems.Add(bh);
           _dal.SaveChanges();
        }

        public void Update(Baohiem bh)
        {
            var existing = _dal.Baohiems.FirstOrDefault(x => x.IdbaoHiem == bh.IdbaoHiem);
            if (existing != null)
            {
                _dal.Entry(existing).CurrentValues.SetValues(bh);
                _dal.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var bh = _dal.Baohiems.FirstOrDefault(x => x.IdbaoHiem == id);
            if (bh != null)
            {
                _dal.Baohiems.Remove(bh);
                _dal.SaveChanges();
            }
        }

        public List<Baohiem> Search(string keyword)
        {
            return _dal.Baohiems
                .Where(x => x.TrangThai.Contains(keyword) || x.TrangThai.Contains(keyword))
                .ToList();
        }
    }
}
