using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 餐厅管理系统.data;

namespace 餐厅管理系统
{
    internal class Restaurant
    {
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public string account {  get; set; }
        public string ResPicture { get; set; }

        public string Password {  get; set; }


        public float Rate  {  get; set; }

        // 餐厅的评论集合
        public List<Review> Reviews { get; set; }

        // 导航属性，用于访问相关的菜品
        public List<Dish> Menu { get; set; }

        public Restaurant()
        {
            // 初始化导航属性
            Reviews = new List<Review>();
            Menu = new List<Dish>();
        }
    }
}