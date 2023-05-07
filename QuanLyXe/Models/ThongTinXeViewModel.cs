using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;

namespace QuanLyXe.Models
{
    public class ThongTinXeViewModel
    {
        public ThongTinXeViewModel()
        {
        }
        [DisplayName("ID")]
        public int MaXe { get; set; }
        [DisplayName("Tên xe")]
        public string TenXe { get; set; }
        [DisplayName("Dòng xe")]
        public string DongXe { get; set; }
        [DisplayName("Bảng số")]
        public string BangSo { get; set; }
        [DisplayName("Dung tích xy lanh")]
        public string DungTichXyLanh { get; set; }
        [DisplayName("Hãng xe")]
        public string HangXe { get; set; }
    }
}
