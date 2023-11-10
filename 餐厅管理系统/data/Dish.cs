using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 餐厅管理系统.data
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }

        //public int RestaurantId { get; set; }

        public string DisPicture { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        // 可以添加其他菜品相关的属性
    }

}
