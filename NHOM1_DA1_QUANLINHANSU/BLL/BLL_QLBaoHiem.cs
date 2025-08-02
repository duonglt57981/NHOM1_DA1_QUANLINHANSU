using NHOM1_DA1_QUANLINHANSU.DAL;
using NHOM1_DA1_QUANLINHANSU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHOM1_DA1_QUANLINHANSU.BLL
{
    public class BLL_QLBaoHiem
    {
        private readonly DAL_QLBaoHiem _dal;

        public BLL_QLBaoHiem()
        {
            _dal = new DAL_QLBaoHiem();
        }

        public List<Baohiem> LayDanhSach() => _dal.GetAll();

        public void Them(Baohiem bh) => _dal.Add(bh);

        public void CapNhat(Baohiem bh) => _dal.Update(bh);

        public void Xoa(int id) => _dal.Delete(id);

        public List<Baohiem> TimKiem(string keyword) => _dal.Search(keyword);
    }
}
