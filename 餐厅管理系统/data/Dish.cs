using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 餐厅管理系统.database;

namespace 餐厅管理系统.data
{
    public class Dish
    {
        public int DishId { get; set; }

        public int RestaurantId { get; set; }

        public string DisPicture { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
       
        public Restaurant Restaurant { get; set; }
    }

}
