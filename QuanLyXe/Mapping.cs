using Infrastructure.Entities;
using QuanLyXe.Models;
using AutoMapper;
namespace QuanLyXe
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<ThongTinXe, ThongTinXeViewModel>();
            CreateMap<ThongTinXeViewModel, ThongTinXe>();
        }
    }
}
