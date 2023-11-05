using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 餐厅管理系统
{
    internal class Review
    {
        public int Id { get; set; } // 主键

        public int RestaurantId { get; set; } // 餐厅ID（外键）
        //public Restaurant Restaurant { get; set; } // 外键关联到餐厅实体

        public string UserId { get; set; } // 用户名ID
        public string Comment { get; set; } // 具体评论
        public int Rating { get; set; } // 评分
    }

}
