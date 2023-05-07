using Infrastructure.Entities;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public interface IThongTinXeService
    {
        IQueryable<ThongTinXe> GetTatCaXe();
        ThongTinXe GetThongTinXe(int id);
        void InsertThongTinXe(ThongTinXe thongTinXe);
        void UpdateThongTinXe(ThongTinXe thongTinXe);
        void DeleteThongTinXe(ThongTinXe thongTinXe);
    }

    public class ThongTinXeService : IThongTinXeService
    {
        private IThongTinXeRepository thongTinXeRepository;

        public ThongTinXeService(IThongTinXeRepository thongTinXeRepository)
        {
            this.thongTinXeRepository = thongTinXeRepository;
        }

        public IQueryable<ThongTinXe> GetTatCaXe()
        {
            return thongTinXeRepository.GetAll();
        }

        public ThongTinXe GetThongTinXe(int id)
        {
            return thongTinXeRepository.GetById(id);
        }

        public void InsertThongTinXe(ThongTinXe thongTinXe)
        {
            thongTinXeRepository.Insert(thongTinXe);
        }

        public void UpdateThongTinXe(ThongTinXe thongTinXe)
        {
            thongTinXeRepository.Update(thongTinXe);
        }

        public void DeleteThongTinXe(ThongTinXe thongTinXe)
        {
            thongTinXeRepository.Delete(thongTinXe);
        }
    }
}
