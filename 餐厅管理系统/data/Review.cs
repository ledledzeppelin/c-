using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 餐厅管理系统
{
    public class Review
    {
        public int ReviewId { get; set; } // 主键

        public int RestaurantId { get; set; }

        public string UserId { get; set; } // 用户名ID
        public string Comment { get; set; } // 具体评论
        public int Rating { get; set; } // 评分

        public Restaurant Restaurant { get; set; }
    }

}
