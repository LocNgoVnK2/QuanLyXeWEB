using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
        [Table("ThongTinXe")]
        public class ThongTinXe
        {
            [Key]
            public int MaXe { get; set; }
            public string TenXe { get; set; }
            public string DongXe { get; set; }
            public string BangSo { get; set; }
            public string DungTichXyLanh { get; set; }
            public string HangXe { get; set; }

        }
    

}
