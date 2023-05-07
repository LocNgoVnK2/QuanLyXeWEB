using AutoMapper;
using Infrastructure.Entities;
using Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyXe.Models;
using System;

namespace QuanLyXe.Controllers
{
    public class ThongTinXeController : Controller
    {
        private readonly IThongTinXeService thongTinXeService;
        private readonly IMapper mapper;
        public ThongTinXeController(IThongTinXeService thongTinXeService, IMapper mapper)
        {
            this.thongTinXeService = thongTinXeService;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            return View(thongTinXeService.GetTatCaXe());
        }

        public IActionResult AddOrEdit(int id = 0)
        {
            ThongTinXeViewModel data = new ThongTinXeViewModel();
            ViewBag.RenderedHtmlTitle = id == 0 ? "THÊM MỚI TT xe" : "CẬP NHẬT TT xe";

            if (id != 0)
            {
                ThongTinXe res = thongTinXeService.GetThongTinXe(id);
                data = mapper.Map<ThongTinXeViewModel>(res);
                if (data == null)
                {
                    return NotFound();
                }
            }

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEdit(int id, ThongTinXeViewModel data)
        {
            ViewBag.RenderedHtmlTitle = id == 0 ? "THÊM MỚI TÀI KHOẢN" : "CẬP NHẬT TÀI KHOẢN";

            if (ModelState.IsValid)
            {
                try
                {
                    ThongTinXe res = mapper.Map<ThongTinXe>(data);
                    if (id != 0)
                    {
                        thongTinXeService.UpdateThongTinXe(res);
                    }
                    else
                    {

                        thongTinXeService.InsertThongTinXe(res);
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }

                return RedirectToAction("Index", "ThongTinXe");
            }

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            ThongTinXe res = thongTinXeService.GetThongTinXe(id);
            thongTinXeService.DeleteThongTinXe(res);

            return RedirectToAction("Index", "ThongTinXe");
        }
    }
}
