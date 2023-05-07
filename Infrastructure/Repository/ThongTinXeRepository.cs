using Infrastructure.EF;
using Infrastructure.Entities;
using Infrastructure.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public interface IThongTinXeRepository : IRepository<ThongTinXe>
    {
    }
    public class ThongTinXeRepository : Repository<ThongTinXe>, IThongTinXeRepository
    {
        public ThongTinXeRepository(EXDbContext context) : base(context)
        {
        }
    }
}
